// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getBlobContainerImmutabilityPolicy(args: GetBlobContainerImmutabilityPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetBlobContainerImmutabilityPolicyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storage/v20181101:getBlobContainerImmutabilityPolicy", {
        "accountName": args.accountName,
        "containerName": args.containerName,
        "immutabilityPolicyName": args.immutabilityPolicyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetBlobContainerImmutabilityPolicyArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    readonly accountName: string;
    /**
     * The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
     */
    readonly containerName: string;
    /**
     * The name of the blob container immutabilityPolicy within the specified storage account. ImmutabilityPolicy Name must be 'default'
     */
    readonly immutabilityPolicyName: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}

/**
 * The ImmutabilityPolicy property of a blob container, including Id, resource name, resource type, Etag.
 */
export interface GetBlobContainerImmutabilityPolicyResult {
    /**
     * Resource Etag.
     */
    readonly etag: string;
    /**
     * The immutability period for the blobs in the container since the policy creation, in days.
     */
    readonly immutabilityPeriodSinceCreationInDays: number;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.
     */
    readonly state: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
