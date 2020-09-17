// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20190301.Inputs
{

    /// <summary>
    /// The parameters of a managed disk.
    /// </summary>
    public sealed class ManagedDiskParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [Input("storageAccountType")]
        public Input<string>? StorageAccountType { get; set; }

        public ManagedDiskParametersArgs()
        {
        }
    }
}