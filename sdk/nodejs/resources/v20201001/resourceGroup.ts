// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Resource group information.
 */
export class ResourceGroup extends pulumi.CustomResource {
    /**
     * Get an existing ResourceGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ResourceGroup {
        return new ResourceGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:resources/v20201001:ResourceGroup';

    /**
     * Returns true if the given object is an instance of ResourceGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ResourceGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ResourceGroup.__pulumiType;
    }

    /**
     * The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The ID of the resource that manages this resource group.
     */
    public readonly managedBy!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource group.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The resource group properties.
     */
    public /*out*/ readonly properties!: pulumi.Output<outputs.resources.v20201001.ResourceGroupPropertiesResponse>;
    /**
     * The tags attached to the resource group.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource group.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ResourceGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ResourceGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["managedBy"] = args ? args.managedBy : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["managedBy"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:resources/latest:ResourceGroup" }, { type: "azure-nextgen:resources/v20151101:ResourceGroup" }, { type: "azure-nextgen:resources/v20160201:ResourceGroup" }, { type: "azure-nextgen:resources/v20160701:ResourceGroup" }, { type: "azure-nextgen:resources/v20160901:ResourceGroup" }, { type: "azure-nextgen:resources/v20170510:ResourceGroup" }, { type: "azure-nextgen:resources/v20180201:ResourceGroup" }, { type: "azure-nextgen:resources/v20180501:ResourceGroup" }, { type: "azure-nextgen:resources/v20190301:ResourceGroup" }, { type: "azure-nextgen:resources/v20190501:ResourceGroup" }, { type: "azure-nextgen:resources/v20190510:ResourceGroup" }, { type: "azure-nextgen:resources/v20190701:ResourceGroup" }, { type: "azure-nextgen:resources/v20190801:ResourceGroup" }, { type: "azure-nextgen:resources/v20191001:ResourceGroup" }, { type: "azure-nextgen:resources/v20200601:ResourceGroup" }, { type: "azure-nextgen:resources/v20200801:ResourceGroup" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ResourceGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ResourceGroup resource.
 */
export interface ResourceGroupArgs {
    /**
     * The location of the resource group. It cannot be changed after the resource group has been created. It must be one of the supported Azure locations.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The ID of the resource that manages this resource group.
     */
    readonly managedBy?: pulumi.Input<string>;
    /**
     * The name of the resource group to create or update. Can include alphanumeric, underscore, parentheses, hyphen, period (except at end), and Unicode characters that match the allowed characters.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The tags attached to the resource group.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
