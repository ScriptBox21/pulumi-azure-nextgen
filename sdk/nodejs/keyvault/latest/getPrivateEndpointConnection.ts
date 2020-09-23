// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getPrivateEndpointConnection(args: GetPrivateEndpointConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateEndpointConnectionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:keyvault/latest:getPrivateEndpointConnection", {
        "privateEndpointConnectionName": args.privateEndpointConnectionName,
        "resourceGroupName": args.resourceGroupName,
        "vaultName": args.vaultName,
    }, opts);
}

export interface GetPrivateEndpointConnectionArgs {
    /**
     * Name of the private endpoint connection associated with the key vault.
     */
    readonly privateEndpointConnectionName: string;
    /**
     * Name of the resource group that contains the key vault.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the key vault.
     */
    readonly vaultName: string;
}

/**
 * Private endpoint connection resource.
 */
export interface GetPrivateEndpointConnectionResult {
    /**
     * Azure location of the key vault resource.
     */
    readonly location: string;
    /**
     * Name of the key vault resource.
     */
    readonly name: string;
    /**
     * Properties of the private endpoint object.
     */
    readonly privateEndpoint?: outputs.keyvault.latest.PrivateEndpointResponse;
    /**
     * Approval state of the private link connection.
     */
    readonly privateLinkServiceConnectionState?: outputs.keyvault.latest.PrivateLinkServiceConnectionStateResponse;
    /**
     * Provisioning state of the private endpoint connection.
     */
    readonly provisioningState: string;
    /**
     * Tags assigned to the key vault resource.
     */
    readonly tags: {[key: string]: string};
    /**
     * Resource type of the key vault resource.
     */
    readonly type: string;
}
