// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200501
{
    /// <summary>
    /// Front Door represents a collection of backend endpoints to route traffic to along with rules that specify how traffic is sent there.
    /// </summary>
    public partial class FrontDoor : Pulumi.CustomResource
    {
        /// <summary>
        /// Backend pools available to routing rules.
        /// </summary>
        [Output("backendPools")]
        public Output<ImmutableArray<Outputs.BackendPoolResponse>> BackendPools { get; private set; } = null!;

        /// <summary>
        /// Settings for all backendPools
        /// </summary>
        [Output("backendPoolsSettings")]
        public Output<Outputs.BackendPoolsSettingsResponse?> BackendPoolsSettings { get; private set; } = null!;

        /// <summary>
        /// The host that each frontendEndpoint must CNAME to.
        /// </summary>
        [Output("cname")]
        public Output<string> Cname { get; private set; } = null!;

        /// <summary>
        /// Operational status of the Front Door load balancer. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Output("enabledState")]
        public Output<string?> EnabledState { get; private set; } = null!;

        /// <summary>
        /// A friendly name for the frontDoor
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// The Id of the frontdoor.
        /// </summary>
        [Output("frontdoorId")]
        public Output<string> FrontdoorId { get; private set; } = null!;

        /// <summary>
        /// Frontend endpoints available to routing rules.
        /// </summary>
        [Output("frontendEndpoints")]
        public Output<ImmutableArray<Outputs.FrontendEndpointResponse>> FrontendEndpoints { get; private set; } = null!;

        /// <summary>
        /// Health probe settings associated with this Front Door instance.
        /// </summary>
        [Output("healthProbeSettings")]
        public Output<ImmutableArray<Outputs.HealthProbeSettingsModelResponse>> HealthProbeSettings { get; private set; } = null!;

        /// <summary>
        /// Load balancing settings associated with this Front Door instance.
        /// </summary>
        [Output("loadBalancingSettings")]
        public Output<ImmutableArray<Outputs.LoadBalancingSettingsModelResponse>> LoadBalancingSettings { get; private set; } = null!;

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
        /// Provisioning state of the Front Door.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource status of the Front Door.
        /// </summary>
        [Output("resourceState")]
        public Output<string> ResourceState { get; private set; } = null!;

        /// <summary>
        /// Routing rules associated with this Front Door.
        /// </summary>
        [Output("routingRules")]
        public Output<ImmutableArray<Outputs.RoutingRuleResponse>> RoutingRules { get; private set; } = null!;

        /// <summary>
        /// Rules Engine Configurations available to routing rules.
        /// </summary>
        [Output("rulesEngines")]
        public Output<ImmutableArray<Outputs.RulesEngineResponse>> RulesEngines { get; private set; } = null!;

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
        /// Create a FrontDoor resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FrontDoor(string name, FrontDoorArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200501:FrontDoor", name, args ?? new FrontDoorArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FrontDoor(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200501:FrontDoor", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:FrontDoor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:FrontDoor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:FrontDoor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190501:FrontDoor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200101:FrontDoor"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:FrontDoor"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FrontDoor resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FrontDoor Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new FrontDoor(name, id, options);
        }
    }

    public sealed class FrontDoorArgs : Pulumi.ResourceArgs
    {
        [Input("backendPools")]
        private InputList<Inputs.BackendPoolArgs>? _backendPools;

        /// <summary>
        /// Backend pools available to routing rules.
        /// </summary>
        public InputList<Inputs.BackendPoolArgs> BackendPools
        {
            get => _backendPools ?? (_backendPools = new InputList<Inputs.BackendPoolArgs>());
            set => _backendPools = value;
        }

        /// <summary>
        /// Settings for all backendPools
        /// </summary>
        [Input("backendPoolsSettings")]
        public Input<Inputs.BackendPoolsSettingsArgs>? BackendPoolsSettings { get; set; }

        /// <summary>
        /// Operational status of the Front Door load balancer. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Input("enabledState")]
        public Input<string>? EnabledState { get; set; }

        /// <summary>
        /// A friendly name for the frontDoor
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// Name of the Front Door which is globally unique.
        /// </summary>
        [Input("frontDoorName", required: true)]
        public Input<string> FrontDoorName { get; set; } = null!;

        [Input("frontendEndpoints")]
        private InputList<Inputs.FrontendEndpointArgs>? _frontendEndpoints;

        /// <summary>
        /// Frontend endpoints available to routing rules.
        /// </summary>
        public InputList<Inputs.FrontendEndpointArgs> FrontendEndpoints
        {
            get => _frontendEndpoints ?? (_frontendEndpoints = new InputList<Inputs.FrontendEndpointArgs>());
            set => _frontendEndpoints = value;
        }

        [Input("healthProbeSettings")]
        private InputList<Inputs.HealthProbeSettingsModelArgs>? _healthProbeSettings;

        /// <summary>
        /// Health probe settings associated with this Front Door instance.
        /// </summary>
        public InputList<Inputs.HealthProbeSettingsModelArgs> HealthProbeSettings
        {
            get => _healthProbeSettings ?? (_healthProbeSettings = new InputList<Inputs.HealthProbeSettingsModelArgs>());
            set => _healthProbeSettings = value;
        }

        [Input("loadBalancingSettings")]
        private InputList<Inputs.LoadBalancingSettingsModelArgs>? _loadBalancingSettings;

        /// <summary>
        /// Load balancing settings associated with this Front Door instance.
        /// </summary>
        public InputList<Inputs.LoadBalancingSettingsModelArgs> LoadBalancingSettings
        {
            get => _loadBalancingSettings ?? (_loadBalancingSettings = new InputList<Inputs.LoadBalancingSettingsModelArgs>());
            set => _loadBalancingSettings = value;
        }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("routingRules")]
        private InputList<Inputs.RoutingRuleArgs>? _routingRules;

        /// <summary>
        /// Routing rules associated with this Front Door.
        /// </summary>
        public InputList<Inputs.RoutingRuleArgs> RoutingRules
        {
            get => _routingRules ?? (_routingRules = new InputList<Inputs.RoutingRuleArgs>());
            set => _routingRules = value;
        }

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

        public FrontDoorArgs()
        {
        }
    }
}
