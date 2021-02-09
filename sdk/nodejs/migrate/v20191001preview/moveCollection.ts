// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Define the move collection.
 */
export class MoveCollection extends pulumi.CustomResource {
    /**
     * Get an existing MoveCollection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): MoveCollection {
        return new MoveCollection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:migrate/v20191001preview:MoveCollection';

    /**
     * Returns true if the given object is an instance of MoveCollection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MoveCollection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MoveCollection.__pulumiType;
    }

    /**
     * The etag of the resource.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Defines the MSI properties of the Move Collection.
     */
    public readonly identity!: pulumi.Output<outputs.migrate.v20191001preview.IdentityResponse | undefined>;
    /**
     * The geo-location where the resource lives.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Defines the move collection properties.
     */
    public readonly properties!: pulumi.Output<outputs.migrate.v20191001preview.MoveCollectionPropertiesResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a MoveCollection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MoveCollectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.moveCollectionName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'moveCollectionName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["moveCollectionName"] = args ? args.moveCollectionName : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
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
        const aliasOpts = { aliases: [{ type: "azure-nextgen:migrate/latest:MoveCollection" }, { type: "azure-nextgen:migrate/v20210101:MoveCollection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(MoveCollection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a MoveCollection resource.
 */
export interface MoveCollectionArgs {
    /**
     * Defines the MSI properties of the Move Collection.
     */
    readonly identity?: pulumi.Input<inputs.migrate.v20191001preview.Identity>;
    /**
     * The geo-location where the resource lives.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The Move Collection Name.
     */
    readonly moveCollectionName: pulumi.Input<string>;
    /**
     * Defines the move collection properties.
     */
    readonly properties?: pulumi.Input<inputs.migrate.v20191001preview.MoveCollectionProperties>;
    /**
     * The Resource Group Name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
