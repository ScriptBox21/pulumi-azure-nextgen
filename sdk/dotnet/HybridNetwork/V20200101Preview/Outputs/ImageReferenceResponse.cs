// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridNetwork.V20200101Preview.Outputs
{

    [OutputType]
    public sealed class ImageReferenceResponse
    {
        /// <summary>
        /// Specifies in decimal numbers, the exact version of image used to create the virtual machine.
        /// </summary>
        public readonly string? ExactVersion;
        /// <summary>
        /// Specifies the offer of the image used to create the virtual machine.
        /// </summary>
        public readonly string? Offer;
        /// <summary>
        /// The image publisher.
        /// </summary>
        public readonly string? Publisher;
        /// <summary>
        /// The image SKU.
        /// </summary>
        public readonly string? Sku;
        /// <summary>
        /// Specifies the version of the image used to create the virtual machine. The allowed formats are Major.Minor.Build or 'latest'. Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest version of an image available at deploy time. Even if you use 'latest', the VM image will not automatically update after deploy time even if a new version becomes available.
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private ImageReferenceResponse(
            string? exactVersion,

            string? offer,

            string? publisher,

            string? sku,

            string? version)
        {
            ExactVersion = exactVersion;
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Version = version;
        }
    }
}
