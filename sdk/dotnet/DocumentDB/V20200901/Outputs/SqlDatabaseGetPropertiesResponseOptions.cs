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
    public sealed class SqlDatabaseGetPropertiesResponseOptions
    {
        /// <summary>
        /// Specifies the Autoscale settings.
        /// </summary>
        public readonly Outputs.AutoscaleSettingsResponse? AutoscaleSettings;
        /// <summary>
        /// Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details.
        /// </summary>
        public readonly int? Throughput;

        [OutputConstructor]
        private SqlDatabaseGetPropertiesResponseOptions(
            Outputs.AutoscaleSettingsResponse? autoscaleSettings,

            int? throughput)
        {
            AutoscaleSettings = autoscaleSettings;
            Throughput = throughput;
        }
    }
}
