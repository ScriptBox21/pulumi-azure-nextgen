// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageSync.V20180701
{
    public static class GetRegisteredServer
    {
        public static Task<GetRegisteredServerResult> InvokeAsync(GetRegisteredServerArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRegisteredServerResult>("azure-nextgen:storagesync/v20180701:getRegisteredServer", args ?? new GetRegisteredServerArgs(), options.WithVersion());
    }


    public sealed class GetRegisteredServerArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// GUID identifying the on-premises server.
        /// </summary>
        [Input("serverId", required: true)]
        public string ServerId { get; set; } = null!;

        /// <summary>
        /// Name of Storage Sync Service resource.
        /// </summary>
        [Input("storageSyncServiceName", required: true)]
        public string StorageSyncServiceName { get; set; } = null!;

        public GetRegisteredServerArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRegisteredServerResult
    {
        /// <summary>
        /// Registered Server Agent Version
        /// </summary>
        public readonly string? AgentVersion;
        /// <summary>
        /// Registered Server clusterId
        /// </summary>
        public readonly string? ClusterId;
        /// <summary>
        /// Registered Server clusterName
        /// </summary>
        public readonly string? ClusterName;
        /// <summary>
        /// Resource discoveryEndpointUri
        /// </summary>
        public readonly string? DiscoveryEndpointUri;
        /// <summary>
        /// Friendly Name
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// Registered Server last heart beat
        /// </summary>
        public readonly string? LastHeartBeat;
        /// <summary>
        /// Resource Last Operation Name
        /// </summary>
        public readonly string? LastOperationName;
        /// <summary>
        /// Registered Server lastWorkflowId
        /// </summary>
        public readonly string? LastWorkflowId;
        /// <summary>
        /// Management Endpoint Uri
        /// </summary>
        public readonly string? ManagementEndpointUri;
        /// <summary>
        /// Monitoring Configuration
        /// </summary>
        public readonly string? MonitoringConfiguration;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Registered Server Provisioning State
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Resource Location
        /// </summary>
        public readonly string? ResourceLocation;
        /// <summary>
        /// Registered Server Certificate
        /// </summary>
        public readonly string? ServerCertificate;
        /// <summary>
        /// Registered Server serverId
        /// </summary>
        public readonly string? ServerId;
        /// <summary>
        /// Registered Server Management Error Code
        /// </summary>
        public readonly int? ServerManagementtErrorCode;
        /// <summary>
        /// Registered Server OS Version
        /// </summary>
        public readonly string? ServerOSVersion;
        /// <summary>
        /// Registered Server serverRole
        /// </summary>
        public readonly string? ServerRole;
        /// <summary>
        /// Service Location
        /// </summary>
        public readonly string? ServiceLocation;
        /// <summary>
        /// Registered Server storageSyncServiceUid
        /// </summary>
        public readonly string? StorageSyncServiceUid;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetRegisteredServerResult(
            string? agentVersion,

            string? clusterId,

            string? clusterName,

            string? discoveryEndpointUri,

            string? friendlyName,

            string? lastHeartBeat,

            string? lastOperationName,

            string? lastWorkflowId,

            string? managementEndpointUri,

            string? monitoringConfiguration,

            string name,

            string? provisioningState,

            string? resourceLocation,

            string? serverCertificate,

            string? serverId,

            int? serverManagementtErrorCode,

            string? serverOSVersion,

            string? serverRole,

            string? serviceLocation,

            string? storageSyncServiceUid,

            string type)
        {
            AgentVersion = agentVersion;
            ClusterId = clusterId;
            ClusterName = clusterName;
            DiscoveryEndpointUri = discoveryEndpointUri;
            FriendlyName = friendlyName;
            LastHeartBeat = lastHeartBeat;
            LastOperationName = lastOperationName;
            LastWorkflowId = lastWorkflowId;
            ManagementEndpointUri = managementEndpointUri;
            MonitoringConfiguration = monitoringConfiguration;
            Name = name;
            ProvisioningState = provisioningState;
            ResourceLocation = resourceLocation;
            ServerCertificate = serverCertificate;
            ServerId = serverId;
            ServerManagementtErrorCode = serverManagementtErrorCode;
            ServerOSVersion = serverOSVersion;
            ServerRole = serverRole;
            ServiceLocation = serviceLocation;
            StorageSyncServiceUid = storageSyncServiceUid;
            Type = type;
        }
    }
}
