// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Specifies information about the Shared Image Gallery that you want to create or update.
 * Latest API Version: 2020-09-30.
 */
/** @deprecated The 'latest' version is deprecated. Please migrate to the function in the top-level module: 'azure-nextgen:compute:getGallery'. */
export function getGallery(args: GetGalleryArgs, opts?: pulumi.InvokeOptions): Promise<GetGalleryResult> {
    pulumi.log.warn("getGallery is deprecated: The 'latest' version is deprecated. Please migrate to the function in the top-level module: 'azure-nextgen:compute:getGallery'.")
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:compute/latest:getGallery", {
        "galleryName": args.galleryName,
        "resourceGroupName": args.resourceGroupName,
        "select": args.select,
    }, opts);
}

export interface GetGalleryArgs {
    /**
     * The name of the Shared Image Gallery.
     */
    readonly galleryName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The select expression to apply on the operation.
     */
    readonly select?: string;
}

/**
 * Specifies information about the Shared Image Gallery that you want to create or update.
 */
export interface GetGalleryResult {
    /**
     * The description of this Shared Image Gallery resource. This property is updatable.
     */
    readonly description?: string;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Describes the gallery unique name.
     */
    readonly identifier?: outputs.compute.latest.GalleryIdentifierResponse;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * Profile for gallery sharing to subscription or tenant
     */
    readonly sharingProfile?: outputs.compute.latest.SharingProfileResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}
