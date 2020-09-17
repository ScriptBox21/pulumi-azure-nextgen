// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Batch.V20200501.Outputs
{

    [OutputType]
    public sealed class DiskEncryptionConfigurationResponse
    {
        /// <summary>
        /// On Linux pool, only "TemporaryDisk" is supported; on Windows pool, "OsDisk" and "TemporaryDisk" must be specified.
        /// </summary>
        public readonly ImmutableArray<string> Targets;

        [OutputConstructor]
        private DiskEncryptionConfigurationResponse(ImmutableArray<string> targets)
        {
            Targets = targets;
        }
    }
}