// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Static Site ARM resource.
 */
export class StaticSite extends pulumi.CustomResource {
    /**
     * Get an existing StaticSite resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StaticSite {
        return new StaticSite(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/latest:StaticSite';

    /**
     * Returns true if the given object is an instance of StaticSite.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StaticSite {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StaticSite.__pulumiType;
    }

    /**
     * The target branch in the repository.
     */
    public readonly branch!: pulumi.Output<string | undefined>;
    /**
     * Build properties to configure on the repository.
     */
    public readonly buildProperties!: pulumi.Output<outputs.web.latest.StaticSiteBuildPropertiesResponse | undefined>;
    /**
     * The custom domains associated with this static site.
     */
    public /*out*/ readonly customDomains!: pulumi.Output<string[]>;
    /**
     * The default autogenerated hostname for the static site.
     */
    public /*out*/ readonly defaultHostname!: pulumi.Output<string>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A user's github repository token. This is used to setup the Github Actions workflow file and API secrets.
     */
    public readonly repositoryToken!: pulumi.Output<string | undefined>;
    /**
     * URL for the repository of the static site.
     */
    public readonly repositoryUrl!: pulumi.Output<string | undefined>;
    /**
     * Description of a SKU for a scalable resource.
     */
    public readonly sku!: pulumi.Output<outputs.web.latest.SkuDescriptionResponse | undefined>;
    /**
     * The system metadata relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.web.latest.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a StaticSite resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StaticSiteArgs, opts?: pulumi.CustomResourceOptions) {
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
            inputs["buildProperties"] = args ? args.buildProperties : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["repositoryToken"] = args ? args.repositoryToken : undefined;
            inputs["repositoryUrl"] = args ? args.repositoryUrl : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["customDomains"] = undefined /*out*/;
            inputs["defaultHostname"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["branch"] = undefined /*out*/;
            inputs["buildProperties"] = undefined /*out*/;
            inputs["customDomains"] = undefined /*out*/;
            inputs["defaultHostname"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["repositoryToken"] = undefined /*out*/;
            inputs["repositoryUrl"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/v20190801:StaticSite" }, { type: "azure-nextgen:web/v20200601:StaticSite" }, { type: "azure-nextgen:web/v20200901:StaticSite" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(StaticSite.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StaticSite resource.
 */
export interface StaticSiteArgs {
    /**
     * The target branch in the repository.
     */
    readonly branch?: pulumi.Input<string>;
    /**
     * Build properties to configure on the repository.
     */
    readonly buildProperties?: pulumi.Input<inputs.web.latest.StaticSiteBuildProperties>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Name of the static site to create or update.
     */
    readonly name: pulumi.Input<string>;
    /**
     * A user's github repository token. This is used to setup the Github Actions workflow file and API secrets.
     */
    readonly repositoryToken?: pulumi.Input<string>;
    /**
     * URL for the repository of the static site.
     */
    readonly repositoryUrl?: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Description of a SKU for a scalable resource.
     */
    readonly sku?: pulumi.Input<inputs.web.latest.SkuDescription>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
