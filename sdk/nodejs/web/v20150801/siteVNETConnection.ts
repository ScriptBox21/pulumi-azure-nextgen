// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * VNETInfo contract. This contract is public and is a stripped down version of VNETInfoInternal
 */
export class SiteVNETConnection extends pulumi.CustomResource {
    /**
     * Get an existing SiteVNETConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SiteVNETConnection {
        return new SiteVNETConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20150801:SiteVNETConnection';

    /**
     * Returns true if the given object is an instance of SiteVNETConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SiteVNETConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SiteVNETConnection.__pulumiType;
    }

    /**
     * A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
     *             Point-To-Site VPN connection.
     */
    public readonly certBlob!: pulumi.Output<string | undefined>;
    /**
     * The client certificate thumbprint
     */
    public readonly certThumbprint!: pulumi.Output<string | undefined>;
    /**
     * Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
     */
    public readonly dnsServers!: pulumi.Output<string | undefined>;
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
     * Flag to determine if a resync is required
     */
    public readonly resyncRequired!: pulumi.Output<boolean | undefined>;
    /**
     * The routes that this virtual network connection uses.
     */
    public readonly routes!: pulumi.Output<outputs.web.v20150801.VnetRouteResponse[] | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * The vnet resource id
     */
    public readonly vnetResourceId!: pulumi.Output<string | undefined>;

    /**
     * Create a SiteVNETConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SiteVNETConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.vnetName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'vnetName'");
            }
            inputs["certBlob"] = args ? args.certBlob : undefined;
            inputs["certThumbprint"] = args ? args.certThumbprint : undefined;
            inputs["dnsServers"] = args ? args.dnsServers : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["resyncRequired"] = args ? args.resyncRequired : undefined;
            inputs["routes"] = args ? args.routes : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["vnetName"] = args ? args.vnetName : undefined;
            inputs["vnetResourceId"] = args ? args.vnetResourceId : undefined;
        } else {
            inputs["certBlob"] = undefined /*out*/;
            inputs["certThumbprint"] = undefined /*out*/;
            inputs["dnsServers"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["resyncRequired"] = undefined /*out*/;
            inputs["routes"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["vnetResourceId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:SiteVNETConnection" }, { type: "azure-nextgen:web/v20160801:SiteVNETConnection" }, { type: "azure-nextgen:web/v20180201:SiteVNETConnection" }, { type: "azure-nextgen:web/v20181101:SiteVNETConnection" }, { type: "azure-nextgen:web/v20190801:SiteVNETConnection" }, { type: "azure-nextgen:web/v20200601:SiteVNETConnection" }, { type: "azure-nextgen:web/v20200901:SiteVNETConnection" }, { type: "azure-nextgen:web/v20201001:SiteVNETConnection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SiteVNETConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SiteVNETConnection resource.
 */
export interface SiteVNETConnectionArgs {
    /**
     * A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
     *             Point-To-Site VPN connection.
     */
    readonly certBlob?: pulumi.Input<string>;
    /**
     * The client certificate thumbprint
     */
    readonly certThumbprint?: pulumi.Input<string>;
    /**
     * Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
     */
    readonly dnsServers?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Kind of resource
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Input<string>;
    /**
     * The resource group name
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Flag to determine if a resync is required
     */
    readonly resyncRequired?: pulumi.Input<boolean>;
    /**
     * The routes that this virtual network connection uses.
     */
    readonly routes?: pulumi.Input<pulumi.Input<inputs.web.v20150801.VnetRoute>[]>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource type
     */
    readonly type?: pulumi.Input<string>;
    /**
     * The name of the Virtual Network
     */
    readonly vnetName: pulumi.Input<string>;
    /**
     * The vnet resource id
     */
    readonly vnetResourceId?: pulumi.Input<string>;
}
