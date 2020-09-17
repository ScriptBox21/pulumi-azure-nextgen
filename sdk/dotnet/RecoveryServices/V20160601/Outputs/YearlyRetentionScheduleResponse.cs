// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20160601.Outputs
{

    [OutputType]
    public sealed class YearlyRetentionScheduleResponse
    {
        /// <summary>
        /// List of the months of year for the yearly retention policy.
        /// </summary>
        public readonly ImmutableArray<string> MonthsOfYear;
        /// <summary>
        /// Retention duration for the retention policy.
        /// </summary>
        public readonly Outputs.RetentionDurationResponse? RetentionDuration;
        /// <summary>
        /// Daily retention format for the yearly retention policy.
        /// </summary>
        public readonly Outputs.DailyRetentionFormatResponse? RetentionScheduleDaily;
        /// <summary>
        /// Retention schedule format for the yearly retention policy.
        /// </summary>
        public readonly string? RetentionScheduleFormatType;
        /// <summary>
        /// Weekly retention format for the yearly retention policy.
        /// </summary>
        public readonly Outputs.WeeklyRetentionFormatResponse? RetentionScheduleWeekly;
        /// <summary>
        /// Retention times for the retention policy.
        /// </summary>
        public readonly ImmutableArray<string> RetentionTimes;

        [OutputConstructor]
        private YearlyRetentionScheduleResponse(
            ImmutableArray<string> monthsOfYear,

            Outputs.RetentionDurationResponse? retentionDuration,

            Outputs.DailyRetentionFormatResponse? retentionScheduleDaily,

            string? retentionScheduleFormatType,

            Outputs.WeeklyRetentionFormatResponse? retentionScheduleWeekly,

            ImmutableArray<string> retentionTimes)
        {
            MonthsOfYear = monthsOfYear;
            RetentionDuration = retentionDuration;
            RetentionScheduleDaily = retentionScheduleDaily;
            RetentionScheduleFormatType = retentionScheduleFormatType;
            RetentionScheduleWeekly = retentionScheduleWeekly;
            RetentionTimes = retentionTimes;
        }
    }
}