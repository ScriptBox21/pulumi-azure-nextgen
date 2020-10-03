// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200801.Outputs
{

    [OutputType]
    public sealed class ComputeInstanceLastOperationResponse
    {
        /// <summary>
        /// Name of the last operation.
        /// </summary>
        public readonly string? OperationName;
        /// <summary>
        /// Operation status.
        /// </summary>
        public readonly string? OperationStatus;
        /// <summary>
        /// Time of the last operation.
        /// </summary>
        public readonly string? OperationTime;

        [OutputConstructor]
        private ComputeInstanceLastOperationResponse(
            string? operationName,

            string? operationStatus,

            string? operationTime)
        {
            OperationName = operationName;
            OperationStatus = operationStatus;
            OperationTime = operationTime;
        }
    }
}
