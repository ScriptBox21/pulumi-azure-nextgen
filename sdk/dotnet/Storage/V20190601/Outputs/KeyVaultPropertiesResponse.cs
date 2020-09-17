// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20190601.Outputs
{

    [OutputType]
    public sealed class KeyVaultPropertiesResponse
    {
        /// <summary>
        /// The object identifier of the current versioned Key Vault Key in use.
        /// </summary>
        public readonly string CurrentVersionedKeyIdentifier;
        /// <summary>
        /// The name of KeyVault key.
        /// </summary>
        public readonly string? KeyName;
        /// <summary>
        /// The Uri of KeyVault.
        /// </summary>
        public readonly string? KeyVaultUri;
        /// <summary>
        /// The version of KeyVault key.
        /// </summary>
        public readonly string? KeyVersion;
        /// <summary>
        /// Timestamp of last rotation of the Key Vault Key.
        /// </summary>
        public readonly string LastKeyRotationTimestamp;

        [OutputConstructor]
        private KeyVaultPropertiesResponse(
            string currentVersionedKeyIdentifier,

            string? keyName,

            string? keyVaultUri,

            string? keyVersion,

            string lastKeyRotationTimestamp)
        {
            CurrentVersionedKeyIdentifier = currentVersionedKeyIdentifier;
            KeyName = keyName;
            KeyVaultUri = keyVaultUri;
            KeyVersion = keyVersion;
            LastKeyRotationTimestamp = lastKeyRotationTimestamp;
        }
    }
}