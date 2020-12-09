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
    public sealed class FactoryIdentityResponse
    {
        /// <summary>
        /// The principal id of the identity.
        /// </summary>
        public readonly string PrincipalId;
        /// <summary>
        /// The client tenant id of the identity.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The identity type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// List of user assigned identities for the factory.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? UserAssignedIdentities;

        [OutputConstructor]
        private FactoryIdentityResponse(
            string principalId,

            string tenantId,

            string type,

            ImmutableDictionary<string, object>? userAssignedIdentities)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
        }
    }
}
