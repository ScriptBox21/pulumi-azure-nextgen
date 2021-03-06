// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Latest API Version: 2019-04-01.
 */
/** @deprecated The 'latest' version is deprecated. Please migrate to the function in the top-level module: 'azure-nextgen:devspaces:listControllerConnectionDetails'. */
export function listControllerConnectionDetails(args: ListControllerConnectionDetailsArgs, opts?: pulumi.InvokeOptions): Promise<ListControllerConnectionDetailsResult> {
    pulumi.log.warn("listControllerConnectionDetails is deprecated: The 'latest' version is deprecated. Please migrate to the function in the top-level module: 'azure-nextgen:devspaces:listControllerConnectionDetails'.")
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:devspaces/latest:listControllerConnectionDetails", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "targetContainerHostResourceId": args.targetContainerHostResourceId,
    }, opts);
}

export interface ListControllerConnectionDetailsArgs {
    /**
     * Name of the resource.
     */
    readonly name: string;
    /**
     * Resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * Resource ID of the target container host mapped to the Azure Dev Spaces Controller.
     */
    readonly targetContainerHostResourceId: string;
}

export interface ListControllerConnectionDetailsResult {
    /**
     * List of Azure Dev Spaces Controller connection details.
     */
    readonly connectionDetailsList?: outputs.devspaces.latest.ControllerConnectionDetailsResponse[];
}
