// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.Latest.Inputs
{

    /// <summary>
    /// The definition of a Docker container.
    /// </summary>
    public sealed class ModelEnvironmentDefinitionDockerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Base Dockerfile used for Docker-based runs. Mutually exclusive with BaseImage.
        /// </summary>
        [Input("baseDockerfile")]
        public Input<string>? BaseDockerfile { get; set; }

        /// <summary>
        /// Base image used for Docker-based runs. Mutually exclusive with BaseDockerfile.
        /// </summary>
        [Input("baseImage")]
        public Input<string>? BaseImage { get; set; }

        /// <summary>
        /// Image registry that contains the base image.
        /// </summary>
        [Input("baseImageRegistry")]
        public Input<Inputs.ModelDockerSectionBaseImageRegistryArgs>? BaseImageRegistry { get; set; }

        public ModelEnvironmentDefinitionDockerArgs()
        {
        }
    }
}
