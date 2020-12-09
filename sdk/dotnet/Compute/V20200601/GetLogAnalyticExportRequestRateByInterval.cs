// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20200601
{
    public static class GetLogAnalyticExportRequestRateByInterval
    {
        public static Task<GetLogAnalyticExportRequestRateByIntervalResult> InvokeAsync(GetLogAnalyticExportRequestRateByIntervalArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLogAnalyticExportRequestRateByIntervalResult>("azure-nextgen:compute/v20200601:getLogAnalyticExportRequestRateByInterval", args ?? new GetLogAnalyticExportRequestRateByIntervalArgs(), options.WithVersion());
    }


    public sealed class GetLogAnalyticExportRequestRateByIntervalArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to.
        /// </summary>
        [Input("blobContainerSasUri", required: true)]
        public string BlobContainerSasUri { get; set; } = null!;

        /// <summary>
        /// From time of the query
        /// </summary>
        [Input("fromTime", required: true)]
        public string FromTime { get; set; } = null!;

        /// <summary>
        /// Group query result by Client Application ID.
        /// </summary>
        [Input("groupByClientApplicationId")]
        public bool? GroupByClientApplicationId { get; set; }

        /// <summary>
        /// Group query result by Operation Name.
        /// </summary>
        [Input("groupByOperationName")]
        public bool? GroupByOperationName { get; set; }

        /// <summary>
        /// Group query result by Resource Name.
        /// </summary>
        [Input("groupByResourceName")]
        public bool? GroupByResourceName { get; set; }

        /// <summary>
        /// Group query result by Throttle Policy applied.
        /// </summary>
        [Input("groupByThrottlePolicy")]
        public bool? GroupByThrottlePolicy { get; set; }

        /// <summary>
        /// Group query result by User Agent.
        /// </summary>
        [Input("groupByUserAgent")]
        public bool? GroupByUserAgent { get; set; }

        /// <summary>
        /// Interval value in minutes used to create LogAnalytics call rate logs.
        /// </summary>
        [Input("intervalLength", required: true)]
        public string IntervalLength { get; set; } = null!;

        /// <summary>
        /// The location upon which virtual-machine-sizes is queried.
        /// </summary>
        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        /// <summary>
        /// To time of the query
        /// </summary>
        [Input("toTime", required: true)]
        public string ToTime { get; set; } = null!;

        public GetLogAnalyticExportRequestRateByIntervalArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLogAnalyticExportRequestRateByIntervalResult
    {
        /// <summary>
        /// LogAnalyticsOutput
        /// </summary>
        public readonly Outputs.LogAnalyticsOutputResponseResult Properties;

        [OutputConstructor]
        private GetLogAnalyticExportRequestRateByIntervalResult(Outputs.LogAnalyticsOutputResponseResult properties)
        {
            Properties = properties;
        }
    }
}
