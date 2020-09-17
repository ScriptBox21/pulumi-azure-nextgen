// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getDisk(args: GetDiskArgs, opts?: pulumi.InvokeOptions): Promise<GetDiskResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:compute/v20170330:getDisk", {
        "diskName": args.diskName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDiskArgs {
    /**
     * The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters.
     */
    readonly diskName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Disk resource.
 */
export interface GetDiskResult {
    /**
     * Disk source information. CreationData information cannot be changed after the disk has been created.
     */
    readonly creationData: outputs.compute.v20170330.CreationDataResponse;
    /**
     * If creationData.createOption is Empty, this field is mandatory and it indicates the size of the VHD to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
     */
    readonly diskSizeGB?: number;
    /**
     * Encryption settings for disk or snapshot
     */
    readonly encryptionSettings?: outputs.compute.v20170330.EncryptionSettingsResponse;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * A relative URI containing the ID of the VM that has the disk attached.
     */
    readonly managedBy: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The Operating System type.
     */
    readonly osType?: string;
    /**
     * The disk provisioning state.
     */
    readonly provisioningState: string;
    /**
     * The disks and snapshots sku name. Can be Standard_LRS or Premium_LRS.
     */
    readonly sku?: outputs.compute.v20170330.DiskSkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * The time when the disk was created.
     */
    readonly timeCreated: string;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * The Logical zone list for Disk.
     */
    readonly zones?: string[];
}