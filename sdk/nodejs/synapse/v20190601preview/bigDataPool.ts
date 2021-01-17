// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A Big Data pool
 */
export class BigDataPool extends pulumi.CustomResource {
    /**
     * Get an existing BigDataPool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): BigDataPool {
        return new BigDataPool(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:synapse/v20190601preview:BigDataPool';

    /**
     * Returns true if the given object is an instance of BigDataPool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BigDataPool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BigDataPool.__pulumiType;
    }

    /**
     * Auto-pausing properties
     */
    public readonly autoPause!: pulumi.Output<outputs.synapse.v20190601preview.AutoPausePropertiesResponse | undefined>;
    /**
     * Auto-scaling properties
     */
    public readonly autoScale!: pulumi.Output<outputs.synapse.v20190601preview.AutoScalePropertiesResponse | undefined>;
    /**
     * The cache size
     */
    public readonly cacheSize!: pulumi.Output<number | undefined>;
    /**
     * The time when the Big Data pool was created.
     */
    public readonly creationDate!: pulumi.Output<string | undefined>;
    /**
     * The default folder where Spark logs will be written.
     */
    public readonly defaultSparkLogFolder!: pulumi.Output<string | undefined>;
    /**
     * Dynamic Executor Allocation
     */
    public readonly dynamicExecutorAllocation!: pulumi.Output<outputs.synapse.v20190601preview.DynamicExecutorAllocationResponse | undefined>;
    /**
     * Whether compute isolation is required or not.
     */
    public readonly isComputeIsolationEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Library version requirements
     */
    public readonly libraryRequirements!: pulumi.Output<outputs.synapse.v20190601preview.LibraryRequirementsResponse | undefined>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The number of nodes in the Big Data pool.
     */
    public readonly nodeCount!: pulumi.Output<number | undefined>;
    /**
     * The level of compute power that each node in the Big Data pool has.
     */
    public readonly nodeSize!: pulumi.Output<string | undefined>;
    /**
     * The kind of nodes that the Big Data pool provides.
     */
    public readonly nodeSizeFamily!: pulumi.Output<string | undefined>;
    /**
     * The state of the Big Data pool.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Whether session level packages enabled.
     */
    public readonly sessionLevelPackagesEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Spark configuration file to specify additional properties
     */
    public readonly sparkConfigProperties!: pulumi.Output<outputs.synapse.v20190601preview.LibraryRequirementsResponse | undefined>;
    /**
     * The Spark events folder
     */
    public readonly sparkEventsFolder!: pulumi.Output<string | undefined>;
    /**
     * The Apache Spark version.
     */
    public readonly sparkVersion!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a BigDataPool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BigDataPoolArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.bigDataPoolName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'bigDataPoolName'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.workspaceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'workspaceName'");
            }
            inputs["autoPause"] = args ? args.autoPause : undefined;
            inputs["autoScale"] = args ? args.autoScale : undefined;
            inputs["bigDataPoolName"] = args ? args.bigDataPoolName : undefined;
            inputs["cacheSize"] = args ? args.cacheSize : undefined;
            inputs["creationDate"] = args ? args.creationDate : undefined;
            inputs["defaultSparkLogFolder"] = args ? args.defaultSparkLogFolder : undefined;
            inputs["dynamicExecutorAllocation"] = args ? args.dynamicExecutorAllocation : undefined;
            inputs["force"] = args ? args.force : undefined;
            inputs["isComputeIsolationEnabled"] = args ? args.isComputeIsolationEnabled : undefined;
            inputs["libraryRequirements"] = args ? args.libraryRequirements : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["nodeCount"] = args ? args.nodeCount : undefined;
            inputs["nodeSize"] = args ? args.nodeSize : undefined;
            inputs["nodeSizeFamily"] = args ? args.nodeSizeFamily : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sessionLevelPackagesEnabled"] = args ? args.sessionLevelPackagesEnabled : undefined;
            inputs["sparkConfigProperties"] = args ? args.sparkConfigProperties : undefined;
            inputs["sparkEventsFolder"] = args ? args.sparkEventsFolder : undefined;
            inputs["sparkVersion"] = args ? args.sparkVersion : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["workspaceName"] = args ? args.workspaceName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["autoPause"] = undefined /*out*/;
            inputs["autoScale"] = undefined /*out*/;
            inputs["cacheSize"] = undefined /*out*/;
            inputs["creationDate"] = undefined /*out*/;
            inputs["defaultSparkLogFolder"] = undefined /*out*/;
            inputs["dynamicExecutorAllocation"] = undefined /*out*/;
            inputs["isComputeIsolationEnabled"] = undefined /*out*/;
            inputs["libraryRequirements"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nodeCount"] = undefined /*out*/;
            inputs["nodeSize"] = undefined /*out*/;
            inputs["nodeSizeFamily"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["sessionLevelPackagesEnabled"] = undefined /*out*/;
            inputs["sparkConfigProperties"] = undefined /*out*/;
            inputs["sparkEventsFolder"] = undefined /*out*/;
            inputs["sparkVersion"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(BigDataPool.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a BigDataPool resource.
 */
export interface BigDataPoolArgs {
    /**
     * Auto-pausing properties
     */
    readonly autoPause?: pulumi.Input<inputs.synapse.v20190601preview.AutoPauseProperties>;
    /**
     * Auto-scaling properties
     */
    readonly autoScale?: pulumi.Input<inputs.synapse.v20190601preview.AutoScaleProperties>;
    /**
     * Big Data pool name
     */
    readonly bigDataPoolName: pulumi.Input<string>;
    /**
     * The cache size
     */
    readonly cacheSize?: pulumi.Input<number>;
    /**
     * The time when the Big Data pool was created.
     */
    readonly creationDate?: pulumi.Input<string>;
    /**
     * The default folder where Spark logs will be written.
     */
    readonly defaultSparkLogFolder?: pulumi.Input<string>;
    /**
     * Dynamic Executor Allocation
     */
    readonly dynamicExecutorAllocation?: pulumi.Input<inputs.synapse.v20190601preview.DynamicExecutorAllocation>;
    /**
     * Whether to stop any running jobs in the Big Data pool
     */
    readonly force?: pulumi.Input<boolean>;
    /**
     * Whether compute isolation is required or not.
     */
    readonly isComputeIsolationEnabled?: pulumi.Input<boolean>;
    /**
     * Library version requirements
     */
    readonly libraryRequirements?: pulumi.Input<inputs.synapse.v20190601preview.LibraryRequirements>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * The number of nodes in the Big Data pool.
     */
    readonly nodeCount?: pulumi.Input<number>;
    /**
     * The level of compute power that each node in the Big Data pool has.
     */
    readonly nodeSize?: pulumi.Input<string | enums.synapse.v20190601preview.NodeSize>;
    /**
     * The kind of nodes that the Big Data pool provides.
     */
    readonly nodeSizeFamily?: pulumi.Input<string | enums.synapse.v20190601preview.NodeSizeFamily>;
    /**
     * The state of the Big Data pool.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Whether session level packages enabled.
     */
    readonly sessionLevelPackagesEnabled?: pulumi.Input<boolean>;
    /**
     * Spark configuration file to specify additional properties
     */
    readonly sparkConfigProperties?: pulumi.Input<inputs.synapse.v20190601preview.LibraryRequirements>;
    /**
     * The Spark events folder
     */
    readonly sparkEventsFolder?: pulumi.Input<string>;
    /**
     * The Apache Spark version.
     */
    readonly sparkVersion?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the workspace
     */
    readonly workspaceName: pulumi.Input<string>;
}
