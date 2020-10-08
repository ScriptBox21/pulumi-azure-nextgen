// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200301.Inputs
{

    /// <summary>
    /// Active Directory
    /// </summary>
    public sealed class ActiveDirectoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Id of the Active Directory
        /// </summary>
        [Input("activeDirectoryId")]
        public Input<string>? ActiveDirectoryId { get; set; }

        [Input("backupOperators")]
        private InputList<string>? _backupOperators;

        /// <summary>
        /// Users to be added to the Built-in Backup Operator active directory group. A list of unique usernames without domain specifier
        /// </summary>
        public InputList<string> BackupOperators
        {
            get => _backupOperators ?? (_backupOperators = new InputList<string>());
            set => _backupOperators = value;
        }

        /// <summary>
        /// Comma separated list of DNS server IP addresses (IPv4 only) for the Active Directory domain
        /// </summary>
        [Input("dns")]
        public Input<string>? Dns { get; set; }

        /// <summary>
        /// Name of the Active Directory domain
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The Organizational Unit (OU) within the Windows Active Directory
        /// </summary>
        [Input("organizationalUnit")]
        public Input<string>? OrganizationalUnit { get; set; }

        /// <summary>
        /// Plain text password of Active Directory domain administrator
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The Active Directory site the service will limit Domain Controller discovery to
        /// </summary>
        [Input("site")]
        public Input<string>? Site { get; set; }

        /// <summary>
        /// NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes
        /// </summary>
        [Input("smbServerName")]
        public Input<string>? SmbServerName { get; set; }

        /// <summary>
        /// Status of the Active Directory
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Username of Active Directory domain administrator
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public ActiveDirectoryArgs()
        {
        }
    }
}
