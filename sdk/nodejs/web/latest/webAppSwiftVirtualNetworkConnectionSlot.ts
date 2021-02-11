// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Swift Virtual Network Contract. This is used to enable the new Swift way of doing virtual network integration.
 * Latest API Version: 2020-09-01.
 */
export class WebAppSwiftVirtualNetworkConnectionSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppSwiftVirtualNetworkConnectionSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppSwiftVirtualNetworkConnectionSlot {
        return new WebAppSwiftVirtualNetworkConnectionSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/latest:WebAppSwiftVirtualNetworkConnectionSlot';

    /**
     * Returns true if the given object is an instance of WebAppSwiftVirtualNetworkConnectionSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppSwiftVirtualNetworkConnectionSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppSwiftVirtualNetworkConnectionSlot.__pulumiType;
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
     * The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
     */
    public readonly subnetResourceId!: pulumi.Output<string | undefined>;
    /**
     * A flag that specifies if the scale unit this Web App is on supports Swift integration.
     */
    public readonly swiftSupported!: pulumi.Output<boolean | undefined>;
    /**
     * The system metadata relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.web.latest.SystemDataResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a WebAppSwiftVirtualNetworkConnectionSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppSwiftVirtualNetworkConnectionSlotArgs, opts?: pulumi.CustomResourceOptions) {
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
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["slot"] = args ? args.slot : undefined;
            inputs["subnetResourceId"] = args ? args.subnetResourceId : undefined;
            inputs["swiftSupported"] = args ? args.swiftSupported : undefined;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["subnetResourceId"] = undefined /*out*/;
            inputs["swiftSupported"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/v20180201:WebAppSwiftVirtualNetworkConnectionSlot" }, { type: "azure-nextgen:web/v20181101:WebAppSwiftVirtualNetworkConnectionSlot" }, { type: "azure-nextgen:web/v20190801:WebAppSwiftVirtualNetworkConnectionSlot" }, { type: "azure-nextgen:web/v20200601:WebAppSwiftVirtualNetworkConnectionSlot" }, { type: "azure-nextgen:web/v20200901:WebAppSwiftVirtualNetworkConnectionSlot" }, { type: "azure-nextgen:web/v20201001:WebAppSwiftVirtualNetworkConnectionSlot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppSwiftVirtualNetworkConnectionSlot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppSwiftVirtualNetworkConnectionSlot resource.
 */
export interface WebAppSwiftVirtualNetworkConnectionSlotArgs {
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
     * The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
     */
    readonly subnetResourceId?: pulumi.Input<string>;
    /**
     * A flag that specifies if the scale unit this Web App is on supports Swift integration.
     */
    readonly swiftSupported?: pulumi.Input<boolean>;
}
