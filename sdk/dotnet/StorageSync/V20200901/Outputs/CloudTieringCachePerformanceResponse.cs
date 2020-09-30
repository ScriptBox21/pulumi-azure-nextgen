// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageSync.V20200901.Outputs
{

    [OutputType]
    public sealed class CloudTieringCachePerformanceResponse
    {
        /// <summary>
        /// Count of bytes that were served from the local server
        /// </summary>
        public readonly int CacheHitBytes;
        /// <summary>
        /// Percentage of total bytes (hit + miss) that were served from the local server
        /// </summary>
        public readonly int CacheHitBytesPercent;
        /// <summary>
        /// Count of bytes that were served from the cloud
        /// </summary>
        public readonly int CacheMissBytes;
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        public readonly string LastUpdatedTimestamp;

        [OutputConstructor]
        private CloudTieringCachePerformanceResponse(
            int cacheHitBytes,

            int cacheHitBytesPercent,

            int cacheMissBytes,

            string lastUpdatedTimestamp)
        {
            CacheHitBytes = cacheHitBytes;
            CacheHitBytesPercent = cacheHitBytesPercent;
            CacheMissBytes = cacheMissBytes;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
        }
    }
}