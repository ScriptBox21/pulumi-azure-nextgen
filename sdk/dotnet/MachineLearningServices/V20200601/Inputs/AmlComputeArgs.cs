// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200601.Inputs
{

    /// <summary>
    /// An Azure Machine Learning compute.
    /// </summary>
    public sealed class AmlComputeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Location for the underlying compute
        /// </summary>
        [Input("computeLocation")]
        public Input<string>? ComputeLocation { get; set; }

        /// <summary>
        /// The type of compute
        /// </summary>
        [Input("computeType", required: true)]
        public Input<string> ComputeType { get; set; } = null!;

        /// <summary>
        /// The description of the Machine Learning compute.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// AML Compute properties
        /// </summary>
        [Input("properties")]
        public Input<Inputs.AmlComputePropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// ARM resource id of the underlying compute
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        public AmlComputeArgs()
        {
        }
    }
}