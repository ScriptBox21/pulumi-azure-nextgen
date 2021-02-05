// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.Latest.Inputs
{

    /// <summary>
    /// The configuration parameters used while performing a rolling upgrade.
    /// </summary>
    public sealed class RollingUpgradePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allow VMSS to ignore AZ boundaries when constructing upgrade batches. Take into consideration the Update Domain and maxBatchInstancePercent to determine the batch size.
        /// </summary>
        [Input("enableCrossZoneUpgrade")]
        public Input<bool>? EnableCrossZoneUpgrade { get; set; }

        /// <summary>
        /// The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability. The default value for this parameter is 20%.
        /// </summary>
        [Input("maxBatchInstancePercent")]
        public Input<int>? MaxBatchInstancePercent { get; set; }

        /// <summary>
        /// The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch. The default value for this parameter is 20%.
        /// </summary>
        [Input("maxUnhealthyInstancePercent")]
        public Input<int>? MaxUnhealthyInstancePercent { get; set; }

        /// <summary>
        /// The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts. The default value for this parameter is 20%.
        /// </summary>
        [Input("maxUnhealthyUpgradedInstancePercent")]
        public Input<int>? MaxUnhealthyUpgradedInstancePercent { get; set; }

        /// <summary>
        /// The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format. The default value is 0 seconds (PT0S).
        /// </summary>
        [Input("pauseTimeBetweenBatches")]
        public Input<string>? PauseTimeBetweenBatches { get; set; }

        /// <summary>
        /// Upgrade all unhealthy instances in a scale set before any healthy instances.
        /// </summary>
        [Input("prioritizeUnhealthyInstances")]
        public Input<bool>? PrioritizeUnhealthyInstances { get; set; }

        public RollingUpgradePolicyArgs()
        {
        }
    }
}
