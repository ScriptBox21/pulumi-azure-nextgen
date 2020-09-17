// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20150615.Outputs
{

    [OutputType]
    public sealed class EndpointsResponse
    {
        /// <summary>
        /// The blob endpoint.
        /// </summary>
        public readonly string? Blob;
        /// <summary>
        /// The file endpoint.
        /// </summary>
        public readonly string? File;
        /// <summary>
        /// The queue endpoint.
        /// </summary>
        public readonly string? Queue;
        /// <summary>
        /// The table endpoint.
        /// </summary>
        public readonly string? Table;

        [OutputConstructor]
        private EndpointsResponse(
            string? blob,

            string? file,

            string? queue,

            string? table)
        {
            Blob = blob;
            File = file;
            Queue = queue;
            Table = table;
        }
    }
}