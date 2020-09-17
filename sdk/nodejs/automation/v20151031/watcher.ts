// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Definition of the watcher type.
 */
export class Watcher extends pulumi.CustomResource {
    /**
     * Get an existing Watcher resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Watcher {
        return new Watcher(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:automation/v20151031:Watcher';

    /**
     * Returns true if the given object is an instance of Watcher.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Watcher {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Watcher.__pulumiType;
    }

    /**
     * Gets or sets the creation time.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string>;
    /**
     * Gets or sets the description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the etag of the resource.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the frequency at which the watcher is invoked.
     */
    public readonly executionFrequencyInSeconds!: pulumi.Output<number | undefined>;
    /**
     * Details of the user who last modified the watcher.
     */
    public /*out*/ readonly lastModifiedBy!: pulumi.Output<string>;
    /**
     * Gets or sets the last modified time.
     */
    public /*out*/ readonly lastModifiedTime!: pulumi.Output<string>;
    /**
     * The Azure Region where the resource lives
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Gets or sets the name of the script the watcher is attached to, i.e. the name of an existing runbook.
     */
    public readonly scriptName!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the parameters of the script.
     */
    public readonly scriptParameters!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Gets or sets the name of the hybrid worker group the watcher will run on.
     */
    public readonly scriptRunOn!: pulumi.Output<string | undefined>;
    /**
     * Gets the current status of the watcher.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Watcher resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WatcherArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.automationAccountName === undefined) {
                throw new Error("Missing required property 'automationAccountName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.watcherName === undefined) {
                throw new Error("Missing required property 'watcherName'");
            }
            inputs["automationAccountName"] = args ? args.automationAccountName : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["executionFrequencyInSeconds"] = args ? args.executionFrequencyInSeconds : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["scriptName"] = args ? args.scriptName : undefined;
            inputs["scriptParameters"] = args ? args.scriptParameters : undefined;
            inputs["scriptRunOn"] = args ? args.scriptRunOn : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["watcherName"] = args ? args.watcherName : undefined;
            inputs["creationTime"] = undefined /*out*/;
            inputs["lastModifiedBy"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["creationTime"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["executionFrequencyInSeconds"] = undefined /*out*/;
            inputs["lastModifiedBy"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["scriptName"] = undefined /*out*/;
            inputs["scriptParameters"] = undefined /*out*/;
            inputs["scriptRunOn"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:automation/latest:Watcher" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Watcher.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Watcher resource.
 */
export interface WatcherArgs {
    /**
     * The name of the automation account.
     */
    readonly automationAccountName: pulumi.Input<string>;
    /**
     * Gets or sets the description.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Gets or sets the etag of the resource.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Gets or sets the frequency at which the watcher is invoked.
     */
    readonly executionFrequencyInSeconds?: pulumi.Input<number>;
    /**
     * The Azure Region where the resource lives
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Name of an Azure Resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Gets or sets the name of the script the watcher is attached to, i.e. the name of an existing runbook.
     */
    readonly scriptName?: pulumi.Input<string>;
    /**
     * Gets or sets the parameters of the script.
     */
    readonly scriptParameters?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Gets or sets the name of the hybrid worker group the watcher will run on.
     */
    readonly scriptRunOn?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The watcher name.
     */
    readonly watcherName: pulumi.Input<string>;
}