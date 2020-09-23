// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getFactoryGitHubAccessToken(args: GetFactoryGitHubAccessTokenArgs, opts?: pulumi.InvokeOptions): Promise<GetFactoryGitHubAccessTokenResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datafactory/v20180601:getFactoryGitHubAccessToken", {
        "factoryName": args.factoryName,
        "gitHubAccessCode": args.gitHubAccessCode,
        "gitHubAccessTokenBaseUrl": args.gitHubAccessTokenBaseUrl,
        "gitHubClientId": args.gitHubClientId,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetFactoryGitHubAccessTokenArgs {
    /**
     * The factory name.
     */
    readonly factoryName: string;
    /**
     * GitHub access code.
     */
    readonly gitHubAccessCode: string;
    /**
     * GitHub access token base URL.
     */
    readonly gitHubAccessTokenBaseUrl: string;
    /**
     * GitHub application client ID.
     */
    readonly gitHubClientId?: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

/**
 * Get GitHub access token response definition.
 */
export interface GetFactoryGitHubAccessTokenResult {
    /**
     * GitHub access token.
     */
    readonly gitHubAccessToken?: string;
}
