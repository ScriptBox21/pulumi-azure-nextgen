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
    /// Represents input files for a Job.
    /// </summary>
    public sealed class JobInputClipArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines a point on the timeline of the input media at which processing will end. Defaults to the end of the input media.
        /// </summary>
        [Input("end")]
        public InputUnion<Inputs.AbsoluteClipTimeArgs, Inputs.UtcClipTimeArgs>? End { get; set; }

        [Input("files")]
        private InputList<string>? _files;

        /// <summary>
        /// List of files. Required for JobInputHttp. Maximum of 4000 characters each.
        /// </summary>
        public InputList<string> Files
        {
            get => _files ?? (_files = new InputList<string>());
            set => _files = value;
        }

        [Input("inputDefinitions")]
        private InputList<object>? _inputDefinitions;

        /// <summary>
        /// Defines a list of InputDefinitions. For each InputDefinition, it defines a list of track selections and related metadata.
        /// </summary>
        public InputList<object> InputDefinitions
        {
            get => _inputDefinitions ?? (_inputDefinitions = new InputList<object>());
            set => _inputDefinitions = value;
        }

        /// <summary>
        /// A label that is assigned to a JobInputClip, that is used to satisfy a reference used in the Transform. For example, a Transform can be authored so as to take an image file with the label 'xyz' and apply it as an overlay onto the input video before it is encoded. When submitting a Job, exactly one of the JobInputs should be the image file, and it should have the label 'xyz'.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.JobInputClip'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// Defines a point on the timeline of the input media at which processing will start. Defaults to the beginning of the input media.
        /// </summary>
        [Input("start")]
        public InputUnion<Inputs.AbsoluteClipTimeArgs, Inputs.UtcClipTimeArgs>? Start { get; set; }

        public JobInputClipArgs()
        {
        }
    }
}
