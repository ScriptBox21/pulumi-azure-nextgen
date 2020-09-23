// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVpnSite(args: GetVpnSiteArgs, opts?: pulumi.InvokeOptions): Promise<GetVpnSiteResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20180601:getVpnSite", {
        "resourceGroupName": args.resourceGroupName,
        "vpnSiteName": args.vpnSiteName,
    }, opts);
}

export interface GetVpnSiteArgs {
    /**
     * The resource group name of the VpnSite.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the VpnSite being retrieved.
     */
    readonly vpnSiteName: string;
}

/**
 * VpnSite Resource.
 */
export interface GetVpnSiteResult {
    /**
     * The AddressSpace that contains an array of IP address ranges.
     */
    readonly addressSpace?: outputs.network.v20180601.AddressSpaceResponse;
    /**
     * The set of bgp properties.
     */
    readonly bgpProperties?: outputs.network.v20180601.BgpSettingsResponse;
    /**
     * The device properties
     */
    readonly deviceProperties?: outputs.network.v20180601.DevicePropertiesResponse;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The ip-address for the vpn-site.
     */
    readonly ipAddress?: string;
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
     * The key for vpn-site that can be used for connections.
     */
    readonly siteKey?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The VirtualWAN to which the vpnSite belongs
     */
    readonly virtualWAN?: outputs.network.v20180601.SubResourceResponse;
}
