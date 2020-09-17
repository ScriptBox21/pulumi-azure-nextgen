// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20180301.Outputs
{

    [OutputType]
    public sealed class MetricDimensionResponse
    {
        /// <summary>
        /// Name of the dimension.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// the dimension operator. Only 'Include' and 'Exclude' are supported
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// list of dimension values.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private MetricDimensionResponse(
            string name,

            string @operator,

            ImmutableArray<string> values)
        {
            Name = name;
            Operator = @operator;
            Values = values;
        }
    }
}