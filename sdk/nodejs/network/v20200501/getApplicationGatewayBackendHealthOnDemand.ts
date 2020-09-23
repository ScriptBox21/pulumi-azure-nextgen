// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getApplicationGatewayBackendHealthOnDemand(args: GetApplicationGatewayBackendHealthOnDemandArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationGatewayBackendHealthOnDemandResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200501:getApplicationGatewayBackendHealthOnDemand", {
        "applicationGatewayName": args.applicationGatewayName,
        "backendAddressPool": args.backendAddressPool,
        "backendHttpSettings": args.backendHttpSettings,
        "expand": args.expand,
        "host": args.host,
        "match": args.match,
        "path": args.path,
        "pickHostNameFromBackendHttpSettings": args.pickHostNameFromBackendHttpSettings,
        "protocol": args.protocol,
        "resourceGroupName": args.resourceGroupName,
        "timeout": args.timeout,
    }, opts);
}

export interface GetApplicationGatewayBackendHealthOnDemandArgs {
    /**
     * The name of the application gateway.
     */
    readonly applicationGatewayName: string;
    /**
     * Reference to backend pool of application gateway to which probe request will be sent.
     */
    readonly backendAddressPool?: inputs.network.v20200501.SubResource;
    /**
     * Reference to backend http setting of application gateway to be used for test probe.
     */
    readonly backendHttpSettings?: inputs.network.v20200501.SubResource;
    /**
     * Expands BackendAddressPool and BackendHttpSettings referenced in backend health.
     */
    readonly expand?: string;
    /**
     * Host name to send the probe to.
     */
    readonly host?: string;
    /**
     * Criterion for classifying a healthy probe response.
     */
    readonly match?: inputs.network.v20200501.ApplicationGatewayProbeHealthResponseMatch;
    /**
     * Relative path of probe. Valid path starts from '/'. Probe is sent to <Protocol>://<host>:<port><path>.
     */
    readonly path?: string;
    /**
     * Whether the host header should be picked from the backend http settings. Default value is false.
     */
    readonly pickHostNameFromBackendHttpSettings?: boolean;
    /**
     * The protocol used for the probe.
     */
    readonly protocol?: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds.
     */
    readonly timeout?: number;
}

/**
 * Result of on demand test probe.
 */
export interface GetApplicationGatewayBackendHealthOnDemandResult {
    /**
     * Reference to an ApplicationGatewayBackendAddressPool resource.
     */
    readonly backendAddressPool?: outputs.network.v20200501.ApplicationGatewayBackendAddressPoolResponse;
    /**
     * Application gateway BackendHealthHttp settings.
     */
    readonly backendHealthHttpSettings?: outputs.network.v20200501.ApplicationGatewayBackendHealthHttpSettingsResponse;
}
