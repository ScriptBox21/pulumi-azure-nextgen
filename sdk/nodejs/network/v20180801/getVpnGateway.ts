// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVpnGateway(args: GetVpnGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetVpnGatewayResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20180801:getVpnGateway", {
        "gatewayName": args.gatewayName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetVpnGatewayArgs {
    /**
     * The name of the gateway.
     */
    readonly gatewayName: string;
    /**
     * The resource group name of the VpnGateway.
     */
    readonly resourceGroupName: string;
}

/**
 * VpnGateway Resource.
 */
export interface GetVpnGatewayResult {
    /**
     * Local network gateway's BGP speaker settings.
     */
    readonly bgpSettings?: outputs.network.v20180801.BgpSettingsResponse;
    /**
     * list of all vpn connections to the gateway.
     */
    readonly connections?: outputs.network.v20180801.VpnConnectionResponse[];
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The VirtualHub to which the gateway belongs
     */
    readonly virtualHub?: outputs.network.v20180801.SubResourceResponse;
    /**
     * The scale unit for this vpn gateway.
     */
    readonly vpnGatewayScaleUnit?: number;
}
