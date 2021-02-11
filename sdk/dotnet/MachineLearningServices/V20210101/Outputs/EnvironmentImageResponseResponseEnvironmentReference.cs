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
    public sealed class EnvironmentImageResponseResponseEnvironmentReference
    {
        /// <summary>
        /// Name of the environment.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Version of the environment.
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private EnvironmentImageResponseResponseEnvironmentReference(
            string? name,

            string? version)
        {
            Name = name;
            Version = version;
        }
    }
}
