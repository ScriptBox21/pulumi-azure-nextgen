// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getAttachedDatabaseConfiguration(args: GetAttachedDatabaseConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetAttachedDatabaseConfigurationResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:kusto/v20200215:getAttachedDatabaseConfiguration", {
        "attachedDatabaseConfigurationName": args.attachedDatabaseConfigurationName,
        "clusterName": args.clusterName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAttachedDatabaseConfigurationArgs {
    /**
     * The name of the attached database configuration.
     */
    readonly attachedDatabaseConfigurationName: string;
    /**
     * The name of the Kusto cluster.
     */
    readonly clusterName: string;
    /**
     * The name of the resource group containing the Kusto cluster.
     */
    readonly resourceGroupName: string;
}

/**
 * Class representing an attached database configuration.
 */
export interface GetAttachedDatabaseConfigurationResult {
    /**
     * The list of databases from the clusterResourceId which are currently attached to the cluster.
     */
    readonly attachedDatabaseNames: string[];
    /**
     * The resource id of the cluster where the databases you would like to attach reside.
     */
    readonly clusterResourceId: string;
    /**
     * The name of the database which you would like to attach, use * if you want to follow all current and future databases.
     */
    readonly databaseName: string;
    /**
     * The default principals modification kind
     */
    readonly defaultPrincipalsModificationKind: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The provisioned state of the resource.
     */
    readonly provisioningState: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
