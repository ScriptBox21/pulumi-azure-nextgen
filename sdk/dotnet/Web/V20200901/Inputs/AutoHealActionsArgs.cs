// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Inputs
{

    /// <summary>
    /// Actions which to take by the auto-heal module when a rule is triggered.
    /// </summary>
    public sealed class AutoHealActionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Predefined action to be taken.
        /// </summary>
        [Input("actionType")]
        public Input<string>? ActionType { get; set; }

        /// <summary>
        /// Custom action to be taken.
        /// </summary>
        [Input("customAction")]
        public Input<Inputs.AutoHealCustomActionArgs>? CustomAction { get; set; }

        /// <summary>
        /// Minimum time the process must execute
        /// before taking the action
        /// </summary>
        [Input("minProcessExecutionTime")]
        public Input<string>? MinProcessExecutionTime { get; set; }

        public AutoHealActionsArgs()
        {
        }
    }
}
