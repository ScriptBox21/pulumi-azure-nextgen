// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201201.Outputs
{

    [OutputType]
    public sealed class AvailablePatchSummaryResponse
    {
        /// <summary>
        /// The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs.
        /// </summary>
        public readonly string AssessmentActivityId;
        /// <summary>
        /// The number of critical or security patches that have been detected as available and not yet installed.
        /// </summary>
        public readonly int CriticalAndSecurityPatchCount;
        /// <summary>
        /// The errors that were encountered during execution of the operation. The details array contains the list of them.
        /// </summary>
        public readonly Outputs.ApiErrorResponse Error;
        /// <summary>
        /// The UTC timestamp when the operation began.
        /// </summary>
        public readonly string LastModifiedTime;
        /// <summary>
        /// The number of all available patches excluding critical and security.
        /// </summary>
        public readonly int OtherPatchCount;
        /// <summary>
        /// The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred.
        /// </summary>
        public readonly bool RebootPending;
        /// <summary>
        /// The UTC timestamp when the operation began.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings."
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private AvailablePatchSummaryResponse(
            string assessmentActivityId,

            int criticalAndSecurityPatchCount,

            Outputs.ApiErrorResponse error,

            string lastModifiedTime,

            int otherPatchCount,

            bool rebootPending,

            string startTime,

            string status)
        {
            AssessmentActivityId = assessmentActivityId;
            CriticalAndSecurityPatchCount = criticalAndSecurityPatchCount;
            Error = error;
            LastModifiedTime = lastModifiedTime;
            OtherPatchCount = otherPatchCount;
            RebootPending = rebootPending;
            StartTime = startTime;
            Status = status;
        }
    }
}
