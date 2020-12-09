// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class SkuDescriptionResponse
    {
        /// <summary>
        /// Capabilities of the SKU, e.g., is traffic manager enabled?
        /// </summary>
        public readonly ImmutableArray<Outputs.CapabilityResponse> Capabilities;
        /// <summary>
        /// Current number of instances assigned to the resource.
        /// </summary>
        public readonly int? Capacity;
        /// <summary>
        /// Family code of the resource SKU.
        /// </summary>
        public readonly string? Family;
        /// <summary>
        /// Locations of the SKU.
        /// </summary>
        public readonly ImmutableArray<string> Locations;
        /// <summary>
        /// Name of the resource SKU.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Size specifier of the resource SKU.
        /// </summary>
        public readonly string? Size;
        /// <summary>
        /// Min, max, and default scale values of the SKU.
        /// </summary>
        public readonly Outputs.SkuCapacityResponse? SkuCapacity;
        /// <summary>
        /// Service tier of the resource SKU.
        /// </summary>
        public readonly string? Tier;

        [OutputConstructor]
        private SkuDescriptionResponse(
            ImmutableArray<Outputs.CapabilityResponse> capabilities,

            int? capacity,

            string? family,

            ImmutableArray<string> locations,

            string? name,

            string? size,

            Outputs.SkuCapacityResponse? skuCapacity,

            string? tier)
        {
            Capabilities = capabilities;
            Capacity = capacity;
            Family = family;
            Locations = locations;
            Name = name;
            Size = size;
            SkuCapacity = skuCapacity;
            Tier = tier;
        }
    }
}
