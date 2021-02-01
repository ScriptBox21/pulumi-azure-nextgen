// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Push settings for the App.
 */
export class WebAppSitePushSettingsSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppSitePushSettingsSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppSitePushSettingsSlot {
        return new WebAppSitePushSettingsSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20200601:WebAppSitePushSettingsSlot';

    /**
     * Returns true if the given object is an instance of WebAppSitePushSettingsSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppSitePushSettingsSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppSitePushSettingsSlot.__pulumiType;
    }

    /**
     * Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
     */
    public readonly dynamicTagsJson!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets a flag indicating whether the Push endpoint is enabled.
     */
    public readonly isPushEnabled!: pulumi.Output<boolean>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
     */
    public readonly tagWhitelistJson!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
     * Tags can consist of alphanumeric characters and the following:
     * '_', '@', '#', '.', ':', '-'. 
     * Validation should be performed at the PushRequestHandler.
     */
    public readonly tagsRequiringAuth!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppSitePushSettingsSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppSitePushSettingsSlotArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.isPushEnabled === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'isPushEnabled'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.slot === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'slot'");
            }
            inputs["dynamicTagsJson"] = args ? args.dynamicTagsJson : undefined;
            inputs["isPushEnabled"] = args ? args.isPushEnabled : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["slot"] = args ? args.slot : undefined;
            inputs["tagWhitelistJson"] = args ? args.tagWhitelistJson : undefined;
            inputs["tagsRequiringAuth"] = args ? args.tagsRequiringAuth : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["dynamicTagsJson"] = undefined /*out*/;
            inputs["isPushEnabled"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["tagWhitelistJson"] = undefined /*out*/;
            inputs["tagsRequiringAuth"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppSitePushSettingsSlot" }, { type: "azure-nextgen:web/v20160801:WebAppSitePushSettingsSlot" }, { type: "azure-nextgen:web/v20180201:WebAppSitePushSettingsSlot" }, { type: "azure-nextgen:web/v20181101:WebAppSitePushSettingsSlot" }, { type: "azure-nextgen:web/v20190801:WebAppSitePushSettingsSlot" }, { type: "azure-nextgen:web/v20200901:WebAppSitePushSettingsSlot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppSitePushSettingsSlot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppSitePushSettingsSlot resource.
 */
export interface WebAppSitePushSettingsSlotArgs {
    /**
     * Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
     */
    readonly dynamicTagsJson?: pulumi.Input<string>;
    /**
     * Gets or sets a flag indicating whether the Push endpoint is enabled.
     */
    readonly isPushEnabled: pulumi.Input<boolean>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Name of web app.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Name of web app slot. If not specified then will default to production slot.
     */
    readonly slot: pulumi.Input<string>;
    /**
     * Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
     */
    readonly tagWhitelistJson?: pulumi.Input<string>;
    /**
     * Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
     * Tags can consist of alphanumeric characters and the following:
     * '_', '@', '#', '.', ':', '-'. 
     * Validation should be performed at the PushRequestHandler.
     */
    readonly tagsRequiringAuth?: pulumi.Input<string>;
}
