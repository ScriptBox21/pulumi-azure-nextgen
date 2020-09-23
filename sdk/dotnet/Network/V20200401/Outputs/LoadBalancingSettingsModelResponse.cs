// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200401.Outputs
{

    [OutputType]
    public sealed class LoadBalancingSettingsModelResponse
    {
        /// <summary>
        /// The additional latency in milliseconds for probes to fall into the lowest latency bucket
        /// </summary>
        public readonly int? AdditionalLatencyMilliseconds;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Resource status.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// The number of samples to consider for load balancing decisions
        /// </summary>
        public readonly int? SampleSize;
        /// <summary>
        /// The number of samples within the sample period that must succeed
        /// </summary>
        public readonly int? SuccessfulSamplesRequired;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private LoadBalancingSettingsModelResponse(
            int? additionalLatencyMilliseconds,

            string? id,

            string? name,

            string resourceState,

            int? sampleSize,

            int? successfulSamplesRequired,

            string type)
        {
            AdditionalLatencyMilliseconds = additionalLatencyMilliseconds;
            Id = id;
            Name = name;
            ResourceState = resourceState;
            SampleSize = sampleSize;
            SuccessfulSamplesRequired = successfulSamplesRequired;
            Type = type;
        }
    }
}
