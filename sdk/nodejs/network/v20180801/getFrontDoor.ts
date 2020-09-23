// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getFrontDoor(args: GetFrontDoorArgs, opts?: pulumi.InvokeOptions): Promise<GetFrontDoorResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20180801:getFrontDoor", {
        "frontDoorName": args.frontDoorName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetFrontDoorArgs {
    /**
     * Name of the Front Door which is globally unique.
     */
    readonly frontDoorName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * Front Door represents a collection of backend endpoints to route traffic to along with rules that specify how traffic is sent there.
 */
export interface GetFrontDoorResult {
    /**
     * Backend pools available to routing rules.
     */
    readonly backendPools?: outputs.network.v20180801.BackendPoolResponse[];
    /**
     * The host that each frontendEndpoint must CNAME to.
     */
    readonly cname: string;
    /**
     * Operational status of the Front Door load balancer. Permitted values are 'Enabled' or 'Disabled'
     */
    readonly enabledState?: string;
    /**
     * A friendly name for the frontDoor
     */
    readonly friendlyName?: string;
    /**
     * Frontend endpoints available to routing rules.
     */
    readonly frontendEndpoints?: outputs.network.v20180801.FrontendEndpointResponse[];
    /**
     * Health probe settings associated with this Front Door instance.
     */
    readonly healthProbeSettings?: outputs.network.v20180801.HealthProbeSettingsModelResponse[];
    /**
     * Load balancing settings associated with this Front Door instance.
     */
    readonly loadBalancingSettings?: outputs.network.v20180801.LoadBalancingSettingsModelResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Provisioning state of the Front Door.
     */
    readonly provisioningState: string;
    /**
     * Resource status of the Front Door.
     */
    readonly resourceState: string;
    /**
     * Routing rules associated with this Front Door.
     */
    readonly routingRules?: outputs.network.v20180801.RoutingRuleResponse[];
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
