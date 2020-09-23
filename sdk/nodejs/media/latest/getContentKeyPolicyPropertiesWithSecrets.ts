// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getContentKeyPolicyPropertiesWithSecrets(args: GetContentKeyPolicyPropertiesWithSecretsArgs, opts?: pulumi.InvokeOptions): Promise<GetContentKeyPolicyPropertiesWithSecretsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/latest:getContentKeyPolicyPropertiesWithSecrets", {
        "accountName": args.accountName,
        "contentKeyPolicyName": args.contentKeyPolicyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetContentKeyPolicyPropertiesWithSecretsArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The Content Key Policy name.
     */
    readonly contentKeyPolicyName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * The properties of the Content Key Policy.
 */
export interface GetContentKeyPolicyPropertiesWithSecretsResult {
    /**
     * The creation date of the Policy
     */
    readonly created: string;
    /**
     * A description for the Policy.
     */
    readonly description?: string;
    /**
     * The last modified date of the Policy
     */
    readonly lastModified: string;
    /**
     * The Key Policy options.
     */
    readonly options: outputs.media.latest.ContentKeyPolicyOptionResponse[];
    /**
     * The legacy Policy ID.
     */
    readonly policyId: string;
}
