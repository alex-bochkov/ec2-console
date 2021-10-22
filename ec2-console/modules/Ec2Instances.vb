Imports Amazon.EC2.Model
Imports Amazon.SecurityToken.Model

Namespace Ec2Instances

    Module EC2

        Private Function NewAmazonEC2Client(AwsAccount As AwsAccount) As Amazon.EC2.AmazonEC2Client

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

            Dim client = New Amazon.EC2.AmazonEC2Client(cred, Amazon.RegionEndpoint.GetBySystemName(AwsAccount.Region))

            Return client

        End Function

        Public Function ListInstanceTypes(AwsAccount As AwsAccount) As List(Of InstanceTypeInfo)

            Dim List As List(Of InstanceTypeInfo) = New List(Of InstanceTypeInfo)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New DescribeInstanceTypesRequest

            Dim Filter = New List(Of String)
            Filter.Add("true")

            request.Filters.Add(New Filter With {.Name = "current-generation", .Values = Filter})
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

            Dim request = New GetPasswordDataRequest
            request.InstanceId = InstanceId

            Dim requestResult = client.GetPasswordDataAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()
            Dim password = result.GetDecryptedPassword(KeyPair.PublicKey)

            Return password

        End Function

        Public Function ListAvailabilityZones(AwsAccount As AwsAccount) As List(Of AvailabilityZone)

            Dim List As List(Of AvailabilityZone) = New List(Of AvailabilityZone)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New DescribeAvailabilityZonesRequest

            Dim region = New List(Of String)
            region.Add(AwsAccount.Region)

            request.Filters.Add(New Filter With {.Name = "region-name", .Values = region})
            'request.MaxResults = 50

            Dim requestResult = client.DescribeAvailabilityZonesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            For Each resultRow In result.AvailabilityZones
                List.Add(resultRow)
            Next

            Return List

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


            'Dim requestValues = New Amazon.ResourceGroupsTaggingAPI.Model.GetTagValuesRequest

            'Dim requestValuesResult = client.GetTagValuesAsync(requestValues).GetAwaiter()
            'While Not requestValuesResult.IsCompleted
            '    Application.DoEvents()
            'End While

            'Dim resultValues = requestValuesResult.GetResult()

            'For Each resultRow In resultValues.


            '    AllTags.Item()

            '    Add(resultRow, New List(Of String))
            'Next


            Return AllTags

        End Function

        Public Function ListEc2Instances(AwsAccount As AwsAccount, UserFilter As Dictionary(Of String, List(Of String)), ByRef NextToken As String) As List(Of Instance)

            Dim List As List(Of Instance) = New List(Of Instance)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New DescribeInstancesRequest

            If Not NextToken Is Nothing Then
                request.NextToken = NextToken
            End If

            Dim tags = New List(Of String)
            tags.Add("DBA")

            request.Filters.Add(New Filter With {.Name = "tag:Owner", .Values = tags})

            For Each Filter In UserFilter
                request.Filters.Add(New Filter With {.Name = Filter.Key, .Values = Filter.Value})
            Next

            request.MaxResults = 50

            Dim requestResult = client.DescribeInstancesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            For Each resultRow In result.Reservations

                Dim instance = resultRow.Instances.Item(0)

                List.Add(instance)

            Next

            NextToken = result.NextToken

            Return List

        End Function

        Public Function ListEc2InstanceStatuses(AwsAccount As AwsAccount, InstanceList As List(Of Instance)) As List(Of InstanceStatus)

            Dim List As List(Of InstanceStatus) = New List(Of InstanceStatus)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New DescribeInstanceStatusRequest

            'Dim InstanceIDs = New List(Of String)
            ' 100 is the max
            For Each instance In InstanceList
                request.InstanceIds.Add(instance.InstanceId)
            Next

            'request.Filters.Add(New Filter With {.Name = "instance-id", .Values = InstanceIDs})
            'request.MaxResults = 50

            Dim requestResult = client.DescribeInstanceStatusAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            For Each resultRow In result.InstanceStatuses

                List.Add(resultRow)

            Next

            Return List

        End Function

        Public Function ListVolumes(AwsAccount As AwsAccount, UserFilter As Dictionary(Of String, List(Of String))) As List(Of Volume)

            Dim List As List(Of Volume) = New List(Of Volume)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New DescribeVolumesRequest

            For Each Filter In UserFilter
                request.Filters.Add(New Filter With {.Name = Filter.Key, .Values = Filter.Value})
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

            For Each resultRow In result.Volumes

                List.Add(resultRow)

            Next

            Return List

        End Function

        Public Function ModifyVolume(AwsAccount As AwsAccount, VolumeId As String,
                                 VolumeSize As Integer,
                                 Optional VolumeType As String = Nothing,
                                 Optional VolumeIops As Integer = Nothing,
                                 Optional VolumeThroughput As Integer = Nothing) As VolumeModification

            Dim List As List(Of Volume) = New List(Of Volume)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New ModifyVolumeRequest
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

        Public Function ListSecurityGroups(AwsAccount As AwsAccount, Instance As Instance) As List(Of SecurityGroup)

            Dim List As List(Of SecurityGroup) = New List(Of SecurityGroup)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New DescribeSecurityGroupsRequest

            Dim VpcID = New List(Of String)
            VpcID.Add(Instance.VpcId)
            ' 100 is the max

            request.Filters.Add(New Filter With {.Name = "vpc-id", .Values = VpcID})
            'request.MaxResults = 50

            Dim requestResult = client.DescribeSecurityGroupsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            For Each resultRow In result.SecurityGroups


                List.Add(resultRow)

            Next

            Return List

        End Function

        Public Function StopInstance(AwsAccount As AwsAccount, InstanceId As String) As Boolean

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New StopInstancesRequest
            request.InstanceIds.Add(InstanceId)

            Dim requestResult = client.StopInstancesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return True

        End Function

        Public Function StartInstance(AwsAccount As AwsAccount, InstanceId As String) As Boolean

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New StartInstancesRequest

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

            Dim request = New TerminateInstancesRequest

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

            Dim request = New RebootInstancesRequest

            request.InstanceIds.Add(InstanceId)

            Dim requestResult = client.RebootInstancesAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return True

        End Function

        Public Function GetConsoleScreenshot(AwsAccount As AwsAccount, InstanceId As String) As GetConsoleScreenshotResponse

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim request = New GetConsoleScreenshotRequest
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

        Public Function GetAccountAttributes(AwsAccount As AwsAccount) As GetCallerIdentityResponse

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
                                           IamInstanceProfileSpecification As IamInstanceProfileSpecification) As IamInstanceProfileAssociation

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

        Public Function GetInstanceProfileAssociation(AwsAccount As AwsAccount, InstanceId As String) As List(Of IamInstanceProfileAssociation)

            Dim client = NewAmazonEC2Client(AwsAccount)

            Dim InstanceIds = New List(Of String)
            InstanceIds.Add(InstanceId)

            Dim request = New Amazon.EC2.Model.DescribeIamInstanceProfileAssociationsRequest
            request.Filters.Add(New Filter With {.Name = "instance-id", .Values = InstanceIds})

            'request.IamInstanceProfile = IamInstanceProfileSpecification

            Dim requestResult = client.DescribeIamInstanceProfileAssociationsAsync(request).GetAwaiter()
            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.IamInstanceProfileAssociations

        End Function

        Public Function RemoveInstanceProfileAssociation(AwsAccount As AwsAccount, AssociationId As String) As IamInstanceProfileAssociation

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

            Dim cred = New Amazon.Runtime.BasicAWSCredentials(AwsAccount.AccessKey, AwsAccount.SecretKey)

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

            Dim requestResult = client.GetResourceConfigHistoryAsync(request).GetAwaiter()

            While Not requestResult.IsCompleted
                Application.DoEvents()
            End While

            Dim result = requestResult.GetResult()

            Return result.ConfigurationItems

        End Function



    End Module

End Namespace