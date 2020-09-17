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
    public sealed class WatchlistItemResponse
    {
        /// <summary>
        /// Describes a user that created the watchlist
        /// </summary>
        public readonly Outputs.UserInfoResponse? CreatedBy;
        /// <summary>
        /// The time the watchlist item was created
        /// </summary>
        public readonly string? CreatedTimeUtc;
        /// <summary>
        /// A key-value pair for a watchlist item entity mapping
        /// </summary>
        public readonly ImmutableDictionary<string, object>? EntityMapping;
        /// <summary>
        /// Azure resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The last time the watchlist item was updated
        /// </summary>
        public readonly string? LastUpdatedTimeUtc;
        /// <summary>
        /// Azure resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The tenantId to which this watchlist item belongs to
        /// </summary>
        public readonly string? TenantId;
        /// <summary>
        /// The time to live for the watchlist item
        /// </summary>
        public readonly string? TimeToLiveUtc;
        /// <summary>
        /// Azure resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Describes a user that updated the watchlist
        /// </summary>
        public readonly Outputs.UserInfoResponse? UpdatedBy;
        /// <summary>
        /// The watchlist id of the parent of this watchlist item
        /// </summary>
        public readonly string WatchlistId;
        /// <summary>
        /// Name of the watchlist item
        /// </summary>
        public readonly string? WatchlistItemName;
        /// <summary>
        /// A key-value pair for a watchlist item
        /// </summary>
        public readonly ImmutableDictionary<string, object> WatchlistItemPair;
        /// <summary>
        /// The type of the watchlist item
        /// </summary>
        public readonly string? WatchlistItemType;

        [OutputConstructor]
        private WatchlistItemResponse(
            Outputs.UserInfoResponse? createdBy,

            string? createdTimeUtc,

            ImmutableDictionary<string, object>? entityMapping,

            string id,

            string? lastUpdatedTimeUtc,

            string name,

            string? tenantId,

            string? timeToLiveUtc,

            string type,

            Outputs.UserInfoResponse? updatedBy,

            string watchlistId,

            string? watchlistItemName,

            ImmutableDictionary<string, object> watchlistItemPair,

            string? watchlistItemType)
        {
            CreatedBy = createdBy;
            CreatedTimeUtc = createdTimeUtc;
            EntityMapping = entityMapping;
            Id = id;
            LastUpdatedTimeUtc = lastUpdatedTimeUtc;
            Name = name;
            TenantId = tenantId;
            TimeToLiveUtc = timeToLiveUtc;
            Type = type;
            UpdatedBy = updatedBy;
            WatchlistId = watchlistId;
            WatchlistItemName = watchlistItemName;
            WatchlistItemPair = watchlistItemPair;
            WatchlistItemType = watchlistItemType;
        }
    }
}