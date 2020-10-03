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
    /// Describes the properties of an audio overlay.
    /// </summary>
    public sealed class AudioOverlayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The gain level of audio in the overlay. The value should be in the range [0, 1.0]. The default is 1.0.
        /// </summary>
        [Input("audioGainLevel")]
        public Input<double>? AudioGainLevel { get; set; }

        /// <summary>
        /// The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration.
        /// </summary>
        [Input("end")]
        public Input<string>? End { get; set; }

        /// <summary>
        /// The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S).
        /// </summary>
        [Input("fadeInDuration")]
        public Input<string>? FadeInDuration { get; set; }

        /// <summary>
        /// The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S).
        /// </summary>
        [Input("fadeOutDuration")]
        public Input<string>? FadeOutDuration { get; set; }

        /// <summary>
        /// The label of the job input which is to be used as an overlay. The Input must specify exactly one file. You can specify an image file in JPG or PNG formats, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file. See https://aka.ms/mesformats for the complete list of supported audio and video file formats.
        /// </summary>
        [Input("inputLabel", required: true)]
        public Input<string> InputLabel { get; set; } = null!;

        /// <summary>
        /// The discriminator for derived types.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video.
        /// </summary>
        [Input("start")]
        public Input<string>? Start { get; set; }

        public AudioOverlayArgs()
        {
        }
    }
}
