// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a Sql pool transparent data encryption configuration.
 * Latest API Version: 2020-12-01.
 */
export class SqlPoolTransparentDataEncryption extends pulumi.CustomResource {
    /**
     * Get an existing SqlPoolTransparentDataEncryption resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SqlPoolTransparentDataEncryption {
        return new SqlPoolTransparentDataEncryption(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:synapse/latest:SqlPoolTransparentDataEncryption';

    /**
     * Returns true if the given object is an instance of SqlPoolTransparentDataEncryption.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SqlPoolTransparentDataEncryption {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SqlPoolTransparentDataEncryption.__pulumiType;
    }

    /**
     * Resource location.
     */
    public /*out*/ readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The status of the database transparent data encryption.
     */
    public readonly status!: pulumi.Output<string | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a SqlPoolTransparentDataEncryption resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SqlPoolTransparentDataEncryptionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.sqlPoolName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sqlPoolName'");
            }
            if ((!args || args.transparentDataEncryptionName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'transparentDataEncryptionName'");
            }
            if ((!args || args.workspaceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'workspaceName'");
            }
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sqlPoolName"] = args ? args.sqlPoolName : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["transparentDataEncryptionName"] = args ? args.transparentDataEncryptionName : undefined;
            inputs["workspaceName"] = args ? args.workspaceName : undefined;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:synapse/v20190601preview:SqlPoolTransparentDataEncryption" }, { type: "azure-nextgen:synapse/v20201201:SqlPoolTransparentDataEncryption" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SqlPoolTransparentDataEncryption.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SqlPoolTransparentDataEncryption resource.
 */
export interface SqlPoolTransparentDataEncryptionArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * SQL pool name
     */
    readonly sqlPoolName: pulumi.Input<string>;
    /**
     * The status of the database transparent data encryption.
     */
    readonly status?: pulumi.Input<string | enums.synapse.latest.TransparentDataEncryptionStatus>;
    /**
     * The name of the transparent data encryption configuration.
     */
    readonly transparentDataEncryptionName: pulumi.Input<string>;
    /**
     * The name of the workspace
     */
    readonly workspaceName: pulumi.Input<string>;
}
