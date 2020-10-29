// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getAttestationProvider(args: GetAttestationProviderArgs, opts?: pulumi.InvokeOptions): Promise<GetAttestationProviderResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:attestation/v20180901preview:getAttestationProvider", {
        "providerName": args.providerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAttestationProviderArgs {
    /**
     * Name of the attestation service instance
     */
    readonly providerName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}

/**
 * Attestation service response message.
 */
export interface GetAttestationProviderResult {
    /**
     * Gets the uri of attestation service
     */
    readonly attestUri?: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Status of attestation service.
     */
    readonly status?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Trust model for the attestation service instance.
     */
    readonly trustModel?: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
