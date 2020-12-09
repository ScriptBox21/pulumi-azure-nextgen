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
    public sealed class ManagedCertificateParametersResponse
    {
        /// <summary>
        /// Certificate expiration date.
        /// </summary>
        public readonly string? ExpirationDate;
        /// <summary>
        /// Subject name in the certificate.
        /// </summary>
        public readonly string? Subject;
        /// <summary>
        /// Certificate thumbprint.
        /// </summary>
        public readonly string? Thumbprint;
        /// <summary>
        /// The type of the Secret to create.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ManagedCertificateParametersResponse(
            string? expirationDate,

            string? subject,

            string? thumbprint,

            string type)
        {
            ExpirationDate = expirationDate;
            Subject = subject;
            Thumbprint = thumbprint;
            Type = type;
        }
    }
}
