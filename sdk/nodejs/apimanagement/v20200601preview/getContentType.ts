// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getContentType(args: GetContentTypeArgs, opts?: pulumi.InvokeOptions): Promise<GetContentTypeResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/v20200601preview:getContentType", {
        "contentTypeId": args.contentTypeId,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetContentTypeArgs {
    /**
     * Content type identifier.
     */
    readonly contentTypeId: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: string;
}

/**
 * Content type contract details.
 */
export interface GetContentTypeResult {
    /**
     * Content type description.
     */
    readonly description?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Content type schema.
     */
    readonly schema?: any;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
    /**
     * Content type version.
     */
    readonly version?: string;
}
