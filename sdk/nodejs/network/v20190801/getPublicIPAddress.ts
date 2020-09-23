// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getPublicIPAddress(args: GetPublicIPAddressArgs, opts?: pulumi.InvokeOptions): Promise<GetPublicIPAddressResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190801:getPublicIPAddress", {
        "expand": args.expand,
        "publicIpAddressName": args.publicIpAddressName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPublicIPAddressArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
    /**
     * The name of the subnet.
     */
    readonly publicIpAddressName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Public IP address resource.
 */
export interface GetPublicIPAddressResult {
    /**
     * The DDoS protection custom policy associated with the public IP address.
     */
    readonly ddosSettings?: outputs.network.v20190801.DdosSettingsResponse;
    /**
     * The FQDN of the DNS record associated with the public IP address.
     */
    readonly dnsSettings?: outputs.network.v20190801.PublicIPAddressDnsSettingsResponse;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * The idle timeout of the public IP address.
     */
    readonly idleTimeoutInMinutes?: number;
    /**
     * The IP address associated with the public IP address resource.
     */
    readonly ipAddress?: string;
    /**
     * The IP configuration associated with the public IP address.
     */
    readonly ipConfiguration: outputs.network.v20190801.IPConfigurationResponse;
    /**
     * The list of tags associated with the public IP address.
     */
    readonly ipTags?: outputs.network.v20190801.IpTagResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the public IP address resource.
     */
    readonly provisioningState: string;
    /**
     * The public IP address version.
     */
    readonly publicIPAddressVersion?: string;
    /**
     * The public IP address allocation method.
     */
    readonly publicIPAllocationMethod?: string;
    /**
     * The Public IP Prefix this Public IP Address should be allocated from.
     */
    readonly publicIPPrefix?: outputs.network.v20190801.SubResourceResponse;
    /**
     * The resource GUID property of the public IP address resource.
     */
    readonly resourceGuid?: string;
    /**
     * The public IP address SKU.
     */
    readonly sku?: outputs.network.v20190801.PublicIPAddressSkuResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * A list of availability zones denoting the IP allocated for the resource needs to come from.
     */
    readonly zones?: string[];
}
