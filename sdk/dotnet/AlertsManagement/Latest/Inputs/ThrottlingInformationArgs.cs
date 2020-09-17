// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AlertsManagement.Latest.Inputs
{

    /// <summary>
    /// Optional throttling information for the alert rule.
    /// </summary>
    public sealed class ThrottlingInformationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The required duration (in ISO8601 format) to wait before notifying on the alert rule again. The time granularity must be in minutes and minimum value is 0 minutes
        /// </summary>
        [Input("duration")]
        public Input<string>? Duration { get; set; }

        public ThrottlingInformationArgs()
        {
        }
    }
}