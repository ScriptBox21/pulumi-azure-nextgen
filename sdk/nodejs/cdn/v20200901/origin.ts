// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
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
    public static readonly __pulumiType = 'azure-nextgen:cdn/v20200901:Origin';

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
     * Origin is enabled for load balancing or not
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.
     */
    public readonly hostName!: pulumi.Output<string>;
    /**
     * The value of the HTTP port. Must be between 1 and 65535.
     */
    public readonly httpPort!: pulumi.Output<number | undefined>;
    /**
     * The value of the HTTPS port. Must be between 1 and 65535.
     */
    public readonly httpsPort!: pulumi.Output<number | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint
     */
    public readonly originHostHeader!: pulumi.Output<string | undefined>;
    /**
     * Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5
     */
    public readonly priority!: pulumi.Output<number | undefined>;
    /**
     * The approval status for the connection to the Private Link
     */
    public /*out*/ readonly privateEndpointStatus!: pulumi.Output<string>;
    /**
     * The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
     */
    public readonly privateLinkAlias!: pulumi.Output<string | undefined>;
    /**
     * A custom message to be included in the approval request to connect to the Private Link.
     */
    public readonly privateLinkApprovalMessage!: pulumi.Output<string | undefined>;
    /**
     * The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
     */
    public readonly privateLinkLocation!: pulumi.Output<string | undefined>;
    /**
     * The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
     */
    public readonly privateLinkResourceId!: pulumi.Output<string | undefined>;
    /**
     * Provisioning status of the origin.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource status of the origin.
     */
    public /*out*/ readonly resourceState!: pulumi.Output<string>;
    /**
     * Read only system data
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.cdn.v20200901.SystemDataResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
     */
    public readonly weight!: pulumi.Output<number | undefined>;

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
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["endpointName"] = args ? args.endpointName : undefined;
            inputs["hostName"] = args ? args.hostName : undefined;
            inputs["httpPort"] = args ? args.httpPort : undefined;
            inputs["httpsPort"] = args ? args.httpsPort : undefined;
            inputs["originHostHeader"] = args ? args.originHostHeader : undefined;
            inputs["originName"] = args ? args.originName : undefined;
            inputs["priority"] = args ? args.priority : undefined;
            inputs["privateLinkAlias"] = args ? args.privateLinkAlias : undefined;
            inputs["privateLinkApprovalMessage"] = args ? args.privateLinkApprovalMessage : undefined;
            inputs["privateLinkLocation"] = args ? args.privateLinkLocation : undefined;
            inputs["privateLinkResourceId"] = args ? args.privateLinkResourceId : undefined;
            inputs["profileName"] = args ? args.profileName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["weight"] = args ? args.weight : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["privateEndpointStatus"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["enabled"] = undefined /*out*/;
            inputs["hostName"] = undefined /*out*/;
            inputs["httpPort"] = undefined /*out*/;
            inputs["httpsPort"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["originHostHeader"] = undefined /*out*/;
            inputs["priority"] = undefined /*out*/;
            inputs["privateEndpointStatus"] = undefined /*out*/;
            inputs["privateLinkAlias"] = undefined /*out*/;
            inputs["privateLinkApprovalMessage"] = undefined /*out*/;
            inputs["privateLinkLocation"] = undefined /*out*/;
            inputs["privateLinkResourceId"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceState"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["weight"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:cdn/latest:Origin" }, { type: "azure-nextgen:cdn/v20150601:Origin" }, { type: "azure-nextgen:cdn/v20160402:Origin" }, { type: "azure-nextgen:cdn/v20191231:Origin" }, { type: "azure-nextgen:cdn/v20200331:Origin" }, { type: "azure-nextgen:cdn/v20200415:Origin" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Origin.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Origin resource.
 */
export interface OriginArgs {
    /**
     * Origin is enabled for load balancing or not
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * Name of the endpoint under the profile which is unique globally.
     */
    readonly endpointName: pulumi.Input<string>;
    /**
     * The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.
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
     * The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint
     */
    readonly originHostHeader?: pulumi.Input<string>;
    /**
     * Name of the origin that is unique within the endpoint.
     */
    readonly originName: pulumi.Input<string>;
    /**
     * Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5
     */
    readonly priority?: pulumi.Input<number>;
    /**
     * The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
     */
    readonly privateLinkAlias?: pulumi.Input<string>;
    /**
     * A custom message to be included in the approval request to connect to the Private Link.
     */
    readonly privateLinkApprovalMessage?: pulumi.Input<string>;
    /**
     * The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
     */
    readonly privateLinkLocation?: pulumi.Input<string>;
    /**
     * The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
     */
    readonly privateLinkResourceId?: pulumi.Input<string>;
    /**
     * Name of the CDN profile which is unique within the resource group.
     */
    readonly profileName: pulumi.Input<string>;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
     */
    readonly weight?: pulumi.Input<number>;
}
