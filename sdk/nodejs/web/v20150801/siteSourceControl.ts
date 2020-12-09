// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Describes the source control configuration for web app
 */
export class SiteSourceControl extends pulumi.CustomResource {
    /**
     * Get an existing SiteSourceControl resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SiteSourceControl {
        return new SiteSourceControl(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20150801:SiteSourceControl';

    /**
     * Returns true if the given object is an instance of SiteSourceControl.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SiteSourceControl {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SiteSourceControl.__pulumiType;
    }

    /**
     * Name of branch to use for deployment
     */
    public readonly branch!: pulumi.Output<string | undefined>;
    /**
     * Whether to manual or continuous integration
     */
    public readonly deploymentRollbackEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Whether to manual or continuous integration
     */
    public readonly isManualIntegration!: pulumi.Output<boolean | undefined>;
    /**
     * Mercurial or Git repository type
     */
    public readonly isMercurial!: pulumi.Output<boolean | undefined>;
    /**
     * Kind of resource
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource Name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Repository or source control url
     */
    public readonly repoUrl!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a SiteSourceControl resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SiteSourceControlArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["branch"] = args ? args.branch : undefined;
            inputs["deploymentRollbackEnabled"] = args ? args.deploymentRollbackEnabled : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["isManualIntegration"] = args ? args.isManualIntegration : undefined;
            inputs["isMercurial"] = args ? args.isMercurial : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["repoUrl"] = args ? args.repoUrl : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
        } else {
            inputs["branch"] = undefined /*out*/;
            inputs["deploymentRollbackEnabled"] = undefined /*out*/;
            inputs["isManualIntegration"] = undefined /*out*/;
            inputs["isMercurial"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["repoUrl"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:SiteSourceControl" }, { type: "azure-nextgen:web/v20160801:SiteSourceControl" }, { type: "azure-nextgen:web/v20180201:SiteSourceControl" }, { type: "azure-nextgen:web/v20181101:SiteSourceControl" }, { type: "azure-nextgen:web/v20190801:SiteSourceControl" }, { type: "azure-nextgen:web/v20200601:SiteSourceControl" }, { type: "azure-nextgen:web/v20200901:SiteSourceControl" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SiteSourceControl.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SiteSourceControl resource.
 */
export interface SiteSourceControlArgs {
    /**
     * Name of branch to use for deployment
     */
    readonly branch?: pulumi.Input<string>;
    /**
     * Whether to manual or continuous integration
     */
    readonly deploymentRollbackEnabled?: pulumi.Input<boolean>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Whether to manual or continuous integration
     */
    readonly isManualIntegration?: pulumi.Input<boolean>;
    /**
     * Mercurial or Git repository type
     */
    readonly isMercurial?: pulumi.Input<boolean>;
    /**
     * Kind of resource
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Input<string>;
    /**
     * Repository or source control url
     */
    readonly repoUrl?: pulumi.Input<string>;
    /**
     * Name of resource group
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource type
     */
    readonly type?: pulumi.Input<string>;
}
