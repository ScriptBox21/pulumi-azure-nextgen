// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190401.Inputs
{

    /// <summary>
    /// NAT rule collection resource.
    /// </summary>
    public sealed class AzureFirewallNatRuleCollectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The action type of a NAT rule collection.
        /// </summary>
        [Input("action")]
        public Input<Inputs.AzureFirewallNatRCActionArgs>? Action { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Priority of the NAT rule collection resource.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("rules")]
        private InputList<Inputs.AzureFirewallNatRuleArgs>? _rules;

        /// <summary>
        /// Collection of rules used by a NAT rule collection.
        /// </summary>
        public InputList<Inputs.AzureFirewallNatRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.AzureFirewallNatRuleArgs>());
            set => _rules = value;
        }

        public AzureFirewallNatRuleCollectionArgs()
        {
        }
    }
}
