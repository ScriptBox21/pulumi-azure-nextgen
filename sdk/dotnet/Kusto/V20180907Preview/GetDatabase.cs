// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Kusto.V20180907Preview
{
    public static class GetDatabase
    {
        public static Task<GetDatabaseResult> InvokeAsync(GetDatabaseArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDatabaseResult>("azure-nextgen:kusto/v20180907preview:getDatabase", args ?? new GetDatabaseArgs(), options.WithVersion());
    }


    public sealed class GetDatabaseArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Kusto cluster.
        /// </summary>
        [Input("clusterName", required: true)]
        public string ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the database in the Kusto cluster.
        /// </summary>
        [Input("databaseName", required: true)]
        public string DatabaseName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group containing the Kusto cluster.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDatabaseArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDatabaseResult
    {
        /// <summary>
        /// An ETag of the resource created.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The number of days of data that should be kept in cache for fast queries.
        /// </summary>
        public readonly int? HotCachePeriodInDays;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioned state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The number of days data should be kept before it stops being accessible to queries.
        /// </summary>
        public readonly int SoftDeletePeriodInDays;
        /// <summary>
        /// The statistics of the database.
        /// </summary>
        public readonly Outputs.DatabaseStatisticsResponse Statistics;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDatabaseResult(
            string etag,

            int? hotCachePeriodInDays,

            string location,

            string name,

            string provisioningState,

            int softDeletePeriodInDays,

            Outputs.DatabaseStatisticsResponse statistics,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Etag = etag;
            HotCachePeriodInDays = hotCachePeriodInDays;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            SoftDeletePeriodInDays = softDeletePeriodInDays;
            Statistics = statistics;
            Tags = tags;
            Type = type;
        }
    }
}
