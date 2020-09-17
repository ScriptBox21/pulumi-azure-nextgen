// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20150401.Inputs
{

    /// <summary>
    /// A rule that provide the triggers and parameters for the scaling action.
    /// </summary>
    public sealed class ScaleRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// the trigger that results in a scaling action.
        /// </summary>
        [Input("metricTrigger", required: true)]
        public Input<Inputs.MetricTriggerArgs> MetricTrigger { get; set; } = null!;

        /// <summary>
        /// the parameters for the scaling action.
        /// </summary>
        [Input("scaleAction", required: true)]
        public Input<Inputs.ScaleActionArgs> ScaleAction { get; set; } = null!;

        public ScaleRuleArgs()
        {
        }
    }
}