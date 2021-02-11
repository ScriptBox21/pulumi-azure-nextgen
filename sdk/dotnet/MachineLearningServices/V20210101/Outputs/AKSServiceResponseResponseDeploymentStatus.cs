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
    public sealed class AKSServiceResponseResponseDeploymentStatus
    {
        /// <summary>
        /// The number of available replicas.
        /// </summary>
        public readonly int? AvailableReplicas;
        /// <summary>
        /// The desired number of replicas.
        /// </summary>
        public readonly int? DesiredReplicas;
        /// <summary>
        /// The error details.
        /// </summary>
        public readonly Outputs.AKSReplicaStatusResponseError? Error;
        /// <summary>
        /// The number of updated replicas.
        /// </summary>
        public readonly int? UpdatedReplicas;

        [OutputConstructor]
        private AKSServiceResponseResponseDeploymentStatus(
            int? availableReplicas,

            int? desiredReplicas,

            Outputs.AKSReplicaStatusResponseError? error,

            int? updatedReplicas)
        {
            AvailableReplicas = availableReplicas;
            DesiredReplicas = desiredReplicas;
            Error = error;
            UpdatedReplicas = updatedReplicas;
        }
    }
}
