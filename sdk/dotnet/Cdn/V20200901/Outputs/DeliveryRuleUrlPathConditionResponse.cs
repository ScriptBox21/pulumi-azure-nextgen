// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901.Outputs
{

    [OutputType]
    public sealed class DeliveryRuleUrlPathConditionResponse
    {
        /// <summary>
        /// The name of the condition for the delivery rule.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Defines the parameters for the condition.
        /// </summary>
        public readonly Outputs.UrlPathMatchConditionParametersResponse Parameters;

        [OutputConstructor]
        private DeliveryRuleUrlPathConditionResponse(
            string name,

            Outputs.UrlPathMatchConditionParametersResponse parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }
}
