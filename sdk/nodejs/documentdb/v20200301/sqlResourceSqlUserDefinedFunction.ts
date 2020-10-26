// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * An Azure Cosmos DB userDefinedFunction.
 */
export class SqlResourceSqlUserDefinedFunction extends pulumi.CustomResource {
    /**
     * Get an existing SqlResourceSqlUserDefinedFunction resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SqlResourceSqlUserDefinedFunction {
        return new SqlResourceSqlUserDefinedFunction(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:documentdb/v20200301:SqlResourceSqlUserDefinedFunction';

    /**
     * Returns true if the given object is an instance of SqlResourceSqlUserDefinedFunction.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SqlResourceSqlUserDefinedFunction {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SqlResourceSqlUserDefinedFunction.__pulumiType;
    }

    /**
     * The location of the resource group to which the resource belongs.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the ARM resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    public readonly resource!: pulumi.Output<outputs.documentdb.v20200301.SqlUserDefinedFunctionGetPropertiesResponseResource | undefined>;
    /**
     * Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of Azure resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a SqlResourceSqlUserDefinedFunction resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SqlResourceSqlUserDefinedFunctionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.containerName === undefined) {
                throw new Error("Missing required property 'containerName'");
            }
            if (!args || args.databaseName === undefined) {
                throw new Error("Missing required property 'databaseName'");
            }
            if (!args || args.options === undefined) {
                throw new Error("Missing required property 'options'");
            }
            if (!args || args.resource === undefined) {
                throw new Error("Missing required property 'resource'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.userDefinedFunctionName === undefined) {
                throw new Error("Missing required property 'userDefinedFunctionName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["containerName"] = args ? args.containerName : undefined;
            inputs["databaseName"] = args ? args.databaseName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["options"] = args ? args.options : undefined;
            inputs["resource"] = args ? args.resource : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["userDefinedFunctionName"] = args ? args.userDefinedFunctionName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["resource"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:documentdb/latest:SqlResourceSqlUserDefinedFunction" }, { type: "azure-nextgen:documentdb/v20190801:SqlResourceSqlUserDefinedFunction" }, { type: "azure-nextgen:documentdb/v20191212:SqlResourceSqlUserDefinedFunction" }, { type: "azure-nextgen:documentdb/v20200401:SqlResourceSqlUserDefinedFunction" }, { type: "azure-nextgen:documentdb/v20200601preview:SqlResourceSqlUserDefinedFunction" }, { type: "azure-nextgen:documentdb/v20200901:SqlResourceSqlUserDefinedFunction" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SqlResourceSqlUserDefinedFunction.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SqlResourceSqlUserDefinedFunction resource.
 */
export interface SqlResourceSqlUserDefinedFunctionArgs {
    /**
     * Cosmos DB database account name.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * Cosmos DB container name.
     */
    readonly containerName: pulumi.Input<string>;
    /**
     * Cosmos DB database name.
     */
    readonly databaseName: pulumi.Input<string>;
    /**
     * The location of the resource group to which the resource belongs.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request.
     */
    readonly options: pulumi.Input<inputs.documentdb.v20200301.CreateUpdateOptions>;
    /**
     * The standard JSON format of a userDefinedFunction
     */
    readonly resource: pulumi.Input<inputs.documentdb.v20200301.SqlUserDefinedFunctionResource>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Cosmos DB userDefinedFunction name.
     */
    readonly userDefinedFunctionName: pulumi.Input<string>;
}
