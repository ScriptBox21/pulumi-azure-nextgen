// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getProfileSupportedOptimizationTypes(args: GetProfileSupportedOptimizationTypesArgs, opts?: pulumi.InvokeOptions): Promise<GetProfileSupportedOptimizationTypesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:cdn/latest:getProfileSupportedOptimizationTypes", {
        "profileName": args.profileName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetProfileSupportedOptimizationTypesArgs {
    /**
     * Name of the CDN profile which is unique within the resource group.
     */
    readonly profileName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * The result of the GetSupportedOptimizationTypes API
 */
export interface GetProfileSupportedOptimizationTypesResult {
    /**
     * Supported optimization types for a profile.
     */
    readonly supportedOptimizationTypes: string[];
}
