// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20210101.Outputs
{

    [OutputType]
    public sealed class ComputeInstanceSshSettingsResponse
    {
        /// <summary>
        /// Specifies the SSH rsa public key file as a string. Use "ssh-keygen -t rsa -b 2048" to generate your SSH key pairs.
        /// </summary>
        public readonly string? AdminPublicKey;
        /// <summary>
        /// Describes the admin user name.
        /// </summary>
        public readonly string AdminUserName;
        /// <summary>
        /// Describes the port for connecting through SSH.
        /// </summary>
        public readonly int SshPort;
        /// <summary>
        /// State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the VNet/subnet policy if applicable.
        /// </summary>
        public readonly string? SshPublicAccess;

        [OutputConstructor]
        private ComputeInstanceSshSettingsResponse(
            string? adminPublicKey,

            string adminUserName,

            int sshPort,

            string? sshPublicAccess)
        {
            AdminPublicKey = adminPublicKey;
            AdminUserName = adminUserName;
            SshPort = sshPort;
            SshPublicAccess = sshPublicAccess;
        }
    }
}
