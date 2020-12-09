// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class CMKIdentityDefinitionResponse
    {
        /// <summary>
        /// The resource id of the user assigned identity to authenticate to customer's key vault.
        /// </summary>
        public readonly string? UserAssignedIdentity;

        [OutputConstructor]
        private CMKIdentityDefinitionResponse(string? userAssignedIdentity)
        {
            UserAssignedIdentity = userAssignedIdentity;
        }
    }
}
