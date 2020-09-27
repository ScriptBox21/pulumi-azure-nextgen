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
    public sealed class ParameterDefinitionResponse
    {
        /// <summary>
        /// Description of this parameter/resourceGroup.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// DisplayName of this parameter/resourceGroup.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// StrongType for UI to render rich experience during assignment time.
        /// </summary>
        public readonly string? StrongType;
        /// <summary>
        /// Allowed data types for Azure Resource Manager template parameters.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ParameterDefinitionResponse(
            string? description,

            string? displayName,

            string? strongType,

            string type)
        {
            Description = description;
            DisplayName = displayName;
            StrongType = strongType;
            Type = type;
        }
    }
}
