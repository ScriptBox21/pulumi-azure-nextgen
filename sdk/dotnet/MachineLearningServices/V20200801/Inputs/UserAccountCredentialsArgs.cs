// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200801.Inputs
{

    /// <summary>
    /// Settings for user account that gets created on each on the nodes of a compute.
    /// </summary>
    public sealed class UserAccountCredentialsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the administrator user account which can be used to SSH to nodes.
        /// </summary>
        [Input("adminUserName", required: true)]
        public Input<string> AdminUserName { get; set; } = null!;

        /// <summary>
        /// Password of the administrator user account.
        /// </summary>
        [Input("adminUserPassword")]
        public Input<string>? AdminUserPassword { get; set; }

        /// <summary>
        /// SSH public key of the administrator user account.
        /// </summary>
        [Input("adminUserSshPublicKey")]
        public Input<string>? AdminUserSshPublicKey { get; set; }

        public UserAccountCredentialsArgs()
        {
        }
    }
}
