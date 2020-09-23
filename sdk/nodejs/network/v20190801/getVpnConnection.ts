// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVpnConnection(args: GetVpnConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetVpnConnectionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190801:getVpnConnection", {
        "connectionName": args.connectionName,
        "gatewayName": args.gatewayName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetVpnConnectionArgs {
    /**
     * The name of the vpn connection.
     */
    readonly connectionName: string;
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
 * VpnConnection Resource.
 */
export interface GetVpnConnectionResult {
    /**
     * Expected bandwidth in MBPS.
     */
    readonly connectionBandwidth?: number;
    /**
     * The connection status.
     */
    readonly connectionStatus: string;
    /**
     * Egress bytes transferred.
     */
    readonly egressBytesTransferred: number;
    /**
     * EnableBgp flag.
     */
    readonly enableBgp?: boolean;
    /**
     * Enable internet security.
     */
    readonly enableInternetSecurity?: boolean;
    /**
     * EnableBgp flag.
     */
    readonly enableRateLimiting?: boolean;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Ingress bytes transferred.
     */
    readonly ingressBytesTransferred: number;
    /**
     * The IPSec Policies to be considered by this connection.
     */
    readonly ipsecPolicies?: outputs.network.v20190801.IpsecPolicyResponse[];
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The provisioning state of the VPN connection resource.
     */
    readonly provisioningState: string;
    /**
     * Id of the connected vpn site.
     */
    readonly remoteVpnSite?: outputs.network.v20190801.SubResourceResponse;
    /**
     * Routing weight for vpn connection.
     */
    readonly routingWeight?: number;
    /**
     * SharedKey for the vpn connection.
     */
    readonly sharedKey?: string;
    /**
     * Use local azure ip to initiate connection.
     */
    readonly useLocalAzureIpAddress?: boolean;
    /**
     * Enable policy-based traffic selectors.
     */
    readonly usePolicyBasedTrafficSelectors?: boolean;
    /**
     * Connection protocol used for this connection.
     */
    readonly vpnConnectionProtocolType?: string;
    /**
     * List of all vpn site link connections to the gateway.
     */
    readonly vpnLinkConnections?: outputs.network.v20190801.VpnSiteLinkConnectionResponse[];
}
