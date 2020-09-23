// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getConnectionMonitor(args: GetConnectionMonitorArgs, opts?: pulumi.InvokeOptions): Promise<GetConnectionMonitorResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190201:getConnectionMonitor", {
        "connectionMonitorName": args.connectionMonitorName,
        "networkWatcherName": args.networkWatcherName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetConnectionMonitorArgs {
    /**
     * The name of the connection monitor.
     */
    readonly connectionMonitorName: string;
    /**
     * The name of the Network Watcher resource.
     */
    readonly networkWatcherName: string;
    /**
     * The name of the resource group containing Network Watcher.
     */
    readonly resourceGroupName: string;
}

/**
 * Information about the connection monitor.
 */
export interface GetConnectionMonitorResult {
    /**
     * Determines if the connection monitor will start automatically once created.
     */
    readonly autoStart?: boolean;
    /**
     * Describes the destination of connection monitor.
     */
    readonly destination: outputs.network.v20190201.ConnectionMonitorDestinationResponse;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * Connection monitor location.
     */
    readonly location?: string;
    /**
     * Monitoring interval in seconds.
     */
    readonly monitoringIntervalInSeconds?: number;
    /**
     * The monitoring status of the connection monitor.
     */
    readonly monitoringStatus?: string;
    /**
     * Name of the connection monitor.
     */
    readonly name: string;
    /**
     * The provisioning state of the connection monitor.
     */
    readonly provisioningState: string;
    /**
     * Describes the source of connection monitor.
     */
    readonly source: outputs.network.v20190201.ConnectionMonitorSourceResponse;
    /**
     * The date and time when the connection monitor was started.
     */
    readonly startTime?: string;
    /**
     * Connection monitor tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Connection monitor type.
     */
    readonly type: string;
}
