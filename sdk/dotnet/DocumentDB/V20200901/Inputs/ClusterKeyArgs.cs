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
    /// Cosmos DB Cassandra table cluster key
    /// </summary>
    public sealed class ClusterKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the Cosmos DB Cassandra table cluster key
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Order of the Cosmos DB Cassandra table cluster key, only support "Asc" and "Desc"
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        public ClusterKeyArgs()
        {
        }
    }
}
