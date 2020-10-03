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
    /// Specifies the live event type and optional encoding settings for encoding live events.
    /// </summary>
    public sealed class LiveEventEncodingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Live event type. When encodingType is set to None, the service simply passes through the incoming video and audio layer(s) to the output. When encodingType is set to Standard or Premium1080p, a live encoder transcodes the incoming stream into multiple bitrates or layers. See https://go.microsoft.com/fwlink/?linkid=2095101 for more information. This property cannot be modified after the live event is created.
        /// </summary>
        [Input("encodingType")]
        public Input<string>? EncodingType { get; set; }

        /// <summary>
        /// Use an ISO 8601 time value between 0.5 to 20 seconds to specify the output fragment length for the video and audio tracks of an encoding live event. For example, use PT2S to indicate 2 seconds. For the video track it also defines the key frame interval, or the length of a GoP (group of pictures).   If this value is not set for an encoding live event, the fragment duration defaults to 2 seconds. The value cannot be set for pass-through live events.
        /// </summary>
        [Input("keyFrameInterval")]
        public Input<string>? KeyFrameInterval { get; set; }

        /// <summary>
        /// The optional encoding preset name, used when encodingType is not None. This value is specified at creation time and cannot be updated. If the encodingType is set to Standard, then the default preset name is ‘Default720p’. Else if the encodingType is set to Premium1080p, the default preset is ‘Default1080p’.
        /// </summary>
        [Input("presetName")]
        public Input<string>? PresetName { get; set; }

        /// <summary>
        /// Specifies how the input video will be resized to fit the desired output resolution(s). Default is None
        /// </summary>
        [Input("stretchMode")]
        public Input<string>? StretchMode { get; set; }

        public LiveEventEncodingArgs()
        {
        }
    }
}
