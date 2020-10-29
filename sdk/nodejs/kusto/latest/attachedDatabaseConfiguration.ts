// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Class representing an attached database configuration.
 */
export class AttachedDatabaseConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing AttachedDatabaseConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AttachedDatabaseConfiguration {
        return new AttachedDatabaseConfiguration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:kusto/latest:AttachedDatabaseConfiguration';

    /**
     * Returns true if the given object is an instance of AttachedDatabaseConfiguration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AttachedDatabaseConfiguration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AttachedDatabaseConfiguration.__pulumiType;
    }

    /**
     * The list of databases from the clusterResourceId which are currently attached to the cluster.
     */
    public /*out*/ readonly attachedDatabaseNames!: pulumi.Output<string[]>;
    /**
     * The resource id of the cluster where the databases you would like to attach reside.
     */
    public readonly clusterResourceId!: pulumi.Output<string>;
    /**
     * The name of the database which you would like to attach, use * if you want to follow all current and future databases.
     */
    public readonly databaseName!: pulumi.Output<string>;
    /**
     * The default principals modification kind
     */
    public readonly defaultPrincipalsModificationKind!: pulumi.Output<string>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioned state of the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a AttachedDatabaseConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AttachedDatabaseConfigurationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.attachedDatabaseConfigurationName === undefined) {
                throw new Error("Missing required property 'attachedDatabaseConfigurationName'");
            }
            if (!args || args.clusterName === undefined) {
                throw new Error("Missing required property 'clusterName'");
            }
            if (!args || args.clusterResourceId === undefined) {
                throw new Error("Missing required property 'clusterResourceId'");
            }
            if (!args || args.databaseName === undefined) {
                throw new Error("Missing required property 'databaseName'");
            }
            if (!args || args.defaultPrincipalsModificationKind === undefined) {
                throw new Error("Missing required property 'defaultPrincipalsModificationKind'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["attachedDatabaseConfigurationName"] = args ? args.attachedDatabaseConfigurationName : undefined;
            inputs["clusterName"] = args ? args.clusterName : undefined;
            inputs["clusterResourceId"] = args ? args.clusterResourceId : undefined;
            inputs["databaseName"] = args ? args.databaseName : undefined;
            inputs["defaultPrincipalsModificationKind"] = args ? args.defaultPrincipalsModificationKind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["attachedDatabaseNames"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["attachedDatabaseNames"] = undefined /*out*/;
            inputs["clusterResourceId"] = undefined /*out*/;
            inputs["databaseName"] = undefined /*out*/;
            inputs["defaultPrincipalsModificationKind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:kusto/v20190907:AttachedDatabaseConfiguration" }, { type: "azure-nextgen:kusto/v20191109:AttachedDatabaseConfiguration" }, { type: "azure-nextgen:kusto/v20200215:AttachedDatabaseConfiguration" }, { type: "azure-nextgen:kusto/v20200614:AttachedDatabaseConfiguration" }, { type: "azure-nextgen:kusto/v20200918:AttachedDatabaseConfiguration" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(AttachedDatabaseConfiguration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AttachedDatabaseConfiguration resource.
 */
export interface AttachedDatabaseConfigurationArgs {
    /**
     * The name of the attached database configuration.
     */
    readonly attachedDatabaseConfigurationName: pulumi.Input<string>;
    /**
     * The name of the Kusto cluster.
     */
    readonly clusterName: pulumi.Input<string>;
    /**
     * The resource id of the cluster where the databases you would like to attach reside.
     */
    readonly clusterResourceId: pulumi.Input<string>;
    /**
     * The name of the database which you would like to attach, use * if you want to follow all current and future databases.
     */
    readonly databaseName: pulumi.Input<string>;
    /**
     * The default principals modification kind
     */
    readonly defaultPrincipalsModificationKind: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the resource group containing the Kusto cluster.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
