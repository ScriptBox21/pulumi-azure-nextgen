// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class AutoHealRulesResponse
    {
        /// <summary>
        /// Actions to be executed when a rule is triggered.
        /// </summary>
        public readonly Outputs.AutoHealActionsResponse? Actions;
        /// <summary>
        /// Conditions that describe when to execute the auto-heal actions.
        /// </summary>
        public readonly Outputs.AutoHealTriggersResponse? Triggers;

        [OutputConstructor]
        private AutoHealRulesResponse(
            Outputs.AutoHealActionsResponse? actions,

            Outputs.AutoHealTriggersResponse? triggers)
        {
            Actions = actions;
            Triggers = triggers;
        }
    }
}
