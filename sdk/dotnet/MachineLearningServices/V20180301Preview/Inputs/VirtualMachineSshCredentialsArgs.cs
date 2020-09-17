// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20180301Preview.Inputs
{

    /// <summary>
    /// Admin credentials for virtual machine
    /// </summary>
    public sealed class VirtualMachineSshCredentialsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Password of admin account
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// Private key data
        /// </summary>
        [Input("privateKeyData")]
        public Input<string>? PrivateKeyData { get; set; }

        /// <summary>
        /// Public key data
        /// </summary>
        [Input("publicKeyData")]
        public Input<string>? PublicKeyData { get; set; }

        /// <summary>
        /// Username of admin account
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public VirtualMachineSshCredentialsArgs()
        {
        }
    }
}