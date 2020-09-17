// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20160801.Outputs
{

    [OutputType]
    public sealed class AutoHealTriggersResponse
    {
        /// <summary>
        /// A rule based on private bytes.
        /// </summary>
        public readonly int? PrivateBytesInKB;
        /// <summary>
        /// A rule based on total requests.
        /// </summary>
        public readonly Outputs.RequestsBasedTriggerResponse? Requests;
        /// <summary>
        /// A rule based on request execution time.
        /// </summary>
        public readonly Outputs.SlowRequestsBasedTriggerResponse? SlowRequests;
        /// <summary>
        /// A rule based on status codes.
        /// </summary>
        public readonly ImmutableArray<Outputs.StatusCodesBasedTriggerResponse> StatusCodes;

        [OutputConstructor]
        private AutoHealTriggersResponse(
            int? privateBytesInKB,

            Outputs.RequestsBasedTriggerResponse? requests,

            Outputs.SlowRequestsBasedTriggerResponse? slowRequests,

            ImmutableArray<Outputs.StatusCodesBasedTriggerResponse> statusCodes)
        {
            PrivateBytesInKB = privateBytesInKB;
            Requests = requests;
            SlowRequests = slowRequests;
            StatusCodes = statusCodes;
        }
    }
}