// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVirtualNetworkGatewayLearnedRoutes(args: GetVirtualNetworkGatewayLearnedRoutesArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayLearnedRoutesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20180101:getVirtualNetworkGatewayLearnedRoutes", {
        "resourceGroupName": args.resourceGroupName,
        "virtualNetworkGatewayName": args.virtualNetworkGatewayName,
    }, opts);
}

export interface GetVirtualNetworkGatewayLearnedRoutesArgs {
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
 * List of virtual network gateway routes
 */
export interface GetVirtualNetworkGatewayLearnedRoutesResult {
    /**
     * List of gateway routes
     */
    readonly value?: outputs.network.v20180101.GatewayRouteResponse[];
}
