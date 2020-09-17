// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.EventHub.Latest.Inputs
{

    /// <summary>
    /// Capture storage details for capture description
    /// </summary>
    public sealed class DestinationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order
        /// </summary>
        [Input("archiveNameFormat")]
        public Input<string>? ArchiveNameFormat { get; set; }

        /// <summary>
        /// Blob container Name
        /// </summary>
        [Input("blobContainer")]
        public Input<string>? BlobContainer { get; set; }

        /// <summary>
        /// Name for capture destination
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Resource id of the storage account to be used to create the blobs
        /// </summary>
        [Input("storageAccountResourceId")]
        public Input<string>? StorageAccountResourceId { get; set; }

        public DestinationArgs()
        {
        }
    }
}