// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getBastionShareableLink(args: GetBastionShareableLinkArgs, opts?: pulumi.InvokeOptions): Promise<GetBastionShareableLinkResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/latest:getBastionShareableLink", {
        "bastionHostName": args.bastionHostName,
        "resourceGroupName": args.resourceGroupName,
        "vms": args.vms,
    }, opts);
}

export interface GetBastionShareableLinkArgs {
    /**
     * The name of the Bastion Host.
     */
    readonly bastionHostName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * List of VM references.
     */
    readonly vms?: inputs.network.latest.BastionShareableLink[];
}

/**
 * Response for all the Bastion Shareable Link endpoints.
 */
export interface GetBastionShareableLinkResult {
    /**
     * The URL to get the next set of results.
     */
    readonly nextLink?: string;
    /**
     * List of Bastion Shareable Links for the request.
     */
    readonly value?: outputs.network.latest.BastionShareableLinkResponse[];
}
