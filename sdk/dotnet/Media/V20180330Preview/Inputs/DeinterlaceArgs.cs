// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180330Preview.Inputs
{

    /// <summary>
    /// Describes the de-interlacing settings.
    /// </summary>
    public sealed class DeinterlaceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The deinterlacing mode. Defaults to AutoPixelAdaptive.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// The field parity for de-interlacing, defaults to Auto.
        /// </summary>
        [Input("parity")]
        public Input<string>? Parity { get; set; }

        public DeinterlaceArgs()
        {
        }
    }
}