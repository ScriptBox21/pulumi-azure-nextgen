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
    /// Describes a virtual machine scale set OS profile.
    /// </summary>
    public sealed class VirtualMachineScaleSetOSProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length (Windows):** 8 characters &lt;br&gt;&lt;br&gt; **Minimum-length (Linux):** 6 characters &lt;br&gt;&lt;br&gt; **Max-length (Windows):** 123 characters &lt;br&gt;&lt;br&gt; **Max-length (Linux):** 72 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** "abc@123", "P@$$w0rd", "P@ssw0rd", "P@ssword123", "Pa$$word", "pass@word1", "Password!", "Password1", "Password22", "iloveyou!" &lt;br&gt;&lt;br&gt; For resetting the password, see [How to reset the Remote Desktop service or its login password in a Windows VM](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-reset-rdp?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; For resetting root password, see [Manage users, SSH, and check or repair disks on Azure Linux VMs using the VMAccess Extension](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-vmaccess-extension?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#reset-root-password)
        /// </summary>
        [Input("adminPassword")]
        public Input<string>? AdminPassword { get; set; }

        /// <summary>
        /// Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Windows-only restriction:** Cannot end in "." &lt;br&gt;&lt;br&gt; **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5". &lt;br&gt;&lt;br&gt; **Minimum-length (Linux):** 1  character &lt;br&gt;&lt;br&gt; **Max-length (Linux):** 64 characters &lt;br&gt;&lt;br&gt; **Max-length (Windows):** 20 characters  &lt;br&gt;&lt;br&gt;&lt;li&gt; For root access to the Linux VM, see [Using root privileges on Linux virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-use-root-privileges?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)&lt;br&gt;&lt;li&gt; For a list of built-in system users on Linux that should not be used in this field, see [Selecting User Names for Linux on Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-usernames?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        [Input("adminUsername")]
        public Input<string>? AdminUsername { get; set; }

        /// <summary>
        /// Specifies the computer name prefix for all of the virtual machines in the scale set. Computer name prefixes must be 1 to 15 characters long.
        /// </summary>
        [Input("computerNamePrefix")]
        public Input<string>? ComputerNamePrefix { get; set; }

        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes. &lt;br&gt;&lt;br&gt; For using cloud-init for your VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        [Input("customData")]
        public Input<string>? CustomData { get; set; }

        /// <summary>
        /// Specifies the Linux operating system settings on the virtual machine. &lt;br&gt;&lt;br&gt;For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) &lt;br&gt;&lt;br&gt; For running non-endorsed distributions, see [Information for Non-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
        /// </summary>
        [Input("linuxConfiguration")]
        public Input<Inputs.LinuxConfigurationArgs>? LinuxConfiguration { get; set; }

        [Input("secrets")]
        private InputList<Inputs.VaultSecretGroupArgs>? _secrets;

        /// <summary>
        /// Specifies set of certificates that should be installed onto the virtual machines in the scale set.
        /// </summary>
        public InputList<Inputs.VaultSecretGroupArgs> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<Inputs.VaultSecretGroupArgs>());
            set => _secrets = value;
        }

        /// <summary>
        /// Specifies Windows operating system settings on the virtual machine.
        /// </summary>
        [Input("windowsConfiguration")]
        public Input<Inputs.WindowsConfigurationArgs>? WindowsConfiguration { get; set; }

        public VirtualMachineScaleSetOSProfileArgs()
        {
        }
    }
}
