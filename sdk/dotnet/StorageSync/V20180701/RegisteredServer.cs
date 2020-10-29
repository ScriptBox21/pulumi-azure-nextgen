// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageSync.V20180701
{
    /// <summary>
    /// Registered Server resource.
    /// </summary>
    public partial class RegisteredServer : Pulumi.CustomResource
    {
        /// <summary>
        /// Registered Server Agent Version
        /// </summary>
        [Output("agentVersion")]
        public Output<string?> AgentVersion { get; private set; } = null!;

        /// <summary>
        /// Registered Server clusterId
        /// </summary>
        [Output("clusterId")]
        public Output<string?> ClusterId { get; private set; } = null!;

        /// <summary>
        /// Registered Server clusterName
        /// </summary>
        [Output("clusterName")]
        public Output<string?> ClusterName { get; private set; } = null!;

        /// <summary>
        /// Resource discoveryEndpointUri
        /// </summary>
        [Output("discoveryEndpointUri")]
        public Output<string?> DiscoveryEndpointUri { get; private set; } = null!;

        /// <summary>
        /// Friendly Name
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// Registered Server last heart beat
        /// </summary>
        [Output("lastHeartBeat")]
        public Output<string?> LastHeartBeat { get; private set; } = null!;

        /// <summary>
        /// Resource Last Operation Name
        /// </summary>
        [Output("lastOperationName")]
        public Output<string?> LastOperationName { get; private set; } = null!;

        /// <summary>
        /// Registered Server lastWorkflowId
        /// </summary>
        [Output("lastWorkflowId")]
        public Output<string?> LastWorkflowId { get; private set; } = null!;

        /// <summary>
        /// Management Endpoint Uri
        /// </summary>
        [Output("managementEndpointUri")]
        public Output<string?> ManagementEndpointUri { get; private set; } = null!;

        /// <summary>
        /// Monitoring Configuration
        /// </summary>
        [Output("monitoringConfiguration")]
        public Output<string?> MonitoringConfiguration { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Registered Server Provisioning State
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("resourceLocation")]
        public Output<string?> ResourceLocation { get; private set; } = null!;

        /// <summary>
        /// Registered Server Certificate
        /// </summary>
        [Output("serverCertificate")]
        public Output<string?> ServerCertificate { get; private set; } = null!;

        /// <summary>
        /// Registered Server serverId
        /// </summary>
        [Output("serverId")]
        public Output<string?> ServerId { get; private set; } = null!;

        /// <summary>
        /// Registered Server Management Error Code
        /// </summary>
        [Output("serverManagementtErrorCode")]
        public Output<int?> ServerManagementtErrorCode { get; private set; } = null!;

        /// <summary>
        /// Registered Server OS Version
        /// </summary>
        [Output("serverOSVersion")]
        public Output<string?> ServerOSVersion { get; private set; } = null!;

        /// <summary>
        /// Registered Server serverRole
        /// </summary>
        [Output("serverRole")]
        public Output<string?> ServerRole { get; private set; } = null!;

        /// <summary>
        /// Service Location
        /// </summary>
        [Output("serviceLocation")]
        public Output<string?> ServiceLocation { get; private set; } = null!;

        /// <summary>
        /// Registered Server storageSyncServiceUid
        /// </summary>
        [Output("storageSyncServiceUid")]
        public Output<string?> StorageSyncServiceUid { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a RegisteredServer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RegisteredServer(string name, RegisteredServerArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:storagesync/v20180701:RegisteredServer", name, args ?? new RegisteredServerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RegisteredServer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:storagesync/v20180701:RegisteredServer", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/latest:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20170605preview:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20180402:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20181001:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20190201:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20190301:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20190601:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20191001:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20200301:RegisteredServer"},
                    new Pulumi.Alias { Type = "azure-nextgen:storagesync/v20200901:RegisteredServer"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RegisteredServer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RegisteredServer Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RegisteredServer(name, id, options);
        }
    }

    public sealed class RegisteredServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Registered Server Agent Version
        /// </summary>
        [Input("agentVersion")]
        public Input<string>? AgentVersion { get; set; }

        /// <summary>
        /// Registered Server clusterId
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// Registered Server clusterName
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        /// <summary>
        /// Friendly Name
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// Registered Server last heart beat
        /// </summary>
        [Input("lastHeartBeat")]
        public Input<string>? LastHeartBeat { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Registered Server Certificate
        /// </summary>
        [Input("serverCertificate")]
        public Input<string>? ServerCertificate { get; set; }

        /// <summary>
        /// Registered Server serverId
        /// </summary>
        [Input("serverId", required: true)]
        public Input<string> ServerId { get; set; } = null!;

        /// <summary>
        /// Registered Server OS Version
        /// </summary>
        [Input("serverOSVersion")]
        public Input<string>? ServerOSVersion { get; set; }

        /// <summary>
        /// Registered Server serverRole
        /// </summary>
        [Input("serverRole")]
        public Input<string>? ServerRole { get; set; }

        /// <summary>
        /// Name of Storage Sync Service resource.
        /// </summary>
        [Input("storageSyncServiceName", required: true)]
        public Input<string> StorageSyncServiceName { get; set; } = null!;

        public RegisteredServerArgs()
        {
        }
    }
}
