// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function listWorkspaceNotebookKeys(args: ListWorkspaceNotebookKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListWorkspaceNotebookKeysResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:machinelearningservices/v20200901preview:listWorkspaceNotebookKeys", {
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface ListWorkspaceNotebookKeysArgs {
    /**
     * Name of the resource group in which workspace is located.
     */
    readonly resourceGroupName: string;
    /**
     * Name of Azure Machine Learning workspace.
     */
    readonly workspaceName: string;
}

export interface ListWorkspaceNotebookKeysResult {
    readonly primaryAccessKey?: string;
    readonly secondaryAccessKey?: string;
}
