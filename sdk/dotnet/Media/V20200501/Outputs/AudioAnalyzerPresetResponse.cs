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
    public sealed class AudioAnalyzerPresetResponse
    {
        /// <summary>
        /// The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US').  If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode::Basic, since automatic language detection is not included in basic mode. If the language isn't specified or set to null, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernable speech. If automatic detection fails to find the language, transcription would fallback to 'en-US'." The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463
        /// </summary>
        public readonly string? AudioLanguage;
        /// <summary>
        /// Dictionary containing key value pairs for parameters not exposed in the preset itself
        /// </summary>
        public readonly ImmutableDictionary<string, string>? ExperimentalOptions;
        /// <summary>
        /// Determines the set of audio analysis operations to be performed. If unspecified, the Standard AudioAnalysisMode would be chosen.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// The discriminator for derived types.
        /// </summary>
        public readonly string OdataType;

        [OutputConstructor]
        private AudioAnalyzerPresetResponse(
            string? audioLanguage,

            ImmutableDictionary<string, string>? experimentalOptions,

            string? mode,

            string odataType)
        {
            AudioLanguage = audioLanguage;
            ExperimentalOptions = experimentalOptions;
            Mode = mode;
            OdataType = odataType;
        }
    }
}
