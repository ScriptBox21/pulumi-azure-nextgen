// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest.Inputs
{

    /// <summary>
    /// Filter First Quality
    /// </summary>
    public sealed class FirstQualityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The first quality bitrate.
        /// </summary>
        [Input("bitrate", required: true)]
        public Input<int> Bitrate { get; set; } = null!;

        public FirstQualityArgs()
        {
        }
    }
}