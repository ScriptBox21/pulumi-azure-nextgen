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
    public sealed class HealthProbeParametersResponse
    {
        /// <summary>
        /// The number of seconds between health probes.Default is 240sec.
        /// </summary>
        public readonly int? ProbeIntervalInSeconds;
        /// <summary>
        /// The path relative to the origin that is used to determine the health of the origin.
        /// </summary>
        public readonly string? ProbePath;
        /// <summary>
        /// Protocol to use for health probe.
        /// </summary>
        public readonly string? ProbeProtocol;
        /// <summary>
        /// The type of health probe request that is made.
        /// </summary>
        public readonly string? ProbeRequestType;

        [OutputConstructor]
        private HealthProbeParametersResponse(
            int? probeIntervalInSeconds,

            string? probePath,

            string? probeProtocol,

            string? probeRequestType)
        {
            ProbeIntervalInSeconds = probeIntervalInSeconds;
            ProbePath = probePath;
            ProbeProtocol = probeProtocol;
            ProbeRequestType = probeRequestType;
        }
    }
}
