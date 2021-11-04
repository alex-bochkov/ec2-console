Namespace AmazonApi
    Module EC2

        Private Function NewAmazonEC2Client(AwsAccount As AwsAccount) As Amazon.EC2.AmazonEC2Client

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            Dim client = New Amazon.EC2.AmazonEC2Client(cred, Amazon.RegionEndpoint.GetBySystemName(AwsAccount.Region))

            Return client

        End Function

        Public Function ListInstanceTypes(AwsAccount As AwsAccount) As List(Of Amazon.EC2.Model.InstanceTypeInfo)

            Dim List As List(Of Amazon.EC2.Model.InstanceTypeInfo) = New List(Of Amazon.EC2.Model.InstanceTypeInfo)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeInstanceTypesRequest

            Dim Filter = New List(Of String)
            Filter.Add("true")

            request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = "current-generation", .Values = Filter})
            'request.MaxResults = 500

            Dim NextToken As String = "first-request"

            While NextToken <> ""

                If NextToken <> "first-request" Then
                    request.NextToken = NextToken
                End If

                Dim requestResult = client.DescribeInstanceTypesAsync(request).GetAwaiter()
                While Not requestResult.IsCompleted
                    Application.DoEvents()
                End While

                Dim result = requestResult.GetResult()

                For Each resultRow In result.InstanceTypes
                    List.Add(resultRow)
                Next

                NextToken = result.NextToken

            End While

            Return List

        End Function

        Public Function GetWindowsPassword(AwsAccount As AwsAccount, InstanceId As String, KeyPair As AwsAccount.KeyPairClass) As String

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.GetPasswordDataRequest
            request.InstanceId = InstanceId

            Dim requestResult = client.GetPasswordDataAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()
            Dim password = result.GetDecryptedPassword(KeyPair.PublicKey)

            Return password

        End Function

        Public Function ListAvailabilityZones(AwsAccount As AwsAccount) As List(Of Amazon.EC2.Model.AvailabilityZone)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeAvailabilityZonesRequest

            Dim region = New List(Of String)
            region.Add(AwsAccount.Region)

            request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = "region-name", .Values = region})
            'request.MaxResults = 50

            Dim requestResult = client.DescribeAvailabilityZonesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.AvailabilityZones

        End Function

        Public Function ListInstanceTags(AwsAccount As AwsAccount) As List(Of Amazon.EC2.Model.TagDescription)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeTagsRequest

            Dim regionFilter = New List(Of String)
            regionFilter.Add(AwsAccount.Region)

            Dim resourceTypeFilter = New List(Of String)
            resourceTypeFilter.Add("instance")

            request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = "resource-type", .Values = resourceTypeFilter})
            'request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = "region", .Values = regionFilter})
            'request.MaxResults = 50

            Dim requestResult = client.DescribeTagsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Tags

        End Function

        Public Function ListTags(AwsAccount As AwsAccount) As SortedDictionary(Of String, List(Of String))

            Dim AllTags As SortedDictionary(Of String, List(Of String)) = New SortedDictionary(Of String, List(Of String))

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            Dim client = New Amazon.ResourceGroupsTaggingAPI.AmazonResourceGroupsTaggingAPIClient(cred, Amazon.RegionEndpoint.USWest1)

            Dim request = New Amazon.ResourceGroupsTaggingAPI.Model.GetTagKeysRequest

            Dim requestResult = client.GetTagKeysAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            For Each resultRow In result.TagKeys
                AllTags.Add(resultRow, New List(Of String))
            Next

            Return AllTags

        End Function

        Public Function ListEc2Instances(AwsAccount As AwsAccount,
                                         UserFilters As Dictionary(Of String, List(Of String))) As List(Of Amazon.EC2.Model.Instance)

            Dim List As List(Of Amazon.EC2.Model.Instance) = New List(Of Amazon.EC2.Model.Instance)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeInstancesRequest

            For Each UserFilter In UserFilters
                If UserFilter.Value.Count > 0 Then
                    request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = UserFilter.Key, .Values = UserFilter.Value})
                End If
            Next

            ' limit the result set
            If My.Settings.MaxInstancesToLoad > 1000 Or My.Settings.MaxInstancesToLoad < 100 Then
                request.MaxResults = 200
            Else
                request.MaxResults = My.Settings.MaxInstancesToLoad
            End If


            ''*******************************************************
            '' paginator approach
            'Dim DescribeInstancesPaginator = client.Paginators.DescribeInstances(request)
            '
            'Dim ReservationsEnumerator = DescribeInstancesPaginator.Reservations.GetAsyncEnumerator()
            '
            'Try
            '
            '    While True
            '
            '        Dim requestResult = ReservationsEnumerator.MoveNextAsync()
            '        While Not requestResult.IsCompleted
            '            Application.DoEvents()
            '        End While
            '
            '        If Not requestResult.Result Then
            '            Exit While
            '        End If
            '
            '        For Each instance In ReservationsEnumerator.Current.Instances
            '            List.Add(instance)
            '
            '            If List.Count >= request.MaxResults Then
            '                Exit While
            '            End If
            '        Next
            '
            '    End While
            '
            'Catch ex As Exception
            'Finally
            '    ReservationsEnumerator.DisposeAsync()
            'End Try

            '*******************************************************
            ' regular async method
            Dim NextToken As String = "first-request"
            While NextToken <> ""

                If NextToken <> "first-request" Then
                    request.NextToken = NextToken
                End If

                Dim requestResult = client.DescribeInstancesAsync(request).GetAwaiter()
                While Not requestResult.IsCompleted
                    Application.DoEvents()
                End While

                Dim result = requestResult.GetResult()

                For Each resultRow In result.Reservations

                    For Each instance In resultRow.Instances

                        List.Add(instance)

                    Next

                Next

                NextToken = result.NextToken

            End While

            Return List

        End Function

        Public Function GetEc2Instance(AwsAccount As AwsAccount, InstanceId As String) As Amazon.EC2.Model.Instance

            Dim ListInstanceId As List(Of String) = New List(Of String)
            ListInstanceId.Add(InstanceId)

            Dim UserFilter = New Dictionary(Of String, List(Of String))
            UserFilter.Add("instance-id", ListInstanceId)

            Dim InstanceResult = AmazonApi.ListEc2Instances(AwsAccount, UserFilter)

            If InstanceResult.Count = 1 Then
                Return InstanceResult.Item(0)
            End If

            Return New Amazon.EC2.Model.Instance

        End Function

        Public Function ListEc2InstanceStatuses(AwsAccount As AwsAccount, InstanceIds As List(Of String)) As Dictionary(Of String, Amazon.EC2.Model.InstanceStatus)

            Dim Dict As Dictionary(Of String, Amazon.EC2.Model.InstanceStatus) = New Dictionary(Of String, Amazon.EC2.Model.InstanceStatus)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeInstanceStatusRequest

            Dim i = 0
            For Each InstanceId In InstanceIds
                i += 1
                request.InstanceIds.Add(InstanceId)

                ' 100 is the max
                If request.InstanceIds.Count = 100 Or i = InstanceIds.Count Then

                    Dim requestResult = client.DescribeInstanceStatusAsync(request).GetAwaiter()
                    While Not requestResult.IsCompleted
                        Application.DoEvents()
                    End While

                    Dim result = requestResult.GetResult()

                    For Each resultRow In result.InstanceStatuses

                        Dict.TryAdd(resultRow.InstanceId, resultRow)

                    Next

                    request.InstanceIds.Clear()

                End If

            Next

            Return Dict

        End Function

        Public Function ListVolumes(AwsAccount As AwsAccount,
                                    UserFilters As Dictionary(Of String, List(Of String))) _
                                    As List(Of Amazon.EC2.Model.Volume)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeVolumesRequest

            For Each UserFilter In UserFilters
                request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = UserFilter.Key, .Values = UserFilter.Value})
            Next

            'Dim InstanceIDs = New List(Of String)
            ' 100 is the max

            'request.Filters.Add(New Filter With {.Name = "instance-id", .Values = InstanceIDs})
            'request.MaxResults = 50

            Dim requestResult = client.DescribeVolumesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Volumes

        End Function

        Public Function ModifyVolume(AwsAccount As AwsAccount, VolumeId As String,
                                 VolumeSize As Integer,
                                 Optional VolumeType As String = Nothing,
                                 Optional VolumeIops As Integer = Nothing,
                                 Optional VolumeThroughput As Integer = Nothing) As Amazon.EC2.Model.VolumeModification

            Dim List As List(Of Amazon.EC2.Model.Volume) = New List(Of Amazon.EC2.Model.Volume)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.ModifyVolumeRequest
            request.VolumeId = VolumeId
            request.Size = VolumeSize

            If Not VolumeIops = Nothing Then
                request.Iops = VolumeIops
            End If

            If Not VolumeThroughput = Nothing Then
                request.Throughput = VolumeThroughput
            End If

            If Not VolumeType = Nothing Then
                request.VolumeType = Amazon.EC2.VolumeType.FindValue(VolumeType)
            End If

            Dim requestResult = client.ModifyVolumeAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.VolumeModification

        End Function

        Public Function CreateVolume(AwsAccount As AwsAccount,
                                     AvailabilityZone As String,
                                     VolumeType As String,
                                     VolumeSize As Integer,
                                     VolumeEncrypted As Boolean,
                                     Optional VolumeIops As Integer = Nothing,
                                     Optional VolumeThroughput As Integer = Nothing) As Amazon.EC2.Model.Volume


            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.CreateVolumeRequest
            request.AvailabilityZone = AvailabilityZone
            request.VolumeType = Amazon.EC2.VolumeType.FindValue(VolumeType)
            request.Size = VolumeSize
            request.Encrypted = VolumeEncrypted

            If Not VolumeIops = Nothing Then
                request.Iops = VolumeIops
            End If

            If Not VolumeThroughput = Nothing Then
                request.Throughput = VolumeThroughput
            End If

            Dim requestResult = client.CreateVolumeAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Volume

        End Function

        Public Function AttachVolume(AwsAccount As AwsAccount,
                                     VolumeId As String,
                                     InstanceId As String,
                                     Device As String) As Amazon.EC2.Model.VolumeAttachment

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.AttachVolumeRequest
            request.VolumeId = VolumeId
            request.InstanceId = InstanceId
            request.Device = Device

            Dim requestResult = client.AttachVolumeAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Attachment

        End Function

        Public Sub ModifyInstanceAttribute_DeleteVolumeOnInstanceTermination(AwsAccount As AwsAccount,
                                     InstanceId As String,
                                     VolumeId As String,
                                     DeviceName As String)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.ModifyInstanceAttributeRequest
            request.InstanceId = InstanceId

            Dim BlockDeviceMapping = New Amazon.EC2.Model.InstanceBlockDeviceMappingSpecification
            BlockDeviceMapping.DeviceName = DeviceName

            BlockDeviceMapping.Ebs = New Amazon.EC2.Model.EbsInstanceBlockDeviceSpecification
            BlockDeviceMapping.Ebs.VolumeId = VolumeId
            BlockDeviceMapping.Ebs.DeleteOnTermination = True

            request.BlockDeviceMappings.Add(BlockDeviceMapping)

            Dim requestResult = client.ModifyInstanceAttributeAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            'Return result.HttpStatusCode.OK

        End Sub

        Public Function DescribeVolumeStatus(AwsAccount As AwsAccount,
                                     VolumeId As String) As Amazon.EC2.Model.VolumeStatusItem


            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeVolumeStatusRequest
            request.VolumeIds.Add(VolumeId)

            Dim requestResult = client.DescribeVolumeStatusAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            If result.VolumeStatuses.Count = 1 Then
                Return result.VolumeStatuses.Item(0)
            Else
                Return New Amazon.EC2.Model.VolumeStatusItem
            End If

        End Function

        Public Function DescribeSecurityGroups(AwsAccount As AwsAccount,
                                               UserFilters As Dictionary(Of String, List(Of String))
                                               ) As List(Of Amazon.EC2.Model.SecurityGroup)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeSecurityGroupsRequest

            For Each UserFilter In UserFilters
                request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = UserFilter.Key, .Values = UserFilter.Value})
            Next

            Dim requestResult = client.DescribeSecurityGroupsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.SecurityGroups

        End Function

        Public Function StopInstance(AwsAccount As AwsAccount, InstanceId As String, Optional Force As Boolean = False) As Boolean

            Dim Instances As List(Of String) = New List(Of String)
            Instances.Add(InstanceId)

            Return StopInstances(AwsAccount, Instances, Force)

        End Function

        Public Function StopInstances(AwsAccount As AwsAccount, InstanceIds As List(Of String), Optional Force As Boolean = False) As Boolean

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.StopInstancesRequest
            request.InstanceIds = InstanceIds
            request.Force = Force

            Dim requestResult = client.StopInstancesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return True

        End Function

        Public Function StartInstance(AwsAccount As AwsAccount, InstanceId As String) As Boolean

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.StartInstancesRequest

            request.InstanceIds.Add(InstanceId)

            Dim requestResult = client.StartInstancesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return True

        End Function

        Public Function TerminateInstance(AwsAccount As AwsAccount, InstanceId As String) As Boolean

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.TerminateInstancesRequest

            request.InstanceIds.Add(InstanceId)

            Dim requestResult = client.TerminateInstancesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return True

        End Function

        Public Function RebootInstance(AwsAccount As AwsAccount, InstanceId As String) As Boolean

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.RebootInstancesRequest

            request.InstanceIds.Add(InstanceId)

            Dim requestResult = client.RebootInstancesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return True

        End Function

        Public Function GetConsoleScreenshot(AwsAccount As AwsAccount, InstanceId As String) As Amazon.EC2.Model.GetConsoleScreenshotResponse

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.GetConsoleScreenshotRequest
            request.InstanceId = InstanceId

            Dim requestResult = client.GetConsoleScreenshotAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result

        End Function

        Public Function GetTerminationProtection(AwsAccount As AwsAccount, InstanceId As String) As Boolean

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeInstanceAttributeRequest
            request.InstanceId = InstanceId
            request.Attribute = "disableApiTermination"

            Dim requestResult = client.DescribeInstanceAttributeAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.InstanceAttribute.DisableApiTermination

        End Function

        Public Function ModifyInstanceType(AwsAccount As AwsAccount, InstanceId As String, InstanceType As String)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.ModifyInstanceAttributeRequest
            request.InstanceId = InstanceId
            request.InstanceType = InstanceType

            Dim requestResult = client.ModifyInstanceAttributeAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result

        End Function

        Public Function UpdateTerminationProtection(AwsAccount As AwsAccount, InstanceId As String, DisableApiTermination As Boolean)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.ModifyInstanceAttributeRequest
            request.InstanceId = InstanceId
            request.DisableApiTermination = DisableApiTermination

            Dim requestResult = client.ModifyInstanceAttributeAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result

        End Function

        Public Function GetAccountAttributes(AwsAccount As AwsAccount) As Amazon.SecurityToken.Model.GetCallerIdentityResponse

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            Dim client = New Amazon.SecurityToken.AmazonSecurityTokenServiceClient(cred, Amazon.RegionEndpoint.GetBySystemName(AwsAccount.Region))

            Dim request = New Amazon.SecurityToken.Model.GetCallerIdentityRequest

            Dim requestResult = client.GetCallerIdentityAsync(request).GetAwaiter()

            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result

        End Function

        Public Function ListInstanceProfiles(AwsAccount As AwsAccount) As List(Of Amazon.IdentityManagement.Model.InstanceProfile)

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            Dim client = New Amazon.IdentityManagement.AmazonIdentityManagementServiceClient(cred, Amazon.RegionEndpoint.GetBySystemName(AwsAccount.Region))

            Dim request = New Amazon.IdentityManagement.Model.ListInstanceProfilesRequest

            Dim requestResult = client.ListInstanceProfilesAsync(request).GetAwaiter()

            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.InstanceProfiles

        End Function



        Public Function AddInstanceProfileAssociation(AwsAccount As AwsAccount, InstanceId As String,
                                           IamInstanceProfileSpecification As Amazon.EC2.Model.IamInstanceProfileSpecification) As Amazon.EC2.Model.IamInstanceProfileAssociation

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.AssociateIamInstanceProfileRequest
            request.InstanceId = InstanceId
            request.IamInstanceProfile = IamInstanceProfileSpecification

            Dim requestResult = client.AssociateIamInstanceProfileAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.IamInstanceProfileAssociation

        End Function

        Public Function GetInstanceProfileAssociation(AwsAccount As AwsAccount, InstanceId As String) As List(Of Amazon.EC2.Model.IamInstanceProfileAssociation)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim InstanceIds = New List(Of String)
            InstanceIds.Add(InstanceId)

            Dim request = New Amazon.EC2.Model.DescribeIamInstanceProfileAssociationsRequest
            request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = "instance-id", .Values = InstanceIds})

            'request.IamInstanceProfile = IamInstanceProfileSpecification

            Dim requestResult = client.DescribeIamInstanceProfileAssociationsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.IamInstanceProfileAssociations

        End Function

        Public Function RemoveInstanceProfileAssociation(AwsAccount As AwsAccount, AssociationId As String) As Amazon.EC2.Model.IamInstanceProfileAssociation

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DisassociateIamInstanceProfileRequest
            request.AssociationId = AssociationId

            Dim requestResult = client.DisassociateIamInstanceProfileAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.IamInstanceProfileAssociation

        End Function

        Public Function CreateTags(AwsAccount As AwsAccount, ResourceId As String, Tags As List(Of Amazon.EC2.Model.Tag)) As Integer

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.CreateTagsRequest
            request.Resources = New List(Of String)
            request.Resources.Add(ResourceId)

            request.Tags = Tags

            Dim requestResult = client.CreateTagsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.HttpStatusCode

        End Function

        Public Function DeleteTags(AwsAccount As AwsAccount, ResourceId As String, Tags As List(Of Amazon.EC2.Model.Tag)) As Integer

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DeleteTagsRequest
            request.Resources = New List(Of String)
            request.Resources.Add(ResourceId)

            request.Tags = Tags

            Dim requestResult = client.DeleteTagsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.HttpStatusCode

        End Function

        Public Function DescribeSubnets(AwsAccount As AwsAccount) As List(Of Amazon.EC2.Model.Subnet)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeSubnetsRequest

            Dim requestResult = client.DescribeSubnetsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Subnets

        End Function

        Public Function DescribeVpcs(AwsAccount As AwsAccount) As List(Of Amazon.EC2.Model.Vpc)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New Amazon.EC2.Model.DescribeVpcsRequest

            Dim requestResult = client.DescribeVpcsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Vpcs

        End Function

        Public Function DescribeImages(AwsAccount As AwsAccount,
                                       Optional UserFilters As Dictionary(Of String, List(Of String)) = Nothing
                                       ) As List(Of Amazon.EC2.Model.Image)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim FilterOwnerValues = New List(Of String)
            FilterOwnerValues.Add("amazon")

            Dim FilterImageIdValues = New List(Of String)

            Dim request = New Amazon.EC2.Model.DescribeImagesRequest

            If UserFilters IsNot Nothing Then
                For Each UserFilter In UserFilters
                    request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = UserFilter.Key, .Values = UserFilter.Value})
                Next
            End If

            'request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = "owner-alias", .Values = FilterOwnerValues})
            ' request.Filters.Add(New Amazon.EC2.Model.Filter With {.Name = "image-id", .Values = FilterImageIdValues})

            Dim requestResult = client.DescribeImagesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Images

        End Function



    End Module
    Module Pricing

        Private Function NewAmazonPricingClient(AwsAccount As AwsAccount) As Amazon.Pricing.AmazonPricingClient

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            'The endpoint is in US-East-1
            'https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/using-pelong.html
            Dim client = New Amazon.Pricing.AmazonPricingClient(cred, Amazon.RegionEndpoint.GetBySystemName("us-east-1"))

            Return client

        End Function

        Public Function GetPriceListForInstanceType(AwsAccount As AwsAccount, instanceType As String) As List(Of String)

            Dim client = NewAmazonPricingClient(AwsAccount)

            Dim request = New Amazon.Pricing.Model.GetProductsRequest
            request.ServiceCode = "AmazonEC2"
            request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "instanceType", .Value = instanceType})
            request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "location", .Value = Amazon.RegionEndpoint.GetBySystemName(AwsAccount.Region).DisplayName})
            request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "preInstalledSw", .Value = "NA"})
            request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "marketoption", .Value = "OnDemand"})
            request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "tenancy", .Value = "Shared"})
            request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "capacitystatus", .Value = "Used"})
            ' request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "operatingSystem", .Value = "Linux"})
            request.Filters.Add(New Amazon.Pricing.Model.Filter With {.Type = "TERM_MATCH", .Field = "licenseModel", .Value = "No License required"})

            Dim requestResult = client.GetProductsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.PriceList

        End Function

    End Module

    Module CloudWatch

        Private Function NewAmazonCloudWatchClient(AwsAccount As AwsAccount) As Amazon.CloudWatch.AmazonCloudWatchClient

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            Dim client = New Amazon.CloudWatch.AmazonCloudWatchClient(cred, Amazon.RegionEndpoint.GetBySystemName(AwsAccount.Region))

            Return client

        End Function

        Public Function GetCpuUtilizationPerInstance(AwsAccount As AwsAccount,
                                                     InstanceId As String,
                                                     Period As String,
                                                     MetricName As String,
                                                     Statistics As String,
                                                     StartTime As DateTime,
                                                     EndTime As DateTime) As List(Of Amazon.CloudWatch.Model.Datapoint)

            Dim client = NewAmazonCloudWatchClient(AwsAccount)

            Dim request = New Amazon.CloudWatch.Model.GetMetricStatisticsRequest
            request.StartTimeUtc = StartTime.ToUniversalTime
            request.EndTimeUtc = EndTime.ToUniversalTime

            request.Period = Period
            request.Statistics.Add(Statistics)
            request.Namespace = "AWS/EC2"
            request.MetricName = MetricName

            request.Dimensions.Add(New Amazon.CloudWatch.Model.Dimension With {.Name = "InstanceId", .Value = InstanceId})

            Dim requestResult = client.GetMetricStatisticsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.Datapoints

        End Function

    End Module

    Module ConfigService
        Private Function NewAmazonConfigServiceClient(AwsAccount As AwsAccount) As Amazon.ConfigService.AmazonConfigServiceClient

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            Dim client = New Amazon.ConfigService.AmazonConfigServiceClient(cred, Amazon.RegionEndpoint.GetBySystemName(AwsAccount.Region))

            Return client

        End Function

        Public Function GetResourceConfigHistory(AwsAccount As AwsAccount,
                                                 ResourceId As String) _
                As List(Of Amazon.ConfigService.Model.ConfigurationItem)

            Dim client = NewAmazonConfigServiceClient(AwsAccount)

            Dim ResourceType As Amazon.ConfigService.ResourceType = Nothing
            If ResourceId.StartsWith("i-") Then
                ResourceType = Amazon.ConfigService.ResourceType.AWSEC2Instance
            ElseIf ResourceId.StartsWith("vol-") Then
                ResourceType = Amazon.ConfigService.ResourceType.AWSEC2Volume
            ElseIf ResourceId.StartsWith("sg-") Then
                ResourceType = Amazon.ConfigService.ResourceType.AWSEC2SecurityGroup
            End If

            Dim request = New Amazon.ConfigService.Model.GetResourceConfigHistoryRequest
            request.ResourceId = ResourceId
            request.ResourceType = ResourceType
            request.Limit = 100

            Dim List As List(Of Amazon.ConfigService.Model.ConfigurationItem) = New List(Of Amazon.ConfigService.Model.ConfigurationItem)

            Dim NextToken As String = "first-request"

            While NextToken <> ""

                If NextToken <> "first-request" Then
                    request.NextToken = NextToken
                End If

                Dim requestResult = client.GetResourceConfigHistoryAsync(request).GetAwaiter()
                While Not requestResult.IsCompleted
                    Application.DoEvents()
                End While

                Dim result = requestResult.GetResult()

                For Each resultRow In result.ConfigurationItems
                    List.Add(resultRow)
                Next

                NextToken = result.NextToken

                'not sure how select properly all records here.. this works way too long
                Exit While

            End While

            Return List

        End Function



    End Module

    Module Internal

        Function GetAllAwsRegions() As List(Of Amazon.RegionEndpoint)

            Dim List As List(Of Amazon.RegionEndpoint) = New List(Of Amazon.RegionEndpoint)

            For Each Region In Amazon.RegionEndpoint.EnumerableAllRegions

                List.Add(Region)

            Next

            Return List

        End Function

        Function CreateSimpleFilter(FilterName As String, FilterValue As String) As Dictionary(Of String, List(Of String))

            Dim UserFilter As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))
            UserFilter.Add(FilterName, New List(Of String) From {FilterValue})

            Return UserFilter

        End Function

    End Module
End Namespace