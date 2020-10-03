// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20200501.Inputs
{

    /// <summary>
    /// HTTP Live Streaming (HLS) packing setting for the live output.
    /// </summary>
    public sealed class HlsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of fragments in an HTTP Live Streaming (HLS) TS segment in the output of the live event. This value does not affect the packing ratio for HLS CMAF output.
        /// </summary>
        [Input("fragmentsPerTsSegment")]
        public Input<int>? FragmentsPerTsSegment { get; set; }

        public HlsArgs()
        {
        }
    }
}
