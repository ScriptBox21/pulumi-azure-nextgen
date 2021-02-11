// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001.Outputs
{

    [OutputType]
    public sealed class ApplicationLogsConfigResponse
    {
        /// <summary>
        /// Application logs to blob storage configuration.
        /// </summary>
        public readonly Outputs.AzureBlobStorageApplicationLogsConfigResponse? AzureBlobStorage;
        /// <summary>
        /// Application logs to azure table storage configuration.
        /// </summary>
        public readonly Outputs.AzureTableStorageApplicationLogsConfigResponse? AzureTableStorage;
        /// <summary>
        /// Application logs to file system configuration.
        /// </summary>
        public readonly Outputs.FileSystemApplicationLogsConfigResponse? FileSystem;

        [OutputConstructor]
        private ApplicationLogsConfigResponse(
            Outputs.AzureBlobStorageApplicationLogsConfigResponse? azureBlobStorage,

            Outputs.AzureTableStorageApplicationLogsConfigResponse? azureTableStorage,

            Outputs.FileSystemApplicationLogsConfigResponse? fileSystem)
        {
            AzureBlobStorage = azureBlobStorage;
            AzureTableStorage = azureTableStorage;
            FileSystem = fileSystem;
        }
    }
}
