// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const ApplicationSharingPolicy = {
    Personal: "Personal",
    Shared: "Shared",
} as const;

/**
 * Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role.
 */
export type ApplicationSharingPolicy = (typeof ApplicationSharingPolicy)[keyof typeof ApplicationSharingPolicy];

export const ComputeEnvironmentType = {
    ACI: "ACI",
    AKS: "AKS",
} as const;

/**
 * The compute environment type for the service.
 */
export type ComputeEnvironmentType = (typeof ComputeEnvironmentType)[keyof typeof ComputeEnvironmentType];

export const ComputeInstanceAuthorizationType = {
    Personal: "personal",
} as const;

/**
 * The Compute Instance Authorization type. Available values are personal (default).
 */
export type ComputeInstanceAuthorizationType = (typeof ComputeInstanceAuthorizationType)[keyof typeof ComputeInstanceAuthorizationType];

export const ComputeType = {
    AKS: "AKS",
    AmlCompute: "AmlCompute",
    ComputeInstance: "ComputeInstance",
    DataFactory: "DataFactory",
    VirtualMachine: "VirtualMachine",
    HDInsight: "HDInsight",
    Databricks: "Databricks",
    DataLakeAnalytics: "DataLakeAnalytics",
} as const;

/**
 * The type of compute
 */
export type ComputeType = (typeof ComputeType)[keyof typeof ComputeType];

export const EncryptionStatus = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Indicates whether or not the encryption is enabled for the workspace.
 */
export type EncryptionStatus = (typeof EncryptionStatus)[keyof typeof EncryptionStatus];

export const ImageAnnotationType = {
    Classification: "Classification",
    BoundingBox: "BoundingBox",
    InstanceSegmentation: "InstanceSegmentation",
} as const;

/**
 * Annotation type of image labeling tasks.
 */
export type ImageAnnotationType = (typeof ImageAnnotationType)[keyof typeof ImageAnnotationType];

export const LinkedServiceLinkType = {
    Synapse: "Synapse",
} as const;

/**
 * Type of the link target.
 */
export type LinkedServiceLinkType = (typeof LinkedServiceLinkType)[keyof typeof LinkedServiceLinkType];

export const MediaType = {
    Image: "Image",
    Text: "Text",
} as const;

/**
 * Media type of data asset.
 */
export type MediaType = (typeof MediaType)[keyof typeof MediaType];

export const OsType = {
    Linux: "Linux",
    Windows: "Windows",
} as const;

/**
 * Compute OS Type
 */
export type OsType = (typeof OsType)[keyof typeof OsType];

export const PrivateEndpointServiceConnectionStatus = {
    Pending: "Pending",
    Approved: "Approved",
    Rejected: "Rejected",
    Disconnected: "Disconnected",
    Timeout: "Timeout",
} as const;

/**
 * Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
 */
export type PrivateEndpointServiceConnectionStatus = (typeof PrivateEndpointServiceConnectionStatus)[keyof typeof PrivateEndpointServiceConnectionStatus];

export const RemoteLoginPortPublicAccess = {
    Enabled: "Enabled",
    Disabled: "Disabled",
    NotSpecified: "NotSpecified",
} as const;

/**
 * State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined, else is open all public nodes. It can be default only during cluster creation time, after creation it will be either enabled or disabled.
 */
export type RemoteLoginPortPublicAccess = (typeof RemoteLoginPortPublicAccess)[keyof typeof RemoteLoginPortPublicAccess];

export const ResourceIdentityType = {
    SystemAssigned: "SystemAssigned",
    SystemAssigned_UserAssigned: "SystemAssigned,UserAssigned",
    UserAssigned: "UserAssigned",
    None: "None",
} as const;

/**
 * The identity type.
 */
export type ResourceIdentityType = (typeof ResourceIdentityType)[keyof typeof ResourceIdentityType];

export const SshPublicAccess = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the VNet/subnet policy if applicable.
 */
export type SshPublicAccess = (typeof SshPublicAccess)[keyof typeof SshPublicAccess];

export const VmPriority = {
    Dedicated: "Dedicated",
    LowPriority: "LowPriority",
} as const;

/**
 * Virtual Machine priority
 */
export type VmPriority = (typeof VmPriority)[keyof typeof VmPriority];
