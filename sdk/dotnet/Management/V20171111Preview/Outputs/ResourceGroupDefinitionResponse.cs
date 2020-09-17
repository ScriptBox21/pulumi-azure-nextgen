// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Management.V20171111Preview.Outputs
{

    [OutputType]
    public sealed class ResourceGroupDefinitionResponse
    {
        /// <summary>
        /// Artifacts which need to be deployed before this resource group.
        /// </summary>
        public readonly ImmutableArray<string> DependsOn;
        /// <summary>
        /// Description of this parameter/resourceGroup.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// DisplayName of this parameter/resourceGroup.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// Location of this resourceGroup, leave empty if the resource group location will be specified during the Blueprint assignment.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Name of this resourceGroup, leave empty if the resource group name will be specified during the Blueprint assignment.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// StrongType for UI to render rich experience during assignment time.
        /// </summary>
        public readonly string? StrongType;

        [OutputConstructor]
        private ResourceGroupDefinitionResponse(
            ImmutableArray<string> dependsOn,

            string? description,

            string? displayName,

            string? location,

            string? name,

            string? strongType)
        {
            DependsOn = dependsOn;
            Description = description;
            DisplayName = displayName;
            Location = location;
            Name = name;
            StrongType = strongType;
        }
    }
}