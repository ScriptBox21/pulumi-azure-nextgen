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
    public sealed class EnterprisePolicyIdentityResponseEncryption
    {
        /// <summary>
        /// Key vault properties.
        /// </summary>
        public readonly Outputs.KeyVaultPropertiesResponse? KeyVaultProperties;

        [OutputConstructor]
        private EnterprisePolicyIdentityResponseEncryption(Outputs.KeyVaultPropertiesResponse? keyVaultProperties)
        {
            KeyVaultProperties = keyVaultProperties;
        }
    }
}
