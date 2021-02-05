// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The scheduled query rule resource.
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
    public static readonly __pulumiType = 'azure-nextgen:insights/v20200501preview:ScheduledQueryRule';

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

    public readonly actions!: pulumi.Output<outputs.insights.v20200501preview.ActionResponse[] | undefined>;
    /**
     * The api-version used when creating this alert rule
     */
    public /*out*/ readonly createdWithApiVersion!: pulumi.Output<string>;
    /**
     * The rule criteria that defines the conditions of the scheduled query rule.
     */
    public readonly criteria!: pulumi.Output<outputs.insights.v20200501preview.ScheduledQueryRuleCriteriaResponse>;
    /**
     * The description of the scheduled query rule.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The display name of the alert rule
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * The flag which indicates whether this scheduled query rule is enabled. Value should be true or false
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. 
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * How often the scheduled query rule is evaluated represented in ISO 8601 duration format.
     */
    public readonly evaluationFrequency!: pulumi.Output<string>;
    /**
     * True if alert rule is legacy Log Analytic rule
     */
    public /*out*/ readonly isLegacyLogAnalyticsRule!: pulumi.Output<boolean>;
    /**
     * Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value.
     */
    public /*out*/ readonly kind!: pulumi.Output<string>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Mute actions for the chosen period of time (in ISO 8601 duration format) after the alert is fired.
     */
    public readonly muteActionsDuration!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * If specified then overrides the query time range (default is WindowSize*NumberOfEvaluationPeriods)
     */
    public readonly overrideQueryTimeRange!: pulumi.Output<string | undefined>;
    /**
     * The list of resource id's that this scheduled query rule is scoped to.
     */
    public readonly scopes!: pulumi.Output<string[]>;
    /**
     * Severity of the alert. Should be an integer between [0-4]. Value of 0 is severest
     */
    public readonly severity!: pulumi.Output<number>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria
     */
    public readonly targetResourceTypes!: pulumi.Output<string[] | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The period of time (in ISO 8601 duration format) on which the Alert query will be executed (bin size).
     */
    public readonly windowSize!: pulumi.Output<string>;

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
            if ((!args || args.criteria === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'criteria'");
            }
            if ((!args || args.enabled === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.evaluationFrequency === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'evaluationFrequency'");
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
            if ((!args || args.scopes === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'scopes'");
            }
            if ((!args || args.severity === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'severity'");
            }
            if ((!args || args.windowSize === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'windowSize'");
            }
            inputs["actions"] = args ? args.actions : undefined;
            inputs["criteria"] = args ? args.criteria : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["evaluationFrequency"] = args ? args.evaluationFrequency : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["muteActionsDuration"] = args ? args.muteActionsDuration : undefined;
            inputs["overrideQueryTimeRange"] = args ? args.overrideQueryTimeRange : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["ruleName"] = args ? args.ruleName : undefined;
            inputs["scopes"] = args ? args.scopes : undefined;
            inputs["severity"] = args ? args.severity : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetResourceTypes"] = args ? args.targetResourceTypes : undefined;
            inputs["windowSize"] = args ? args.windowSize : undefined;
            inputs["createdWithApiVersion"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["isLegacyLogAnalyticsRule"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["actions"] = undefined /*out*/;
            inputs["createdWithApiVersion"] = undefined /*out*/;
            inputs["criteria"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["evaluationFrequency"] = undefined /*out*/;
            inputs["isLegacyLogAnalyticsRule"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["muteActionsDuration"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["overrideQueryTimeRange"] = undefined /*out*/;
            inputs["scopes"] = undefined /*out*/;
            inputs["severity"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["targetResourceTypes"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["windowSize"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:insights/latest:ScheduledQueryRule" }, { type: "azure-nextgen:insights/v20180416:ScheduledQueryRule" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ScheduledQueryRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ScheduledQueryRule resource.
 */
export interface ScheduledQueryRuleArgs {
    readonly actions?: pulumi.Input<pulumi.Input<inputs.insights.v20200501preview.Action>[]>;
    /**
     * The rule criteria that defines the conditions of the scheduled query rule.
     */
    readonly criteria: pulumi.Input<inputs.insights.v20200501preview.ScheduledQueryRuleCriteria>;
    /**
     * The description of the scheduled query rule.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The display name of the alert rule
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The flag which indicates whether this scheduled query rule is enabled. Value should be true or false
     */
    readonly enabled: pulumi.Input<boolean>;
    /**
     * How often the scheduled query rule is evaluated represented in ISO 8601 duration format.
     */
    readonly evaluationFrequency: pulumi.Input<string>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * Mute actions for the chosen period of time (in ISO 8601 duration format) after the alert is fired.
     */
    readonly muteActionsDuration?: pulumi.Input<string>;
    /**
     * If specified then overrides the query time range (default is WindowSize*NumberOfEvaluationPeriods)
     */
    readonly overrideQueryTimeRange?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the rule.
     */
    readonly ruleName: pulumi.Input<string>;
    /**
     * The list of resource id's that this scheduled query rule is scoped to.
     */
    readonly scopes: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Severity of the alert. Should be an integer between [0-4]. Value of 0 is severest
     */
    readonly severity: pulumi.Input<number>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria
     */
    readonly targetResourceTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The period of time (in ISO 8601 duration format) on which the Alert query will be executed (bin size).
     */
    readonly windowSize: pulumi.Input<string>;
}
