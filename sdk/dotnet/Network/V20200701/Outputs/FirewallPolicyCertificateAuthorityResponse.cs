// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class FirewallPolicyCertificateAuthorityResponse
    {
        /// <summary>
        /// Secret Id of (base-64 encoded unencrypted pfx) 'Secret' or 'Certificate' object stored in KeyVault.
        /// </summary>
        public readonly string? KeyVaultSecretId;
        /// <summary>
        /// Name of the CA certificate.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private FirewallPolicyCertificateAuthorityResponse(
            string? keyVaultSecretId,

            string? name)
        {
            KeyVaultSecretId = keyVaultSecretId;
            Name = name;
        }
    }
}