// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getZone(args: GetZoneArgs, opts?: pulumi.InvokeOptions): Promise<GetZoneResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20170901:getZone", {
        "resourceGroupName": args.resourceGroupName,
        "zoneName": args.zoneName,
    }, opts);
}

export interface GetZoneArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the DNS zone (without a terminating dot).
     */
    readonly zoneName: string;
}

/**
 * Describes a DNS zone.
 */
export interface GetZoneResult {
    /**
     * The etag of the zone.
     */
    readonly etag?: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The maximum number of record sets that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored.
     */
    readonly maxNumberOfRecordSets: number;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The name servers for this DNS zone. This is a read-only property and any attempt to set this value will be ignored.
     */
    readonly nameServers: string[];
    /**
     * The current number of record sets in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored.
     */
    readonly numberOfRecordSets: number;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
