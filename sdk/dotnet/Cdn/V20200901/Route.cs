// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901
{
    /// <summary>
    /// Friendly Routes name mapping to the any Routes or secret related information.
    /// </summary>
    public partial class Route : Pulumi.CustomResource
    {
        /// <summary>
        /// compression settings.
        /// </summary>
        [Output("compressionSettings")]
        public Output<ImmutableArray<Outputs.CompressionSettingsResponse>> CompressionSettings { get; private set; } = null!;

        /// <summary>
        /// Domains referenced by this endpoint.
        /// </summary>
        [Output("customDomains")]
        public Output<ImmutableArray<Outputs.ResourceReferenceResponse>> CustomDomains { get; private set; } = null!;

        [Output("deploymentStatus")]
        public Output<string> DeploymentStatus { get; private set; } = null!;

        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Output("enabledState")]
        public Output<string?> EnabledState { get; private set; } = null!;

        /// <summary>
        /// Protocol this rule will use when forwarding traffic to backends.
        /// </summary>
        [Output("forwardingProtocol")]
        public Output<string?> ForwardingProtocol { get; private set; } = null!;

        /// <summary>
        /// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed.
        /// </summary>
        [Output("httpsRedirect")]
        public Output<string?> HttpsRedirect { get; private set; } = null!;

        /// <summary>
        /// whether this route will be linked to the default endpoint domain.
        /// </summary>
        [Output("linkToDefaultDomain")]
        public Output<string?> LinkToDefaultDomain { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies what scenario the customer wants this AzureFrontDoor endpoint to optimize for, e.g. Download, Media services. With this information, AzureFrontDoor can apply scenario driven optimization.
        /// </summary>
        [Output("optimizationType")]
        public Output<string?> OptimizationType { get; private set; } = null!;

        /// <summary>
        /// A reference to the origin group.
        /// </summary>
        [Output("originGroup")]
        public Output<Outputs.ResourceReferenceResponse> OriginGroup { get; private set; } = null!;

        /// <summary>
        /// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        [Output("originPath")]
        public Output<string?> OriginPath { get; private set; } = null!;

        /// <summary>
        /// The route patterns of the rule.
        /// </summary>
        [Output("patternsToMatch")]
        public Output<ImmutableArray<string>> PatternsToMatch { get; private set; } = null!;

        /// <summary>
        /// Provisioning status
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Defines how AzureFrontDoor caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// </summary>
        [Output("queryStringCachingBehavior")]
        public Output<string?> QueryStringCachingBehavior { get; private set; } = null!;

        /// <summary>
        /// rule sets referenced by this endpoint.
        /// </summary>
        [Output("ruleSets")]
        public Output<ImmutableArray<Outputs.ResourceReferenceResponse>> RuleSets { get; private set; } = null!;

        /// <summary>
        /// List of supported protocols for this route.
        /// </summary>
        [Output("supportedProtocols")]
        public Output<ImmutableArray<string>> SupportedProtocols { get; private set; } = null!;

        /// <summary>
        /// Read only system data
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Route resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Route(string name, RouteArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/v20200901:Route", name, args ?? new RouteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Route(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/v20200901:Route", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/latest:Route"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Route resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Route Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Route(name, id, options);
        }
    }

    public sealed class RouteArgs : Pulumi.ResourceArgs
    {
        [Input("compressionSettings")]
        private InputList<Inputs.CompressionSettingsArgs>? _compressionSettings;

        /// <summary>
        /// compression settings.
        /// </summary>
        public InputList<Inputs.CompressionSettingsArgs> CompressionSettings
        {
            get => _compressionSettings ?? (_compressionSettings = new InputList<Inputs.CompressionSettingsArgs>());
            set => _compressionSettings = value;
        }

        [Input("customDomains")]
        private InputList<Inputs.ResourceReferenceArgs>? _customDomains;

        /// <summary>
        /// Domains referenced by this endpoint.
        /// </summary>
        public InputList<Inputs.ResourceReferenceArgs> CustomDomains
        {
            get => _customDomains ?? (_customDomains = new InputList<Inputs.ResourceReferenceArgs>());
            set => _customDomains = value;
        }

        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Input("enabledState")]
        public Input<string>? EnabledState { get; set; }

        /// <summary>
        /// Name of the endpoint under the profile which is unique globally.
        /// </summary>
        [Input("endpointName", required: true)]
        public Input<string> EndpointName { get; set; } = null!;

        /// <summary>
        /// Protocol this rule will use when forwarding traffic to backends.
        /// </summary>
        [Input("forwardingProtocol")]
        public Input<string>? ForwardingProtocol { get; set; }

        /// <summary>
        /// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed.
        /// </summary>
        [Input("httpsRedirect")]
        public Input<string>? HttpsRedirect { get; set; }

        /// <summary>
        /// whether this route will be linked to the default endpoint domain.
        /// </summary>
        [Input("linkToDefaultDomain")]
        public Input<string>? LinkToDefaultDomain { get; set; }

        /// <summary>
        /// Specifies what scenario the customer wants this AzureFrontDoor endpoint to optimize for, e.g. Download, Media services. With this information, AzureFrontDoor can apply scenario driven optimization.
        /// </summary>
        [Input("optimizationType")]
        public Input<string>? OptimizationType { get; set; }

        /// <summary>
        /// A reference to the origin group.
        /// </summary>
        [Input("originGroup", required: true)]
        public Input<Inputs.ResourceReferenceArgs> OriginGroup { get; set; } = null!;

        /// <summary>
        /// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        [Input("originPath")]
        public Input<string>? OriginPath { get; set; }

        [Input("patternsToMatch")]
        private InputList<string>? _patternsToMatch;

        /// <summary>
        /// The route patterns of the rule.
        /// </summary>
        public InputList<string> PatternsToMatch
        {
            get => _patternsToMatch ?? (_patternsToMatch = new InputList<string>());
            set => _patternsToMatch = value;
        }

        /// <summary>
        /// Name of the CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Defines how AzureFrontDoor caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// </summary>
        [Input("queryStringCachingBehavior")]
        public Input<string>? QueryStringCachingBehavior { get; set; }

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the routing rule.
        /// </summary>
        [Input("routeName", required: true)]
        public Input<string> RouteName { get; set; } = null!;

        [Input("ruleSets")]
        private InputList<Inputs.ResourceReferenceArgs>? _ruleSets;

        /// <summary>
        /// rule sets referenced by this endpoint.
        /// </summary>
        public InputList<Inputs.ResourceReferenceArgs> RuleSets
        {
            get => _ruleSets ?? (_ruleSets = new InputList<Inputs.ResourceReferenceArgs>());
            set => _ruleSets = value;
        }

        [Input("supportedProtocols")]
        private InputList<string>? _supportedProtocols;

        /// <summary>
        /// List of supported protocols for this route.
        /// </summary>
        public InputList<string> SupportedProtocols
        {
            get => _supportedProtocols ?? (_supportedProtocols = new InputList<string>());
            set => _supportedProtocols = value;
        }

        public RouteArgs()
        {
        }
    }
}
