// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getLogAnalyticExportRequestRateByInterval(args: GetLogAnalyticExportRequestRateByIntervalArgs, opts?: pulumi.InvokeOptions): Promise<GetLogAnalyticExportRequestRateByIntervalResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:compute/latest:getLogAnalyticExportRequestRateByInterval", {
        "blobContainerSasUri": args.blobContainerSasUri,
        "fromTime": args.fromTime,
        "groupByClientApplicationId": args.groupByClientApplicationId,
        "groupByOperationName": args.groupByOperationName,
        "groupByResourceName": args.groupByResourceName,
        "groupByThrottlePolicy": args.groupByThrottlePolicy,
        "groupByUserAgent": args.groupByUserAgent,
        "intervalLength": args.intervalLength,
        "location": args.location,
        "toTime": args.toTime,
    }, opts);
}

export interface GetLogAnalyticExportRequestRateByIntervalArgs {
    /**
     * SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
     */
    readonly blobContainerSasUri: string;
    /**
     * From time of the query
     */
    readonly fromTime: string;
    /**
     * Group query result by Client Application ID.
     */
    readonly groupByClientApplicationId?: boolean;
    /**
     * Group query result by Operation Name.
     */
    readonly groupByOperationName?: boolean;
    /**
     * Group query result by Resource Name.
     */
    readonly groupByResourceName?: boolean;
    /**
     * Group query result by Throttle Policy applied.
     */
    readonly groupByThrottlePolicy?: boolean;
    /**
     * Group query result by User Agent.
     */
    readonly groupByUserAgent?: boolean;
    /**
     * Interval value in minutes used to create LogAnalytics call rate logs.
     */
    readonly intervalLength: string;
    /**
     * The location upon which virtual-machine-sizes is queried.
     */
    readonly location: string;
    /**
     * To time of the query
     */
    readonly toTime: string;
}

/**
 * LogAnalytics operation status response
 */
export interface GetLogAnalyticExportRequestRateByIntervalResult {
    /**
     * LogAnalyticsOutput
     */
    readonly properties: outputs.compute.latest.LogAnalyticsOutputResponse;
}
