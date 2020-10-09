// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageSync.Latest
{
    /// <summary>
    /// Server Endpoint object.
    /// </summary>
    public partial class ServerEndpoint : Pulumi.CustomResource
    {
        /// <summary>
        /// Cloud Tiering.
        /// </summary>
        [Output("cloudTiering")]
        public Output<string?> CloudTiering { get; private set; } = null!;

        /// <summary>
        /// Cloud tiering status. Only populated if cloud tiering is enabled.
        /// </summary>
        [Output("cloudTieringStatus")]
        public Output<Outputs.ServerEndpointCloudTieringStatusResponse> CloudTieringStatus { get; private set; } = null!;

        /// <summary>
        /// Friendly Name
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// Policy for how namespace and files are recalled during FastDr.
        /// </summary>
        [Output("initialDownloadPolicy")]
        public Output<string?> InitialDownloadPolicy { get; private set; } = null!;

        /// <summary>
        /// Resource Last Operation Name
        /// </summary>
        [Output("lastOperationName")]
        public Output<string> LastOperationName { get; private set; } = null!;

        /// <summary>
        /// ServerEndpoint lastWorkflowId
        /// </summary>
        [Output("lastWorkflowId")]
        public Output<string> LastWorkflowId { get; private set; } = null!;

        /// <summary>
        /// Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access.
        /// </summary>
        [Output("localCacheMode")]
        public Output<string?> LocalCacheMode { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Offline data transfer
        /// </summary>
        [Output("offlineDataTransfer")]
        public Output<string?> OfflineDataTransfer { get; private set; } = null!;

        /// <summary>
        /// Offline data transfer share name
        /// </summary>
        [Output("offlineDataTransferShareName")]
        public Output<string?> OfflineDataTransferShareName { get; private set; } = null!;

        /// <summary>
        /// Offline data transfer storage account resource ID
        /// </summary>
        [Output("offlineDataTransferStorageAccountResourceId")]
        public Output<string> OfflineDataTransferStorageAccountResourceId { get; private set; } = null!;

        /// <summary>
        /// Offline data transfer storage account tenant ID
        /// </summary>
        [Output("offlineDataTransferStorageAccountTenantId")]
        public Output<string> OfflineDataTransferStorageAccountTenantId { get; private set; } = null!;

        /// <summary>
        /// ServerEndpoint Provisioning State
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Recall status. Only populated if cloud tiering is enabled.
        /// </summary>
        [Output("recallStatus")]
        public Output<Outputs.ServerEndpointRecallStatusResponse> RecallStatus { get; private set; } = null!;

        /// <summary>
        /// Server Local path.
        /// </summary>
        [Output("serverLocalPath")]
        public Output<string?> ServerLocalPath { get; private set; } = null!;

        /// <summary>
        /// Server name
        /// </summary>
        [Output("serverName")]
        public Output<string> ServerName { get; private set; } = null!;

        /// <summary>
        /// Server Resource Id.
        /// </summary>
        [Output("serverResourceId")]
        public Output<string?> ServerResourceId { get; private set; } = null!;

        /// <summary>
        /// Server Endpoint sync status
        /// </summary>
        [Output("syncStatus")]
        public Output<Outputs.ServerEndpointSyncStatusResponse> SyncStatus { get; private set; } = null!;

        /// <summary>
        /// Tier files older than days.
        /// </summary>
        [Output("tierFilesOlderThanDays")]
        public Output<int?> TierFilesOlderThanDays { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Level of free space to be maintained by Cloud Tiering if it is enabled.
        /// </summary>
        [Output("volumeFreeSpacePercent")]
        public Output<int?> VolumeFreeSpacePercent { get; private set; } = null!;


        /// <summary>
        /// Create a ServerEndpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServerEndpoint(string name, ServerEndpointArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:storagesync/latest:ServerEndpoint", name, args ?? new ServerEndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServerEndpoint(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:storagesync/latest:ServerEndpoint", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20170605preview:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20180402:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20180701:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20181001:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20190201:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20190301:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20190601:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20191001:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20200301:ServerEndpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20200901:ServerEndpoint"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServerEndpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServerEndpoint Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServerEndpoint(name, id, options);
        }
    }

    public sealed class ServerEndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud Tiering.
        /// </summary>
        [Input("cloudTiering")]
        public Input<string>? CloudTiering { get; set; }

        /// <summary>
        /// Friendly Name
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// Policy for how namespace and files are recalled during FastDr.
        /// </summary>
        [Input("initialDownloadPolicy")]
        public Input<string>? InitialDownloadPolicy { get; set; }

        /// <summary>
        /// Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access.
        /// </summary>
        [Input("localCacheMode")]
        public Input<string>? LocalCacheMode { get; set; }

        /// <summary>
        /// Offline data transfer
        /// </summary>
        [Input("offlineDataTransfer")]
        public Input<string>? OfflineDataTransfer { get; set; }

        /// <summary>
        /// Offline data transfer share name
        /// </summary>
        [Input("offlineDataTransferShareName")]
        public Input<string>? OfflineDataTransferShareName { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Server Endpoint object.
        /// </summary>
        [Input("serverEndpointName", required: true)]
        public Input<string> ServerEndpointName { get; set; } = null!;

        /// <summary>
        /// Server Local path.
        /// </summary>
        [Input("serverLocalPath")]
        public Input<string>? ServerLocalPath { get; set; }

        /// <summary>
        /// Server Resource Id.
        /// </summary>
        [Input("serverResourceId")]
        public Input<string>? ServerResourceId { get; set; }

        /// <summary>
        /// Name of Storage Sync Service resource.
        /// </summary>
        [Input("storageSyncServiceName", required: true)]
        public Input<string> StorageSyncServiceName { get; set; } = null!;

        /// <summary>
        /// Name of Sync Group resource.
        /// </summary>
        [Input("syncGroupName", required: true)]
        public Input<string> SyncGroupName { get; set; } = null!;

        /// <summary>
        /// Tier files older than days.
        /// </summary>
        [Input("tierFilesOlderThanDays")]
        public Input<int>? TierFilesOlderThanDays { get; set; }

        /// <summary>
        /// Level of free space to be maintained by Cloud Tiering if it is enabled.
        /// </summary>
        [Input("volumeFreeSpacePercent")]
        public Input<int>? VolumeFreeSpacePercent { get; set; }

        public ServerEndpointArgs()
        {
        }
    }
}
