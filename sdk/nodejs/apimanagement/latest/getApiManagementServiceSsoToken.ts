// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getApiManagementServiceSsoToken(args: GetApiManagementServiceSsoTokenArgs, opts?: pulumi.InvokeOptions): Promise<GetApiManagementServiceSsoTokenResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/latest:getApiManagementServiceSsoToken", {
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetApiManagementServiceSsoTokenArgs {
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
 * The response of the GetSsoToken operation.
 */
export interface GetApiManagementServiceSsoTokenResult {
    /**
     * Redirect URL to the Publisher Portal containing the SSO token.
     */
    readonly redirectUri?: string;
}
