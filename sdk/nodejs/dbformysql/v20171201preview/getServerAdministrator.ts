// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getServerAdministrator(args: GetServerAdministratorArgs, opts?: pulumi.InvokeOptions): Promise<GetServerAdministratorResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:dbformysql/v20171201preview:getServerAdministrator", {
        "resourceGroupName": args.resourceGroupName,
        "serverName": args.serverName,
    }, opts);
}

export interface GetServerAdministratorArgs {
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the server.
     */
    readonly serverName: string;
}

/**
 * Represents a and external administrator to be created.
 */
export interface GetServerAdministratorResult {
    /**
     * The type of administrator.
     */
    readonly administratorType: string;
    /**
     * The server administrator login account name.
     */
    readonly login: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The server administrator Sid (Secure ID).
     */
    readonly sid: string;
    /**
     * The server Active Directory Administrator tenant id.
     */
    readonly tenantId: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
