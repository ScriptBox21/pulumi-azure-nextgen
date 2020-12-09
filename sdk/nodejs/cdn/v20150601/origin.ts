// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.
 */
export class Origin extends pulumi.CustomResource {
    /**
     * Get an existing Origin resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Origin {
        return new Origin(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:cdn/v20150601:Origin';

    /**
     * Returns true if the given object is an instance of Origin.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Origin {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Origin.__pulumiType;
    }

    /**
     * The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
     */
    public readonly hostName!: pulumi.Output<string>;
    /**
     * The value of the HTTP port. Must be between 1 and 65535.
     */
    public readonly httpPort!: pulumi.Output<number | undefined>;
    /**
     * The value of the https port. Must be between 1 and 65535.
     */
    public readonly httpsPort!: pulumi.Output<number | undefined>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Provisioning status of the origin.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource status of the origin.
     */
    public /*out*/ readonly resourceState!: pulumi.Output<string>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Origin resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OriginArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.endpointName === undefined) {
                throw new Error("Missing required property 'endpointName'");
            }
            if (!args || args.hostName === undefined) {
                throw new Error("Missing required property 'hostName'");
            }
            if (!args || args.originName === undefined) {
                throw new Error("Missing required property 'originName'");
            }
            if (!args || args.profileName === undefined) {
                throw new Error("Missing required property 'profileName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["endpointName"] = args ? args.endpointName : undefined;
            inputs["hostName"] = args ? args.hostName : undefined;
            inputs["httpPort"] = args ? args.httpPort : undefined;
            inputs["httpsPort"] = args ? args.httpsPort : undefined;
            inputs["originName"] = args ? args.originName : undefined;
            inputs["profileName"] = args ? args.profileName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["hostName"] = undefined /*out*/;
            inputs["httpPort"] = undefined /*out*/;
            inputs["httpsPort"] = undefined /*out*/;
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
        const aliasOpts = { aliases: [{ type: "azure-nextgen:cdn/latest:Origin" }, { type: "azure-nextgen:cdn/v20160402:Origin" }, { type: "azure-nextgen:cdn/v20191231:Origin" }, { type: "azure-nextgen:cdn/v20200331:Origin" }, { type: "azure-nextgen:cdn/v20200415:Origin" }, { type: "azure-nextgen:cdn/v20200901:Origin" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Origin.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Origin resource.
 */
export interface OriginArgs {
    /**
     * Name of the endpoint within the CDN profile.
     */
    readonly endpointName: pulumi.Input<string>;
    /**
     * The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.
     */
    readonly hostName: pulumi.Input<string>;
    /**
     * The value of the HTTP port. Must be between 1 and 65535.
     */
    readonly httpPort?: pulumi.Input<number>;
    /**
     * The value of the HTTPS port. Must be between 1 and 65535.
     */
    readonly httpsPort?: pulumi.Input<number>;
    /**
     * Name of the origin, an arbitrary value but it needs to be unique under endpoint
     */
    readonly originName: pulumi.Input<string>;
    /**
     * Name of the CDN profile within the resource group.
     */
    readonly profileName: pulumi.Input<string>;
    /**
     * Name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
