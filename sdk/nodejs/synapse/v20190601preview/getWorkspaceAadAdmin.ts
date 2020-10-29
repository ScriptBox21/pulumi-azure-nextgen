// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getWorkspaceAadAdmin(args: GetWorkspaceAadAdminArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkspaceAadAdminResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:synapse/v20190601preview:getWorkspaceAadAdmin", {
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetWorkspaceAadAdminArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the workspace
     */
    readonly workspaceName: string;
}

/**
 * Workspace active directory administrator
 */
export interface GetWorkspaceAadAdminResult {
    /**
     * Workspace active directory administrator type
     */
    readonly administratorType?: string;
    /**
     * Login of the workspace active directory administrator
     */
    readonly login?: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Object ID of the workspace active directory administrator
     */
    readonly sid?: string;
    /**
     * Tenant ID of the workspace active directory administrator
     */
    readonly tenantId?: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
