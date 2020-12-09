// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.Latest.Outputs
{

    [OutputType]
    public sealed class UrlSigningKeyParametersResponse
    {
        /// <summary>
        /// Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash.
        /// </summary>
        public readonly string KeyId;
        /// <summary>
        /// Resource reference to the KV secret
        /// </summary>
        public readonly Outputs.ResourceReferenceResponse SecretSource;
        /// <summary>
        /// Version of the secret to be used
        /// </summary>
        public readonly string? SecretVersion;
        /// <summary>
        /// The type of the Secret to create.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private UrlSigningKeyParametersResponse(
            string keyId,

            Outputs.ResourceReferenceResponse secretSource,

            string? secretVersion,

            string type)
        {
            KeyId = keyId;
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            Type = type;
        }
    }
}
