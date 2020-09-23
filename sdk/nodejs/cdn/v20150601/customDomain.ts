// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * CDN CustomDomain represents a mapping between a user specified domain name and a CDN endpoint. This is to use custom domain names to represent the URLs for branding purposes.
 */
export class CustomDomain extends pulumi.CustomResource {
    /**
     * Get an existing CustomDomain resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CustomDomain {
        return new CustomDomain(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:cdn/v20150601:CustomDomain';

    /**
     * Returns true if the given object is an instance of CustomDomain.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CustomDomain {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CustomDomain.__pulumiType;
    }

    /**
     * The host name of the custom domain. Must be a domain name.
     */
    public readonly hostName!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Provisioning status of the custom domain.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource status of the custom domain.
     */
    public /*out*/ readonly resourceState!: pulumi.Output<string>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a CustomDomain resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CustomDomainArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.customDomainName === undefined) {
                throw new Error("Missing required property 'customDomainName'");
            }
            if (!args || args.endpointName === undefined) {
                throw new Error("Missing required property 'endpointName'");
            }
            if (!args || args.hostName === undefined) {
                throw new Error("Missing required property 'hostName'");
            }
            if (!args || args.profileName === undefined) {
                throw new Error("Missing required property 'profileName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["customDomainName"] = args ? args.customDomainName : undefined;
            inputs["endpointName"] = args ? args.endpointName : undefined;
            inputs["hostName"] = args ? args.hostName : undefined;
            inputs["profileName"] = args ? args.profileName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["hostName"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:cdn/latest:CustomDomain" }, { type: "azure-nextgen:cdn/v20160402:CustomDomain" }, { type: "azure-nextgen:cdn/v20161002:CustomDomain" }, { type: "azure-nextgen:cdn/v20170402:CustomDomain" }, { type: "azure-nextgen:cdn/v20171012:CustomDomain" }, { type: "azure-nextgen:cdn/v20190415:CustomDomain" }, { type: "azure-nextgen:cdn/v20190615:CustomDomain" }, { type: "azure-nextgen:cdn/v20190615preview:CustomDomain" }, { type: "azure-nextgen:cdn/v20191231:CustomDomain" }, { type: "azure-nextgen:cdn/v20200331:CustomDomain" }, { type: "azure-nextgen:cdn/v20200415:CustomDomain" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(CustomDomain.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CustomDomain resource.
 */
export interface CustomDomainArgs {
    /**
     * Name of the custom domain within an endpoint.
     */
    readonly customDomainName: pulumi.Input<string>;
    /**
     * Name of the endpoint within the CDN profile.
     */
    readonly endpointName: pulumi.Input<string>;
    /**
     * The host name of the custom domain. Must be a domain name.
     */
    readonly hostName: pulumi.Input<string>;
    /**
     * Name of the CDN profile within the resource group.
     */
    readonly profileName: pulumi.Input<string>;
    /**
     * Name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
