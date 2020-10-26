// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Organization resource.
 */
export class Organization extends pulumi.CustomResource {
    /**
     * Get an existing Organization resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Organization {
        return new Organization(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:confluent/v20200301preview:Organization';

    /**
     * Returns true if the given object is an instance of Organization.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Organization {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Organization.__pulumiType;
    }

    /**
     * The creation time of the resource.
     */
    public /*out*/ readonly createdTime!: pulumi.Output<string>;
    /**
     * Location of Organization resource
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Confluent offer detail
     */
    public readonly offerDetail!: pulumi.Output<outputs.confluent.v20200301preview.OrganizationResourcePropertiesResponseOfferDetail | undefined>;
    /**
     * Id of the Confluent organization.
     */
    public /*out*/ readonly organizationId!: pulumi.Output<string>;
    /**
     * Provision states for confluent RP
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * SSO url for the Confluent organization.
     */
    public /*out*/ readonly ssoUrl!: pulumi.Output<string>;
    /**
     * Organization resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Subscriber detail
     */
    public readonly userDetail!: pulumi.Output<outputs.confluent.v20200301preview.OrganizationResourcePropertiesResponseUserDetail | undefined>;

    /**
     * Create a Organization resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OrganizationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.organizationName === undefined) {
                throw new Error("Missing required property 'organizationName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["offerDetail"] = args ? args.offerDetail : undefined;
            inputs["organizationName"] = args ? args.organizationName : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["userDetail"] = args ? args.userDetail : undefined;
            inputs["createdTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["organizationId"] = undefined /*out*/;
            inputs["ssoUrl"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["createdTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["offerDetail"] = undefined /*out*/;
            inputs["organizationId"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["ssoUrl"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["userDetail"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Organization.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Organization resource.
 */
export interface OrganizationArgs {
    /**
     * Location of Organization resource
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Confluent offer detail
     */
    readonly offerDetail?: pulumi.Input<inputs.confluent.v20200301preview.OrganizationResourcePropertiesOfferDetail>;
    /**
     * Organization resource name
     */
    readonly organizationName: pulumi.Input<string>;
    /**
     * Provision states for confluent RP
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * Resource group name
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Organization resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Subscriber detail
     */
    readonly userDetail?: pulumi.Input<inputs.confluent.v20200301preview.OrganizationResourcePropertiesUserDetail>;
}