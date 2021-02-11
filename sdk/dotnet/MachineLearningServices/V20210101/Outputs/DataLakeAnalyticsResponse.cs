// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20210101.Outputs
{

    [OutputType]
    public sealed class DataLakeAnalyticsResponse
    {
        /// <summary>
        /// Location for the underlying compute
        /// </summary>
        public readonly string? ComputeLocation;
        /// <summary>
        /// The type of compute
        /// Expected value is 'DataLakeAnalytics'.
        /// </summary>
        public readonly string ComputeType;
        /// <summary>
        /// The description of the Machine Learning compute.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned it if false.
        /// </summary>
        public readonly bool IsAttachedCompute;
        public readonly Outputs.DataLakeAnalyticsResponseProperties? Properties;
        /// <summary>
        /// Errors during provisioning
        /// </summary>
        public readonly ImmutableArray<Outputs.MachineLearningServiceErrorResponse> ProvisioningErrors;
        /// <summary>
        /// The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// ARM resource id of the underlying compute
        /// </summary>
        public readonly string? ResourceId;

        [OutputConstructor]
        private DataLakeAnalyticsResponse(
            string? computeLocation,

            string computeType,

            string? description,

            bool isAttachedCompute,

            Outputs.DataLakeAnalyticsResponseProperties? properties,

            ImmutableArray<Outputs.MachineLearningServiceErrorResponse> provisioningErrors,

            string provisioningState,

            string? resourceId)
        {
            ComputeLocation = computeLocation;
            ComputeType = computeType;
            Description = description;
            IsAttachedCompute = isAttachedCompute;
            Properties = properties;
            ProvisioningErrors = provisioningErrors;
            ProvisioningState = provisioningState;
            ResourceId = resourceId;
        }
    }
}
