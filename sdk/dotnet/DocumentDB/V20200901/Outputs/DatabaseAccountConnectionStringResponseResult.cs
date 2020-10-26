// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200901.Outputs
{

    [OutputType]
    public sealed class DatabaseAccountConnectionStringResponseResult
    {
        /// <summary>
        /// Value of the connection string
        /// </summary>
        public readonly string ConnectionString;
        /// <summary>
        /// Description of the connection string
        /// </summary>
        public readonly string Description;

        [OutputConstructor]
        private DatabaseAccountConnectionStringResponseResult(
            string connectionString,

            string description)
        {
            ConnectionString = connectionString;
            Description = description;
        }
    }
}
