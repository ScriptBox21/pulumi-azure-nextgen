// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.Latest
{
    /// <summary>
    /// Defines web application firewall policy for Azure CDN.
    /// </summary>
    public partial class Policy : Pulumi.CustomResource
    {
        /// <summary>
        /// Describes custom rules inside the policy.
        /// </summary>
        [Output("customRules")]
        public Output<Outputs.CustomRuleListResponse?> CustomRules { get; private set; } = null!;

        /// <summary>
        /// Describes Azure CDN endpoints associated with this Web Application Firewall policy.
        /// </summary>
        [Output("endpointLinks")]
        public Output<ImmutableArray<Outputs.CdnEndpointResponse>> EndpointLinks { get; private set; } = null!;

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Describes managed rules inside the policy.
        /// </summary>
        [Output("managedRules")]
        public Output<Outputs.ManagedRuleSetListResponse?> ManagedRules { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Describes  policySettings for policy
        /// </summary>
        [Output("policySettings")]
        public Output<Outputs.PolicySettingsResponse?> PolicySettings { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the WebApplicationFirewallPolicy.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Describes rate limit rules inside the policy.
        /// </summary>
        [Output("rateLimitRules")]
        public Output<Outputs.RateLimitRuleListResponse?> RateLimitRules { get; private set; } = null!;

        [Output("resourceState")]
        public Output<string> ResourceState { get; private set; } = null!;

        /// <summary>
        /// The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse> Sku { get; private set; } = null!;

        /// <summary>
        /// Read only system data
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

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
        /// Create a Policy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Policy(string name, PolicyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/latest:Policy", name, args ?? new PolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Policy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/latest:Policy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/v20190615:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/v20190615preview:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/v20200331:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/v20200415:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/v20200901:Policy"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Policy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Policy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Policy(name, id, options);
        }
    }

    public sealed class PolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describes custom rules inside the policy.
        /// </summary>
        [Input("customRules")]
        public Input<Inputs.CustomRuleListArgs>? CustomRules { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Describes managed rules inside the policy.
        /// </summary>
        [Input("managedRules")]
        public Input<Inputs.ManagedRuleSetListArgs>? ManagedRules { get; set; }

        /// <summary>
        /// The name of the CdnWebApplicationFirewallPolicy.
        /// </summary>
        [Input("policyName", required: true)]
        public Input<string> PolicyName { get; set; } = null!;

        /// <summary>
        /// Describes  policySettings for policy
        /// </summary>
        [Input("policySettings")]
        public Input<Inputs.PolicySettingsArgs>? PolicySettings { get; set; }

        /// <summary>
        /// Describes rate limit rules inside the policy.
        /// </summary>
        [Input("rateLimitRules")]
        public Input<Inputs.RateLimitRuleListArgs>? RateLimitRules { get; set; }

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.SkuArgs> Sku { get; set; } = null!;

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

        public PolicyArgs()
        {
        }
    }
}
