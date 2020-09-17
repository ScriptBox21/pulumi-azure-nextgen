// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AadIam.Latest.Inputs
{

    /// <summary>
    /// Specifies the retention policy for the log.
    /// </summary>
    public sealed class RetentionPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of days for the retention in days. A value of 0 will retain the events indefinitely.
        /// </summary>
        [Input("days", required: true)]
        public Input<int> Days { get; set; } = null!;

        /// <summary>
        /// A value indicating whether the retention policy is enabled.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public RetentionPolicyArgs()
        {
        }
    }
}