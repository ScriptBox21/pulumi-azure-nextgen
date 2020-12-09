// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getRuleSet(args: GetRuleSetArgs, opts?: pulumi.InvokeOptions): Promise<GetRuleSetResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:cdn/v20200901:getRuleSet", {
        "profileName": args.profileName,
        "resourceGroupName": args.resourceGroupName,
        "ruleSetName": args.ruleSetName,
    }, opts);
}

export interface GetRuleSetArgs {
    /**
     * Name of the CDN profile which is unique within the resource group.
     */
    readonly profileName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the rule set under the profile which is unique globally.
     */
    readonly ruleSetName: string;
}

/**
 * Friendly RuleSet name mapping to the any RuleSet or secret related information.
 */
export interface GetRuleSetResult {
    readonly deploymentStatus: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Provisioning status
     */
    readonly provisioningState: string;
    /**
     * Read only system data
     */
    readonly systemData: outputs.cdn.v20200901.SystemDataResponse;
    /**
     * Resource type.
     */
    readonly type: string;
}
