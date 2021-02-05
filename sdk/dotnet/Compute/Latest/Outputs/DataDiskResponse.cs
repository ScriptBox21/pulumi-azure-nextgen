// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.Latest.Outputs
{

    [OutputType]
    public sealed class DataDiskResponse
    {
        /// <summary>
        /// Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**
        /// </summary>
        public readonly string? Caching;
        /// <summary>
        /// Specifies how the virtual machine should be created.&lt;br&gt;&lt;br&gt; Possible values are:&lt;br&gt;&lt;br&gt; **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.&lt;br&gt;&lt;br&gt; **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
        /// </summary>
        public readonly string CreateOption;
        /// <summary>
        /// Specifies the detach behavior to be used while detaching a disk or which is already in the process of detachment from the virtual machine. Supported values: **ForceDetach**. &lt;br&gt;&lt;br&gt; detachOption: **ForceDetach** is applicable only for managed data disks. If a previous detachment attempt of the data disk did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed when using this detach behavior. &lt;br&gt;&lt;br&gt; This feature is still in preview mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk update toBeDetached to 'true' along with setting detachOption: 'ForceDetach'.
        /// </summary>
        public readonly string? DetachOption;
        /// <summary>
        /// Specifies the Read-Write IOPS for the managed disk when StorageAccountType is UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine Scale Set.
        /// </summary>
        public readonly double DiskIOPSReadWrite;
        /// <summary>
        /// Specifies the bandwidth in MB per second for the managed disk when StorageAccountType is UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine Scale Set.
        /// </summary>
        public readonly double DiskMBpsReadWrite;
        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB
        /// </summary>
        public readonly int? DiskSizeGB;
        /// <summary>
        /// The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
        /// </summary>
        public readonly Outputs.VirtualHardDiskResponse? Image;
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM.
        /// </summary>
        public readonly int Lun;
        /// <summary>
        /// The managed disk parameters.
        /// </summary>
        public readonly Outputs.ManagedDiskParametersResponse? ManagedDisk;
        /// <summary>
        /// The disk name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset
        /// </summary>
        public readonly bool? ToBeDetached;
        /// <summary>
        /// The virtual hard disk.
        /// </summary>
        public readonly Outputs.VirtualHardDiskResponse? Vhd;
        /// <summary>
        /// Specifies whether writeAccelerator should be enabled or disabled on the disk.
        /// </summary>
        public readonly bool? WriteAcceleratorEnabled;

        [OutputConstructor]
        private DataDiskResponse(
            string? caching,

            string createOption,

            string? detachOption,

            double diskIOPSReadWrite,

            double diskMBpsReadWrite,

            int? diskSizeGB,

            Outputs.VirtualHardDiskResponse? image,

            int lun,

            Outputs.ManagedDiskParametersResponse? managedDisk,

            string? name,

            bool? toBeDetached,

            Outputs.VirtualHardDiskResponse? vhd,

            bool? writeAcceleratorEnabled)
        {
            Caching = caching;
            CreateOption = createOption;
            DetachOption = detachOption;
            DiskIOPSReadWrite = diskIOPSReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DiskSizeGB = diskSizeGB;
            Image = image;
            Lun = lun;
            ManagedDisk = managedDisk;
            Name = name;
            ToBeDetached = toBeDetached;
            Vhd = vhd;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
        }
    }
}
