// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.PowerPlatform.V20201030Preview.Outputs
{

    [OutputType]
    public sealed class EnterprisePolicyIdentityResponseLockbox
    {
        /// <summary>
        /// lockbox configuration
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private EnterprisePolicyIdentityResponseLockbox(string? status)
        {
            Status = status;
        }
    }
}
