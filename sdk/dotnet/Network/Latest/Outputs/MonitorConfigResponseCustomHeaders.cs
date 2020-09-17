// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest.Outputs
{

    [OutputType]
    public sealed class MonitorConfigResponseCustomHeaders
    {
        /// <summary>
        /// Header name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Header value.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private MonitorConfigResponseCustomHeaders(
            string? name,

            string? value)
        {
            Name = name;
            Value = value;
        }
    }
}