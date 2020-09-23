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
    public sealed class AzureFirewallApplicationRuleCollectionResponse
    {
        /// <summary>
        /// The action type of a rule collection
        /// </summary>
        public readonly Outputs.AzureFirewallRCActionResponse? Action;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Priority of the application rule collection resource.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Collection of rules used by a application rule collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.AzureFirewallApplicationRuleResponse> Rules;

        [OutputConstructor]
        private AzureFirewallApplicationRuleCollectionResponse(
            Outputs.AzureFirewallRCActionResponse? action,

            string etag,

            string? id,

            string? name,

            int? priority,

            string provisioningState,

            ImmutableArray<Outputs.AzureFirewallApplicationRuleResponse> rules)
        {
            Action = action;
            Etag = etag;
            Id = id;
            Name = name;
            Priority = priority;
            ProvisioningState = provisioningState;
            Rules = rules;
        }
    }
}
