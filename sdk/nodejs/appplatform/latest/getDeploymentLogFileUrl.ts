// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getDeploymentLogFileUrl(args: GetDeploymentLogFileUrlArgs, opts?: pulumi.InvokeOptions): Promise<GetDeploymentLogFileUrlResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:appplatform/latest:getDeploymentLogFileUrl", {
        "appName": args.appName,
        "deploymentName": args.deploymentName,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetDeploymentLogFileUrlArgs {
    /**
     * The name of the App resource.
     */
    readonly appName: string;
    /**
     * The name of the Deployment resource.
     */
    readonly deploymentName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Service resource.
     */
    readonly serviceName: string;
}

/**
 * Log file URL payload
 */
export interface GetDeploymentLogFileUrlResult {
    /**
     * URL of the log file
     */
    readonly url: string;
}
