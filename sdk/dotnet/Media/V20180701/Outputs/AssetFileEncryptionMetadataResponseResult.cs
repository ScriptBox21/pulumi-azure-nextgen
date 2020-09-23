// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180701.Outputs
{

    [OutputType]
    public sealed class AssetFileEncryptionMetadataResponseResult
    {
        /// <summary>
        /// The Asset File Id.
        /// </summary>
        public readonly string AssetFileId;
        /// <summary>
        /// The Asset File name.
        /// </summary>
        public readonly string? AssetFileName;
        /// <summary>
        /// The Asset File initialization vector.
        /// </summary>
        public readonly string? InitializationVector;

        [OutputConstructor]
        private AssetFileEncryptionMetadataResponseResult(
            string assetFileId,

            string? assetFileName,

            string? initializationVector)
        {
            AssetFileId = assetFileId;
            AssetFileName = assetFileName;
            InitializationVector = initializationVector;
        }
    }
}
