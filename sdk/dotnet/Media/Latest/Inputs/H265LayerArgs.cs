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
    /// Describes the settings to be used when encoding the input video into a desired output bitrate layer with the H.265 video codec.
    /// </summary>
    public sealed class H265LayerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether or not adaptive B-frames are to be used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use.
        /// </summary>
        [Input("adaptiveBFrame")]
        public Input<bool>? AdaptiveBFrame { get; set; }

        /// <summary>
        /// The number of B-frames to be used when encoding this layer.  If not specified, the encoder chooses an appropriate number based on the video profile and level.
        /// </summary>
        [Input("bFrames")]
        public Input<int>? BFrames { get; set; }

        /// <summary>
        /// The average bitrate in bits per second at which to encode the input video when generating this layer. For example: a target bitrate of 3000Kbps or 3Mbps means this value should be 3000000 This is a required field.
        /// </summary>
        [Input("bitrate", required: true)]
        public Input<int> Bitrate { get; set; } = null!;

        /// <summary>
        /// The VBV buffer window length. The value should be in ISO 8601 format. The value should be in the range [0.1-100] seconds. The default is 5 seconds (for example, PT5S).
        /// </summary>
        [Input("bufferWindow")]
        public Input<string>? BufferWindow { get; set; }

        /// <summary>
        /// The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.
        /// </summary>
        [Input("frameRate")]
        public Input<string>? FrameRate { get; set; }

        /// <summary>
        /// The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input.
        /// </summary>
        [Input("height")]
        public Input<string>? Height { get; set; }

        /// <summary>
        /// The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// We currently support Level up to 6.2. The value can be Auto, or a number that matches the H.265 profile. If not specified, the default is Auto, which lets the encoder choose the Level that is appropriate for this layer.
        /// </summary>
        [Input("level")]
        public Input<string>? Level { get; set; }

        /// <summary>
        /// The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.
        /// </summary>
        [Input("maxBitrate")]
        public Input<int>? MaxBitrate { get; set; }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.H265VideoLayer'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// We currently support Main. Default is Auto.
        /// </summary>
        [Input("profile")]
        public InputUnion<string, Pulumi.AzureNextGen.Media.Latest.H265VideoProfile>? Profile { get; set; }

        /// <summary>
        /// The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.
        /// </summary>
        [Input("referenceFrames")]
        public Input<int>? ReferenceFrames { get; set; }

        /// <summary>
        /// The number of slices to be used when encoding this layer. If not specified, default is zero, which means that encoder will use a single slice for each frame.
        /// </summary>
        [Input("slices")]
        public Input<int>? Slices { get; set; }

        /// <summary>
        /// The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input.
        /// </summary>
        [Input("width")]
        public Input<string>? Width { get; set; }

        public H265LayerArgs()
        {
        }
    }
}
