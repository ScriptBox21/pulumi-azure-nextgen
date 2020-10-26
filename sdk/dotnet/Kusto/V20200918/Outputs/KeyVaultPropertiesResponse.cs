// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Kusto.V20200918.Outputs
{

    [OutputType]
    public sealed class KeyVaultPropertiesResponse
    {
        /// <summary>
        /// The name of the key vault key.
        /// </summary>
        public readonly string KeyName;
        /// <summary>
        /// The Uri of the key vault.
        /// </summary>
        public readonly string KeyVaultUri;
        /// <summary>
        /// The version of the key vault key.
        /// </summary>
        public readonly string? KeyVersion;
        /// <summary>
        /// The user assigned identity (ARM resource id) that has access to the key.
        /// </summary>
        public readonly string? UserIdentity;

        [OutputConstructor]
        private KeyVaultPropertiesResponse(
            string keyName,

            string keyVaultUri,

            string? keyVersion,

            string? userIdentity)
        {
            KeyName = keyName;
            KeyVaultUri = keyVaultUri;
            KeyVersion = keyVersion;
            UserIdentity = userIdentity;
        }
    }
}