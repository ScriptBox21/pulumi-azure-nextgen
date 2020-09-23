// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.Latest
{
    public static class GetDisk
    {
        public static Task<GetDiskResult> InvokeAsync(GetDiskArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDiskResult>("azure-nextgen:compute/latest:getDisk", args ?? new GetDiskArgs(), options.WithVersion());
    }


    public sealed class GetDiskArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters.
        /// </summary>
        [Input("diskName", required: true)]
        public string DiskName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDiskArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDiskResult
    {
        /// <summary>
        /// Disk source information. CreationData information cannot be changed after the disk has been created.
        /// </summary>
        public readonly Outputs.CreationDataResponse CreationData;
        /// <summary>
        /// ARM id of the DiskAccess resource for using private endpoints on disks.
        /// </summary>
        public readonly string? DiskAccessId;
        /// <summary>
        /// The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One operation can transfer between 4k and 256k bytes.
        /// </summary>
        public readonly int? DiskIOPSReadOnly;
        /// <summary>
        /// The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.
        /// </summary>
        public readonly int? DiskIOPSReadWrite;
        /// <summary>
        /// The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10.
        /// </summary>
        public readonly int? DiskMBpsReadOnly;
        /// <summary>
        /// The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10.
        /// </summary>
        public readonly int? DiskMBpsReadWrite;
        /// <summary>
        /// The size of the disk in bytes. This field is read only.
        /// </summary>
        public readonly int DiskSizeBytes;
        /// <summary>
        /// If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        /// </summary>
        public readonly int? DiskSizeGB;
        /// <summary>
        /// The state of the disk.
        /// </summary>
        public readonly string DiskState;
        /// <summary>
        /// Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.
        /// </summary>
        public readonly Outputs.EncryptionResponse? Encryption;
        /// <summary>
        /// Encryption settings collection used for Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot.
        /// </summary>
        public readonly Outputs.EncryptionSettingsCollectionResponse? EncryptionSettingsCollection;
        /// <summary>
        /// The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        /// </summary>
        public readonly string? HyperVGeneration;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// A relative URI containing the ID of the VM that has the disk attached.
        /// </summary>
        public readonly string ManagedBy;
        /// <summary>
        /// List of relative URIs containing the IDs of the VMs that have the disk attached. maxShares should be set to a value greater than one for disks to allow attaching them to multiple VMs.
        /// </summary>
        public readonly ImmutableArray<string> ManagedByExtended;
        /// <summary>
        /// The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time.
        /// </summary>
        public readonly int? MaxShares;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Policy for accessing the disk via network.
        /// </summary>
        public readonly string? NetworkAccessPolicy;
        /// <summary>
        /// The Operating System type.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// The disk provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Details of the list of all VMs that have the disk attached. maxShares should be set to a value greater than one for disks to allow attaching them to multiple VMs.
        /// </summary>
        public readonly ImmutableArray<Outputs.ShareInfoElementResponse> ShareInfo;
        /// <summary>
        /// The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, or UltraSSD_LRS.
        /// </summary>
        public readonly Outputs.DiskSkuResponse? Sku;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Performance tier of the disk (e.g, P4, S10) as described here: https://azure.microsoft.com/en-us/pricing/details/managed-disks/. Does not apply to Ultra disks.
        /// </summary>
        public readonly string? Tier;
        /// <summary>
        /// The time when the disk was created.
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Unique Guid identifying the resource.
        /// </summary>
        public readonly string UniqueId;
        /// <summary>
        /// The Logical zone list for Disk.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetDiskResult(
            Outputs.CreationDataResponse creationData,

            string? diskAccessId,

            int? diskIOPSReadOnly,

            int? diskIOPSReadWrite,

            int? diskMBpsReadOnly,

            int? diskMBpsReadWrite,

            int diskSizeBytes,

            int? diskSizeGB,

            string diskState,

            Outputs.EncryptionResponse? encryption,

            Outputs.EncryptionSettingsCollectionResponse? encryptionSettingsCollection,

            string? hyperVGeneration,

            string location,

            string managedBy,

            ImmutableArray<string> managedByExtended,

            int? maxShares,

            string name,

            string? networkAccessPolicy,

            string? osType,

            string provisioningState,

            ImmutableArray<Outputs.ShareInfoElementResponse> shareInfo,

            Outputs.DiskSkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string? tier,

            string timeCreated,

            string type,

            string uniqueId,

            ImmutableArray<string> zones)
        {
            CreationData = creationData;
            DiskAccessId = diskAccessId;
            DiskIOPSReadOnly = diskIOPSReadOnly;
            DiskIOPSReadWrite = diskIOPSReadWrite;
            DiskMBpsReadOnly = diskMBpsReadOnly;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DiskSizeBytes = diskSizeBytes;
            DiskSizeGB = diskSizeGB;
            DiskState = diskState;
            Encryption = encryption;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            HyperVGeneration = hyperVGeneration;
            Location = location;
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            MaxShares = maxShares;
            Name = name;
            NetworkAccessPolicy = networkAccessPolicy;
            OsType = osType;
            ProvisioningState = provisioningState;
            ShareInfo = shareInfo;
            Sku = sku;
            Tags = tags;
            Tier = tier;
            TimeCreated = timeCreated;
            Type = type;
            UniqueId = uniqueId;
            Zones = zones;
        }
    }
}
