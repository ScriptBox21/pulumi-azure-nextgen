// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201201.Inputs
{

    /// <summary>
    /// Describes a Encryption Settings for a Disk
    /// </summary>
    public sealed class DiskEncryptionSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the location of the disk encryption key, which is a Key Vault Secret.
        /// </summary>
        [Input("diskEncryptionKey")]
        public Input<Inputs.KeyVaultSecretReferenceArgs>? DiskEncryptionKey { get; set; }

        /// <summary>
        /// Specifies whether disk encryption should be enabled on the virtual machine.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Specifies the location of the key encryption key in Key Vault.
        /// </summary>
        [Input("keyEncryptionKey")]
        public Input<Inputs.KeyVaultKeyReferenceArgs>? KeyEncryptionKey { get; set; }

        public DiskEncryptionSettingsArgs()
        {
        }
    }
}
