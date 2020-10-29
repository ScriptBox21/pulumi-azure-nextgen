// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getStreamingEndpoint(args: GetStreamingEndpointArgs, opts?: pulumi.InvokeOptions): Promise<GetStreamingEndpointResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/latest:getStreamingEndpoint", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "streamingEndpointName": args.streamingEndpointName,
    }, opts);
}

export interface GetStreamingEndpointArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the streaming endpoint, maximum length is 24.
     */
    readonly streamingEndpointName: string;
}

/**
 * The streaming endpoint.
 */
export interface GetStreamingEndpointResult {
    /**
     * The access control definition of the streaming endpoint.
     */
    readonly accessControl?: outputs.media.latest.StreamingEndpointAccessControlResponse;
    /**
     * This feature is deprecated, do not set a value for this property.
     */
    readonly availabilitySetName?: string;
    /**
     * The CDN enabled flag.
     */
    readonly cdnEnabled?: boolean;
    /**
     * The CDN profile name.
     */
    readonly cdnProfile?: string;
    /**
     * The CDN provider name.
     */
    readonly cdnProvider?: string;
    /**
     * The exact time the streaming endpoint was created.
     */
    readonly created: string;
    /**
     * The streaming endpoint access policies.
     */
    readonly crossSiteAccessPolicies?: outputs.media.latest.CrossSiteAccessPoliciesResponse;
    /**
     * The custom host names of the streaming endpoint
     */
    readonly customHostNames?: string[];
    /**
     * The streaming endpoint description.
     */
    readonly description?: string;
    /**
     * The free trial expiration time.
     */
    readonly freeTrialEndTime: string;
    /**
     * The streaming endpoint host name.
     */
    readonly hostName: string;
    /**
     * The exact time the streaming endpoint was last modified.
     */
    readonly lastModified: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * Max cache age
     */
    readonly maxCacheAge?: number;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The provisioning state of the streaming endpoint.
     */
    readonly provisioningState: string;
    /**
     * The resource state of the streaming endpoint.
     */
    readonly resourceState: string;
    /**
     * The number of scale units. Use the Scale operation to adjust this value.
     */
    readonly scaleUnits: number;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
