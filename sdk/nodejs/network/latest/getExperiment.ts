// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getExperiment(args: GetExperimentArgs, opts?: pulumi.InvokeOptions): Promise<GetExperimentResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/latest:getExperiment", {
        "experimentName": args.experimentName,
        "profileName": args.profileName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetExperimentArgs {
    /**
     * The Experiment identifier associated with the Experiment
     */
    readonly experimentName: string;
    /**
     * The Profile identifier associated with the Tenant and Partner
     */
    readonly profileName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * Defines the properties of an Experiment
 */
export interface GetExperimentResult {
    /**
     * The description of the details or intents of the Experiment
     */
    readonly description?: string;
    /**
     * The state of the Experiment
     */
    readonly enabledState?: string;
    /**
     * The endpoint A of an experiment
     */
    readonly endpointA?: outputs.network.latest.EndpointResponse;
    /**
     * The endpoint B of an experiment
     */
    readonly endpointB?: outputs.network.latest.EndpointResponse;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Resource status.
     */
    readonly resourceState: string;
    /**
     * The uri to the Script used in the Experiment
     */
    readonly scriptFileUri: string;
    /**
     * The description of Experiment status from the server side
     */
    readonly status: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
