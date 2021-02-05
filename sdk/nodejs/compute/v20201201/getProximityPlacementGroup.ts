// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getProximityPlacementGroup(args: GetProximityPlacementGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetProximityPlacementGroupResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:compute/v20201201:getProximityPlacementGroup", {
        "includeColocationStatus": args.includeColocationStatus,
        "proximityPlacementGroupName": args.proximityPlacementGroupName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetProximityPlacementGroupArgs {
    /**
     * includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group.
     */
    readonly includeColocationStatus?: string;
    /**
     * The name of the proximity placement group.
     */
    readonly proximityPlacementGroupName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Specifies information about the proximity placement group.
 */
export interface GetProximityPlacementGroupResult {
    /**
     * A list of references to all availability sets in the proximity placement group.
     */
    readonly availabilitySets: outputs.compute.v20201201.SubResourceWithColocationStatusResponse[];
    /**
     * Describes colocation status of the Proximity Placement Group.
     */
    readonly colocationStatus?: outputs.compute.v20201201.InstanceViewStatusResponse;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
     */
    readonly proximityPlacementGroupType?: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * A list of references to all virtual machine scale sets in the proximity placement group.
     */
    readonly virtualMachineScaleSets: outputs.compute.v20201201.SubResourceWithColocationStatusResponse[];
    /**
     * A list of references to all virtual machines in the proximity placement group.
     */
    readonly virtualMachines: outputs.compute.v20201201.SubResourceWithColocationStatusResponse[];
}
