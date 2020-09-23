// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.Latest.Outputs
{

    [OutputType]
    public sealed class LocationResponse
    {
        /// <summary>
        /// The connection endpoint for the specific region. Example: https://&amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.documents.azure.com:443/
        /// </summary>
        public readonly string DocumentEndpoint;
        /// <summary>
        /// The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists.
        /// </summary>
        public readonly int? FailoverPriority;
        /// <summary>
        /// The unique identifier of the region within the database account. Example: &amp;lt;accountName&amp;gt;-&amp;lt;locationName&amp;gt;.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Flag to indicate whether or not this region is an AvailabilityZone region
        /// </summary>
        public readonly bool? IsZoneRedundant;
        /// <summary>
        /// The name of the region.
        /// </summary>
        public readonly string? LocationName;
        /// <summary>
        /// The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'DeletionFailed' – the Cosmos DB account deletion failed.
        /// </summary>
        public readonly string ProvisioningState;

        [OutputConstructor]
        private LocationResponse(
            string documentEndpoint,

            int? failoverPriority,

            string id,

            bool? isZoneRedundant,

            string? locationName,

            string provisioningState)
        {
            DocumentEndpoint = documentEndpoint;
            FailoverPriority = failoverPriority;
            Id = id;
            IsZoneRedundant = isZoneRedundant;
            LocationName = locationName;
            ProvisioningState = provisioningState;
        }
    }
}
