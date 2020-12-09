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
    /// Metric limits set on an app.
    /// </summary>
    public sealed class SiteLimitsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum allowed disk size usage in MB.
        /// </summary>
        [Input("maxDiskSizeInMb")]
        public Input<int>? MaxDiskSizeInMb { get; set; }

        /// <summary>
        /// Maximum allowed memory usage in MB.
        /// </summary>
        [Input("maxMemoryInMb")]
        public Input<int>? MaxMemoryInMb { get; set; }

        /// <summary>
        /// Maximum allowed CPU usage percentage.
        /// </summary>
        [Input("maxPercentageCpu")]
        public Input<double>? MaxPercentageCpu { get; set; }

        public SiteLimitsArgs()
        {
        }
    }
}
