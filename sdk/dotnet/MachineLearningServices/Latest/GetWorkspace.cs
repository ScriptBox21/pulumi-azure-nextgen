// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.Latest
{
    public static class GetWorkspace
    {
        public static Task<GetWorkspaceResult> InvokeAsync(GetWorkspaceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWorkspaceResult>("azure-nextgen:machinelearningservices/latest:getWorkspace", args ?? new GetWorkspaceArgs(), options.WithVersion());
    }


    public sealed class GetWorkspaceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetWorkspaceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWorkspaceResult
    {
        /// <summary>
        /// The flag to indicate whether to allow public access when behind VNet.
        /// </summary>
        public readonly bool? AllowPublicAccessWhenBehindVnet;
        /// <summary>
        /// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        public readonly string? ApplicationInsights;
        /// <summary>
        /// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        public readonly string? ContainerRegistry;
        /// <summary>
        /// The description of this workspace.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Url for the discovery service to identify regional endpoints for machine learning experimentation services
        /// </summary>
        public readonly string? DiscoveryUrl;
        /// <summary>
        /// The encryption settings of Azure ML workspace.
        /// </summary>
        public readonly Outputs.EncryptionPropertyResponse? Encryption;
        /// <summary>
        /// The friendly name for this workspace. This name in mutable
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
        /// </summary>
        public readonly bool? HbiWorkspace;
        /// <summary>
        /// Specifies the resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity of the resource.
        /// </summary>
        public readonly Outputs.IdentityResponse? Identity;
        /// <summary>
        /// The compute name for image build
        /// </summary>
        public readonly string? ImageBuildCompute;
        /// <summary>
        /// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        public readonly string? KeyVault;
        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Specifies the name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The notebook info of Azure ML workspace.
        /// </summary>
        public readonly Outputs.NotebookResourceInfoResponse NotebookInfo;
        /// <summary>
        /// The user assigned identity resource id that represents the workspace identity.
        /// </summary>
        public readonly string? PrimaryUserAssignedIdentity;
        /// <summary>
        /// The list of private endpoint connections in the workspace.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateEndpointConnectionResponse> PrivateEndpointConnections;
        /// <summary>
        /// Count of private connections in the workspace
        /// </summary>
        public readonly int PrivateLinkCount;
        /// <summary>
        /// The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The service managed resource settings.
        /// </summary>
        public readonly Outputs.ServiceManagedResourcesSettingsResponse? ServiceManagedResourcesSettings;
        /// <summary>
        /// The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace
        /// </summary>
        public readonly string ServiceProvisionedResourceGroup;
        /// <summary>
        /// The list of shared private link resources in this workspace.
        /// </summary>
        public readonly ImmutableArray<Outputs.SharedPrivateLinkResourceResponse> SharedPrivateLinkResources;
        /// <summary>
        /// The sku of the workspace.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        public readonly string? StorageAccount;
        /// <summary>
        /// Read only system data
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Specifies the type of the resource.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The immutable id associated with this workspace.
        /// </summary>
        public readonly string WorkspaceId;

        [OutputConstructor]
        private GetWorkspaceResult(
            bool? allowPublicAccessWhenBehindVnet,

            string? applicationInsights,

            string? containerRegistry,

            string? description,

            string? discoveryUrl,

            Outputs.EncryptionPropertyResponse? encryption,

            string? friendlyName,

            bool? hbiWorkspace,

            string id,

            Outputs.IdentityResponse? identity,

            string? imageBuildCompute,

            string? keyVault,

            string? location,

            string name,

            Outputs.NotebookResourceInfoResponse notebookInfo,

            string? primaryUserAssignedIdentity,

            ImmutableArray<Outputs.PrivateEndpointConnectionResponse> privateEndpointConnections,

            int privateLinkCount,

            string provisioningState,

            Outputs.ServiceManagedResourcesSettingsResponse? serviceManagedResourcesSettings,

            string serviceProvisionedResourceGroup,

            ImmutableArray<Outputs.SharedPrivateLinkResourceResponse> sharedPrivateLinkResources,

            Outputs.SkuResponse? sku,

            string? storageAccount,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type,

            string workspaceId)
        {
            AllowPublicAccessWhenBehindVnet = allowPublicAccessWhenBehindVnet;
            ApplicationInsights = applicationInsights;
            ContainerRegistry = containerRegistry;
            Description = description;
            DiscoveryUrl = discoveryUrl;
            Encryption = encryption;
            FriendlyName = friendlyName;
            HbiWorkspace = hbiWorkspace;
            Id = id;
            Identity = identity;
            ImageBuildCompute = imageBuildCompute;
            KeyVault = keyVault;
            Location = location;
            Name = name;
            NotebookInfo = notebookInfo;
            PrimaryUserAssignedIdentity = primaryUserAssignedIdentity;
            PrivateEndpointConnections = privateEndpointConnections;
            PrivateLinkCount = privateLinkCount;
            ProvisioningState = provisioningState;
            ServiceManagedResourcesSettings = serviceManagedResourcesSettings;
            ServiceProvisionedResourceGroup = serviceProvisionedResourceGroup;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            Sku = sku;
            StorageAccount = storageAccount;
            SystemData = systemData;
            Tags = tags;
            Type = type;
            WorkspaceId = workspaceId;
        }
    }
}
