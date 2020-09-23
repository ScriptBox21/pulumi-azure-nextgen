// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getOrigin(args: GetOriginArgs, opts?: pulumi.InvokeOptions): Promise<GetOriginResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:cdn/v20150601:getOrigin", {
        "endpointName": args.endpointName,
        "originName": args.originName,
        "profileName": args.profileName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetOriginArgs {
    /**
     * Name of the endpoint within the CDN profile.
     */
    readonly endpointName: string;
    /**
     * Name of the origin, an arbitrary value but it needs to be unique under endpoint
     */
    readonly originName: string;
    /**
     * Name of the CDN profile within the resource group.
     */
    readonly profileName: string;
    /**
     * Name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.
 */
export interface GetOriginResult {
    /**
     * The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
     */
    readonly hostName: string;
    /**
     * The value of the HTTP port. Must be between 1 and 65535.
     */
    readonly httpPort?: number;
    /**
     * The value of the https port. Must be between 1 and 65535.
     */
    readonly httpsPort?: number;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Provisioning status of the origin.
     */
    readonly provisioningState: string;
    /**
     * Resource status of the origin.
     */
    readonly resourceState: string;
    /**
     * Resource type
     */
    readonly type: string;
}
