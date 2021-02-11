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
    /// A Sequence contains an ordered list of Clips where each clip is a JobInput.  The Sequence will be treated as a single input.
    /// </summary>
    public sealed class JobInputSequenceArgs : Pulumi.ResourceArgs
    {
        [Input("inputs")]
        private InputList<Inputs.JobInputClipArgs>? _inputs;

        /// <summary>
        /// JobInputs that make up the timeline.
        /// </summary>
        public InputList<Inputs.JobInputClipArgs> Inputs
        {
            get => _inputs ?? (_inputs = new InputList<Inputs.JobInputClipArgs>());
            set => _inputs = value;
        }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.JobInputSequence'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        public JobInputSequenceArgs()
        {
        }
    }
}
