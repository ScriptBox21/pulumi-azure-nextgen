// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.EventHub.V20180101Preview.Outputs
{

    [OutputType]
    public sealed class DestinationResponse
    {
        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        public readonly string? ArchiveNameFormat;
        /// <summary>
        /// Blob container Name
        /// </summary>
        public readonly string? BlobContainer;
        /// <summary>
        /// Name for capture destination
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Resource id of the storage account to be used to create the blobs
        /// </summary>
        public readonly string? StorageAccountResourceId;

        [OutputConstructor]
        private DestinationResponse(
            string? archiveNameFormat,

            string? blobContainer,

            string? name,

            string? storageAccountResourceId)
        {
            ArchiveNameFormat = archiveNameFormat;
            BlobContainer = blobContainer;
            Name = name;
            StorageAccountResourceId = storageAccountResourceId;
        }
    }
}
