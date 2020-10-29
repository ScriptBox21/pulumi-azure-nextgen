// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * The Live Output.
 */
export class LiveOutput extends pulumi.CustomResource {
    /**
     * Get an existing LiveOutput resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LiveOutput {
        return new LiveOutput(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:media/v20200501:LiveOutput';

    /**
     * Returns true if the given object is an instance of LiveOutput.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LiveOutput {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LiveOutput.__pulumiType;
    }

    /**
     * ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
     */
    public readonly archiveWindowLength!: pulumi.Output<string>;
    /**
     * The asset that the live output will write to.
     */
    public readonly assetName!: pulumi.Output<string>;
    /**
     * The creation time the live output.
     */
    public /*out*/ readonly created!: pulumi.Output<string>;
    /**
     * The description of the live output.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * HTTP Live Streaming (HLS) packing setting for the live output.
     */
    public readonly hls!: pulumi.Output<outputs.media.v20200501.HlsResponse | undefined>;
    /**
     * The time the live output was last modified.
     */
    public /*out*/ readonly lastModified!: pulumi.Output<string>;
    /**
     * The manifest file name. If not provided, the service will generate one automatically.
     */
    public readonly manifestName!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The initial timestamp that the live output will start at, any content before this value will not be archived.
     */
    public readonly outputSnapTime!: pulumi.Output<number | undefined>;
    /**
     * The provisioning state of the live output.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource state of the live output.
     */
    public /*out*/ readonly resourceState!: pulumi.Output<string>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a LiveOutput resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LiveOutputArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.archiveWindowLength === undefined) {
                throw new Error("Missing required property 'archiveWindowLength'");
            }
            if (!args || args.assetName === undefined) {
                throw new Error("Missing required property 'assetName'");
            }
            if (!args || args.liveEventName === undefined) {
                throw new Error("Missing required property 'liveEventName'");
            }
            if (!args || args.liveOutputName === undefined) {
                throw new Error("Missing required property 'liveOutputName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["archiveWindowLength"] = args ? args.archiveWindowLength : undefined;
            inputs["assetName"] = args ? args.assetName : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["hls"] = args ? args.hls : undefined;
            inputs["liveEventName"] = args ? args.liveEventName : undefined;
            inputs["liveOutputName"] = args ? args.liveOutputName : undefined;
            inputs["manifestName"] = args ? args.manifestName : undefined;
            inputs["outputSnapTime"] = args ? args.outputSnapTime : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["created"] = undefined /*out*/;
            inputs["lastModified"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["archiveWindowLength"] = undefined /*out*/;
            inputs["assetName"] = undefined /*out*/;
            inputs["created"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["hls"] = undefined /*out*/;
            inputs["lastModified"] = undefined /*out*/;
            inputs["manifestName"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["outputSnapTime"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:media/latest:LiveOutput" }, { type: "azure-nextgen:media/v20180330preview:LiveOutput" }, { type: "azure-nextgen:media/v20180601preview:LiveOutput" }, { type: "azure-nextgen:media/v20180701:LiveOutput" }, { type: "azure-nextgen:media/v20190501preview:LiveOutput" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(LiveOutput.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LiveOutput resource.
 */
export interface LiveOutputArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
     */
    readonly archiveWindowLength: pulumi.Input<string>;
    /**
     * The asset that the live output will write to.
     */
    readonly assetName: pulumi.Input<string>;
    /**
     * The description of the live output.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * HTTP Live Streaming (HLS) packing setting for the live output.
     */
    readonly hls?: pulumi.Input<inputs.media.v20200501.Hls>;
    /**
     * The name of the live event, maximum length is 32.
     */
    readonly liveEventName: pulumi.Input<string>;
    /**
     * The name of the live output.
     */
    readonly liveOutputName: pulumi.Input<string>;
    /**
     * The manifest file name. If not provided, the service will generate one automatically.
     */
    readonly manifestName?: pulumi.Input<string>;
    /**
     * The initial timestamp that the live output will start at, any content before this value will not be archived.
     */
    readonly outputSnapTime?: pulumi.Input<number>;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
