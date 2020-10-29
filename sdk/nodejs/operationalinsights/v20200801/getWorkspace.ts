// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getWorkspace(args: GetWorkspaceArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkspaceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:operationalinsights/v20200801:getWorkspace", {
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetWorkspaceArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the workspace.
     */
    readonly workspaceName: string;
}

/**
 * The top level Workspace resource container.
 */
export interface GetWorkspaceResult {
    /**
     * This is a read-only property. Represents the ID associated with the workspace.
     */
    readonly customerId: string;
    /**
     * The ETag of the workspace.
     */
    readonly eTag?: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * List of linked private link scope resources.
     */
    readonly privateLinkScopedResources: outputs.operationalinsights.v20200801.PrivateLinkScopedResourceResponse[];
    /**
     * The provisioning state of the workspace.
     */
    readonly provisioningState?: string;
    /**
     * The network access type for accessing Log Analytics ingestion.
     */
    readonly publicNetworkAccessForIngestion?: string;
    /**
     * The network access type for accessing Log Analytics query.
     */
    readonly publicNetworkAccessForQuery?: string;
    /**
     * The workspace data retention in days, between 30 and 730.
     */
    readonly retentionInDays?: number;
    /**
     * The SKU of the workspace.
     */
    readonly sku?: outputs.operationalinsights.v20200801.WorkspaceSkuResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
    /**
     * The daily volume cap for ingestion.
     */
    readonly workspaceCapping?: outputs.operationalinsights.v20200801.WorkspaceCappingResponse;
}
