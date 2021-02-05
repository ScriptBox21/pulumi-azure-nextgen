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
    /// Specifies settings related to VM Guest Patching on Windows.
    /// </summary>
    public sealed class PatchSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables customers to patch their Azure VMs without requiring a reboot. For enableHotpatching, the 'provisionVMAgent' must be set to true and 'patchMode' must be set to 'AutomaticByPlatform'.
        /// </summary>
        [Input("enableHotpatching")]
        public Input<bool>? EnableHotpatching { get; set; }

        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of patches to a virtual machine. You do this by applying patches manually inside the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be false&lt;br /&gt;&lt;br /&gt; **AutomaticByOS** - The virtual machine will automatically be updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates must be true. &lt;br /&gt;&lt;br /&gt; ** AutomaticByPlatform** - the virtual machine will automatically updated by the platform. The properties provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates must be true 
        /// </summary>
        [Input("patchMode")]
        public InputUnion<string, Pulumi.AzureNextGen.Compute.V20201201.WindowsVMGuestPatchMode>? PatchMode { get; set; }

        public PatchSettingsArgs()
        {
        }
    }
}
