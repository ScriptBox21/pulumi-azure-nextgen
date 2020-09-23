// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * VirtualHub Resource.
 */
export class VirtualHub extends pulumi.CustomResource {
    /**
     * Get an existing VirtualHub resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualHub {
        return new VirtualHub(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20180701:VirtualHub';

    /**
     * Returns true if the given object is an instance of VirtualHub.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualHub {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualHub.__pulumiType;
    }

    /**
     * Address-prefix for this VirtualHub.
     */
    public readonly addressPrefix!: pulumi.Output<string | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * list of all vnet connections with this VirtualHub.
     */
    public readonly hubVirtualNetworkConnections!: pulumi.Output<outputs.network.v20180701.HubVirtualNetworkConnectionResponse[] | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The VirtualWAN to which the VirtualHub belongs
     */
    public readonly virtualWan!: pulumi.Output<outputs.network.v20180701.SubResourceResponse | undefined>;

    /**
     * Create a VirtualHub resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualHubArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.virtualHubName === undefined) {
                throw new Error("Missing required property 'virtualHubName'");
            }
            inputs["addressPrefix"] = args ? args.addressPrefix : undefined;
            inputs["hubVirtualNetworkConnections"] = args ? args.hubVirtualNetworkConnections : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["virtualHubName"] = args ? args.virtualHubName : undefined;
            inputs["virtualWan"] = args ? args.virtualWan : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["hubVirtualNetworkConnections"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualWan"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:VirtualHub" }, { type: "azure-nextgen:network/v20180401:VirtualHub" }, { type: "azure-nextgen:network/v20180601:VirtualHub" }, { type: "azure-nextgen:network/v20180801:VirtualHub" }, { type: "azure-nextgen:network/v20181001:VirtualHub" }, { type: "azure-nextgen:network/v20181101:VirtualHub" }, { type: "azure-nextgen:network/v20181201:VirtualHub" }, { type: "azure-nextgen:network/v20190201:VirtualHub" }, { type: "azure-nextgen:network/v20190401:VirtualHub" }, { type: "azure-nextgen:network/v20190601:VirtualHub" }, { type: "azure-nextgen:network/v20190701:VirtualHub" }, { type: "azure-nextgen:network/v20190801:VirtualHub" }, { type: "azure-nextgen:network/v20190901:VirtualHub" }, { type: "azure-nextgen:network/v20191101:VirtualHub" }, { type: "azure-nextgen:network/v20191201:VirtualHub" }, { type: "azure-nextgen:network/v20200301:VirtualHub" }, { type: "azure-nextgen:network/v20200401:VirtualHub" }, { type: "azure-nextgen:network/v20200501:VirtualHub" }, { type: "azure-nextgen:network/v20200601:VirtualHub" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualHub.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualHub resource.
 */
export interface VirtualHubArgs {
    /**
     * Address-prefix for this VirtualHub.
     */
    readonly addressPrefix?: pulumi.Input<string>;
    /**
     * list of all vnet connections with this VirtualHub.
     */
    readonly hubVirtualNetworkConnections?: pulumi.Input<pulumi.Input<inputs.network.v20180701.HubVirtualNetworkConnection>[]>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The resource group name of the VirtualHub.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the VirtualHub.
     */
    readonly virtualHubName: pulumi.Input<string>;
    /**
     * The VirtualWAN to which the VirtualHub belongs
     */
    readonly virtualWan?: pulumi.Input<inputs.network.v20180701.SubResource>;
}
