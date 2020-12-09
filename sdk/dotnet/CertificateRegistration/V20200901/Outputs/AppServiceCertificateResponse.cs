// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CertificateRegistration.V20200901.Outputs
{

    [OutputType]
    public sealed class AppServiceCertificateResponse
    {
        /// <summary>
        /// Key Vault resource Id.
        /// </summary>
        public readonly string? KeyVaultId;
        /// <summary>
        /// Key Vault secret name.
        /// </summary>
        public readonly string? KeyVaultSecretName;
        /// <summary>
        /// Status of the Key Vault secret.
        /// </summary>
        public readonly string ProvisioningState;

        [OutputConstructor]
        private AppServiceCertificateResponse(
            string? keyVaultId,

            string? keyVaultSecretName,

            string provisioningState)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            ProvisioningState = provisioningState;
        }
    }
}
