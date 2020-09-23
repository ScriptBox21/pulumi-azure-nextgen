// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getOnPremiseIotSensor(args: GetOnPremiseIotSensorArgs, opts?: pulumi.InvokeOptions): Promise<GetOnPremiseIotSensorResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:security/v20200806preview:getOnPremiseIotSensor", {
        "onPremiseIotSensorName": args.onPremiseIotSensorName,
    }, opts);
}

export interface GetOnPremiseIotSensorArgs {
    /**
     * Name of the on-premise IoT sensor
     */
    readonly onPremiseIotSensorName: string;
}

/**
 * On-premise IoT sensor
 */
export interface GetOnPremiseIotSensorResult {
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Resource type
     */
    readonly type: string;
}
