// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVendorSkuPreview(args: GetVendorSkuPreviewArgs, opts?: pulumi.InvokeOptions): Promise<GetVendorSkuPreviewResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:hybridnetwork/v20200101preview:getVendorSkuPreview", {
        "previewSubscription": args.previewSubscription,
        "skuName": args.skuName,
        "vendorName": args.vendorName,
    }, opts);
}

export interface GetVendorSkuPreviewArgs {
    /**
     * Preview subscription id.
     */
    readonly previewSubscription: string;
    /**
     * The name of the vendor sku.
     */
    readonly skuName: string;
    /**
     * The name of the vendor.
     */
    readonly vendorName: string;
}

/**
 * Customer subscription which can use a sku.
 */
export interface GetVendorSkuPreviewResult {
    /**
     * Preview subscription id
     */
    readonly name: string;
    /**
     * Type of the resource
     */
    readonly type: string;
}