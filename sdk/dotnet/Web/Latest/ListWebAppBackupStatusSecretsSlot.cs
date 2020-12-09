// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest
{
    public static class ListWebAppBackupStatusSecretsSlot
    {
        public static Task<ListWebAppBackupStatusSecretsSlotResult> InvokeAsync(ListWebAppBackupStatusSecretsSlotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppBackupStatusSecretsSlotResult>("azure-nextgen:web/latest:listWebAppBackupStatusSecretsSlot", args ?? new ListWebAppBackupStatusSecretsSlotArgs(), options.WithVersion());
    }


    public sealed class ListWebAppBackupStatusSecretsSlotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of backup.
        /// </summary>
        [Input("backupId", required: true)]
        public string BackupId { get; set; } = null!;

        /// <summary>
        /// Name of the backup.
        /// </summary>
        [Input("backupName")]
        public string? BackupName { get; set; }

        /// <summary>
        /// Schedule for the backup if it is executed periodically.
        /// </summary>
        [Input("backupSchedule")]
        public Inputs.BackupScheduleArgs? BackupSchedule { get; set; }

        [Input("databases")]
        private List<Inputs.DatabaseBackupSettingArgs>? _databases;

        /// <summary>
        /// Databases included in the backup.
        /// </summary>
        public List<Inputs.DatabaseBackupSettingArgs> Databases
        {
            get => _databases ?? (_databases = new List<Inputs.DatabaseBackupSettingArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
        /// </summary>
        [Input("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Name of web app.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of web app slot. If not specified then will default to production slot.
        /// </summary>
        [Input("slot", required: true)]
        public string Slot { get; set; } = null!;

        /// <summary>
        /// SAS URL to the container.
        /// </summary>
        [Input("storageAccountUrl", required: true)]
        public string StorageAccountUrl { get; set; } = null!;

        public ListWebAppBackupStatusSecretsSlotArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppBackupStatusSecretsSlotResult
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
        public readonly ImmutableArray<Outputs.DatabaseBackupSettingResponseResult> Databases;
        /// <summary>
        /// Timestamp when this backup finished.
        /// </summary>
        public readonly string FinishedTimeStamp;
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
        public readonly int SizeInBytes;
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
        public readonly int WebsiteSizeInBytes;

        [OutputConstructor]
        private ListWebAppBackupStatusSecretsSlotResult(
            int backupId,

            string blobName,

            string correlationId,

            string created,

            ImmutableArray<Outputs.DatabaseBackupSettingResponseResult> databases,

            string finishedTimeStamp,

            string? kind,

            string lastRestoreTimeStamp,

            string log,

            string name,

            bool scheduled,

            int sizeInBytes,

            string status,

            string storageAccountUrl,

            Outputs.SystemDataResponse systemData,

            string type,

            int websiteSizeInBytes)
        {
            BackupId = backupId;
            BlobName = blobName;
            CorrelationId = correlationId;
            Created = created;
            Databases = databases;
            FinishedTimeStamp = finishedTimeStamp;
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
