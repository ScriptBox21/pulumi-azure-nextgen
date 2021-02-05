// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20180416
{
    /// <summary>
    /// The Log Search Rule resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:insights/v20180416:ScheduledQueryRule")]
    public partial class ScheduledQueryRule : Pulumi.CustomResource
    {
        /// <summary>
        /// Action needs to be taken on rule execution.
        /// </summary>
        [Output("action")]
        public Output<Union<Outputs.AlertingActionResponse, Outputs.LogToMetricActionResponse>> Action { get; private set; } = null!;

        /// <summary>
        /// The api-version used when creating this alert rule
        /// </summary>
        [Output("createdWithApiVersion")]
        public Output<string> CreatedWithApiVersion { get; private set; } = null!;

        /// <summary>
        /// The description of the Log Search rule.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The display name of the alert rule
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The flag which indicates whether the Log Search rule is enabled. Value should be true or false
        /// </summary>
        [Output("enabled")]
        public Output<string?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. 
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// True if alert rule is legacy Log Analytic rule
        /// </summary>
        [Output("isLegacyLogAnalyticsRule")]
        public Output<bool> IsLegacyLogAnalyticsRule { get; private set; } = null!;

        /// <summary>
        /// Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value.
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Last time the rule was updated in IS08601 format.
        /// </summary>
        [Output("lastUpdatedTime")]
        public Output<string> LastUpdatedTime { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Azure resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the scheduled query rule
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Schedule (Frequency, Time Window) for rule. Required for action type - AlertingAction
        /// </summary>
        [Output("schedule")]
        public Output<Outputs.ScheduleResponse?> Schedule { get; private set; } = null!;

        /// <summary>
        /// Data Source against which rule will Query Data
        /// </summary>
        [Output("source")]
        public Output<Outputs.SourceResponse> Source { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Azure resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ScheduledQueryRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ScheduledQueryRule(string name, ScheduledQueryRuleArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:insights/v20180416:ScheduledQueryRule", name, args ?? new ScheduledQueryRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ScheduledQueryRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:insights/v20180416:ScheduledQueryRule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:insights/latest:ScheduledQueryRule"},
                    new Pulumi.Alias { Type = "azure-nextgen:insights/v20200501preview:ScheduledQueryRule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ScheduledQueryRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ScheduledQueryRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ScheduledQueryRule(name, id, options);
        }
    }

    public sealed class ScheduledQueryRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Action needs to be taken on rule execution.
        /// </summary>
        [Input("action", required: true)]
        public InputUnion<Inputs.AlertingActionArgs, Inputs.LogToMetricActionArgs> Action { get; set; } = null!;

        /// <summary>
        /// The description of the Log Search rule.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of the alert rule
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The flag which indicates whether the Log Search rule is enabled. Value should be true or false
        /// </summary>
        [Input("enabled")]
        public InputUnion<string, Pulumi.AzureNextGen.Insights.V20180416.Enabled>? Enabled { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        /// <summary>
        /// Schedule (Frequency, Time Window) for rule. Required for action type - AlertingAction
        /// </summary>
        [Input("schedule")]
        public Input<Inputs.ScheduleArgs>? Schedule { get; set; }

        /// <summary>
        /// Data Source against which rule will Query Data
        /// </summary>
        [Input("source", required: true)]
        public Input<Inputs.SourceArgs> Source { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ScheduledQueryRuleArgs()
        {
        }
    }
}
