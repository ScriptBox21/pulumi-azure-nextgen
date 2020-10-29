// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20180701
{
    public static class GetStorageAccount
    {
        public static Task<GetStorageAccountResult> InvokeAsync(GetStorageAccountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStorageAccountResult>("azure-nextgen:storage/v20180701:getStorageAccount", args ?? new GetStorageAccountArgs(), options.WithVersion());
    }


    public sealed class GetStorageAccountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// May be used to expand the properties within account's properties. By default, data is not included when fetching properties. Currently we only support geoReplicationStats.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetStorageAccountArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStorageAccountResult
    {
        /// <summary>
        /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
        /// </summary>
        public readonly string AccessTier;
        /// <summary>
        /// Gets the creation date and time of the storage account in UTC.
        /// </summary>
        public readonly string CreationTime;
        /// <summary>
        /// Gets the custom domain the user assigned to this storage account.
        /// </summary>
        public readonly Outputs.CustomDomainResponse CustomDomain;
        /// <summary>
        /// Enables Azure Files AAD Integration for SMB if sets to true.
        /// </summary>
        public readonly bool? EnableAzureFilesAadIntegration;
        /// <summary>
        /// Allows https traffic only to storage service if sets to true.
        /// </summary>
        public readonly bool? EnableHttpsTrafficOnly;
        /// <summary>
        /// Gets the encryption settings on the account. If unspecified, the account is unencrypted.
        /// </summary>
        public readonly Outputs.EncryptionResponse Encryption;
        /// <summary>
        /// If the failover is in progress, the value will be true, otherwise, it will be null.
        /// </summary>
        public readonly bool FailoverInProgress;
        /// <summary>
        /// Geo Replication Stats
        /// </summary>
        public readonly Outputs.GeoReplicationStatsResponse GeoReplicationStats;
        /// <summary>
        /// The identity of the resource.
        /// </summary>
        public readonly Outputs.IdentityResponse? Identity;
        /// <summary>
        /// Account HierarchicalNamespace enabled if sets to true.
        /// </summary>
        public readonly bool? IsHnsEnabled;
        /// <summary>
        /// Gets the Kind.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
        /// </summary>
        public readonly string LastGeoFailoverTime;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Network rule set
        /// </summary>
        public readonly Outputs.NetworkRuleSetResponse NetworkRuleSet;
        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
        /// </summary>
        public readonly Outputs.EndpointsResponse PrimaryEndpoints;
        /// <summary>
        /// Gets the location of the primary data center for the storage account.
        /// </summary>
        public readonly string PrimaryLocation;
        /// <summary>
        /// Gets the status of the storage account at the time the operation was called.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
        /// </summary>
        public readonly Outputs.EndpointsResponse SecondaryEndpoints;
        /// <summary>
        /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
        /// </summary>
        public readonly string SecondaryLocation;
        /// <summary>
        /// Gets the SKU.
        /// </summary>
        public readonly Outputs.SkuResponse Sku;
        /// <summary>
        /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
        /// </summary>
        public readonly string StatusOfPrimary;
        /// <summary>
        /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
        /// </summary>
        public readonly string StatusOfSecondary;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetStorageAccountResult(
            string accessTier,

            string creationTime,

            Outputs.CustomDomainResponse customDomain,

            bool? enableAzureFilesAadIntegration,

            bool? enableHttpsTrafficOnly,

            Outputs.EncryptionResponse encryption,

            bool failoverInProgress,

            Outputs.GeoReplicationStatsResponse geoReplicationStats,

            Outputs.IdentityResponse? identity,

            bool? isHnsEnabled,

            string kind,

            string lastGeoFailoverTime,

            string location,

            string name,

            Outputs.NetworkRuleSetResponse networkRuleSet,

            Outputs.EndpointsResponse primaryEndpoints,

            string primaryLocation,

            string provisioningState,

            Outputs.EndpointsResponse secondaryEndpoints,

            string secondaryLocation,

            Outputs.SkuResponse sku,

            string statusOfPrimary,

            string statusOfSecondary,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            AccessTier = accessTier;
            CreationTime = creationTime;
            CustomDomain = customDomain;
            EnableAzureFilesAadIntegration = enableAzureFilesAadIntegration;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            Encryption = encryption;
            FailoverInProgress = failoverInProgress;
            GeoReplicationStats = geoReplicationStats;
            Identity = identity;
            IsHnsEnabled = isHnsEnabled;
            Kind = kind;
            LastGeoFailoverTime = lastGeoFailoverTime;
            Location = location;
            Name = name;
            NetworkRuleSet = networkRuleSet;
            PrimaryEndpoints = primaryEndpoints;
            PrimaryLocation = primaryLocation;
            ProvisioningState = provisioningState;
            SecondaryEndpoints = secondaryEndpoints;
            SecondaryLocation = secondaryLocation;
            Sku = sku;
            StatusOfPrimary = statusOfPrimary;
            StatusOfSecondary = statusOfSecondary;
            Tags = tags;
            Type = type;
        }
    }
}
