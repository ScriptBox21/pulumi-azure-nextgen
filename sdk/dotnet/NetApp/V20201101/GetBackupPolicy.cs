// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20201101
{
    public static class GetBackupPolicy
    {
        public static Task<GetBackupPolicyResult> InvokeAsync(GetBackupPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBackupPolicyResult>("azure-nextgen:netapp/v20201101:getBackupPolicy", args ?? new GetBackupPolicyArgs(), options.WithVersion());
    }


    public sealed class GetBackupPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// Backup policy Name which uniquely identify backup policy.
        /// </summary>
        [Input("backupPolicyName", required: true)]
        public string BackupPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetBackupPolicyArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBackupPolicyResult
    {
        /// <summary>
        /// Daily backups count to keep
        /// </summary>
        public readonly int? DailyBackupsToKeep;
        /// <summary>
        /// The property to decide policy is enabled or not
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Monthly backups count to keep
        /// </summary>
        public readonly int? MonthlyBackupsToKeep;
        /// <summary>
        /// Name of backup policy
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Azure lifecycle management
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// A list of volumes assigned to this policy
        /// </summary>
        public readonly ImmutableArray<Outputs.VolumeBackupsResponse> VolumeBackups;
        /// <summary>
        /// Volumes using current backup policy
        /// </summary>
        public readonly int? VolumesAssigned;
        /// <summary>
        /// Weekly backups count to keep
        /// </summary>
        public readonly int? WeeklyBackupsToKeep;
        /// <summary>
        /// Yearly backups count to keep
        /// </summary>
        public readonly int? YearlyBackupsToKeep;

        [OutputConstructor]
        private GetBackupPolicyResult(
            int? dailyBackupsToKeep,

            bool? enabled,

            string id,

            string location,

            int? monthlyBackupsToKeep,

            string name,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<Outputs.VolumeBackupsResponse> volumeBackups,

            int? volumesAssigned,

            int? weeklyBackupsToKeep,

            int? yearlyBackupsToKeep)
        {
            DailyBackupsToKeep = dailyBackupsToKeep;
            Enabled = enabled;
            Id = id;
            Location = location;
            MonthlyBackupsToKeep = monthlyBackupsToKeep;
            Name = name;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            VolumeBackups = volumeBackups;
            VolumesAssigned = volumesAssigned;
            WeeklyBackupsToKeep = weeklyBackupsToKeep;
            YearlyBackupsToKeep = yearlyBackupsToKeep;
        }
    }
}
