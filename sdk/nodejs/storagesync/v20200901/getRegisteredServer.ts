// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getRegisteredServer(args: GetRegisteredServerArgs, opts?: pulumi.InvokeOptions): Promise<GetRegisteredServerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storagesync/v20200901:getRegisteredServer", {
        "resourceGroupName": args.resourceGroupName,
        "serverId": args.serverId,
        "storageSyncServiceName": args.storageSyncServiceName,
    }, opts);
}

export interface GetRegisteredServerArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * GUID identifying the on-premises server.
     */
    readonly serverId: string;
    /**
     * Name of Storage Sync Service resource.
     */
    readonly storageSyncServiceName: string;
}

/**
 * Registered Server resource.
 */
export interface GetRegisteredServerResult {
    /**
     * Registered Server Agent Version
     */
    readonly agentVersion?: string;
    /**
     * Registered Server Agent Version Expiration Date
     */
    readonly agentVersionExpirationDate: string;
    /**
     * Registered Server Agent Version Status
     */
    readonly agentVersionStatus: string;
    /**
     * Registered Server clusterId
     */
    readonly clusterId?: string;
    /**
     * Registered Server clusterName
     */
    readonly clusterName?: string;
    /**
     * Resource discoveryEndpointUri
     */
    readonly discoveryEndpointUri: string;
    /**
     * Friendly Name
     */
    readonly friendlyName?: string;
    /**
     * Registered Server last heart beat
     */
    readonly lastHeartBeat: string;
    /**
     * Resource Last Operation Name
     */
    readonly lastOperationName: string;
    /**
     * Registered Server lastWorkflowId
     */
    readonly lastWorkflowId: string;
    /**
     * Management Endpoint Uri
     */
    readonly managementEndpointUri: string;
    /**
     * Monitoring Configuration
     */
    readonly monitoringConfiguration: string;
    /**
     * Telemetry Endpoint Uri
     */
    readonly monitoringEndpointUri: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Registered Server Provisioning State
     */
    readonly provisioningState: string;
    /**
     * Resource Location
     */
    readonly resourceLocation: string;
    /**
     * Registered Server Certificate
     */
    readonly serverCertificate?: string;
    /**
     * Registered Server serverId
     */
    readonly serverId?: string;
    /**
     * Registered Server Management Error Code
     */
    readonly serverManagementErrorCode: number;
    /**
     * Server name
     */
    readonly serverName: string;
    /**
     * Registered Server OS Version
     */
    readonly serverOSVersion?: string;
    /**
     * Registered Server serverRole
     */
    readonly serverRole?: string;
    /**
     * Service Location
     */
    readonly serviceLocation: string;
    /**
     * Registered Server storageSyncServiceUid
     */
    readonly storageSyncServiceUid: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
