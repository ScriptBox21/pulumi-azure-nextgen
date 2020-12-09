// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listWebAppConnectionStringsSlot(args: ListWebAppConnectionStringsSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListWebAppConnectionStringsSlotResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20200901:listWebAppConnectionStringsSlot", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}

export interface ListWebAppConnectionStringsSlotArgs {
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the deployment slot. If a slot is not specified, the API will get the connection settings for the production slot.
     */
    readonly slot: string;
}

/**
 * String dictionary resource.
 */
export interface ListWebAppConnectionStringsSlotResult {
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Connection strings.
     */
    readonly properties: {[key: string]: outputs.web.v20200901.ConnStringValueTypePairResponse};
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.web.v20200901.SystemDataResponse;
    /**
     * Resource type.
     */
    readonly type: string;
}
