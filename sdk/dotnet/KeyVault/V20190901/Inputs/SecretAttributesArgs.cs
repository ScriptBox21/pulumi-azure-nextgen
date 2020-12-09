// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.KeyVault.V20190901.Inputs
{

    /// <summary>
    /// The secret management attributes.
    /// </summary>
    public sealed class SecretAttributesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Determines whether the object is enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Expiry date in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [Input("expires")]
        public Input<int>? Expires { get; set; }

        /// <summary>
        /// Not before date in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [Input("notBefore")]
        public Input<int>? NotBefore { get; set; }

        public SecretAttributesArgs()
        {
        }
    }
}
