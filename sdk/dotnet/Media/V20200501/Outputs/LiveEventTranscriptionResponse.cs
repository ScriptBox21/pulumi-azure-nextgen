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
    public sealed class LiveEventTranscriptionResponse
    {
        /// <summary>
        /// Provides a mechanism to select the audio track in the input live feed, to which speech-to-text transcription is applied. This property is reserved for future use, any value set on this property will be ignored.
        /// </summary>
        public readonly ImmutableArray<Outputs.LiveEventInputTrackSelectionResponse> InputTrackSelection;
        /// <summary>
        /// Specifies the language (locale) to be used for speech-to-text transcription – it should match the spoken language in the audio track. The value should be in BCP-47 format (e.g: 'en-US'). See https://go.microsoft.com/fwlink/?linkid=2133742 for more information about the live transcription feature and the list of supported languages.
        /// </summary>
        public readonly string? Language;
        /// <summary>
        /// Describes a transcription track in the output of a live event, generated using speech-to-text transcription. This property is reserved for future use, any value set on this property will be ignored.
        /// </summary>
        public readonly Outputs.LiveEventOutputTranscriptionTrackResponse? OutputTranscriptionTrack;

        [OutputConstructor]
        private LiveEventTranscriptionResponse(
            ImmutableArray<Outputs.LiveEventInputTrackSelectionResponse> inputTrackSelection,

            string? language,

            Outputs.LiveEventOutputTranscriptionTrackResponse? outputTranscriptionTrack)
        {
            InputTrackSelection = inputTrackSelection;
            Language = language;
            OutputTranscriptionTrack = outputTranscriptionTrack;
        }
    }
}
