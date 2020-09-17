// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataShare.Latest.Outputs
{

    [OutputType]
    public sealed class ShareSynchronizationResponseResult
    {
        /// <summary>
        /// Email of the user who created the synchronization
        /// </summary>
        public readonly string? ConsumerEmail;
        /// <summary>
        /// Name of the user who created the synchronization
        /// </summary>
        public readonly string? ConsumerName;
        /// <summary>
        /// Tenant name of the consumer who created the synchronization
        /// </summary>
        public readonly string? ConsumerTenantName;
        /// <summary>
        /// synchronization duration
        /// </summary>
        public readonly int? DurationMs;
        /// <summary>
        /// End time of synchronization
        /// </summary>
        public readonly string? EndTime;
        /// <summary>
        /// message of synchronization
        /// </summary>
        public readonly string? Message;
        /// <summary>
        /// start time of synchronization
        /// </summary>
        public readonly string? StartTime;
        /// <summary>
        /// Raw Status
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// Synchronization id
        /// </summary>
        public readonly string? SynchronizationId;
        /// <summary>
        /// Synchronization mode
        /// </summary>
        public readonly string SynchronizationMode;

        [OutputConstructor]
        private ShareSynchronizationResponseResult(
            string? consumerEmail,

            string? consumerName,

            string? consumerTenantName,

            int? durationMs,

            string? endTime,

            string? message,

            string? startTime,

            string? status,

            string? synchronizationId,

            string synchronizationMode)
        {
            ConsumerEmail = consumerEmail;
            ConsumerName = consumerName;
            ConsumerTenantName = consumerTenantName;
            DurationMs = durationMs;
            EndTime = endTime;
            Message = message;
            StartTime = startTime;
            Status = status;
            SynchronizationId = synchronizationId;
            SynchronizationMode = synchronizationMode;
        }
    }
}