// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20201001.Outputs
{

    [OutputType]
    public sealed class AlertRuleAllOfConditionResponse
    {
        /// <summary>
        /// The list of Activity Log Alert rule conditions.
        /// </summary>
        public readonly ImmutableArray<Outputs.AlertRuleAnyOfOrLeafConditionResponse> AllOf;

        [OutputConstructor]
        private AlertRuleAllOfConditionResponse(ImmutableArray<Outputs.AlertRuleAnyOfOrLeafConditionResponse> allOf)
        {
            AllOf = allOf;
        }
    }
}
