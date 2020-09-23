// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVirtualNetworkGatewayVpnclientIpsecParameters(args: GetVirtualNetworkGatewayVpnclientIpsecParametersArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayVpnclientIpsecParametersResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190401:getVirtualNetworkGatewayVpnclientIpsecParameters", {
        "resourceGroupName": args.resourceGroupName,
        "virtualNetworkGatewayName": args.virtualNetworkGatewayName,
    }, opts);
}

export interface GetVirtualNetworkGatewayVpnclientIpsecParametersArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The virtual network gateway name.
     */
    readonly virtualNetworkGatewayName: string;
}

/**
 * An IPSec parameters for a virtual network gateway P2S connection.
 */
export interface GetVirtualNetworkGatewayVpnclientIpsecParametersResult {
    /**
     * The DH Group used in IKE Phase 1 for initial SA.
     */
    readonly dhGroup: string;
    /**
     * The IKE encryption algorithm (IKE phase 2).
     */
    readonly ikeEncryption: string;
    /**
     * The IKE integrity algorithm (IKE phase 2).
     */
    readonly ikeIntegrity: string;
    /**
     * The IPSec encryption algorithm (IKE phase 1).
     */
    readonly ipsecEncryption: string;
    /**
     * The IPSec integrity algorithm (IKE phase 1).
     */
    readonly ipsecIntegrity: string;
    /**
     * The Pfs Group used in IKE Phase 2 for new child SA.
     */
    readonly pfsGroup: string;
    /**
     * The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for P2S client..
     */
    readonly saDataSizeKilobytes: number;
    /**
     * The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for P2S client.
     */
    readonly saLifeTimeSeconds: number;
}
