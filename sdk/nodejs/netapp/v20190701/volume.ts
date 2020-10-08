// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Volume resource
 */
export class Volume extends pulumi.CustomResource {
    /**
     * Get an existing Volume resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Volume {
        return new Volume(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:netapp/v20190701:Volume';

    /**
     * Returns true if the given object is an instance of Volume.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Volume {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Volume.__pulumiType;
    }

    /**
     * Unique Baremetal Tenant Identifier.
     */
    public /*out*/ readonly baremetalTenantId!: pulumi.Output<string>;
    /**
     * A unique file path for the volume. Used when creating mount targets
     */
    public readonly creationToken!: pulumi.Output<string>;
    /**
     * Set of export policy rules
     */
    public readonly exportPolicy!: pulumi.Output<outputs.netapp.v20190701.VolumePropertiesResponseExportPolicy | undefined>;
    /**
     * Unique FileSystem Identifier.
     */
    public /*out*/ readonly fileSystemId!: pulumi.Output<string>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * List of mount targets
     */
    public readonly mountTargets!: pulumi.Output<outputs.netapp.v20190701.MountTargetPropertiesResponse[] | undefined>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Set of protocol types
     */
    public readonly protocolTypes!: pulumi.Output<string[] | undefined>;
    /**
     * Azure lifecycle management
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The service level of the file system
     */
    public readonly serviceLevel!: pulumi.Output<string | undefined>;
    /**
     * UUID v4 or resource identifier used to identify the Snapshot.
     */
    public readonly snapshotId!: pulumi.Output<string | undefined>;
    /**
     * The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<any | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
     */
    public readonly usageThreshold!: pulumi.Output<number>;

    /**
     * Create a Volume resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VolumeArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.creationToken === undefined) {
                throw new Error("Missing required property 'creationToken'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.poolName === undefined) {
                throw new Error("Missing required property 'poolName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.subnetId === undefined) {
                throw new Error("Missing required property 'subnetId'");
            }
            if (!args || args.usageThreshold === undefined) {
                throw new Error("Missing required property 'usageThreshold'");
            }
            if (!args || args.volumeName === undefined) {
                throw new Error("Missing required property 'volumeName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["creationToken"] = args ? args.creationToken : undefined;
            inputs["exportPolicy"] = args ? args.exportPolicy : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["mountTargets"] = args ? args.mountTargets : undefined;
            inputs["poolName"] = args ? args.poolName : undefined;
            inputs["protocolTypes"] = args ? args.protocolTypes : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceLevel"] = args ? args.serviceLevel : undefined;
            inputs["snapshotId"] = args ? args.snapshotId : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["usageThreshold"] = args ? args.usageThreshold : undefined;
            inputs["volumeName"] = args ? args.volumeName : undefined;
            inputs["baremetalTenantId"] = undefined /*out*/;
            inputs["fileSystemId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["baremetalTenantId"] = undefined /*out*/;
            inputs["creationToken"] = undefined /*out*/;
            inputs["exportPolicy"] = undefined /*out*/;
            inputs["fileSystemId"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["mountTargets"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["protocolTypes"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["serviceLevel"] = undefined /*out*/;
            inputs["snapshotId"] = undefined /*out*/;
            inputs["subnetId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["usageThreshold"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:netapp/latest:Volume" }, { type: "azure-nextgen:netapp/v20170815:Volume" }, { type: "azure-nextgen:netapp/v20190501:Volume" }, { type: "azure-nextgen:netapp/v20190601:Volume" }, { type: "azure-nextgen:netapp/v20190801:Volume" }, { type: "azure-nextgen:netapp/v20191001:Volume" }, { type: "azure-nextgen:netapp/v20191101:Volume" }, { type: "azure-nextgen:netapp/v20200201:Volume" }, { type: "azure-nextgen:netapp/v20200301:Volume" }, { type: "azure-nextgen:netapp/v20200601:Volume" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Volume.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Volume resource.
 */
export interface VolumeArgs {
    /**
     * The name of the NetApp account
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * A unique file path for the volume. Used when creating mount targets
     */
    readonly creationToken: pulumi.Input<string>;
    /**
     * Set of export policy rules
     */
    readonly exportPolicy?: pulumi.Input<inputs.netapp.v20190701.VolumePropertiesExportPolicy>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * List of mount targets
     */
    readonly mountTargets?: pulumi.Input<pulumi.Input<inputs.netapp.v20190701.MountTargetProperties>[]>;
    /**
     * The name of the capacity pool
     */
    readonly poolName: pulumi.Input<string>;
    /**
     * Set of protocol types
     */
    readonly protocolTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The service level of the file system
     */
    readonly serviceLevel?: pulumi.Input<string>;
    /**
     * UUID v4 or resource identifier used to identify the Snapshot.
     */
    readonly snapshotId?: pulumi.Input<string>;
    /**
     * The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
     */
    readonly subnetId: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: any;
    /**
     * Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
     */
    readonly usageThreshold: pulumi.Input<number>;
    /**
     * The name of the volume
     */
    readonly volumeName: pulumi.Input<string>;
}
