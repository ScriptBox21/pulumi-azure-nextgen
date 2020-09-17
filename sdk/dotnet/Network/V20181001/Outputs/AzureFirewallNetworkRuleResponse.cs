// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20181001.Outputs
{

    [OutputType]
    public sealed class AzureFirewallNetworkRuleResponse
    {
        /// <summary>
        /// Description of the rule.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// List of destination IP addresses.
        /// </summary>
        public readonly ImmutableArray<string> DestinationAddresses;
        /// <summary>
        /// List of destination ports.
        /// </summary>
        public readonly ImmutableArray<string> DestinationPorts;
        /// <summary>
        /// Name of the network rule.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Array of AzureFirewallNetworkRuleProtocols.
        /// </summary>
        public readonly ImmutableArray<string> Protocols;
        /// <summary>
        /// List of source IP addresses for this rule.
        /// </summary>
        public readonly ImmutableArray<string> SourceAddresses;

        [OutputConstructor]
        private AzureFirewallNetworkRuleResponse(
            string? description,

            ImmutableArray<string> destinationAddresses,

            ImmutableArray<string> destinationPorts,

            string? name,

            ImmutableArray<string> protocols,

            ImmutableArray<string> sourceAddresses)
        {
            Description = description;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            Name = name;
            Protocols = protocols;
            SourceAddresses = sourceAddresses;
        }
    }
}