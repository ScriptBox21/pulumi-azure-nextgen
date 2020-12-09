// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20200801.Outputs
{

    [OutputType]
    public sealed class AliasPathResponse
    {
        /// <summary>
        /// The API versions.
        /// </summary>
        public readonly ImmutableArray<string> ApiVersions;
        /// <summary>
        /// The metadata of the alias path. If missing, fall back to the default metadata of the alias.
        /// </summary>
        public readonly Outputs.AliasPathMetadataResponse Metadata;
        /// <summary>
        /// The path of an alias.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// The pattern for an alias path.
        /// </summary>
        public readonly Outputs.AliasPatternResponse? Pattern;

        [OutputConstructor]
        private AliasPathResponse(
            ImmutableArray<string> apiVersions,

            Outputs.AliasPathMetadataResponse metadata,

            string? path,

            Outputs.AliasPatternResponse? pattern)
        {
            ApiVersions = apiVersions;
            Metadata = metadata;
            Path = path;
            Pattern = pattern;
        }
    }
}
