// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200501Preview.Outputs
{

    [OutputType]
    public sealed class DatasetResponseLatest
    {
        /// <summary>
        /// User who created.
        /// </summary>
        public readonly Outputs.UserInfoResponse? CreatedBy;
        /// <summary>
        /// The dataset creation time (UTC).
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        ///  Datastore and reference to location of data such as relativePath, Sql Query and etc.
        /// </summary>
        public readonly Outputs.DatasetResponseDataPath? DataPath;
        /// <summary>
        /// Dataflow Json
        /// </summary>
        public readonly string Dataflow;
        /// <summary>
        /// Dataset state
        /// </summary>
        public readonly Outputs.DatasetStateResponse? DatasetDefinitionState;
        /// <summary>
        /// Unique Dataset identifier.
        /// </summary>
        public readonly string DatasetId;
        /// <summary>
        /// Description about the dataset.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// eTag description
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Dataset FileType, specified by user.
        /// </summary>
        public readonly string FileType;
        /// <summary>
        /// The dataset last modified time (UTC).
        /// </summary>
        public readonly string ModifiedTime;
        /// <summary>
        /// Summary of Definition changes.
        /// </summary>
        public readonly string Notes;
        /// <summary>
        /// Indicates how the source data is partitioned. This is defined to filter on a range of partitioned data before performing actions or materialization.
        /// </summary>
        public readonly bool PartitionFormatInPath;
        /// <summary>
        /// Properties stores information like name of time series column for time series dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableDictionary<string, object>>? Properties;
        /// <summary>
        /// Indicates the saved dataset this definition is mapping to, populated on Get.
        /// </summary>
        public readonly string SavedDatasetId;
        /// <summary>
        /// Tags associated with the dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        ///  Telemetry information about the dataset including information like which service the dataset was created from.
        /// </summary>
        public readonly ImmutableDictionary<string, string> TelemetryInfo;
        /// <summary>
        ///  Whether to use description and tags from the definition level as opposed to dataset level (old behavior).
        /// </summary>
        public readonly bool UseDescriptionTagsFromDefinition;
        /// <summary>
        /// An identifier uniquely identifies a definition change.
        /// </summary>
        public readonly string VersionId;

        [OutputConstructor]
        private DatasetResponseLatest(
            Outputs.UserInfoResponse? createdBy,

            string createdTime,

            Outputs.DatasetResponseDataPath? dataPath,

            string dataflow,

            Outputs.DatasetStateResponse? datasetDefinitionState,

            string datasetId,

            string description,

            string etag,

            string fileType,

            string modifiedTime,

            string notes,

            bool partitionFormatInPath,

            ImmutableDictionary<string, ImmutableDictionary<string, object>>? properties,

            string savedDatasetId,

            ImmutableDictionary<string, string> tags,

            ImmutableDictionary<string, string> telemetryInfo,

            bool useDescriptionTagsFromDefinition,

            string versionId)
        {
            CreatedBy = createdBy;
            CreatedTime = createdTime;
            DataPath = dataPath;
            Dataflow = dataflow;
            DatasetDefinitionState = datasetDefinitionState;
            DatasetId = datasetId;
            Description = description;
            Etag = etag;
            FileType = fileType;
            ModifiedTime = modifiedTime;
            Notes = notes;
            PartitionFormatInPath = partitionFormatInPath;
            Properties = properties;
            SavedDatasetId = savedDatasetId;
            Tags = tags;
            TelemetryInfo = telemetryInfo;
            UseDescriptionTagsFromDefinition = useDescriptionTagsFromDefinition;
            VersionId = versionId;
        }
    }
}
