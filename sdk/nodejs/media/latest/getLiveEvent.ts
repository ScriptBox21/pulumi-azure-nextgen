// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getLiveEvent(args: GetLiveEventArgs, opts?: pulumi.InvokeOptions): Promise<GetLiveEventResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/latest:getLiveEvent", {
        "accountName": args.accountName,
        "liveEventName": args.liveEventName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetLiveEventArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The name of the live event, maximum length is 32.
     */
    readonly liveEventName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * The live event.
 */
export interface GetLiveEventResult {
    /**
     * The creation time for the live event
     */
    readonly created: string;
    /**
     * Live event cross site access policies.
     */
    readonly crossSiteAccessPolicies?: outputs.media.latest.CrossSiteAccessPoliciesResponse;
    /**
     * A description for the live event.
     */
    readonly description?: string;
    /**
     * Encoding settings for the live event. It configures whether a live encoder is used for the live event and settings for the live encoder if it is used.
     */
    readonly encoding?: outputs.media.latest.LiveEventEncodingResponse;
    /**
     * When useStaticHostname is set to true, the hostnamePrefix specifies the first part of the hostname assigned to the live event preview and ingest endpoints. The final hostname would be a combination of this prefix, the media service account name and a short code for the Azure Media Services data center.
     */
    readonly hostnamePrefix?: string;
    /**
     * Live event input settings. It defines how the live event receives input from a contribution encoder.
     */
    readonly input: outputs.media.latest.LiveEventInputResponse;
    /**
     * The last modified time of the live event.
     */
    readonly lastModified: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Live event preview settings. Preview allows live event producers to preview the live streaming content without creating any live output.
     */
    readonly preview?: outputs.media.latest.LiveEventPreviewResponse;
    /**
     * The provisioning state of the live event.
     */
    readonly provisioningState: string;
    /**
     * The resource state of the live event. See https://go.microsoft.com/fwlink/?linkid=2139012 for more information.
     */
    readonly resourceState: string;
    /**
     * The options to use for the LiveEvent. This value is specified at creation time and cannot be updated. The valid values for the array entry values are 'Default' and 'LowLatency'.
     */
    readonly streamOptions?: string[];
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Live transcription settings for the live event. See https://go.microsoft.com/fwlink/?linkid=2133742 for more information about the live transcription feature.
     */
    readonly transcriptions?: outputs.media.latest.LiveEventTranscriptionResponse[];
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: string;
    /**
     * Specifies whether a static hostname would be assigned to the live event preview and ingest endpoints. This value can only be updated if the live event is in Standby state
     */
    readonly useStaticHostname?: boolean;
}
