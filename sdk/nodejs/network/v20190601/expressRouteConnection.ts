// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * ExpressRouteConnection resource.
 */
export class ExpressRouteConnection extends pulumi.CustomResource {
    /**
     * Get an existing ExpressRouteConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ExpressRouteConnection {
        return new ExpressRouteConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20190601:ExpressRouteConnection';

    /**
     * Returns true if the given object is an instance of ExpressRouteConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExpressRouteConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExpressRouteConnection.__pulumiType;
    }

    /**
     * Authorization key to establish the connection.
     */
    public readonly authorizationKey!: pulumi.Output<string | undefined>;
    /**
     * The ExpressRoute circuit peering.
     */
    public readonly expressRouteCircuitPeering!: pulumi.Output<outputs.network.v20190601.ExpressRouteCircuitPeeringIdResponse>;
    /**
     * The name of the resource.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The routing weight associated to the connection.
     */
    public readonly routingWeight!: pulumi.Output<number | undefined>;

    /**
     * Create a ExpressRouteConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExpressRouteConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.connectionName === undefined) {
                throw new Error("Missing required property 'connectionName'");
            }
            if (!args || args.expressRouteCircuitPeering === undefined) {
                throw new Error("Missing required property 'expressRouteCircuitPeering'");
            }
            if (!args || args.expressRouteGatewayName === undefined) {
                throw new Error("Missing required property 'expressRouteGatewayName'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["authorizationKey"] = args ? args.authorizationKey : undefined;
            inputs["connectionName"] = args ? args.connectionName : undefined;
            inputs["expressRouteCircuitPeering"] = args ? args.expressRouteCircuitPeering : undefined;
            inputs["expressRouteGatewayName"] = args ? args.expressRouteGatewayName : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routingWeight"] = args ? args.routingWeight : undefined;
            inputs["provisioningState"] = undefined /*out*/;
        } else {
            inputs["authorizationKey"] = undefined /*out*/;
            inputs["expressRouteCircuitPeering"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["routingWeight"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20180801:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20181001:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20181101:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20181201:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20190201:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20190401:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20190701:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20190801:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20190901:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20191101:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20191201:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20200301:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20200401:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20200501:ExpressRouteConnection" }, { type: "azure-nextgen:network/v20200601:ExpressRouteConnection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ExpressRouteConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ExpressRouteConnection resource.
 */
export interface ExpressRouteConnectionArgs {
    /**
     * Authorization key to establish the connection.
     */
    readonly authorizationKey?: pulumi.Input<string>;
    /**
     * The name of the connection subresource.
     */
    readonly connectionName: pulumi.Input<string>;
    /**
     * The ExpressRoute circuit peering.
     */
    readonly expressRouteCircuitPeering: pulumi.Input<inputs.network.v20190601.ExpressRouteCircuitPeeringId>;
    /**
     * The name of the ExpressRoute gateway.
     */
    readonly expressRouteGatewayName: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The name of the resource.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The routing weight associated to the connection.
     */
    readonly routingWeight?: pulumi.Input<number>;
}
