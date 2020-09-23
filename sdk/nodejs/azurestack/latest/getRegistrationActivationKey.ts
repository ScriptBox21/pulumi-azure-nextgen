// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getRegistrationActivationKey(args: GetRegistrationActivationKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetRegistrationActivationKeyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:azurestack/latest:getRegistrationActivationKey", {
        "registrationName": args.registrationName,
        "resourceGroup": args.resourceGroup,
    }, opts);
}

export interface GetRegistrationActivationKeyArgs {
    /**
     * Name of the Azure Stack registration.
     */
    readonly registrationName: string;
    /**
     * Name of the resource group.
     */
    readonly resourceGroup: string;
}

/**
 * The resource containing the Azure Stack activation key.
 */
export interface GetRegistrationActivationKeyResult {
    /**
     * Azure Stack activation key.
     */
    readonly activationKey?: string;
}
