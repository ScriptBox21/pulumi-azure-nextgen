// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CustomerInsights.V20170426.Outputs
{

    [OutputType]
    public sealed class PredictionDistributionDefinitionResponseResult
    {
        /// <summary>
        /// Distributions of the prediction.
        /// </summary>
        public readonly ImmutableArray<Outputs.PredictionDistributionDefinitionResponseDistributionsResult> Distributions;
        /// <summary>
        /// Total negatives in the distribution.
        /// </summary>
        public readonly int? TotalNegatives;
        /// <summary>
        /// Total positive in the distribution.
        /// </summary>
        public readonly int? TotalPositives;

        [OutputConstructor]
        private PredictionDistributionDefinitionResponseResult(
            ImmutableArray<Outputs.PredictionDistributionDefinitionResponseDistributionsResult> distributions,

            int? totalNegatives,

            int? totalPositives)
        {
            Distributions = distributions;
            TotalNegatives = totalNegatives;
            TotalPositives = totalPositives;
        }
    }
}
