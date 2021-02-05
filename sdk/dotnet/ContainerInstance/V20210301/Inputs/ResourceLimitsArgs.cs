// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20210301.Inputs
{

    /// <summary>
    /// The resource limits.
    /// </summary>
    public sealed class ResourceLimitsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CPU limit of this container instance.
        /// </summary>
        [Input("cpu")]
        public Input<double>? Cpu { get; set; }

        /// <summary>
        /// The GPU limit of this container instance.
        /// </summary>
        [Input("gpu")]
        public Input<Inputs.GpuResourceArgs>? Gpu { get; set; }

        /// <summary>
        /// The memory limit in GB of this container instance.
        /// </summary>
        [Input("memoryInGB")]
        public Input<double>? MemoryInGB { get; set; }

        public ResourceLimitsArgs()
        {
        }
    }
}
