// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.PowerPlatform.V20201030Preview.Outputs
{

    [OutputType]
    public sealed class EnterprisePolicyIdentityResponse
    {
        /// <summary>
        /// The encryption settings for a configuration store.
        /// </summary>
        public readonly Outputs.EnterprisePolicyIdentityResponseEncryption? Encryption;
        /// <summary>
        /// Settings concerning lockbox.
        /// </summary>
        public readonly Outputs.EnterprisePolicyIdentityResponseLockbox? Lockbox;
        /// <summary>
        /// The principal id of EnterprisePolicy identity.
        /// </summary>
        public readonly string SystemAssignedIdentityPrincipalId;
        /// <summary>
        /// Metadata for the enterprisePolicy.
        /// </summary>
        public readonly Outputs.SystemDataResponse? SystemData;
        /// <summary>
        /// The tenant id associated with the EnterprisePolicy.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The type of identity used for the EnterprisePolicy. Currently, the only supported type is 'SystemAssigned', which implicitly creates an identity.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private EnterprisePolicyIdentityResponse(
            Outputs.EnterprisePolicyIdentityResponseEncryption? encryption,

            Outputs.EnterprisePolicyIdentityResponseLockbox? lockbox,

            string systemAssignedIdentityPrincipalId,

            Outputs.SystemDataResponse? systemData,

            string tenantId,

            string? type)
        {
            Encryption = encryption;
            Lockbox = lockbox;
            SystemAssignedIdentityPrincipalId = systemAssignedIdentityPrincipalId;
            SystemData = systemData;
            TenantId = tenantId;
            Type = type;
        }
    }
}
