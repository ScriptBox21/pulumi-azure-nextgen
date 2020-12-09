// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Source control configuration for an app.
 */
export class WebAppSourceControlSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppSourceControlSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppSourceControlSlot {
        return new WebAppSourceControlSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20160801:WebAppSourceControlSlot';

    /**
     * Returns true if the given object is an instance of WebAppSourceControlSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppSourceControlSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppSourceControlSlot.__pulumiType;
    }

    /**
     * Name of branch to use for deployment.
     */
    public readonly branch!: pulumi.Output<string | undefined>;
    /**
     * <code>true</code> to enable deployment rollback; otherwise, <code>false</code>.
     */
    public readonly deploymentRollbackEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * <code>true</code> to limit to manual integration; <code>false</code> to enable continuous integration (which configures webhooks into online repos like GitHub).
     */
    public readonly isManualIntegration!: pulumi.Output<boolean | undefined>;
    /**
     * <code>true</code> for a Mercurial repository; <code>false</code> for a Git repository.
     */
    public readonly isMercurial!: pulumi.Output<boolean | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Repository or source control URL.
     */
    public readonly repoUrl!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppSourceControlSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppSourceControlSlotArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.slot === undefined) {
                throw new Error("Missing required property 'slot'");
            }
            inputs["branch"] = args ? args.branch : undefined;
            inputs["deploymentRollbackEnabled"] = args ? args.deploymentRollbackEnabled : undefined;
            inputs["isManualIntegration"] = args ? args.isManualIntegration : undefined;
            inputs["isMercurial"] = args ? args.isMercurial : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["repoUrl"] = args ? args.repoUrl : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["slot"] = args ? args.slot : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["branch"] = undefined /*out*/;
            inputs["deploymentRollbackEnabled"] = undefined /*out*/;
            inputs["isManualIntegration"] = undefined /*out*/;
            inputs["isMercurial"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["repoUrl"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppSourceControlSlot" }, { type: "azure-nextgen:web/v20150801:WebAppSourceControlSlot" }, { type: "azure-nextgen:web/v20180201:WebAppSourceControlSlot" }, { type: "azure-nextgen:web/v20181101:WebAppSourceControlSlot" }, { type: "azure-nextgen:web/v20190801:WebAppSourceControlSlot" }, { type: "azure-nextgen:web/v20200601:WebAppSourceControlSlot" }, { type: "azure-nextgen:web/v20200901:WebAppSourceControlSlot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppSourceControlSlot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppSourceControlSlot resource.
 */
export interface WebAppSourceControlSlotArgs {
    /**
     * Name of branch to use for deployment.
     */
    readonly branch?: pulumi.Input<string>;
    /**
     * <code>true</code> to enable deployment rollback; otherwise, <code>false</code>.
     */
    readonly deploymentRollbackEnabled?: pulumi.Input<boolean>;
    /**
     * <code>true</code> to limit to manual integration; <code>false</code> to enable continuous integration (which configures webhooks into online repos like GitHub).
     */
    readonly isManualIntegration?: pulumi.Input<boolean>;
    /**
     * <code>true</code> for a Mercurial repository; <code>false</code> for a Git repository.
     */
    readonly isMercurial?: pulumi.Input<boolean>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Name of the app.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Repository or source control URL.
     */
    readonly repoUrl?: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the deployment slot. If a slot is not specified, the API will update the source control configuration for the production slot.
     */
    readonly slot: pulumi.Input<string>;
}
