// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getAppServicePlan(args: GetAppServicePlanArgs, opts?: pulumi.InvokeOptions): Promise<GetAppServicePlanResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20201001:getAppServicePlan", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAppServicePlanArgs {
    /**
     * Name of the App Service plan.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * App Service plan.
 */
export interface GetAppServicePlanResult {
    /**
     * The time when the server farm free offer expires.
     */
    readonly freeOfferExpirationTime?: string;
    /**
     * Geographical location for the App Service plan.
     */
    readonly geoRegion: string;
    /**
     * Specification for the App Service Environment to use for the App Service plan.
     */
    readonly hostingEnvironmentProfile?: outputs.web.v20201001.HostingEnvironmentProfileResponse;
    /**
     * If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
     */
    readonly hyperV?: boolean;
    /**
     * Resource Id.
     */
    readonly id: string;
    /**
     * If <code>true</code>, this App Service Plan owns spot instances.
     */
    readonly isSpot?: boolean;
    /**
     * Obsolete: If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
     */
    readonly isXenon?: boolean;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Location.
     */
    readonly location: string;
    /**
     * Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan
     */
    readonly maximumElasticWorkerCount?: number;
    /**
     * Maximum number of instances that can be assigned to this App Service plan.
     */
    readonly maximumNumberOfWorkers: number;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Number of apps assigned to this App Service plan.
     */
    readonly numberOfSites: number;
    /**
     * If <code>true</code>, apps assigned to this App Service plan can be scaled independently.
     * If <code>false</code>, apps assigned to this App Service plan will scale to all instances of the plan.
     */
    readonly perSiteScaling?: boolean;
    /**
     * Provisioning state of the App Service Environment.
     */
    readonly provisioningState: string;
    /**
     * If Linux app service plan <code>true</code>, <code>false</code> otherwise.
     */
    readonly reserved?: boolean;
    /**
     * Resource group of the App Service plan.
     */
    readonly resourceGroup: string;
    /**
     * Description of a SKU for a scalable resource.
     */
    readonly sku?: outputs.web.v20201001.SkuDescriptionResponse;
    /**
     * The time when the server farm expires. Valid only if it is a spot server farm.
     */
    readonly spotExpirationTime?: string;
    /**
     * App Service plan status.
     */
    readonly status: string;
    /**
     * App Service plan subscription.
     */
    readonly subscription: string;
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.web.v20201001.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Scaling worker count.
     */
    readonly targetWorkerCount?: number;
    /**
     * Scaling worker size ID.
     */
    readonly targetWorkerSizeId?: number;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * Target worker tier assigned to the App Service plan.
     */
    readonly workerTierName?: string;
}
