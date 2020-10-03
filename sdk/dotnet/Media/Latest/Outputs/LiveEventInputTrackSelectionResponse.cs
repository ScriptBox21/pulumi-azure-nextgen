// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest.Outputs
{

    [OutputType]
    public sealed class LiveEventInputTrackSelectionResponse
    {
        /// <summary>
        /// Comparing operation. This property is reserved for future use, any value set on this property will be ignored.
        /// </summary>
        public readonly string? Operation;
        /// <summary>
        /// Property name to select. This property is reserved for future use, any value set on this property will be ignored.
        /// </summary>
        public readonly string? Property;
        /// <summary>
        /// Property value to select. This property is reserved for future use, any value set on this property will be ignored.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private LiveEventInputTrackSelectionResponse(
            string? operation,

            string? property,

            string? value)
        {
            Operation = operation;
            Property = property;
            Value = value;
        }
    }
}
