// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Domain ownership Identifier.
 */
export class DomainOwnershipIdentifier extends pulumi.CustomResource {
    /**
     * Get an existing DomainOwnershipIdentifier resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DomainOwnershipIdentifier {
        return new DomainOwnershipIdentifier(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:domainregistration/v20200901:DomainOwnershipIdentifier';

    /**
     * Returns true if the given object is an instance of DomainOwnershipIdentifier.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DomainOwnershipIdentifier {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DomainOwnershipIdentifier.__pulumiType;
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
     * Ownership Id.
     */
    public readonly ownershipId!: pulumi.Output<string | undefined>;
    /**
     * The system metadata relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.domainregistration.v20200901.SystemDataResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a DomainOwnershipIdentifier resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DomainOwnershipIdentifierArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.domainName === undefined) {
                throw new Error("Missing required property 'domainName'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["domainName"] = args ? args.domainName : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["ownershipId"] = args ? args.ownershipId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["ownershipId"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:domainregistration/latest:DomainOwnershipIdentifier" }, { type: "azure-nextgen:domainregistration/v20150401:DomainOwnershipIdentifier" }, { type: "azure-nextgen:domainregistration/v20180201:DomainOwnershipIdentifier" }, { type: "azure-nextgen:domainregistration/v20190801:DomainOwnershipIdentifier" }, { type: "azure-nextgen:domainregistration/v20200601:DomainOwnershipIdentifier" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(DomainOwnershipIdentifier.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DomainOwnershipIdentifier resource.
 */
export interface DomainOwnershipIdentifierArgs {
    /**
     * Name of domain.
     */
    readonly domainName: pulumi.Input<string>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Name of identifier.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Ownership Id.
     */
    readonly ownershipId?: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
