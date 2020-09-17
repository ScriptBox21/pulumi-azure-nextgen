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
    return pulumi.runtime.invoke("azure-nextgen:operationalinsights/v20151101preview:getWorkspace", {
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetWorkspaceArgs {
    /**
     * The resource group name of the workspace.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the Log Analytics Workspace.
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
     * Resource location
     */
    readonly location?: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * This is a legacy property and is not used anymore. Kept here for backward compatibility.
     */
    readonly portalUrl: string;
    /**
     * The provisioning state of the workspace.
     */
    readonly provisioningState?: string;
    /**
     * The workspace data retention in days. -1 means Unlimited retention for the Unlimited Sku. 730 days is the maximum allowed for all other Skus. 
     */
    readonly retentionInDays?: number;
    /**
     * The SKU of the workspace.
     */
    readonly sku?: outputs.operationalinsights.v20151101preview.SkuResponse;
    /**
     * This is a read-only legacy property. It is always set to 'Azure' by the service. Kept here for backward compatibility.
     */
    readonly source: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}