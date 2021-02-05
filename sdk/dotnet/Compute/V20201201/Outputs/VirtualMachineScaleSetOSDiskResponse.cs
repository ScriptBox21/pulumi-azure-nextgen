// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201201.Outputs
{

    [OutputType]
    public sealed class VirtualMachineScaleSetOSDiskResponse
    {
        /// <summary>
        /// Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**
        /// </summary>
        public readonly string? Caching;
        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created.&lt;br&gt;&lt;br&gt; The only allowed value is: **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
        /// </summary>
        public readonly string CreateOption;
        /// <summary>
        /// Specifies the ephemeral disk Settings for the operating system disk used by the virtual machine scale set.
        /// </summary>
        public readonly Outputs.DiffDiskSettingsResponse? DiffDiskSettings;
        /// <summary>
        /// Specifies the size of the operating system disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB
        /// </summary>
        public readonly int? DiskSizeGB;
        /// <summary>
        /// Specifies information about the unmanaged user image to base the scale set on.
        /// </summary>
        public readonly Outputs.VirtualHardDiskResponse? Image;
        /// <summary>
        /// The managed disk parameters.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetManagedDiskParametersResponse? ManagedDisk;
        /// <summary>
        /// The disk name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// Specifies the container urls that are used to store operating system disks for the scale set.
        /// </summary>
        public readonly ImmutableArray<string> VhdContainers;
        /// <summary>
        /// Specifies whether writeAccelerator should be enabled or disabled on the disk.
        /// </summary>
        public readonly bool? WriteAcceleratorEnabled;

        [OutputConstructor]
        private VirtualMachineScaleSetOSDiskResponse(
            string? caching,

            string createOption,

            Outputs.DiffDiskSettingsResponse? diffDiskSettings,

            int? diskSizeGB,

            Outputs.VirtualHardDiskResponse? image,

            Outputs.VirtualMachineScaleSetManagedDiskParametersResponse? managedDisk,

            string? name,

            string? osType,

            ImmutableArray<string> vhdContainers,

            bool? writeAcceleratorEnabled)
        {
            Caching = caching;
            CreateOption = createOption;
            DiffDiskSettings = diffDiskSettings;
            DiskSizeGB = diskSizeGB;
            Image = image;
            ManagedDisk = managedDisk;
            Name = name;
            OsType = osType;
            VhdContainers = vhdContainers;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
        }
    }
}
