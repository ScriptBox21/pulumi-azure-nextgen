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
    /// The resource requirements.
    /// </summary>
    public sealed class ResourceRequirementsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource limits of this container instance.
        /// </summary>
        [Input("limits")]
        public Input<Inputs.ResourceLimitsArgs>? Limits { get; set; }

        /// <summary>
        /// The resource requests of this container instance.
        /// </summary>
        [Input("requests", required: true)]
        public Input<Inputs.ResourceRequestsArgs> Requests { get; set; } = null!;

        public ResourceRequirementsArgs()
        {
        }
    }
}
