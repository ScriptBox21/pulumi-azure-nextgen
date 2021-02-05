// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getBookmark(args: GetBookmarkArgs, opts?: pulumi.InvokeOptions): Promise<GetBookmarkResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:securityinsights/v20190101preview:getBookmark", {
        "bookmarkId": args.bookmarkId,
        "operationalInsightsResourceProvider": args.operationalInsightsResourceProvider,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetBookmarkArgs {
    /**
     * Bookmark ID
     */
    readonly bookmarkId: string;
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    readonly operationalInsightsResourceProvider: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the workspace.
     */
    readonly workspaceName: string;
}

/**
 * Represents a bookmark in Azure Security Insights.
 */
export interface GetBookmarkResult {
    /**
     * The time the bookmark was created
     */
    readonly created?: string;
    /**
     * Describes a user that created the bookmark
     */
    readonly createdBy?: outputs.securityinsights.v20190101preview.UserInfoResponse;
    /**
     * The display name of the bookmark
     */
    readonly displayName: string;
    /**
     * Etag of the azure resource
     */
    readonly etag?: string;
    /**
     * The bookmark event time
     */
    readonly eventTime?: string;
    /**
     * Azure resource Id
     */
    readonly id: string;
    /**
     * Describes an incident that relates to bookmark
     */
    readonly incidentInfo?: outputs.securityinsights.v20190101preview.IncidentInfoResponse;
    /**
     * List of labels relevant to this bookmark
     */
    readonly labels?: string[];
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * The notes of the bookmark
     */
    readonly notes?: string;
    /**
     * The query of the bookmark.
     */
    readonly query: string;
    /**
     * The end time for the query
     */
    readonly queryEndTime?: string;
    /**
     * The query result of the bookmark.
     */
    readonly queryResult?: string;
    /**
     * The start time for the query
     */
    readonly queryStartTime?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
    /**
     * The last time the bookmark was updated
     */
    readonly updated?: string;
    /**
     * Describes a user that updated the bookmark
     */
    readonly updatedBy?: outputs.securityinsights.v20190101preview.UserInfoResponse;
}
