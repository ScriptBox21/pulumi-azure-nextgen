// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class BackupItemResponseResult
    {
        /// <summary>
        /// Id of the backup.
        /// </summary>
        public readonly int BackupId;
        /// <summary>
        /// Name of the blob which contains data for this backup.
        /// </summary>
        public readonly string BlobName;
        /// <summary>
        /// Unique correlation identifier. Please use this along with the timestamp while communicating with Azure support.
        /// </summary>
        public readonly string CorrelationId;
        /// <summary>
        /// Timestamp of the backup creation.
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// List of databases included in the backup.
        /// </summary>
        public readonly ImmutableArray<Outputs.DatabaseBackupSettingResponse> Databases;
        /// <summary>
        /// Timestamp when this backup finished.
        /// </summary>
        public readonly string FinishedTimeStamp;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Timestamp of a last restore operation which used this backup.
        /// </summary>
        public readonly string LastRestoreTimeStamp;
        /// <summary>
        /// Details regarding this backup. Might contain an error message.
        /// </summary>
        public readonly string Log;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// True if this backup has been created due to a schedule being triggered.
        /// </summary>
        public readonly bool Scheduled;
        /// <summary>
        /// Size of the backup in bytes.
        /// </summary>
        public readonly double SizeInBytes;
        /// <summary>
        /// Backup status.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// SAS URL for the storage account container which contains this backup.
        /// </summary>
        public readonly string StorageAccountUrl;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Size of the original web app which has been backed up.
        /// </summary>
        public readonly double WebsiteSizeInBytes;

        [OutputConstructor]
        private BackupItemResponseResult(
            int backupId,

            string blobName,

            string correlationId,

            string created,

            ImmutableArray<Outputs.DatabaseBackupSettingResponse> databases,

            string finishedTimeStamp,

            string id,

            string? kind,

            string lastRestoreTimeStamp,

            string log,

            string name,

            bool scheduled,

            double sizeInBytes,

            string status,

            string storageAccountUrl,

            Outputs.SystemDataResponse systemData,

            string type,

            double websiteSizeInBytes)
        {
            BackupId = backupId;
            BlobName = blobName;
            CorrelationId = correlationId;
            Created = created;
            Databases = databases;
            FinishedTimeStamp = finishedTimeStamp;
            Id = id;
            Kind = kind;
            LastRestoreTimeStamp = lastRestoreTimeStamp;
            Log = log;
            Name = name;
            Scheduled = scheduled;
            SizeInBytes = sizeInBytes;
            Status = status;
            StorageAccountUrl = storageAccountUrl;
            SystemData = systemData;
            Type = type;
            WebsiteSizeInBytes = websiteSizeInBytes;
        }
    }
}
