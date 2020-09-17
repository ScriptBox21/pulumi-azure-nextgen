// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getManager(args: GetManagerArgs, opts?: pulumi.InvokeOptions): Promise<GetManagerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storsimple/latest:getManager", {
        "managerName": args.managerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetManagerArgs {
    /**
     * The manager name
     */
    readonly managerName: string;
    /**
     * The resource group name
     */
    readonly resourceGroupName: string;
}

/**
 * The StorSimple Manager.
 */
export interface GetManagerResult {
    /**
     * Represents the type of StorSimple Manager.
     */
    readonly cisIntrinsicSettings?: outputs.storsimple.latest.ManagerIntrinsicSettingsResponse;
    /**
     * The etag of the manager.
     */
    readonly etag?: string;
    /**
     * The geo location of the resource.
     */
    readonly location: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * Specifies the state of the resource as it is getting provisioned. Value of "Succeeded" means the Manager was successfully created.
     */
    readonly provisioningState?: string;
    /**
     * Specifies the Sku.
     */
    readonly sku?: outputs.storsimple.latest.ManagerSkuResponse;
    /**
     * The tags attached to the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type: string;
}