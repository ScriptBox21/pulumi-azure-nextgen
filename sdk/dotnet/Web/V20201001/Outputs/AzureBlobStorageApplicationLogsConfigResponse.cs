// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001.Outputs
{

    [OutputType]
    public sealed class AzureBlobStorageApplicationLogsConfigResponse
    {
        /// <summary>
        /// Log level.
        /// </summary>
        public readonly string? Level;
        /// <summary>
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        public readonly int? RetentionInDays;
        /// <summary>
        /// SAS url to a azure blob container with read/write/list/delete permissions.
        /// </summary>
        public readonly string? SasUrl;

        [OutputConstructor]
        private AzureBlobStorageApplicationLogsConfigResponse(
            string? level,

            int? retentionInDays,

            string? sasUrl)
        {
            Level = level;
            RetentionInDays = retentionInDays;
            SasUrl = sasUrl;
        }
    }
}
