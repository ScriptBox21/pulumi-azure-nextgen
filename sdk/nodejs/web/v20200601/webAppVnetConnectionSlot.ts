// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Virtual Network information contract.
 */
export class WebAppVnetConnectionSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppVnetConnectionSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppVnetConnectionSlot {
        return new WebAppVnetConnectionSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20200601:WebAppVnetConnectionSlot';

    /**
     * Returns true if the given object is an instance of WebAppVnetConnectionSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppVnetConnectionSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppVnetConnectionSlot.__pulumiType;
    }

    /**
     * A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
     * Point-To-Site VPN connection.
     */
    public readonly certBlob!: pulumi.Output<string | undefined>;
    /**
     * The client certificate thumbprint.
     */
    public /*out*/ readonly certThumbprint!: pulumi.Output<string>;
    /**
     * DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses.
     */
    public readonly dnsServers!: pulumi.Output<string | undefined>;
    /**
     * Flag that is used to denote if this is VNET injection
     */
    public readonly isSwift!: pulumi.Output<boolean | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * <code>true</code> if a resync is required; otherwise, <code>false</code>.
     */
    public /*out*/ readonly resyncRequired!: pulumi.Output<boolean>;
    /**
     * The routes that this Virtual Network connection uses.
     */
    public /*out*/ readonly routes!: pulumi.Output<outputs.web.v20200601.VnetRouteResponse[]>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The Virtual Network's resource ID.
     */
    public readonly vnetResourceId!: pulumi.Output<string | undefined>;

    /**
     * Create a WebAppVnetConnectionSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppVnetConnectionSlotArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.slot === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'slot'");
            }
            if ((!args || args.vnetName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'vnetName'");
            }
            inputs["certBlob"] = args ? args.certBlob : undefined;
            inputs["dnsServers"] = args ? args.dnsServers : undefined;
            inputs["isSwift"] = args ? args.isSwift : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["slot"] = args ? args.slot : undefined;
            inputs["vnetName"] = args ? args.vnetName : undefined;
            inputs["vnetResourceId"] = args ? args.vnetResourceId : undefined;
            inputs["certThumbprint"] = undefined /*out*/;
            inputs["resyncRequired"] = undefined /*out*/;
            inputs["routes"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["certBlob"] = undefined /*out*/;
            inputs["certThumbprint"] = undefined /*out*/;
            inputs["dnsServers"] = undefined /*out*/;
            inputs["isSwift"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["resyncRequired"] = undefined /*out*/;
            inputs["routes"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["vnetResourceId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppVnetConnectionSlot" }, { type: "azure-nextgen:web/v20150801:WebAppVnetConnectionSlot" }, { type: "azure-nextgen:web/v20160801:WebAppVnetConnectionSlot" }, { type: "azure-nextgen:web/v20180201:WebAppVnetConnectionSlot" }, { type: "azure-nextgen:web/v20181101:WebAppVnetConnectionSlot" }, { type: "azure-nextgen:web/v20190801:WebAppVnetConnectionSlot" }, { type: "azure-nextgen:web/v20200901:WebAppVnetConnectionSlot" }, { type: "azure-nextgen:web/v20201001:WebAppVnetConnectionSlot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppVnetConnectionSlot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppVnetConnectionSlot resource.
 */
export interface WebAppVnetConnectionSlotArgs {
    /**
     * A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
     * Point-To-Site VPN connection.
     */
    readonly certBlob?: pulumi.Input<string>;
    /**
     * DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses.
     */
    readonly dnsServers?: pulumi.Input<string>;
    /**
     * Flag that is used to denote if this is VNET injection
     */
    readonly isSwift?: pulumi.Input<boolean>;
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
     * Name of the deployment slot. If a slot is not specified, the API will add or update connections for the production slot.
     */
    readonly slot: pulumi.Input<string>;
    /**
     * Name of an existing Virtual Network.
     */
    readonly vnetName: pulumi.Input<string>;
    /**
     * The Virtual Network's resource ID.
     */
    readonly vnetResourceId?: pulumi.Input<string>;
}
