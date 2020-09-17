// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20190601Preview.Outputs
{

    [OutputType]
    public sealed class AutoPausePropertiesResponse
    {
        /// <summary>
        /// Number of minutes of idle time before the Big Data pool is automatically paused.
        /// </summary>
        public readonly int? DelayInMinutes;
        /// <summary>
        /// Whether auto-pausing is enabled for the Big Data pool.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private AutoPausePropertiesResponse(
            int? delayInMinutes,

            bool? enabled)
        {
            DelayInMinutes = delayInMinutes;
            Enabled = enabled;
        }
    }
}