// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabricMesh.V20180701Preview.Outputs
{

    [OutputType]
    public sealed class VolumeProviderParametersAzureFileResponse
    {
        /// <summary>
        /// Access key of the Azure storage account for the File Share.
        /// </summary>
        public readonly string? AccountKey;
        /// <summary>
        /// Name of the Azure storage account for the File Share.
        /// </summary>
        public readonly string AccountName;
        /// <summary>
        /// Name of the Azure Files file share that provides storage for the volume.
        /// </summary>
        public readonly string ShareName;

        [OutputConstructor]
        private VolumeProviderParametersAzureFileResponse(
            string? accountKey,

            string accountName,

            string shareName)
        {
            AccountKey = accountKey;
            AccountName = accountName;
            ShareName = shareName;
        }
    }
}