// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20210101.Outputs
{

    [OutputType]
    public sealed class ModelEnvironmentDefinitionResponseResponseDocker
    {
        /// <summary>
        /// Base Dockerfile used for Docker-based runs. Mutually exclusive with BaseImage.
        /// </summary>
        public readonly string? BaseDockerfile;
        /// <summary>
        /// Base image used for Docker-based runs. Mutually exclusive with BaseDockerfile.
        /// </summary>
        public readonly string? BaseImage;
        /// <summary>
        /// Image registry that contains the base image.
        /// </summary>
        public readonly Outputs.ModelDockerSectionResponseResponseBaseImageRegistry? BaseImageRegistry;

        [OutputConstructor]
        private ModelEnvironmentDefinitionResponseResponseDocker(
            string? baseDockerfile,

            string? baseImage,

            Outputs.ModelDockerSectionResponseResponseBaseImageRegistry? baseImageRegistry)
        {
            BaseDockerfile = baseDockerfile;
            BaseImage = baseImage;
            BaseImageRegistry = baseImageRegistry;
        }
    }
}
