// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701
{
    /// <summary>
    /// Network watcher in a resource group.
    /// </summary>
    public partial class NetworkWatcher : Pulumi.CustomResource
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the network watcher resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkWatcher resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkWatcher(string name, NetworkWatcherArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190701:NetworkWatcher", name, args ?? new NetworkWatcherArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NetworkWatcher(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190701:NetworkWatcher", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160901:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20161201:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170301:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170601:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170801:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170901:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171001:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171101:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180101:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:NetworkWatcher"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:NetworkWatcher"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NetworkWatcher resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkWatcher Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NetworkWatcher(name, id, options);
        }
    }

    public sealed class NetworkWatcherArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the network watcher.
        /// </summary>
        [Input("networkWatcherName", required: true)]
        public Input<string> NetworkWatcherName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public NetworkWatcherArgs()
        {
        }
    }
}
