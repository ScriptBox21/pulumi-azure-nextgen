// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Response for Disk pool request.
 */
export class DiskPool extends pulumi.CustomResource {
    /**
     * Get an existing DiskPool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DiskPool {
        return new DiskPool(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:storagepool/v20200315preview:DiskPool';

    /**
     * Returns true if the given object is an instance of DiskPool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DiskPool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DiskPool.__pulumiType;
    }

    /**
     * List of additional capabilities for Disk pool.
     */
    public readonly additionalCapabilities!: pulumi.Output<string[] | undefined>;
    /**
     * Logical zone for Disk pool resource; example: ["1"].
     */
    public readonly availabilityZones!: pulumi.Output<string[]>;
    /**
     * List of Azure Managed Disks to attach to a Disk pool. Can attach 8 disks at most.
     */
    public readonly disks!: pulumi.Output<outputs.storagepool.v20200315preview.DiskResponse[] | undefined>;
    /**
     * The geo-location where the resource lives.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * State of the operation on the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Operational status of the Disk pool.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Azure Resource ID of a Subnet for the Disk pool.
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * Resource metadata required by ARM RPC
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.storagepool.v20200315preview.SystemMetadataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Determines the SKU of VM deployed for Disk pool
     */
    public readonly tier!: pulumi.Output<string>;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a DiskPool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiskPoolArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.availabilityZones === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'availabilityZones'");
            }
            if ((!args || args.diskPoolName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'diskPoolName'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.subnetId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'subnetId'");
            }
            if ((!args || args.tier === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'tier'");
            }
            inputs["additionalCapabilities"] = args ? args.additionalCapabilities : undefined;
            inputs["availabilityZones"] = args ? args.availabilityZones : undefined;
            inputs["diskPoolName"] = args ? args.diskPoolName : undefined;
            inputs["disks"] = args ? args.disks : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["tier"] = args ? args.tier : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["additionalCapabilities"] = undefined /*out*/;
            inputs["availabilityZones"] = undefined /*out*/;
            inputs["disks"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["subnetId"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["tier"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(DiskPool.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DiskPool resource.
 */
export interface DiskPoolArgs {
    /**
     * List of additional capabilities for a Disk pool.
     */
    readonly additionalCapabilities?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Logical zone for Disk pool resource; example: ["1"].
     */
    readonly availabilityZones: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the Disk pool.
     */
    readonly diskPoolName: pulumi.Input<string>;
    /**
     * List of Azure Managed Disks to attach to a Disk pool. Can attach 8 disks at most.
     */
    readonly disks?: pulumi.Input<pulumi.Input<inputs.storagepool.v20200315preview.Disk>[]>;
    /**
     * The geo-location where the resource lives.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Azure Resource ID of a Subnet for the Disk pool.
     */
    readonly subnetId: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Determines the SKU of VM deployed for Disk pool
     */
    readonly tier: pulumi.Input<string | enums.storagepool.v20200315preview.DiskPoolTier>;
}
