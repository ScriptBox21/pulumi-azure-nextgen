// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DevOps.V20190701Preview.Inputs
{

    /// <summary>
    /// Repository containing the source code for a pipeline.
    /// </summary>
    public sealed class CodeRepositoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authorization info to access the code repository.
        /// </summary>
        [Input("authorization")]
        public Input<Inputs.AuthorizationArgs>? Authorization { get; set; }

        /// <summary>
        /// Default branch used to configure Continuous Integration (CI) in the pipeline.
        /// </summary>
        [Input("defaultBranch", required: true)]
        public Input<string> DefaultBranch { get; set; } = null!;

        /// <summary>
        /// Unique immutable identifier of the code repository.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Type of code repository.
        /// </summary>
        [Input("repositoryType", required: true)]
        public Input<string> RepositoryType { get; set; } = null!;

        public CodeRepositoryArgs()
        {
        }
    }
}