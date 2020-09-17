// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerRegistry.V20180901.Outputs
{

    [OutputType]
    public sealed class PlatformPropertiesResponse
    {
        /// <summary>
        /// The OS architecture.
        /// </summary>
        public readonly string? Architecture;
        /// <summary>
        /// The operating system type required for the run.
        /// </summary>
        public readonly string Os;
        /// <summary>
        /// Variant of the CPU.
        /// </summary>
        public readonly string? Variant;

        [OutputConstructor]
        private PlatformPropertiesResponse(
            string? architecture,

            string os,

            string? variant)
        {
            Architecture = architecture;
            Os = os;
            Variant = variant;
        }
    }
}