// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getApiKeyDefaultKey(args: GetApiKeyDefaultKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetApiKeyDefaultKeyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datadog/v20200201preview:getApiKeyDefaultKey", {
        "monitorName": args.monitorName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetApiKeyDefaultKeyArgs {
    /**
     * Monitor resource name
     */
    readonly monitorName: string;
    /**
     * The name of the resource group to which the Datadog resource belongs.
     */
    readonly resourceGroupName: string;
}

export interface GetApiKeyDefaultKeyResult {
    /**
     * The time of creation of the API key.
     */
    readonly created?: string;
    /**
     * The user that created the API key.
     */
    readonly createdBy?: string;
    /**
     * The value of the API key.
     */
    readonly key: string;
    /**
     * The name of the API key.
     */
    readonly name?: string;
}
