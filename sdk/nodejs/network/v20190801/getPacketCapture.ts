// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getPacketCapture(args: GetPacketCaptureArgs, opts?: pulumi.InvokeOptions): Promise<GetPacketCaptureResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190801:getPacketCapture", {
        "networkWatcherName": args.networkWatcherName,
        "packetCaptureName": args.packetCaptureName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPacketCaptureArgs {
    /**
     * The name of the network watcher.
     */
    readonly networkWatcherName: string;
    /**
     * The name of the packet capture session.
     */
    readonly packetCaptureName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Information about packet capture session.
 */
export interface GetPacketCaptureResult {
    /**
     * Number of bytes captured per packet, the remaining bytes are truncated.
     */
    readonly bytesToCapturePerPacket?: number;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * A list of packet capture filters.
     */
    readonly filters?: outputs.network.v20190801.PacketCaptureFilterResponse[];
    /**
     * Name of the packet capture session.
     */
    readonly name: string;
    /**
     * The provisioning state of the packet capture session.
     */
    readonly provisioningState: string;
    /**
     * Describes the storage location for a packet capture session.
     */
    readonly storageLocation: outputs.network.v20190801.PacketCaptureStorageLocationResponse;
    /**
     * The ID of the targeted resource, only VM is currently supported.
     */
    readonly target: string;
    /**
     * Maximum duration of the capture session in seconds.
     */
    readonly timeLimitInSeconds?: number;
    /**
     * Maximum size of the capture output.
     */
    readonly totalBytesPerSession?: number;
}
