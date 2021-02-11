// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20200501.Outputs
{

    [OutputType]
    public sealed class H265LayerResponse
    {
        /// <summary>
        /// Specifies whether or not adaptive B-frames are to be used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use.
        /// </summary>
        public readonly bool? AdaptiveBFrame;
        /// <summary>
        /// The number of B-frames to be used when encoding this layer.  If not specified, the encoder chooses an appropriate number based on the video profile and level.
        /// </summary>
        public readonly int? BFrames;
        /// <summary>
        /// The average bitrate in bits per second at which to encode the input video when generating this layer. For example: a target bitrate of 3000Kbps or 3Mbps means this value should be 3000000 This is a required field.
        /// </summary>
        public readonly int Bitrate;
        /// <summary>
        /// The VBV buffer window length. The value should be in ISO 8601 format. The value should be in the range [0.1-100] seconds. The default is 5 seconds (for example, PT5S).
        /// </summary>
        public readonly string? BufferWindow;
        /// <summary>
        /// The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video.
        /// </summary>
        public readonly string? FrameRate;
        /// <summary>
        /// The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input.
        /// </summary>
        public readonly string? Height;
        /// <summary>
        /// The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file.
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// We currently support Level up to 6.2. The value can be Auto, or a number that matches the H.265 profile. If not specified, the default is Auto, which lets the encoder choose the Level that is appropriate for this layer.
        /// </summary>
        public readonly string? Level;
        /// <summary>
        /// The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate.
        /// </summary>
        public readonly int? MaxBitrate;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.H265VideoLayer'.
        /// </summary>
        public readonly string OdataType;
        /// <summary>
        /// We currently support Main. Default is Auto.
        /// </summary>
        public readonly string? Profile;
        /// <summary>
        /// The number of reference frames to be used when encoding this layer. If not specified, the encoder determines an appropriate number based on the encoder complexity setting.
        /// </summary>
        public readonly int? ReferenceFrames;
        /// <summary>
        /// The number of slices to be used when encoding this layer. If not specified, default is zero, which means that encoder will use a single slice for each frame.
        /// </summary>
        public readonly int? Slices;
        /// <summary>
        /// The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input.
        /// </summary>
        public readonly string? Width;

        [OutputConstructor]
        private H265LayerResponse(
            bool? adaptiveBFrame,

            int? bFrames,

            int bitrate,

            string? bufferWindow,

            string? frameRate,

            string? height,

            string? label,

            string? level,

            int? maxBitrate,

            string odataType,

            string? profile,

            int? referenceFrames,

            int? slices,

            string? width)
        {
            AdaptiveBFrame = adaptiveBFrame;
            BFrames = bFrames;
            Bitrate = bitrate;
            BufferWindow = bufferWindow;
            FrameRate = frameRate;
            Height = height;
            Label = label;
            Level = level;
            MaxBitrate = maxBitrate;
            OdataType = odataType;
            Profile = profile;
            ReferenceFrames = referenceFrames;
            Slices = slices;
            Width = width;
        }
    }
}
