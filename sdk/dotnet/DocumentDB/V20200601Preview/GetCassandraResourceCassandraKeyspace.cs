// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200601Preview
{
    public static class GetCassandraResourceCassandraKeyspace
    {
        public static Task<GetCassandraResourceCassandraKeyspaceResult> InvokeAsync(GetCassandraResourceCassandraKeyspaceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCassandraResourceCassandraKeyspaceResult>("azure-nextgen:documentdb/v20200601preview:getCassandraResourceCassandraKeyspace", args ?? new GetCassandraResourceCassandraKeyspaceArgs(), options.WithVersion());
    }


    public sealed class GetCassandraResourceCassandraKeyspaceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cosmos DB database account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// Cosmos DB keyspace name.
        /// </summary>
        [Input("keyspaceName", required: true)]
        public string KeyspaceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetCassandraResourceCassandraKeyspaceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCassandraResourceCassandraKeyspaceResult
    {
        /// <summary>
        /// Identity for the resource.
        /// </summary>
        public readonly Outputs.ManagedServiceIdentityResponse? Identity;
        /// <summary>
        /// The location of the resource group to which the resource belongs.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the ARM resource.
        /// </summary>
        public readonly string Name;
        public readonly Outputs.CassandraKeyspaceGetPropertiesResponseOptions? Options;
        public readonly Outputs.CassandraKeyspaceGetPropertiesResponseResource? Resource;
        /// <summary>
        /// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of Azure resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetCassandraResourceCassandraKeyspaceResult(
            Outputs.ManagedServiceIdentityResponse? identity,

            string? location,

            string name,

            Outputs.CassandraKeyspaceGetPropertiesResponseOptions? options,

            Outputs.CassandraKeyspaceGetPropertiesResponseResource? resource,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Identity = identity;
            Location = location;
            Name = name;
            Options = options;
            Resource = resource;
            Tags = tags;
            Type = type;
        }
    }
}