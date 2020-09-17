// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class BinaryDatasetResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<ImmutableDictionary<string, object>> Annotations;
        /// <summary>
        /// The data compression method used for the binary dataset.
        /// </summary>
        public readonly Union<Outputs.DatasetBZip2CompressionResponse, Union<Outputs.DatasetDeflateCompressionResponse, Union<Outputs.DatasetGZipCompressionResponse, Union<Outputs.DatasetTarCompressionResponse, Union<Outputs.DatasetTarGZipCompressionResponse, Outputs.DatasetZipDeflateCompressionResponse>>>>>? Compression;
        /// <summary>
        /// Dataset description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        public readonly Outputs.DatasetResponseFolder? Folder;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// The location of the Binary storage.
        /// </summary>
        public readonly Union<Outputs.AmazonS3LocationResponse, Union<Outputs.AzureBlobFSLocationResponse, Union<Outputs.AzureBlobStorageLocationResponse, Union<Outputs.AzureDataLakeStoreLocationResponse, Union<Outputs.AzureFileStorageLocationResponse, Union<Outputs.FileServerLocationResponse, Union<Outputs.FtpServerLocationResponse, Union<Outputs.GoogleCloudStorageLocationResponse, Union<Outputs.HdfsLocationResponse, Union<Outputs.HttpServerLocationResponse, Outputs.SftpLocationResponse>>>>>>>>>> Location;
        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Schema;
        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Structure;
        /// <summary>
        /// Type of dataset.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private BinaryDatasetResponse(
            ImmutableArray<ImmutableDictionary<string, object>> annotations,

            Union<Outputs.DatasetBZip2CompressionResponse, Union<Outputs.DatasetDeflateCompressionResponse, Union<Outputs.DatasetGZipCompressionResponse, Union<Outputs.DatasetTarCompressionResponse, Union<Outputs.DatasetTarGZipCompressionResponse, Outputs.DatasetZipDeflateCompressionResponse>>>>>? compression,

            string? description,

            Outputs.DatasetResponseFolder? folder,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            Union<Outputs.AmazonS3LocationResponse, Union<Outputs.AzureBlobFSLocationResponse, Union<Outputs.AzureBlobStorageLocationResponse, Union<Outputs.AzureDataLakeStoreLocationResponse, Union<Outputs.AzureFileStorageLocationResponse, Union<Outputs.FileServerLocationResponse, Union<Outputs.FtpServerLocationResponse, Union<Outputs.GoogleCloudStorageLocationResponse, Union<Outputs.HdfsLocationResponse, Union<Outputs.HttpServerLocationResponse, Outputs.SftpLocationResponse>>>>>>>>>> location,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            ImmutableDictionary<string, object>? schema,

            ImmutableDictionary<string, object>? structure,

            string type)
        {
            Annotations = annotations;
            Compression = compression;
            Description = description;
            Folder = folder;
            LinkedServiceName = linkedServiceName;
            Location = location;
            Parameters = parameters;
            Schema = schema;
            Structure = structure;
            Type = type;
        }
    }
}