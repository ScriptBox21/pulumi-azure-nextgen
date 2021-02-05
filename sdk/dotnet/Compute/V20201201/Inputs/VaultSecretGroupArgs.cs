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
    /// Describes a set of certificates which are all in the same Key Vault.
    /// </summary>
    public sealed class VaultSecretGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The relative URL of the Key Vault containing all of the certificates in VaultCertificates.
        /// </summary>
        [Input("sourceVault")]
        public Input<Inputs.SubResourceArgs>? SourceVault { get; set; }

        [Input("vaultCertificates")]
        private InputList<Inputs.VaultCertificateArgs>? _vaultCertificates;

        /// <summary>
        /// The list of key vault references in SourceVault which contain certificates.
        /// </summary>
        public InputList<Inputs.VaultCertificateArgs> VaultCertificates
        {
            get => _vaultCertificates ?? (_vaultCertificates = new InputList<Inputs.VaultCertificateArgs>());
            set => _vaultCertificates = value;
        }

        public VaultSecretGroupArgs()
        {
        }
    }
}
