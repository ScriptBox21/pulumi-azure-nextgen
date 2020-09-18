// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getMachineLearningDataset(args: GetMachineLearningDatasetArgs, opts?: pulumi.InvokeOptions): Promise<GetMachineLearningDatasetResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:machinelearningservices/v20200501preview:getMachineLearningDataset", {
        "datasetName": args.datasetName,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetMachineLearningDatasetArgs {
    /**
     * The Dataset name.
     */
    readonly datasetName: string;
    /**
     * Name of the resource group in which workspace is located.
     */
    readonly resourceGroupName: string;
    /**
     * Name of Azure Machine Learning workspace.
     */
    readonly workspaceName: string;
}

/**
 * Machine Learning dataset object wrapped into ARM resource envelope.
 */
export interface GetMachineLearningDatasetResult {
    /**
     * The identity of the resource.
     */
    readonly identity?: outputs.machinelearningservices.v20200501preview.IdentityResponse;
    /**
     * Specifies the location of the resource.
     */
    readonly location?: string;
    /**
     * Specifies the name of the resource.
     */
    readonly name: string;
    /**
     * Dataset properties
     */
    readonly properties: outputs.machinelearningservices.v20200501preview.DatasetResponse;
    /**
     * The sku of the workspace.
     */
    readonly sku?: outputs.machinelearningservices.v20200501preview.SkuResponse;
    /**
     * Contains resource tags defined as key/value pairs.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Specifies the type of the resource.
     */
    readonly type: string;
}
