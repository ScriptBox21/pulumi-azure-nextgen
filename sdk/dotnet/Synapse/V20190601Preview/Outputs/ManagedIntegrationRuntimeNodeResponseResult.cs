// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20190601Preview.Outputs
{

    [OutputType]
    public sealed class ManagedIntegrationRuntimeNodeResponseResult
    {
        /// <summary>
        /// The errors that occurred on this integration runtime node.
        /// </summary>
        public readonly ImmutableArray<Outputs.ManagedIntegrationRuntimeErrorResponseResult> Errors;
        /// <summary>
        /// The managed integration runtime node id.
        /// </summary>
        public readonly string NodeId;
        /// <summary>
        /// The managed integration runtime node status.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private ManagedIntegrationRuntimeNodeResponseResult(
            ImmutableArray<Outputs.ManagedIntegrationRuntimeErrorResponseResult> errors,

            string nodeId,

            string status)
        {
            Errors = errors;
            NodeId = nodeId;
            Status = status;
        }
    }
}
