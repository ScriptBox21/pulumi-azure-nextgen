// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201201.Outputs
{

    [OutputType]
    public sealed class DiskInstanceViewResponse
    {
        /// <summary>
        /// Specifies the encryption settings for the OS Disk. &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15
        /// </summary>
        public readonly ImmutableArray<Outputs.DiskEncryptionSettingsResponse> EncryptionSettings;
        /// <summary>
        /// The disk name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The resource status information.
        /// </summary>
        public readonly ImmutableArray<Outputs.InstanceViewStatusResponse> Statuses;

        [OutputConstructor]
        private DiskInstanceViewResponse(
            ImmutableArray<Outputs.DiskEncryptionSettingsResponse> encryptionSettings,

            string? name,

            ImmutableArray<Outputs.InstanceViewStatusResponse> statuses)
        {
            EncryptionSettings = encryptionSettings;
            Name = name;
            Statuses = statuses;
        }
    }
}
