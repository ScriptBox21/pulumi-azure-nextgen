// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A domain specific resource identifier.
 */
export class WebAppDomainOwnershipIdentifierSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppDomainOwnershipIdentifierSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppDomainOwnershipIdentifierSlot {
        return new WebAppDomainOwnershipIdentifierSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20200601:WebAppDomainOwnershipIdentifierSlot';

    /**
     * Returns true if the given object is an instance of WebAppDomainOwnershipIdentifierSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppDomainOwnershipIdentifierSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppDomainOwnershipIdentifierSlot.__pulumiType;
    }

    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * String representation of the identity.
     */
    public readonly value!: pulumi.Output<string | undefined>;

    /**
     * Create a WebAppDomainOwnershipIdentifierSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppDomainOwnershipIdentifierSlotArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.domainOwnershipIdentifierName === undefined) {
                throw new Error("Missing required property 'domainOwnershipIdentifierName'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.slot === undefined) {
                throw new Error("Missing required property 'slot'");
            }
            inputs["domainOwnershipIdentifierName"] = args ? args.domainOwnershipIdentifierName : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["slot"] = args ? args.slot : undefined;
            inputs["value"] = args ? args.value : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["value"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppDomainOwnershipIdentifierSlot" }, { type: "azure-nextgen:web/v20160801:WebAppDomainOwnershipIdentifierSlot" }, { type: "azure-nextgen:web/v20180201:WebAppDomainOwnershipIdentifierSlot" }, { type: "azure-nextgen:web/v20181101:WebAppDomainOwnershipIdentifierSlot" }, { type: "azure-nextgen:web/v20190801:WebAppDomainOwnershipIdentifierSlot" }, { type: "azure-nextgen:web/v20200901:WebAppDomainOwnershipIdentifierSlot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppDomainOwnershipIdentifierSlot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppDomainOwnershipIdentifierSlot resource.
 */
export interface WebAppDomainOwnershipIdentifierSlotArgs {
    /**
     * Name of domain ownership identifier.
     */
    readonly domainOwnershipIdentifierName: pulumi.Input<string>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Name of the app.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the deployment slot. If a slot is not specified, the API will delete the binding for the production slot.
     */
    readonly slot: pulumi.Input<string>;
    /**
     * String representation of the identity.
     */
    readonly value?: pulumi.Input<string>;
}
