// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listStaticSiteBuildFunctionAppSettings(args: ListStaticSiteBuildFunctionAppSettingsArgs, opts?: pulumi.InvokeOptions): Promise<ListStaticSiteBuildFunctionAppSettingsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20200901:listStaticSiteBuildFunctionAppSettings", {
        "name": args.name,
        "prId": args.prId,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListStaticSiteBuildFunctionAppSettingsArgs {
    /**
     * Name of the static site.
     */
    readonly name: string;
    /**
     * The stage site identifier.
     */
    readonly prId: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * String dictionary resource.
 */
export interface ListStaticSiteBuildFunctionAppSettingsResult {
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Settings.
     */
    readonly properties: {[key: string]: string};
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.web.v20200901.SystemDataResponse;
    /**
     * Resource type.
     */
    readonly type: string;
}
