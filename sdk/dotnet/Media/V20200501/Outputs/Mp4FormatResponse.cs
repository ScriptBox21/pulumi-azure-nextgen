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
    public sealed class Mp4FormatResponse
    {
        /// <summary>
        /// The pattern of the file names for the generated output files. The following macros are supported in the file name: {Basename} - An expansion macro that will use the name of the input video file. If the base name(the file suffix is not included) of the input video file is less than 32 characters long, the base name of input video files will be used. If the length of base name of the input video file exceeds 32 characters, the base name is truncated to the first 32 characters in total length. {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {Bitrate} - The audio/video bitrate. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. {Resolution} - The video resolution. Any unsubstituted macros will be collapsed and removed from the filename.
        /// </summary>
        public readonly string FilenamePattern;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.MultiBitrateFormat'.
        /// </summary>
        public readonly string OdataType;
        /// <summary>
        /// The list of output files to produce.  Each entry in the list is a set of audio and video layer labels to be muxed together .
        /// </summary>
        public readonly ImmutableArray<Outputs.OutputFileResponse> OutputFiles;

        [OutputConstructor]
        private Mp4FormatResponse(
            string filenamePattern,

            string odataType,

            ImmutableArray<Outputs.OutputFileResponse> outputFiles)
        {
            FilenamePattern = filenamePattern;
            OdataType = odataType;
            OutputFiles = outputFiles;
        }
    }
}
