// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const CachingTypes = {
    None: "None",
    ReadOnly: "ReadOnly",
    ReadWrite: "ReadWrite",
} as const;

/**
 * Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None** for Standard storage. **ReadOnly** for Premium storage.
 */
export type CachingTypes = (typeof CachingTypes)[keyof typeof CachingTypes];

export const ComponentNames = {
    Microsoft_Windows_Shell_Setup: "Microsoft-Windows-Shell-Setup",
} as const;

/**
 * The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.
 */
export type ComponentNames = (typeof ComponentNames)[keyof typeof ComponentNames];

export const DedicatedHostLicenseTypes = {
    None: "None",
    Windows_Server_Hybrid: "Windows_Server_Hybrid",
    Windows_Server_Perpetual: "Windows_Server_Perpetual",
} as const;

/**
 * Specifies the software license type that will be applied to the VMs deployed on the dedicated host. <br><br> Possible values are: <br><br> **None** <br><br> **Windows_Server_Hybrid** <br><br> **Windows_Server_Perpetual** <br><br> Default: **None**
 */
export type DedicatedHostLicenseTypes = (typeof DedicatedHostLicenseTypes)[keyof typeof DedicatedHostLicenseTypes];

export const DiffDiskOptions = {
    Local: "Local",
} as const;

/**
 * Specifies the ephemeral disk settings for operating system disk.
 */
export type DiffDiskOptions = (typeof DiffDiskOptions)[keyof typeof DiffDiskOptions];

export const DiffDiskPlacement = {
    CacheDisk: "CacheDisk",
    ResourceDisk: "ResourceDisk",
} as const;

/**
 * Specifies the ephemeral disk placement for operating system disk.<br><br> Possible values are: <br><br> **CacheDisk** <br><br> **ResourceDisk** <br><br> Default: **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk** is used.<br><br> Refer to VM size documentation for Windows VM at https://docs.microsoft.com/en-us/azure/virtual-machines/windows/sizes and Linux VM at https://docs.microsoft.com/en-us/azure/virtual-machines/linux/sizes to check which VM sizes exposes a cache disk.
 */
export type DiffDiskPlacement = (typeof DiffDiskPlacement)[keyof typeof DiffDiskPlacement];

export const DiskCreateOption = {
    /**
     * Create an empty data disk of a size given by diskSizeGB.
     */
    Empty: "Empty",
    /**
     * Disk will be attached to a VM.
     */
    Attach: "Attach",
    /**
     * Create a new disk from a platform image specified by the given imageReference or galleryImageReference.
     */
    FromImage: "FromImage",
    /**
     * Create a disk by importing from a blob specified by a sourceUri in a storage account specified by storageAccountId.
     */
    Import: "Import",
    /**
     * Create a new disk or snapshot by copying from a disk or snapshot specified by the given sourceResourceId.
     */
    Copy: "Copy",
    /**
     * Create a new disk by copying from a backup recovery point.
     */
    Restore: "Restore",
    /**
     * Create a new disk by obtaining a write token and using it to directly upload the contents of the disk.
     */
    Upload: "Upload",
} as const;

/**
 * This enumerates the possible sources of a disk's creation.
 */
export type DiskCreateOption = (typeof DiskCreateOption)[keyof typeof DiskCreateOption];

export const DiskCreateOptionTypes = {
    FromImage: "FromImage",
    Empty: "Empty",
    Attach: "Attach",
} as const;

/**
 * Specifies how the virtual machine should be created.<br><br> Possible values are:<br><br> **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.<br><br> **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
 */
export type DiskCreateOptionTypes = (typeof DiskCreateOptionTypes)[keyof typeof DiskCreateOptionTypes];

export const DiskEncryptionSetIdentityType = {
    SystemAssigned: "SystemAssigned",
    None: "None",
} as const;

/**
 * The type of Managed Identity used by the DiskEncryptionSet. Only SystemAssigned is supported for new creations. Disk Encryption Sets can be updated with Identity type None during migration of subscription to a new Azure Active Directory tenant; it will cause the encrypted resources to lose access to the keys.
 */
export type DiskEncryptionSetIdentityType = (typeof DiskEncryptionSetIdentityType)[keyof typeof DiskEncryptionSetIdentityType];

export const DiskEncryptionSetType = {
    /**
     * Resource using diskEncryptionSet would be encrypted at rest with Customer managed key that can be changed and revoked by a customer.
     */
    EncryptionAtRestWithCustomerKey: "EncryptionAtRestWithCustomerKey",
    /**
     * Resource using diskEncryptionSet would be encrypted at rest with two layers of encryption. One of the keys is Customer managed and the other key is Platform managed.
     */
    EncryptionAtRestWithPlatformAndCustomerKeys: "EncryptionAtRestWithPlatformAndCustomerKeys",
} as const;

/**
 * The type of key used to encrypt the data of the disk.
 */
export type DiskEncryptionSetType = (typeof DiskEncryptionSetType)[keyof typeof DiskEncryptionSetType];

export const DiskStorageAccountTypes = {
    /**
     * Standard HDD locally redundant storage. Best for backup, non-critical, and infrequent access.
     */
    Standard_LRS: "Standard_LRS",
    /**
     * Premium SSD locally redundant storage. Best for production and performance sensitive workloads.
     */
    Premium_LRS: "Premium_LRS",
    /**
     * Standard SSD locally redundant storage. Best for web servers, lightly used enterprise applications and dev/test.
     */
    StandardSSD_LRS: "StandardSSD_LRS",
    /**
     * Ultra SSD locally redundant storage. Best for IO-intensive workloads such as SAP HANA, top tier databases (for example, SQL, Oracle), and other transaction-heavy workloads.
     */
    UltraSSD_LRS: "UltraSSD_LRS",
} as const;

/**
 * The sku name.
 */
export type DiskStorageAccountTypes = (typeof DiskStorageAccountTypes)[keyof typeof DiskStorageAccountTypes];

export const EncryptionType = {
    /**
     * Disk is encrypted at rest with Platform managed key. It is the default encryption type. This is not a valid encryption type for disk encryption sets.
     */
    EncryptionAtRestWithPlatformKey: "EncryptionAtRestWithPlatformKey",
    /**
     * Disk is encrypted at rest with Customer managed key that can be changed and revoked by a customer.
     */
    EncryptionAtRestWithCustomerKey: "EncryptionAtRestWithCustomerKey",
    /**
     * Disk is encrypted at rest with 2 layers of encryption. One of the keys is Customer managed and the other key is Platform managed.
     */
    EncryptionAtRestWithPlatformAndCustomerKeys: "EncryptionAtRestWithPlatformAndCustomerKeys",
} as const;

/**
 * The type of key used to encrypt the data of the disk.
 */
export type EncryptionType = (typeof EncryptionType)[keyof typeof EncryptionType];

export const ExtendedLocationTypes = {
    EdgeZone: "EdgeZone",
} as const;

/**
 * The type of the extended location.
 */
export type ExtendedLocationTypes = (typeof ExtendedLocationTypes)[keyof typeof ExtendedLocationTypes];

export const GallerySharingPermissionTypes = {
    Private: "Private",
    Groups: "Groups",
} as const;

/**
 * This property allows you to specify the permission of sharing gallery. <br><br> Possible values are: <br><br> **Private** <br><br> **Groups**
 */
export type GallerySharingPermissionTypes = (typeof GallerySharingPermissionTypes)[keyof typeof GallerySharingPermissionTypes];

export const HostCaching = {
    None: "None",
    ReadOnly: "ReadOnly",
    ReadWrite: "ReadWrite",
} as const;

/**
 * The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'
 */
export type HostCaching = (typeof HostCaching)[keyof typeof HostCaching];

export const HyperVGeneration = {
    V1: "V1",
    V2: "V2",
} as const;

/**
 * The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
 */
export type HyperVGeneration = (typeof HyperVGeneration)[keyof typeof HyperVGeneration];

export const HyperVGenerationTypes = {
    V1: "V1",
    V2: "V2",
} as const;

/**
 * Gets the HyperVGenerationType of the VirtualMachine created from the image
 */
export type HyperVGenerationTypes = (typeof HyperVGenerationTypes)[keyof typeof HyperVGenerationTypes];

export const IPVersion = {
    IPv4: "IPv4",
    IPv6: "IPv6",
} as const;

/**
 * Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: 'IPv4' and 'IPv6'.
 */
export type IPVersion = (typeof IPVersion)[keyof typeof IPVersion];

export const InGuestPatchMode = {
    Manual: "Manual",
    AutomaticByOS: "AutomaticByOS",
    AutomaticByPlatform: "AutomaticByPlatform",
} as const;

/**
 * Specifies the mode of in-guest patching to IaaS virtual machine.<br /><br /> Possible values are:<br /><br /> **Manual** - You  control the application of patches to a virtual machine. You do this by applying patches manually inside the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be false<br /><br /> **AutomaticByOS** - The virtual machine will automatically be updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates must be true. <br /><br /> ** AutomaticByPlatform** - the virtual machine will automatically updated by the platform. The properties provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates must be true 
 */
export type InGuestPatchMode = (typeof InGuestPatchMode)[keyof typeof InGuestPatchMode];

export const IntervalInMins = {
    ThreeMins: "ThreeMins",
    FiveMins: "FiveMins",
    ThirtyMins: "ThirtyMins",
    SixtyMins: "SixtyMins",
} as const;

/**
 * Interval value in minutes used to create LogAnalytics call rate logs.
 */
export type IntervalInMins = (typeof IntervalInMins)[keyof typeof IntervalInMins];

export const NetworkAccessPolicy = {
    /**
     * The disk can be exported or uploaded to from any network.
     */
    AllowAll: "AllowAll",
    /**
     * The disk can be exported or uploaded to using a DiskAccess resource's private endpoints.
     */
    AllowPrivate: "AllowPrivate",
    /**
     * The disk cannot be exported.
     */
    DenyAll: "DenyAll",
} as const;

/**
 * Policy for accessing the disk via network.
 */
export type NetworkAccessPolicy = (typeof NetworkAccessPolicy)[keyof typeof NetworkAccessPolicy];

export const OperatingSystemStateTypes = {
    /**
     * Generalized image. Needs to be provisioned during deployment time.
     */
    Generalized: "Generalized",
    /**
     * Specialized image. Contains already provisioned OS Disk.
     */
    Specialized: "Specialized",
} as const;

/**
 * The OS State.
 */
export type OperatingSystemStateTypes = (typeof OperatingSystemStateTypes)[keyof typeof OperatingSystemStateTypes];

export const OperatingSystemTypes = {
    Windows: "Windows",
    Linux: "Linux",
} as const;

/**
 * This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**
 */
export type OperatingSystemTypes = (typeof OperatingSystemTypes)[keyof typeof OperatingSystemTypes];

export const PassNames = {
    OobeSystem: "OobeSystem",
} as const;

/**
 * The pass name. Currently, the only allowable value is OobeSystem.
 */
export type PassNames = (typeof PassNames)[keyof typeof PassNames];

export const PrivateEndpointServiceConnectionStatus = {
    Pending: "Pending",
    Approved: "Approved",
    Rejected: "Rejected",
} as const;

/**
 * Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
 */
export type PrivateEndpointServiceConnectionStatus = (typeof PrivateEndpointServiceConnectionStatus)[keyof typeof PrivateEndpointServiceConnectionStatus];

export const ProtocolTypes = {
    Http: "Http",
    Https: "Https",
} as const;

/**
 * Specifies the protocol of WinRM listener. <br><br> Possible values are: <br>**http** <br><br> **https**
 */
export type ProtocolTypes = (typeof ProtocolTypes)[keyof typeof ProtocolTypes];

export const ProximityPlacementGroupType = {
    Standard: "Standard",
    Ultra: "Ultra",
} as const;

/**
 * Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
 */
export type ProximityPlacementGroupType = (typeof ProximityPlacementGroupType)[keyof typeof ProximityPlacementGroupType];

export const ResourceIdentityType = {
    SystemAssigned: "SystemAssigned",
    UserAssigned: "UserAssigned",
    SystemAssigned_UserAssigned: "SystemAssigned, UserAssigned",
    None: "None",
} as const;

/**
 * The type of identity used for the virtual machine scale set. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities. The type 'None' will remove any identities from the virtual machine scale set.
 */
export type ResourceIdentityType = (typeof ResourceIdentityType)[keyof typeof ResourceIdentityType];

export const SettingNames = {
    AutoLogon: "AutoLogon",
    FirstLogonCommands: "FirstLogonCommands",
} as const;

/**
 * Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon.
 */
export type SettingNames = (typeof SettingNames)[keyof typeof SettingNames];

export const SnapshotStorageAccountTypes = {
    /**
     * Standard HDD locally redundant storage
     */
    Standard_LRS: "Standard_LRS",
    /**
     * Premium SSD locally redundant storage
     */
    Premium_LRS: "Premium_LRS",
    /**
     * Standard zone redundant storage
     */
    Standard_ZRS: "Standard_ZRS",
} as const;

/**
 * The sku name.
 */
export type SnapshotStorageAccountTypes = (typeof SnapshotStorageAccountTypes)[keyof typeof SnapshotStorageAccountTypes];

export const StatusLevelTypes = {
    Info: "Info",
    Warning: "Warning",
    Error: "Error",
} as const;

/**
 * The level code.
 */
export type StatusLevelTypes = (typeof StatusLevelTypes)[keyof typeof StatusLevelTypes];

export const StorageAccountType = {
    Standard_LRS: "Standard_LRS",
    Standard_ZRS: "Standard_ZRS",
    Premium_LRS: "Premium_LRS",
} as const;

/**
 * Specifies the storage account type to be used to store the image. This property is not updatable.
 */
export type StorageAccountType = (typeof StorageAccountType)[keyof typeof StorageAccountType];

export const StorageAccountTypes = {
    Standard_LRS: "Standard_LRS",
    Premium_LRS: "Premium_LRS",
    StandardSSD_LRS: "StandardSSD_LRS",
    UltraSSD_LRS: "UltraSSD_LRS",
} as const;

/**
 * Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
 */
export type StorageAccountTypes = (typeof StorageAccountTypes)[keyof typeof StorageAccountTypes];

export const UpgradeMode = {
    Automatic: "Automatic",
    Manual: "Manual",
    Rolling: "Rolling",
} as const;

/**
 * Specifies the mode of an upgrade to virtual machines in the scale set.<br /><br /> Possible values are:<br /><br /> **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.<br /><br /> **Automatic** - All virtual machines in the scale set are  automatically updated at the same time.
 */
export type UpgradeMode = (typeof UpgradeMode)[keyof typeof UpgradeMode];

export const VirtualMachineEvictionPolicyTypes = {
    Deallocate: "Deallocate",
    Delete: "Delete",
} as const;

/**
 * Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. <br><br>For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01. <br><br>For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview.
 */
export type VirtualMachineEvictionPolicyTypes = (typeof VirtualMachineEvictionPolicyTypes)[keyof typeof VirtualMachineEvictionPolicyTypes];

export const VirtualMachinePriorityTypes = {
    Regular: "Regular",
    Low: "Low",
    Spot: "Spot",
} as const;

/**
 * Specifies the priority for the virtual machines in the scale set. <br><br>Minimum api-version: 2017-10-30-preview
 */
export type VirtualMachinePriorityTypes = (typeof VirtualMachinePriorityTypes)[keyof typeof VirtualMachinePriorityTypes];

export const VirtualMachineScaleSetScaleInRules = {
    Default: "Default",
    OldestVM: "OldestVM",
    NewestVM: "NewestVM",
} as const;

export type VirtualMachineScaleSetScaleInRules = (typeof VirtualMachineScaleSetScaleInRules)[keyof typeof VirtualMachineScaleSetScaleInRules];

export const VirtualMachineSizeTypes = {
    Basic_A0: "Basic_A0",
    Basic_A1: "Basic_A1",
    Basic_A2: "Basic_A2",
    Basic_A3: "Basic_A3",
    Basic_A4: "Basic_A4",
    Standard_A0: "Standard_A0",
    Standard_A1: "Standard_A1",
    Standard_A2: "Standard_A2",
    Standard_A3: "Standard_A3",
    Standard_A4: "Standard_A4",
    Standard_A5: "Standard_A5",
    Standard_A6: "Standard_A6",
    Standard_A7: "Standard_A7",
    Standard_A8: "Standard_A8",
    Standard_A9: "Standard_A9",
    Standard_A10: "Standard_A10",
    Standard_A11: "Standard_A11",
    Standard_A1_v2: "Standard_A1_v2",
    Standard_A2_v2: "Standard_A2_v2",
    Standard_A4_v2: "Standard_A4_v2",
    Standard_A8_v2: "Standard_A8_v2",
    Standard_A2m_v2: "Standard_A2m_v2",
    Standard_A4m_v2: "Standard_A4m_v2",
    Standard_A8m_v2: "Standard_A8m_v2",
    Standard_B1s: "Standard_B1s",
    Standard_B1ms: "Standard_B1ms",
    Standard_B2s: "Standard_B2s",
    Standard_B2ms: "Standard_B2ms",
    Standard_B4ms: "Standard_B4ms",
    Standard_B8ms: "Standard_B8ms",
    Standard_D1: "Standard_D1",
    Standard_D2: "Standard_D2",
    Standard_D3: "Standard_D3",
    Standard_D4: "Standard_D4",
    Standard_D11: "Standard_D11",
    Standard_D12: "Standard_D12",
    Standard_D13: "Standard_D13",
    Standard_D14: "Standard_D14",
    Standard_D1_v2: "Standard_D1_v2",
    Standard_D2_v2: "Standard_D2_v2",
    Standard_D3_v2: "Standard_D3_v2",
    Standard_D4_v2: "Standard_D4_v2",
    Standard_D5_v2: "Standard_D5_v2",
    Standard_D2_v3: "Standard_D2_v3",
    Standard_D4_v3: "Standard_D4_v3",
    Standard_D8_v3: "Standard_D8_v3",
    Standard_D16_v3: "Standard_D16_v3",
    Standard_D32_v3: "Standard_D32_v3",
    Standard_D64_v3: "Standard_D64_v3",
    Standard_D2s_v3: "Standard_D2s_v3",
    Standard_D4s_v3: "Standard_D4s_v3",
    Standard_D8s_v3: "Standard_D8s_v3",
    Standard_D16s_v3: "Standard_D16s_v3",
    Standard_D32s_v3: "Standard_D32s_v3",
    Standard_D64s_v3: "Standard_D64s_v3",
    Standard_D11_v2: "Standard_D11_v2",
    Standard_D12_v2: "Standard_D12_v2",
    Standard_D13_v2: "Standard_D13_v2",
    Standard_D14_v2: "Standard_D14_v2",
    Standard_D15_v2: "Standard_D15_v2",
    Standard_DS1: "Standard_DS1",
    Standard_DS2: "Standard_DS2",
    Standard_DS3: "Standard_DS3",
    Standard_DS4: "Standard_DS4",
    Standard_DS11: "Standard_DS11",
    Standard_DS12: "Standard_DS12",
    Standard_DS13: "Standard_DS13",
    Standard_DS14: "Standard_DS14",
    Standard_DS1_v2: "Standard_DS1_v2",
    Standard_DS2_v2: "Standard_DS2_v2",
    Standard_DS3_v2: "Standard_DS3_v2",
    Standard_DS4_v2: "Standard_DS4_v2",
    Standard_DS5_v2: "Standard_DS5_v2",
    Standard_DS11_v2: "Standard_DS11_v2",
    Standard_DS12_v2: "Standard_DS12_v2",
    Standard_DS13_v2: "Standard_DS13_v2",
    Standard_DS14_v2: "Standard_DS14_v2",
    Standard_DS15_v2: "Standard_DS15_v2",
    Standard_DS13_4_v2: "Standard_DS13-4_v2",
    Standard_DS13_2_v2: "Standard_DS13-2_v2",
    Standard_DS14_8_v2: "Standard_DS14-8_v2",
    Standard_DS14_4_v2: "Standard_DS14-4_v2",
    Standard_E2_v3: "Standard_E2_v3",
    Standard_E4_v3: "Standard_E4_v3",
    Standard_E8_v3: "Standard_E8_v3",
    Standard_E16_v3: "Standard_E16_v3",
    Standard_E32_v3: "Standard_E32_v3",
    Standard_E64_v3: "Standard_E64_v3",
    Standard_E2s_v3: "Standard_E2s_v3",
    Standard_E4s_v3: "Standard_E4s_v3",
    Standard_E8s_v3: "Standard_E8s_v3",
    Standard_E16s_v3: "Standard_E16s_v3",
    Standard_E32s_v3: "Standard_E32s_v3",
    Standard_E64s_v3: "Standard_E64s_v3",
    Standard_E32_16_v3: "Standard_E32-16_v3",
    Standard_E32_8s_v3: "Standard_E32-8s_v3",
    Standard_E64_32s_v3: "Standard_E64-32s_v3",
    Standard_E64_16s_v3: "Standard_E64-16s_v3",
    Standard_F1: "Standard_F1",
    Standard_F2: "Standard_F2",
    Standard_F4: "Standard_F4",
    Standard_F8: "Standard_F8",
    Standard_F16: "Standard_F16",
    Standard_F1s: "Standard_F1s",
    Standard_F2s: "Standard_F2s",
    Standard_F4s: "Standard_F4s",
    Standard_F8s: "Standard_F8s",
    Standard_F16s: "Standard_F16s",
    Standard_F2s_v2: "Standard_F2s_v2",
    Standard_F4s_v2: "Standard_F4s_v2",
    Standard_F8s_v2: "Standard_F8s_v2",
    Standard_F16s_v2: "Standard_F16s_v2",
    Standard_F32s_v2: "Standard_F32s_v2",
    Standard_F64s_v2: "Standard_F64s_v2",
    Standard_F72s_v2: "Standard_F72s_v2",
    Standard_G1: "Standard_G1",
    Standard_G2: "Standard_G2",
    Standard_G3: "Standard_G3",
    Standard_G4: "Standard_G4",
    Standard_G5: "Standard_G5",
    Standard_GS1: "Standard_GS1",
    Standard_GS2: "Standard_GS2",
    Standard_GS3: "Standard_GS3",
    Standard_GS4: "Standard_GS4",
    Standard_GS5: "Standard_GS5",
    Standard_GS4_8: "Standard_GS4-8",
    Standard_GS4_4: "Standard_GS4-4",
    Standard_GS5_16: "Standard_GS5-16",
    Standard_GS5_8: "Standard_GS5-8",
    Standard_H8: "Standard_H8",
    Standard_H16: "Standard_H16",
    Standard_H8m: "Standard_H8m",
    Standard_H16m: "Standard_H16m",
    Standard_H16r: "Standard_H16r",
    Standard_H16mr: "Standard_H16mr",
    Standard_L4s: "Standard_L4s",
    Standard_L8s: "Standard_L8s",
    Standard_L16s: "Standard_L16s",
    Standard_L32s: "Standard_L32s",
    Standard_M64s: "Standard_M64s",
    Standard_M64ms: "Standard_M64ms",
    Standard_M128s: "Standard_M128s",
    Standard_M128ms: "Standard_M128ms",
    Standard_M64_32ms: "Standard_M64-32ms",
    Standard_M64_16ms: "Standard_M64-16ms",
    Standard_M128_64ms: "Standard_M128-64ms",
    Standard_M128_32ms: "Standard_M128-32ms",
    Standard_NC6: "Standard_NC6",
    Standard_NC12: "Standard_NC12",
    Standard_NC24: "Standard_NC24",
    Standard_NC24r: "Standard_NC24r",
    Standard_NC6s_v2: "Standard_NC6s_v2",
    Standard_NC12s_v2: "Standard_NC12s_v2",
    Standard_NC24s_v2: "Standard_NC24s_v2",
    Standard_NC24rs_v2: "Standard_NC24rs_v2",
    Standard_NC6s_v3: "Standard_NC6s_v3",
    Standard_NC12s_v3: "Standard_NC12s_v3",
    Standard_NC24s_v3: "Standard_NC24s_v3",
    Standard_NC24rs_v3: "Standard_NC24rs_v3",
    Standard_ND6s: "Standard_ND6s",
    Standard_ND12s: "Standard_ND12s",
    Standard_ND24s: "Standard_ND24s",
    Standard_ND24rs: "Standard_ND24rs",
    Standard_NV6: "Standard_NV6",
    Standard_NV12: "Standard_NV12",
    Standard_NV24: "Standard_NV24",
} as const;

/**
 * Specifies the size of the virtual machine. For more information about virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/en-us/azure/virtual-machines/sizes). <br><br> The available VM sizes depend on region and availability set. For a list of available sizes use these APIs:  <br><br> [List all available virtual machine sizes in an availability set](https://docs.microsoft.com/rest/api/compute/availabilitysets/listavailablesizes) <br><br> [List all available virtual machine sizes in a region]( https://docs.microsoft.com/en-us/rest/api/compute/resourceskus/list) <br><br> [List all available virtual machine sizes for resizing](https://docs.microsoft.com/rest/api/compute/virtualmachines/listavailablesizes). <br><br> This list of sizes is no longer updated and the **VirtualMachineSizeTypes** string constants will be removed from the subsequent REST API specification. Use [List all available virtual machine sizes in a region]( https://docs.microsoft.com/en-us/rest/api/compute/resourceskus/list) to get the latest sizes.
 */
export type VirtualMachineSizeTypes = (typeof VirtualMachineSizeTypes)[keyof typeof VirtualMachineSizeTypes];
