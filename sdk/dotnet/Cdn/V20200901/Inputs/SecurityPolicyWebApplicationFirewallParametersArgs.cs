// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901.Inputs
{

    /// <summary>
    /// The json object containing security policy waf parameters
    /// </summary>
    public sealed class SecurityPolicyWebApplicationFirewallParametersArgs : Pulumi.ResourceArgs
    {
        [Input("associations")]
        private InputList<Inputs.SecurityPolicyWebApplicationFirewallAssociationArgs>? _associations;

        /// <summary>
        /// Waf associations
        /// </summary>
        public InputList<Inputs.SecurityPolicyWebApplicationFirewallAssociationArgs> Associations
        {
            get => _associations ?? (_associations = new InputList<Inputs.SecurityPolicyWebApplicationFirewallAssociationArgs>());
            set => _associations = value;
        }

        /// <summary>
        /// The type of the Security policy to create.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("wafPolicy")]
        public Input<Inputs.ResourceReferenceArgs>? WafPolicy { get; set; }

        public SecurityPolicyWebApplicationFirewallParametersArgs()
        {
        }
    }
}
