// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Batch.Latest.Inputs
{

    /// <summary>
    /// Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead.
    /// </summary>
    public sealed class EncryptionPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of the key source.
        /// </summary>
        [Input("keySource")]
        public Input<string>? KeySource { get; set; }

        /// <summary>
        /// Additional details when using Microsoft.KeyVault
        /// </summary>
        [Input("keyVaultProperties")]
        public Input<Inputs.KeyVaultPropertiesArgs>? KeyVaultProperties { get; set; }

        public EncryptionPropertiesArgs()
        {
        }
    }
}