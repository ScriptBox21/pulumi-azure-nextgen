// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * A export resource.
 */
export class Export extends pulumi.CustomResource {
    /**
     * Get an existing Export resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Export {
        return new Export(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:costmanagement/v20191101:Export';

    /**
     * Returns true if the given object is an instance of Export.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Export {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Export.__pulumiType;
    }

    /**
     * Has definition for the export.
     */
    public readonly definition!: pulumi.Output<outputs.costmanagement.v20191101.ExportDefinitionResponse>;
    /**
     * Has delivery information for the export.
     */
    public readonly deliveryInfo!: pulumi.Output<outputs.costmanagement.v20191101.ExportDeliveryInfoResponse>;
    /**
     * eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
     */
    public readonly eTag!: pulumi.Output<string | undefined>;
    /**
     * The format of the export being delivered.
     */
    public readonly format!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Has schedule information for the export.
     */
    public readonly schedule!: pulumi.Output<outputs.costmanagement.v20191101.ExportScheduleResponse | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Export resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExportArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.definition === undefined) {
                throw new Error("Missing required property 'definition'");
            }
            if (!args || args.deliveryInfo === undefined) {
                throw new Error("Missing required property 'deliveryInfo'");
            }
            if (!args || args.exportName === undefined) {
                throw new Error("Missing required property 'exportName'");
            }
            if (!args || args.scope === undefined) {
                throw new Error("Missing required property 'scope'");
            }
            inputs["definition"] = args ? args.definition : undefined;
            inputs["deliveryInfo"] = args ? args.deliveryInfo : undefined;
            inputs["eTag"] = args ? args.eTag : undefined;
            inputs["exportName"] = args ? args.exportName : undefined;
            inputs["format"] = args ? args.format : undefined;
            inputs["schedule"] = args ? args.schedule : undefined;
            inputs["scope"] = args ? args.scope : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["definition"] = undefined /*out*/;
            inputs["deliveryInfo"] = undefined /*out*/;
            inputs["eTag"] = undefined /*out*/;
            inputs["format"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["schedule"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:costmanagement/latest:Export" }, { type: "azure-nextgen:costmanagement/v20190101:Export" }, { type: "azure-nextgen:costmanagement/v20190901:Export" }, { type: "azure-nextgen:costmanagement/v20191001:Export" }, { type: "azure-nextgen:costmanagement/v20200601:Export" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Export.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Export resource.
 */
export interface ExportArgs {
    /**
     * Has definition for the export.
     */
    readonly definition: pulumi.Input<inputs.costmanagement.v20191101.ExportDefinition>;
    /**
     * Has delivery information for the export.
     */
    readonly deliveryInfo: pulumi.Input<inputs.costmanagement.v20191101.ExportDeliveryInfo>;
    /**
     * eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
     */
    readonly eTag?: pulumi.Input<string>;
    /**
     * Export Name.
     */
    readonly exportName: pulumi.Input<string>;
    /**
     * The format of the export being delivered.
     */
    readonly format?: pulumi.Input<string>;
    /**
     * Has schedule information for the export.
     */
    readonly schedule?: pulumi.Input<inputs.costmanagement.v20191101.ExportSchedule>;
    /**
     * The scope associated with query and export operations. This includes '/subscriptions/{subscriptionId}/' for subscription scope, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, '/providers/Microsoft.Management/managementGroups/{managementGroupId} for Management Group scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for billingProfile scope, '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}' for invoiceSection scope, and '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}' specific for partners.
     */
    readonly scope: pulumi.Input<string>;
}
