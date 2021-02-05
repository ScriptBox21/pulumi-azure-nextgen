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
    /// Describes a data disk.
    /// </summary>
    public sealed class ImageDataDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Virtual Hard Disk.
        /// </summary>
        [Input("blobUri")]
        public Input<string>? BlobUri { get; set; }

        /// <summary>
        /// Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**
        /// </summary>
        [Input("caching")]
        public Input<Pulumi.AzureNextGen.Compute.V20201201.CachingTypes>? Caching { get; set; }

        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed image disk.
        /// </summary>
        [Input("diskEncryptionSet")]
        public Input<Inputs.DiskEncryptionSetParametersArgs>? DiskEncryptionSet { get; set; }

        /// <summary>
        /// Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB
        /// </summary>
        [Input("diskSizeGB")]
        public Input<int>? DiskSizeGB { get; set; }

        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM.
        /// </summary>
        [Input("lun", required: true)]
        public Input<int> Lun { get; set; } = null!;

        /// <summary>
        /// The managedDisk.
        /// </summary>
        [Input("managedDisk")]
        public Input<Inputs.SubResourceArgs>? ManagedDisk { get; set; }

        /// <summary>
        /// The snapshot.
        /// </summary>
        [Input("snapshot")]
        public Input<Inputs.SubResourceArgs>? Snapshot { get; set; }

        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [Input("storageAccountType")]
        public InputUnion<string, Pulumi.AzureNextGen.Compute.V20201201.StorageAccountTypes>? StorageAccountType { get; set; }

        public ImageDataDiskArgs()
        {
        }
    }
}
