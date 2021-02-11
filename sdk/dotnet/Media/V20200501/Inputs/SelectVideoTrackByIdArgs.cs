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
    /// Select video tracks from the input by specifying a track identifier.
    /// </summary>
    public sealed class SelectVideoTrackByIdArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.VideoTrackDescriptor'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// Track identifier to select
        /// </summary>
        [Input("trackId", required: true)]
        public Input<double> TrackId { get; set; } = null!;

        public SelectVideoTrackByIdArgs()
        {
        }
    }
}
