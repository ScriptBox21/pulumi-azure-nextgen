// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getDataManager(args: GetDataManagerArgs, opts?: pulumi.InvokeOptions): Promise<GetDataManagerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:hybriddata/v20190601:getDataManager", {
        "dataManagerName": args.dataManagerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDataManagerArgs {
    /**
     * The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
     */
    readonly dataManagerName: string;
    /**
     * The Resource Group Name
     */
    readonly resourceGroupName: string;
}

/**
 * The DataManager resource.
 */
export interface GetDataManagerResult {
    /**
     * Etag of the Resource.
     */
    readonly etag?: string;
    /**
     * The location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East
     * US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo
     * region is specified on update the request will succeed.
     */
    readonly location: string;
    /**
     * The Resource Name.
     */
    readonly name: string;
    /**
     * The sku type.
     */
    readonly sku?: outputs.hybriddata.v20190601.SkuResponse;
    /**
     * The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource
     * (across resource groups).
     */
    readonly tags?: {[key: string]: string};
    /**
     * The Resource type.
     */
    readonly type: string;
}