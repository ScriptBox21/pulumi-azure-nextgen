// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180419.Outputs
{

    [OutputType]
    public sealed class MigratePostgreSqlAzureDbForPostgreSqlSyncTaskInputResponse
    {
        /// <summary>
        /// Databases to migrate
        /// </summary>
        public readonly ImmutableArray<Outputs.MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseInputResponse> SelectedDatabases;
        /// <summary>
        /// Connection information for source PostgreSQL
        /// </summary>
        public readonly Outputs.PostgreSqlConnectionInfoResponse SourceConnectionInfo;
        /// <summary>
        /// Connection information for target Azure Database for PostgreSQL
        /// </summary>
        public readonly Outputs.PostgreSqlConnectionInfoResponse TargetConnectionInfo;

        [OutputConstructor]
        private MigratePostgreSqlAzureDbForPostgreSqlSyncTaskInputResponse(
            ImmutableArray<Outputs.MigratePostgreSqlAzureDbForPostgreSqlSyncDatabaseInputResponse> selectedDatabases,

            Outputs.PostgreSqlConnectionInfoResponse sourceConnectionInfo,

            Outputs.PostgreSqlConnectionInfoResponse targetConnectionInfo)
        {
            SelectedDatabases = selectedDatabases;
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
        }
    }
}