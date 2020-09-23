// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180401
{
    /// <summary>
    /// Azure Firewall resource
    /// </summary>
    public partial class AzureFirewall : Pulumi.CustomResource
    {
        /// <summary>
        /// Collection of application rule collections used by a Azure Firewall.
        /// </summary>
        [Output("applicationRuleCollections")]
        public Output<ImmutableArray<Outputs.AzureFirewallApplicationRuleCollectionResponse>> ApplicationRuleCollections { get; private set; } = null!;

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// IP configuration of the Azure Firewall resource.
        /// </summary>
        [Output("ipConfigurations")]
        public Output<ImmutableArray<Outputs.AzureFirewallIPConfigurationResponse>> IpConfigurations { get; private set; } = null!;

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
        /// Collection of network rule collections used by a Azure Firewall.
        /// </summary>
        [Output("networkRuleCollections")]
        public Output<ImmutableArray<Outputs.AzureFirewallNetworkRuleCollectionResponse>> NetworkRuleCollections { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the resource.
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
        /// Create a AzureFirewall resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AzureFirewall(string name, AzureFirewallArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20180401:AzureFirewall", name, args ?? new AzureFirewallArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AzureFirewall(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20180401:AzureFirewall", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:AzureFirewall"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AzureFirewall resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AzureFirewall Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AzureFirewall(name, id, options);
        }
    }

    public sealed class AzureFirewallArgs : Pulumi.ResourceArgs
    {
        [Input("applicationRuleCollections")]
        private InputList<Inputs.AzureFirewallApplicationRuleCollectionArgs>? _applicationRuleCollections;

        /// <summary>
        /// Collection of application rule collections used by a Azure Firewall.
        /// </summary>
        public InputList<Inputs.AzureFirewallApplicationRuleCollectionArgs> ApplicationRuleCollections
        {
            get => _applicationRuleCollections ?? (_applicationRuleCollections = new InputList<Inputs.AzureFirewallApplicationRuleCollectionArgs>());
            set => _applicationRuleCollections = value;
        }

        /// <summary>
        /// The name of the Azure Firewall.
        /// </summary>
        [Input("azureFirewallName", required: true)]
        public Input<string> AzureFirewallName { get; set; } = null!;

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ipConfigurations")]
        private InputList<Inputs.AzureFirewallIPConfigurationArgs>? _ipConfigurations;

        /// <summary>
        /// IP configuration of the Azure Firewall resource.
        /// </summary>
        public InputList<Inputs.AzureFirewallIPConfigurationArgs> IpConfigurations
        {
            get => _ipConfigurations ?? (_ipConfigurations = new InputList<Inputs.AzureFirewallIPConfigurationArgs>());
            set => _ipConfigurations = value;
        }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("networkRuleCollections")]
        private InputList<Inputs.AzureFirewallNetworkRuleCollectionArgs>? _networkRuleCollections;

        /// <summary>
        /// Collection of network rule collections used by a Azure Firewall.
        /// </summary>
        public InputList<Inputs.AzureFirewallNetworkRuleCollectionArgs> NetworkRuleCollections
        {
            get => _networkRuleCollections ?? (_networkRuleCollections = new InputList<Inputs.AzureFirewallNetworkRuleCollectionArgs>());
            set => _networkRuleCollections = value;
        }

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

        public AzureFirewallArgs()
        {
        }
    }
}
