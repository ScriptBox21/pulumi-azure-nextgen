// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001.Inputs
{

    /// <summary>
    /// Trigger based on request execution time.
    /// </summary>
    public sealed class SlowRequestsBasedTriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Request Count.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// Time interval.
        /// </summary>
        [Input("timeInterval")]
        public Input<string>? TimeInterval { get; set; }

        /// <summary>
        /// Time taken.
        /// </summary>
        [Input("timeTaken")]
        public Input<string>? TimeTaken { get; set; }

        public SlowRequestsBasedTriggerArgs()
        {
        }
    }
}
