// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200901.Inputs
{

    /// <summary>
    /// A region in which the Azure Cosmos DB database account is deployed.
    /// </summary>
    public sealed class LocationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The failover priority of the region. A failover priority of 0 indicates a write region. The maximum value for a failover priority = (total number of regions - 1). Failover priority values must be unique for each of the regions in which the database account exists.
        /// </summary>
        [Input("failoverPriority")]
        public Input<int>? FailoverPriority { get; set; }

        /// <summary>
        /// Flag to indicate whether or not this region is an AvailabilityZone region
        /// </summary>
        [Input("isZoneRedundant")]
        public Input<bool>? IsZoneRedundant { get; set; }

        /// <summary>
        /// The name of the region.
        /// </summary>
        [Input("locationName")]
        public Input<string>? LocationName { get; set; }

        public LocationArgs()
        {
        }
    }
}