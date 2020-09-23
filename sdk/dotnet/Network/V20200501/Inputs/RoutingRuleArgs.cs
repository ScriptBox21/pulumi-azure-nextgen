// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200501.Inputs
{

    /// <summary>
    /// A routing rule represents a specification for traffic to treat and where to send it, along with health probe information.
    /// </summary>
    public sealed class RoutingRuleArgs : Pulumi.ResourceArgs
    {
        [Input("acceptedProtocols")]
        private InputList<string>? _acceptedProtocols;

        /// <summary>
        /// Protocol schemes to match for this rule
        /// </summary>
        public InputList<string> AcceptedProtocols
        {
            get => _acceptedProtocols ?? (_acceptedProtocols = new InputList<string>());
            set => _acceptedProtocols = value;
        }

        /// <summary>
        /// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
        /// </summary>
        [Input("enabledState")]
        public Input<string>? EnabledState { get; set; }

        [Input("frontendEndpoints")]
        private InputList<Inputs.SubResourceArgs>? _frontendEndpoints;

        /// <summary>
        /// Frontend endpoints associated with this rule
        /// </summary>
        public InputList<Inputs.SubResourceArgs> FrontendEndpoints
        {
            get => _frontendEndpoints ?? (_frontendEndpoints = new InputList<Inputs.SubResourceArgs>());
            set => _frontendEndpoints = value;
        }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Resource name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

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
        /// A reference to the routing configuration.
        /// </summary>
        [Input("routeConfiguration")]
        public InputUnion<Inputs.ForwardingConfigurationArgs, Inputs.RedirectConfigurationArgs>? RouteConfiguration { get; set; }

        /// <summary>
        /// A reference to a specific Rules Engine Configuration to apply to this route.
        /// </summary>
        [Input("rulesEngine")]
        public Input<Inputs.SubResourceArgs>? RulesEngine { get; set; }

        /// <summary>
        /// Defines the Web Application Firewall policy for each routing rule (if applicable)
        /// </summary>
        [Input("webApplicationFirewallPolicyLink")]
        public Input<Inputs.RoutingRuleUpdateParametersWebApplicationFirewallPolicyLinkArgs>? WebApplicationFirewallPolicyLink { get; set; }

        public RoutingRuleArgs()
        {
        }
    }
}
