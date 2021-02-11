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
    public sealed class SkuCapacityResponse
    {
        /// <summary>
        /// Default number of workers for this App Service plan SKU.
        /// </summary>
        public readonly int? Default;
        /// <summary>
        /// Maximum number of workers for this App Service plan SKU.
        /// </summary>
        public readonly int? Maximum;
        /// <summary>
        /// Minimum number of workers for this App Service plan SKU.
        /// </summary>
        public readonly int? Minimum;
        /// <summary>
        /// Available scale configurations for an App Service plan.
        /// </summary>
        public readonly string? ScaleType;

        [OutputConstructor]
        private SkuCapacityResponse(
            int? @default,

            int? maximum,

            int? minimum,

            string? scaleType)
        {
            Default = @default;
            Maximum = maximum;
            Minimum = minimum;
            ScaleType = scaleType;
        }
    }
}
