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
    /// Select audio tracks from the input by specifying a track identifier.
    /// </summary>
    public sealed class SelectAudioTrackByIdArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional designation for single channel audio tracks.  Can be used to combine the tracks into stereo or multi-channel audio tracks.
        /// </summary>
        [Input("channelMapping")]
        public InputUnion<string, Pulumi.AzureNextGen.Media.V20200501.ChannelMapping>? ChannelMapping { get; set; }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.AudioTrackDescriptor'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// Track identifier to select
        /// </summary>
        [Input("trackId", required: true)]
        public Input<double> TrackId { get; set; } = null!;

        public SelectAudioTrackByIdArgs()
        {
        }
    }
}
