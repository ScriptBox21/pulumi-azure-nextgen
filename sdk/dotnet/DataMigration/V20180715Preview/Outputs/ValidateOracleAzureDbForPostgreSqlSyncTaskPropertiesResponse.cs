// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180715Preview.Outputs
{

    [OutputType]
    public sealed class ValidateOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse
    {
        /// <summary>
        /// Key value pairs of client data to attach meta data information to task
        /// </summary>
        public readonly ImmutableDictionary<string, string>? ClientData;
        /// <summary>
        /// Array of command properties.
        /// </summary>
        public readonly ImmutableArray<Union<Outputs.MigrateMISyncCompleteCommandPropertiesResponse, Outputs.MigrateSyncCompleteCommandPropertiesResponse>> Commands;
        /// <summary>
        /// Array of errors. This is ignored if submitted.
        /// </summary>
        public readonly ImmutableArray<Outputs.ODataErrorResponse> Errors;
        /// <summary>
        /// Input for the task that migrates Oracle databases to Azure Database for PostgreSQL for online migrations
        /// </summary>
        public readonly Outputs.MigrateOracleAzureDbPostgreSqlSyncTaskInputResponse? Input;
        /// <summary>
        /// An array containing a single validation error response object
        /// </summary>
        public readonly ImmutableArray<Outputs.ValidateOracleAzureDbPostgreSqlSyncTaskOutputResponse> Output;
        /// <summary>
        /// The state of the task. This is ignored if submitted.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Task type.
        /// </summary>
        public readonly string TaskType;

        [OutputConstructor]
        private ValidateOracleAzureDbForPostgreSqlSyncTaskPropertiesResponse(
            ImmutableDictionary<string, string>? clientData,

            ImmutableArray<Union<Outputs.MigrateMISyncCompleteCommandPropertiesResponse, Outputs.MigrateSyncCompleteCommandPropertiesResponse>> commands,

            ImmutableArray<Outputs.ODataErrorResponse> errors,

            Outputs.MigrateOracleAzureDbPostgreSqlSyncTaskInputResponse? input,

            ImmutableArray<Outputs.ValidateOracleAzureDbPostgreSqlSyncTaskOutputResponse> output,

            string state,

            string taskType)
        {
            ClientData = clientData;
            Commands = commands;
            Errors = errors;
            Input = input;
            Output = output;
            State = state;
            TaskType = taskType;
        }
    }
}