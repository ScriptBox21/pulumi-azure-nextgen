// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20210301.Outputs
{

    [OutputType]
    public sealed class GitRepoVolumeResponse
    {
        /// <summary>
        /// Target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.
        /// </summary>
        public readonly string? Directory;
        /// <summary>
        /// Repository URL
        /// </summary>
        public readonly string Repository;
        /// <summary>
        /// Commit hash for the specified revision.
        /// </summary>
        public readonly string? Revision;

        [OutputConstructor]
        private GitRepoVolumeResponse(
            string? directory,

            string repository,

            string? revision)
        {
            Directory = directory;
            Repository = repository;
            Revision = revision;
        }
    }
}
