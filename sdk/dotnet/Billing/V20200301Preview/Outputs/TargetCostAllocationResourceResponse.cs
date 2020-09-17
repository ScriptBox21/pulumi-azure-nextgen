// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Billing.V20200301Preview.Outputs
{

    [OutputType]
    public sealed class TargetCostAllocationResourceResponse
    {
        /// <summary>
        /// If resource type is dimension, this must be either ResourceGroupName or SubscriptionId. If resource type is tag, this must be a valid Azure tag
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Method of cost allocation for the rule
        /// </summary>
        public readonly string PolicyType;
        /// <summary>
        /// Type of resources contained in this cost allocation rule
        /// </summary>
        public readonly string ResourceType;
        /// <summary>
        /// Target resources for cost allocation. This list cannot contain more than 25 values.
        /// </summary>
        public readonly ImmutableArray<Outputs.CostAllocationProportionResponse> Values;

        [OutputConstructor]
        private TargetCostAllocationResourceResponse(
            string name,

            string policyType,

            string resourceType,

            ImmutableArray<Outputs.CostAllocationProportionResponse> values)
        {
            Name = name;
            PolicyType = policyType;
            ResourceType = resourceType;
            Values = values;
        }
    }
}