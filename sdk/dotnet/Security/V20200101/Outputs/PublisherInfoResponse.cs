// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Security.V20200101.Outputs
{

    [OutputType]
    public sealed class PublisherInfoResponse
    {
        /// <summary>
        /// The "OriginalName" field taken from the file's version resource
        /// </summary>
        public readonly string? BinaryName;
        /// <summary>
        /// The product name taken from the file's version resource
        /// </summary>
        public readonly string? ProductName;
        /// <summary>
        /// The Subject field of the x.509 certificate used to sign the code, using the following fields -  O = Organization, L = Locality, S = State or Province, and C = Country
        /// </summary>
        public readonly string? PublisherName;
        /// <summary>
        /// The binary file version taken from the file's version resource
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private PublisherInfoResponse(
            string? binaryName,

            string? productName,

            string? publisherName,

            string? version)
        {
            BinaryName = binaryName;
            ProductName = productName;
            PublisherName = publisherName;
            Version = version;
        }
    }
}