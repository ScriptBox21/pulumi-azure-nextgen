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
    public sealed class NetworkFunctionUserConfigurationResponseOsProfile
    {
        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. &lt;br&gt;&lt;br&gt; **Note: Do not pass any secrets or passwords in customData property** &lt;br&gt;&lt;br&gt; This property cannot be updated after the VM is created. &lt;br&gt;&lt;br&gt; customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/) &lt;br&gt;&lt;br&gt; For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        public readonly string? CustomData;

        [OutputConstructor]
        private NetworkFunctionUserConfigurationResponseOsProfile(string? customData)
        {
            CustomData = customData;
        }
    }
}