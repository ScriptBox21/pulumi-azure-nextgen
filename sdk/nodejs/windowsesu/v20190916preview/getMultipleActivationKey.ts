// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getMultipleActivationKey(args: GetMultipleActivationKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetMultipleActivationKeyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:windowsesu/v20190916preview:getMultipleActivationKey", {
        "multipleActivationKeyName": args.multipleActivationKeyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetMultipleActivationKeyArgs {
    /**
     * The name of the MAK key.
     */
    readonly multipleActivationKeyName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}

/**
 * MAK key details.
 */
export interface GetMultipleActivationKeyResult {
    /**
     * Agreement number under which the key is requested.
     */
    readonly agreementNumber?: string;
    /**
     * End of support of security updates activated by the MAK key.
     */
    readonly expirationDate: string;
    /**
     * Number of activations/servers using the MAK key.
     */
    readonly installedServerNumber?: number;
    /**
     * <code> true </code> if user has eligible on-premises Windows physical or virtual machines, and that the requested key will only be used in their organization; <code> false </code> otherwise.
     */
    readonly isEligible?: boolean;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * MAK 5x5 key.
     */
    readonly multipleActivationKey: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Type of OS for which the key is requested.
     */
    readonly osType?: string;
    readonly provisioningState: string;
    /**
     * Type of support
     */
    readonly supportType?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
