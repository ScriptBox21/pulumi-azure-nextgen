// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * The replication policy between two storage accounts. Multiple rules can be defined in one policy.
 */
export class ObjectReplicationPolicy extends pulumi.CustomResource {
    /**
     * Get an existing ObjectReplicationPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ObjectReplicationPolicy {
        return new ObjectReplicationPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:storage/latest:ObjectReplicationPolicy';

    /**
     * Returns true if the given object is an instance of ObjectReplicationPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ObjectReplicationPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ObjectReplicationPolicy.__pulumiType;
    }

    /**
     * Required. Destination account name.
     */
    public readonly destinationAccount!: pulumi.Output<string>;
    /**
     * Indicates when the policy is enabled on the source account.
     */
    public /*out*/ readonly enabledTime!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * A unique id for object replication policy.
     */
    public /*out*/ readonly policyId!: pulumi.Output<string>;
    /**
     * The storage account object replication rules.
     */
    public readonly rules!: pulumi.Output<outputs.storage.latest.ObjectReplicationPolicyRuleResponse[] | undefined>;
    /**
     * Required. Source account name.
     */
    public readonly sourceAccount!: pulumi.Output<string>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ObjectReplicationPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ObjectReplicationPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.destinationAccount === undefined) {
                throw new Error("Missing required property 'destinationAccount'");
            }
            if (!args || args.objectReplicationPolicyId === undefined) {
                throw new Error("Missing required property 'objectReplicationPolicyId'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sourceAccount === undefined) {
                throw new Error("Missing required property 'sourceAccount'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["destinationAccount"] = args ? args.destinationAccount : undefined;
            inputs["objectReplicationPolicyId"] = args ? args.objectReplicationPolicyId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["rules"] = args ? args.rules : undefined;
            inputs["sourceAccount"] = args ? args.sourceAccount : undefined;
            inputs["enabledTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["policyId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["destinationAccount"] = undefined /*out*/;
            inputs["enabledTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["policyId"] = undefined /*out*/;
            inputs["rules"] = undefined /*out*/;
            inputs["sourceAccount"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:storage/v20190601:ObjectReplicationPolicy" }, { type: "azure-nextgen:storage/v20200801preview:ObjectReplicationPolicy" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ObjectReplicationPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ObjectReplicationPolicy resource.
 */
export interface ObjectReplicationPolicyArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * Required. Destination account name.
     */
    readonly destinationAccount: pulumi.Input<string>;
    /**
     * The ID of object replication policy or 'default' if the policy ID is unknown.
     */
    readonly objectReplicationPolicyId: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The storage account object replication rules.
     */
    readonly rules?: pulumi.Input<pulumi.Input<inputs.storage.latest.ObjectReplicationPolicyRule>[]>;
    /**
     * Required. Source account name.
     */
    readonly sourceAccount: pulumi.Input<string>;
}
