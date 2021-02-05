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
    /// Specifies settings related to VM Guest Patching on Linux.
    /// </summary>
    public sealed class LinuxPatchSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **ImageDefault** - The virtual machine's default patching configuration is used. &lt;br /&gt;&lt;br /&gt; **AutomaticByPlatform** - The virtual machine will be automatically updated by the platform. The property provisionVMAgent must be true
        /// </summary>
        [Input("patchMode")]
        public InputUnion<string, Pulumi.AzureNextGen.Compute.V20201201.LinuxVMGuestPatchMode>? PatchMode { get; set; }

        public LinuxPatchSettingsArgs()
        {
        }
    }
}
