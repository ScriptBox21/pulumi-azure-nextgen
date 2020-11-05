// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.Latest.Outputs
{

    [OutputType]
    public sealed class IdentityPropertiesResponse
    {
        /// <summary>
        /// Managed service identity type.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// User assigned identity properties.
        /// </summary>
        public readonly Outputs.UserAssignedPropertiesResponse? UserAssigned;

        [OutputConstructor]
        private IdentityPropertiesResponse(
            string? type,

            Outputs.UserAssignedPropertiesResponse? userAssigned)
        {
            Type = type;
            UserAssigned = userAssigned;
        }
    }
}