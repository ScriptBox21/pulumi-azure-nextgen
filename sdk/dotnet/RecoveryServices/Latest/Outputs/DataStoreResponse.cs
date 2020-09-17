// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.Latest.Outputs
{

    [OutputType]
    public sealed class DataStoreResponse
    {
        /// <summary>
        /// The capacity of data store in GBs.
        /// </summary>
        public readonly string? Capacity;
        /// <summary>
        /// The free space of data store in GBs.
        /// </summary>
        public readonly string? FreeSpace;
        /// <summary>
        /// The symbolic name of data store.
        /// </summary>
        public readonly string? SymbolicName;
        /// <summary>
        /// The type of data store.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// The uuid of data store.
        /// </summary>
        public readonly string? Uuid;

        [OutputConstructor]
        private DataStoreResponse(
            string? capacity,

            string? freeSpace,

            string? symbolicName,

            string? type,

            string? uuid)
        {
            Capacity = capacity;
            FreeSpace = freeSpace;
            SymbolicName = symbolicName;
            Type = type;
            Uuid = uuid;
        }
    }
}