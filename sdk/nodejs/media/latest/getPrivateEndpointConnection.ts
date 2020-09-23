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
    return pulumi.runtime.invoke("azure-nextgen:media/latest:getPrivateEndpointConnection", {
        "accountName": args.accountName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPrivateEndpointConnectionArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    readonly name: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * The Private Endpoint Connection resource.
 */
export interface GetPrivateEndpointConnectionResult {
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The resource of private end point.
     */
    readonly privateEndpoint?: outputs.media.latest.PrivateEndpointResponse;
    /**
     * A collection of information about the state of the connection between service consumer and provider.
     */
    readonly privateLinkServiceConnectionState: outputs.media.latest.PrivateLinkServiceConnectionStateResponse;
    /**
     * The provisioning state of the private endpoint connection resource.
     */
    readonly provisioningState: string;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: string;
}
