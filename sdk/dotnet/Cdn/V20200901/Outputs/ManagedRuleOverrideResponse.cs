// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901.Outputs
{

    [OutputType]
    public sealed class ManagedRuleOverrideResponse
    {
        /// <summary>
        /// Describes the override action to be applied when rule matches.
        /// </summary>
        public readonly string? Action;
        /// <summary>
        /// Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified.
        /// </summary>
        public readonly string? EnabledState;
        /// <summary>
        /// Identifier for the managed rule.
        /// </summary>
        public readonly string RuleId;

        [OutputConstructor]
        private ManagedRuleOverrideResponse(
            string? action,

            string? enabledState,

            string ruleId)
        {
            Action = action;
            EnabledState = enabledState;
            RuleId = ruleId;
        }
    }
}
