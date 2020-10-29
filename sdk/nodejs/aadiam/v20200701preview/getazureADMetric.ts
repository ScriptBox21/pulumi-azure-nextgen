// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getazureADMetric(args: GetazureADMetricArgs, opts?: pulumi.InvokeOptions): Promise<GetazureADMetricResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:aadiam/v20200701preview:getazureADMetric", {
        "azureADMetricsName": args.azureADMetricsName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetazureADMetricArgs {
    /**
     * Name of the azureADMetrics instance.
     */
    readonly azureADMetricsName: string;
    /**
     * Name of an Azure resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * AzureADMetrics resource.
 */
export interface GetazureADMetricResult {
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    readonly properties: outputs.aadiam.v20200701preview.AzureADMetricsPropertiesFormatResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
