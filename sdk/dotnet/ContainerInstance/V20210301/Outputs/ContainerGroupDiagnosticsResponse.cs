// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20210301.Outputs
{

    [OutputType]
    public sealed class ContainerGroupDiagnosticsResponse
    {
        /// <summary>
        /// Container group log analytics information.
        /// </summary>
        public readonly Outputs.LogAnalyticsResponse? LogAnalytics;

        [OutputConstructor]
        private ContainerGroupDiagnosticsResponse(Outputs.LogAnalyticsResponse? logAnalytics)
        {
            LogAnalytics = logAnalytics;
        }
    }
}
