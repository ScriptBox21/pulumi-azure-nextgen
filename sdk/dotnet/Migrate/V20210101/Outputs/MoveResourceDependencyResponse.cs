// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.V20210101.Outputs
{

    [OutputType]
    public sealed class MoveResourceDependencyResponse
    {
        /// <summary>
        /// Defines the properties for automatic resolution.
        /// </summary>
        public readonly Outputs.AutomaticResolutionPropertiesResponse? AutomaticResolution;
        /// <summary>
        /// Defines the dependency type.
        /// </summary>
        public readonly string? DependencyType;
        /// <summary>
        /// Gets the source ARM ID of the dependent resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Gets or sets a value indicating whether the dependency is optional.
        /// </summary>
        public readonly string? IsOptional;
        /// <summary>
        /// Defines the properties for manual resolution.
        /// </summary>
        public readonly Outputs.ManualResolutionPropertiesResponse? ManualResolution;
        /// <summary>
        /// Gets the dependency resolution status.
        /// </summary>
        public readonly string? ResolutionStatus;
        /// <summary>
        /// Defines the resolution type.
        /// </summary>
        public readonly string? ResolutionType;

        [OutputConstructor]
        private MoveResourceDependencyResponse(
            Outputs.AutomaticResolutionPropertiesResponse? automaticResolution,

            string? dependencyType,

            string? id,

            string? isOptional,

            Outputs.ManualResolutionPropertiesResponse? manualResolution,

            string? resolutionStatus,

            string? resolutionType)
        {
            AutomaticResolution = automaticResolution;
            DependencyType = dependencyType;
            Id = id;
            IsOptional = isOptional;
            ManualResolution = manualResolution;
            ResolutionStatus = resolutionStatus;
            ResolutionType = resolutionType;
        }
    }
}
