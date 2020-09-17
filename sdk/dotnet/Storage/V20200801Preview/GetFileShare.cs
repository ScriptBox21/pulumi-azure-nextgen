// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20200801Preview
{
    public static class GetFileShare
    {
        public static Task<GetFileShareResult> InvokeAsync(GetFileShareArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFileShareResult>("azure-nextgen:storage/v20200801preview:getFileShare", args ?? new GetFileShareArgs(), options.WithVersion());
    }


    public sealed class GetFileShareArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// Optional, used to expand the properties within share's properties.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the file share within the specified storage account. File share names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
        /// </summary>
        [Input("shareName", required: true)]
        public string ShareName { get; set; } = null!;

        public GetFileShareArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFileShareResult
    {
        /// <summary>
        /// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
        /// </summary>
        public readonly string? AccessTier;
        /// <summary>
        /// Indicates the last modification time for share access tier.
        /// </summary>
        public readonly string AccessTierChangeTime;
        /// <summary>
        /// Indicates if there is a pending transition for access tier.
        /// </summary>
        public readonly string AccessTierStatus;
        /// <summary>
        /// Indicates whether the share was deleted.
        /// </summary>
        public readonly bool Deleted;
        /// <summary>
        /// The deleted time if the share was deleted.
        /// </summary>
        public readonly string DeletedTime;
        /// <summary>
        /// The authentication protocol that is used for the file share. Can only be specified when creating a share.
        /// </summary>
        public readonly string? EnabledProtocols;
        /// <summary>
        /// Resource Etag.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Returns the date and time the share was last modified.
        /// </summary>
        public readonly string LastModifiedTime;
        /// <summary>
        /// A name-value pair to associate with the share as metadata.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Metadata;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Remaining retention days for share that was soft deleted.
        /// </summary>
        public readonly int RemainingRetentionDays;
        /// <summary>
        /// The property is for NFS share only. The default is NoRootSquash.
        /// </summary>
        public readonly string? RootSquash;
        /// <summary>
        /// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
        /// </summary>
        public readonly int? ShareQuota;
        /// <summary>
        /// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
        /// </summary>
        public readonly int ShareUsageBytes;
        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The version of the share.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private GetFileShareResult(
            string? accessTier,

            string accessTierChangeTime,

            string accessTierStatus,

            bool deleted,

            string deletedTime,

            string? enabledProtocols,

            string etag,

            string lastModifiedTime,

            ImmutableDictionary<string, string>? metadata,

            string name,

            int remainingRetentionDays,

            string? rootSquash,

            int? shareQuota,

            int shareUsageBytes,

            string type,

            string version)
        {
            AccessTier = accessTier;
            AccessTierChangeTime = accessTierChangeTime;
            AccessTierStatus = accessTierStatus;
            Deleted = deleted;
            DeletedTime = deletedTime;
            EnabledProtocols = enabledProtocols;
            Etag = etag;
            LastModifiedTime = lastModifiedTime;
            Metadata = metadata;
            Name = name;
            RemainingRetentionDays = remainingRetentionDays;
            RootSquash = rootSquash;
            ShareQuota = shareQuota;
            ShareUsageBytes = shareUsageBytes;
            Type = type;
            Version = version;
        }
    }
}