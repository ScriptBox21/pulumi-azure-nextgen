// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.SecurityInsights.V20190101Preview.Outputs
{

    [OutputType]
    public sealed class ActivityTimelineItemResponseResult
    {
        /// <summary>
        /// The grouping bucket end time.
        /// </summary>
        public readonly string BucketEndTimeUTC;
        /// <summary>
        /// The grouping bucket start time.
        /// </summary>
        public readonly string BucketStartTimeUTC;
        /// <summary>
        /// The activity timeline content.
        /// </summary>
        public readonly string Content;
        /// <summary>
        /// The time of the first activity in the grouping bucket.
        /// </summary>
        public readonly string FirstActivityTimeUTC;
        /// <summary>
        /// The entity query kind type.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// The time of the last activity in the grouping bucket.
        /// </summary>
        public readonly string LastActivityTimeUTC;
        /// <summary>
        /// The activity query id.
        /// </summary>
        public readonly string QueryId;
        /// <summary>
        /// The activity timeline title.
        /// </summary>
        public readonly string Title;

        [OutputConstructor]
        private ActivityTimelineItemResponseResult(
            string bucketEndTimeUTC,

            string bucketStartTimeUTC,

            string content,

            string firstActivityTimeUTC,

            string kind,

            string lastActivityTimeUTC,

            string queryId,

            string title)
        {
            BucketEndTimeUTC = bucketEndTimeUTC;
            BucketStartTimeUTC = bucketStartTimeUTC;
            Content = content;
            FirstActivityTimeUTC = firstActivityTimeUTC;
            Kind = kind;
            LastActivityTimeUTC = lastActivityTimeUTC;
            QueryId = queryId;
            Title = title;
        }
    }
}