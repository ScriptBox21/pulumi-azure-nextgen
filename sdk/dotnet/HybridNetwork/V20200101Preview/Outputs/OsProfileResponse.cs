// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridNetwork.V20200101Preview.Outputs
{

    [OutputType]
    public sealed class OsProfileResponse
    {
        /// <summary>
        /// Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Windows-only restriction:** Cannot end in "." &lt;br&gt;&lt;br&gt; **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". &lt;br&gt;&lt;br&gt; **Minimum-length (Linux):** 1  character &lt;br&gt;&lt;br&gt; **Max-length (Linux):** 64 characters &lt;br&gt;&lt;br&gt; **Max-length (Windows):** 20 characters  &lt;br&gt;&lt;br&gt;&lt;li&gt; For root access to the Linux VM, see [Using root privileges on Linux virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)&lt;br&gt;&lt;li&gt; For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for Linux on Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
        /// </summary>
        public readonly string? AdminUsername;
        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. &lt;br&gt;&lt;br&gt; **Note: Do not pass any secrets or passwords in customData property** &lt;br&gt;&lt;br&gt; This property cannot be updated after the VM is created. &lt;br&gt;&lt;br&gt; customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/) &lt;br&gt;&lt;br&gt; For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        public readonly string? CustomData;
        /// <summary>
        /// Indicates if custom data is required to deploy this role.
        /// </summary>
        public readonly bool? CustomDataRequired;
        /// <summary>
        /// Specifies the Linux operating system settings on the virtual machine. &lt;br&gt;&lt;br&gt;For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) &lt;br&gt;&lt;br&gt; For running non-endorsed distributions, see [Information for Non-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
        /// </summary>
        public readonly Outputs.LinuxConfigurationResponse? LinuxConfiguration;

        [OutputConstructor]
        private OsProfileResponse(
            string? adminUsername,

            string? customData,

            bool? customDataRequired,

            Outputs.LinuxConfigurationResponse? linuxConfiguration)
        {
            AdminUsername = adminUsername;
            CustomData = customData;
            CustomDataRequired = customDataRequired;
            LinuxConfiguration = linuxConfiguration;
        }
    }
}
