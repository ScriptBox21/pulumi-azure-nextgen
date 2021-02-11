// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Virtual Network route contract used to pass routing information for a Virtual Network.
 */
export class AppServicePlanRouteForVnet extends pulumi.CustomResource {
    /**
     * Get an existing AppServicePlanRouteForVnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AppServicePlanRouteForVnet {
        return new AppServicePlanRouteForVnet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20200601:AppServicePlanRouteForVnet';

    /**
     * Returns true if the given object is an instance of AppServicePlanRouteForVnet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AppServicePlanRouteForVnet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AppServicePlanRouteForVnet.__pulumiType;
    }

    /**
     * The ending address for this route. If the start address is specified in CIDR notation, this must be omitted.
     */
    public readonly endAddress!: pulumi.Output<string | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The type of route this is:
     * DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918
     * INHERITED - Routes inherited from the real Virtual Network routes
     * STATIC - Static route set on the app only
     *
     * These values will be used for syncing an app's routes with those from a Virtual Network.
     */
    public readonly routeType!: pulumi.Output<string | undefined>;
    /**
     * The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified.
     */
    public readonly startAddress!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a AppServicePlanRouteForVnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AppServicePlanRouteForVnetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.routeName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'routeName'");
            }
            if ((!args || args.vnetName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'vnetName'");
            }
            inputs["endAddress"] = args ? args.endAddress : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routeName"] = args ? args.routeName : undefined;
            inputs["routeType"] = args ? args.routeType : undefined;
            inputs["startAddress"] = args ? args.startAddress : undefined;
            inputs["vnetName"] = args ? args.vnetName : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["endAddress"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["routeType"] = undefined /*out*/;
            inputs["startAddress"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:AppServicePlanRouteForVnet" }, { type: "azure-nextgen:web/v20150801:AppServicePlanRouteForVnet" }, { type: "azure-nextgen:web/v20160901:AppServicePlanRouteForVnet" }, { type: "azure-nextgen:web/v20180201:AppServicePlanRouteForVnet" }, { type: "azure-nextgen:web/v20190801:AppServicePlanRouteForVnet" }, { type: "azure-nextgen:web/v20200901:AppServicePlanRouteForVnet" }, { type: "azure-nextgen:web/v20201001:AppServicePlanRouteForVnet" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(AppServicePlanRouteForVnet.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AppServicePlanRouteForVnet resource.
 */
export interface AppServicePlanRouteForVnetArgs {
    /**
     * The ending address for this route. If the start address is specified in CIDR notation, this must be omitted.
     */
    readonly endAddress?: pulumi.Input<string>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Name of the App Service plan.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the Virtual Network route.
     */
    readonly routeName: pulumi.Input<string>;
    /**
     * The type of route this is:
     * DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918
     * INHERITED - Routes inherited from the real Virtual Network routes
     * STATIC - Static route set on the app only
     *
     * These values will be used for syncing an app's routes with those from a Virtual Network.
     */
    readonly routeType?: pulumi.Input<string | enums.web.v20200601.RouteType>;
    /**
     * The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified.
     */
    readonly startAddress?: pulumi.Input<string>;
    /**
     * Name of the Virtual Network.
     */
    readonly vnetName: pulumi.Input<string>;
}
