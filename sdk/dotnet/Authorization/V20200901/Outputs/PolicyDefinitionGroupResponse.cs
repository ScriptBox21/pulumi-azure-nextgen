// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20200901.Outputs
{

    [OutputType]
    public sealed class PolicyDefinitionGroupResponse
    {
        /// <summary>
        /// A resource ID of a resource that contains additional metadata about the group.
        /// </summary>
        public readonly string? AdditionalMetadataId;
        /// <summary>
        /// The group's category.
        /// </summary>
        public readonly string? Category;
        /// <summary>
        /// The group's description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The group's display name.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The name of the group.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private PolicyDefinitionGroupResponse(
            string? additionalMetadataId,

            string? category,

            string? description,

            string? displayName,

            string name)
        {
            AdditionalMetadataId = additionalMetadataId;
            Category = category;
            Description = description;
            DisplayName = displayName;
            Name = name;
        }
    }
}
