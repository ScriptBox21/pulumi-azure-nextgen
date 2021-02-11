// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getStreamingLocator(args: GetStreamingLocatorArgs, opts?: pulumi.InvokeOptions): Promise<GetStreamingLocatorResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/v20200501:getStreamingLocator", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "streamingLocatorName": args.streamingLocatorName,
    }, opts);
}

export interface GetStreamingLocatorArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The Streaming Locator name.
     */
    readonly streamingLocatorName: string;
}

/**
 * A Streaming Locator resource
 */
export interface GetStreamingLocatorResult {
    /**
     * Alternative Media ID of this Streaming Locator
     */
    readonly alternativeMediaId?: string;
    /**
     * Asset Name
     */
    readonly assetName: string;
    /**
     * The ContentKeys used by this Streaming Locator.
     */
    readonly contentKeys?: outputs.media.v20200501.StreamingLocatorContentKeyResponse[];
    /**
     * The creation time of the Streaming Locator.
     */
    readonly created: string;
    /**
     * Name of the default ContentKeyPolicy used by this Streaming Locator.
     */
    readonly defaultContentKeyPolicyName?: string;
    /**
     * The end time of the Streaming Locator.
     */
    readonly endTime?: string;
    /**
     * A list of asset or account filters which apply to this streaming locator
     */
    readonly filters?: string[];
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The start time of the Streaming Locator.
     */
    readonly startTime?: string;
    /**
     * The StreamingLocatorId of the Streaming Locator.
     */
    readonly streamingLocatorId?: string;
    /**
     * Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
     */
    readonly streamingPolicyName: string;
    /**
     * The system metadata relating to this resource.
     */
    readonly systemData: outputs.media.v20200501.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
