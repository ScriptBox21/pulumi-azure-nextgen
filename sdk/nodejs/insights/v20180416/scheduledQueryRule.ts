// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The Log Search Rule resource.
 */
export class ScheduledQueryRule extends pulumi.CustomResource {
    /**
     * Get an existing ScheduledQueryRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ScheduledQueryRule {
        return new ScheduledQueryRule(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:insights/v20180416:ScheduledQueryRule';

    /**
     * Returns true if the given object is an instance of ScheduledQueryRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ScheduledQueryRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ScheduledQueryRule.__pulumiType;
    }

    /**
     * Action needs to be taken on rule execution.
     */
    public readonly action!: pulumi.Output<outputs.insights.v20180416.AlertingActionResponse | outputs.insights.v20180416.LogToMetricActionResponse>;
    /**
     * The api-version used when creating this alert rule
     */
    public /*out*/ readonly createdWithApiVersion!: pulumi.Output<string>;
    /**
     * The description of the Log Search rule.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The display name of the alert rule
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * The flag which indicates whether the Log Search rule is enabled. Value should be true or false
     */
    public readonly enabled!: pulumi.Output<string | undefined>;
    /**
     * The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. 
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * True if alert rule is legacy Log Analytic rule
     */
    public /*out*/ readonly isLegacyLogAnalyticsRule!: pulumi.Output<boolean>;
    /**
     * Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value.
     */
    public /*out*/ readonly kind!: pulumi.Output<string>;
    /**
     * Last time the rule was updated in IS08601 format.
     */
    public /*out*/ readonly lastUpdatedTime!: pulumi.Output<string>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Azure resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Provisioning state of the scheduled query rule
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Schedule (Frequency, Time Window) for rule. Required for action type - AlertingAction
     */
    public readonly schedule!: pulumi.Output<outputs.insights.v20180416.ScheduleResponse | undefined>;
    /**
     * Data Source against which rule will Query Data
     */
    public readonly source!: pulumi.Output<outputs.insights.v20180416.SourceResponse>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Azure resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ScheduledQueryRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ScheduledQueryRuleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.action === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'action'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.ruleName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'ruleName'");
            }
            if ((!args || args.source === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'source'");
            }
            inputs["action"] = args ? args.action : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["ruleName"] = args ? args.ruleName : undefined;
            inputs["schedule"] = args ? args.schedule : undefined;
            inputs["source"] = args ? args.source : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["createdWithApiVersion"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["isLegacyLogAnalyticsRule"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["lastUpdatedTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["action"] = undefined /*out*/;
            inputs["createdWithApiVersion"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["isLegacyLogAnalyticsRule"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["lastUpdatedTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["schedule"] = undefined /*out*/;
            inputs["source"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:insights/latest:ScheduledQueryRule" }, { type: "azure-nextgen:insights/v20200501preview:ScheduledQueryRule" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ScheduledQueryRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ScheduledQueryRule resource.
 */
export interface ScheduledQueryRuleArgs {
    /**
     * Action needs to be taken on rule execution.
     */
    readonly action: pulumi.Input<inputs.insights.v20180416.AlertingAction | inputs.insights.v20180416.LogToMetricAction>;
    /**
     * The description of the Log Search rule.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The display name of the alert rule
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The flag which indicates whether the Log Search rule is enabled. Value should be true or false
     */
    readonly enabled?: pulumi.Input<string | enums.insights.v20180416.Enabled>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the rule.
     */
    readonly ruleName: pulumi.Input<string>;
    /**
     * Schedule (Frequency, Time Window) for rule. Required for action type - AlertingAction
     */
    readonly schedule?: pulumi.Input<inputs.insights.v20180416.Schedule>;
    /**
     * Data Source against which rule will Query Data
     */
    readonly source: pulumi.Input<inputs.insights.v20180416.Source>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
