// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001.Outputs
{

    [OutputType]
    public sealed class AutoHealActionsResponse
    {
        /// <summary>
        /// Predefined action to be taken.
        /// </summary>
        public readonly string? ActionType;
        /// <summary>
        /// Custom action to be taken.
        /// </summary>
        public readonly Outputs.AutoHealCustomActionResponse? CustomAction;
        /// <summary>
        /// Minimum time the process must execute
        /// before taking the action
        /// </summary>
        public readonly string? MinProcessExecutionTime;

        [OutputConstructor]
        private AutoHealActionsResponse(
            string? actionType,

            Outputs.AutoHealCustomActionResponse? customAction,

            string? minProcessExecutionTime)
        {
            ActionType = actionType;
            CustomAction = customAction;
            MinProcessExecutionTime = minProcessExecutionTime;
        }
    }
}
