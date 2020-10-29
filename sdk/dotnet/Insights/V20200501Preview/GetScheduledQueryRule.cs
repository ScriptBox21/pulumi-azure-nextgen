// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20200501Preview
{
    public static class GetScheduledQueryRule
    {
        public static Task<GetScheduledQueryRuleResult> InvokeAsync(GetScheduledQueryRuleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetScheduledQueryRuleResult>("azure-nextgen:insights/v20200501preview:getScheduledQueryRule", args ?? new GetScheduledQueryRuleArgs(), options.WithVersion());
    }


    public sealed class GetScheduledQueryRuleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [Input("ruleName", required: true)]
        public string RuleName { get; set; } = null!;

        public GetScheduledQueryRuleArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetScheduledQueryRuleResult
    {
        public readonly ImmutableArray<Outputs.ActionResponse> Actions;
        /// <summary>
        /// The rule criteria that defines the conditions of the scheduled query rule.
        /// </summary>
        public readonly Outputs.ScheduledQueryRuleCriteriaResponse Criteria;
        /// <summary>
        /// The description of the scheduled query rule.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The flag which indicates whether this scheduled query rule is enabled. Value should be true or false
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// How often the scheduled query rule is evaluated represented in ISO 8601 duration format.
        /// </summary>
        public readonly string EvaluationFrequency;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Mute actions for the chosen period of time (in ISO 8601 duration format) after the alert is fired.
        /// </summary>
        public readonly string? MuteActionsDuration;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The list of resource id's that this scheduled query rule is scoped to.
        /// </summary>
        public readonly ImmutableArray<string> Scopes;
        /// <summary>
        /// Severity of the alert. Should be an integer between [0-4]. Value of 0 is severest
        /// </summary>
        public readonly double Severity;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria
        /// </summary>
        public readonly ImmutableArray<string> TargetResourceTypes;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The period of time (in ISO 8601 duration format) on which the Alert query will be executed (bin size).
        /// </summary>
        public readonly string WindowSize;

        [OutputConstructor]
        private GetScheduledQueryRuleResult(
            ImmutableArray<Outputs.ActionResponse> actions,

            Outputs.ScheduledQueryRuleCriteriaResponse criteria,

            string? description,

            bool enabled,

            string evaluationFrequency,

            string location,

            string? muteActionsDuration,

            string name,

            ImmutableArray<string> scopes,

            double severity,

            ImmutableDictionary<string, string>? tags,

            ImmutableArray<string> targetResourceTypes,

            string type,

            string windowSize)
        {
            Actions = actions;
            Criteria = criteria;
            Description = description;
            Enabled = enabled;
            EvaluationFrequency = evaluationFrequency;
            Location = location;
            MuteActionsDuration = muteActionsDuration;
            Name = name;
            Scopes = scopes;
            Severity = severity;
            Tags = tags;
            TargetResourceTypes = targetResourceTypes;
            Type = type;
            WindowSize = windowSize;
        }
    }
}
