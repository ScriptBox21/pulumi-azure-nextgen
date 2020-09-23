// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVirtualNetworkGatewayAdvertisedRoutes(args: GetVirtualNetworkGatewayAdvertisedRoutesArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayAdvertisedRoutesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190901:getVirtualNetworkGatewayAdvertisedRoutes", {
        "peer": args.peer,
        "resourceGroupName": args.resourceGroupName,
        "virtualNetworkGatewayName": args.virtualNetworkGatewayName,
    }, opts);
}

export interface GetVirtualNetworkGatewayAdvertisedRoutesArgs {
    /**
     * The IP address of the peer.
     */
    readonly peer: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the virtual network gateway.
     */
    readonly virtualNetworkGatewayName: string;
}

/**
 * List of virtual network gateway routes.
 */
export interface GetVirtualNetworkGatewayAdvertisedRoutesResult {
    /**
     * List of gateway routes.
     */
    readonly value?: outputs.network.v20190901.GatewayRouteResponse[];
}
