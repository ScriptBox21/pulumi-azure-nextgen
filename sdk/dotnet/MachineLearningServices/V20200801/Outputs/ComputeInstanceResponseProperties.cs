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
    public sealed class ComputeInstanceResponseProperties
    {
        /// <summary>
        /// Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role.
        /// </summary>
        public readonly string? ApplicationSharingPolicy;
        /// <summary>
        /// Describes available applications and their endpoints on this ComputeInstance.
        /// </summary>
        public readonly ImmutableArray<Outputs.ComputeInstanceApplicationResponse> Applications;
        /// <summary>
        /// Describes all connectivity endpoints available for this ComputeInstance.
        /// </summary>
        public readonly Outputs.ComputeInstanceConnectivityEndpointsResponse ConnectivityEndpoints;
        /// <summary>
        /// Describes information on user who created this ComputeInstance.
        /// </summary>
        public readonly Outputs.ComputeInstanceCreatedByResponse CreatedBy;
        /// <summary>
        /// Collection of errors encountered on this ComputeInstance.
        /// </summary>
        public readonly ImmutableArray<Outputs.MachineLearningServiceErrorResponse> Errors;
        /// <summary>
        /// The last operation on ComputeInstance.
        /// </summary>
        public readonly Outputs.ComputeInstanceLastOperationResponse LastOperation;
        /// <summary>
        /// Specifies policy and settings for SSH access.
        /// </summary>
        public readonly Outputs.ComputeInstanceSshSettingsResponse? SshSettings;
        /// <summary>
        /// The current state of this ComputeInstance.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Virtual network subnet resource ID the compute nodes belong to.
        /// </summary>
        public readonly Outputs.ResourceIdResponse? Subnet;
        /// <summary>
        /// Virtual Machine Size
        /// </summary>
        public readonly string? VmSize;

        [OutputConstructor]
        private ComputeInstanceResponseProperties(
            string? applicationSharingPolicy,

            ImmutableArray<Outputs.ComputeInstanceApplicationResponse> applications,

            Outputs.ComputeInstanceConnectivityEndpointsResponse connectivityEndpoints,

            Outputs.ComputeInstanceCreatedByResponse createdBy,

            ImmutableArray<Outputs.MachineLearningServiceErrorResponse> errors,

            Outputs.ComputeInstanceLastOperationResponse lastOperation,

            Outputs.ComputeInstanceSshSettingsResponse? sshSettings,

            string state,

            Outputs.ResourceIdResponse? subnet,

            string? vmSize)
        {
            ApplicationSharingPolicy = applicationSharingPolicy;
            Applications = applications;
            ConnectivityEndpoints = connectivityEndpoints;
            CreatedBy = createdBy;
            Errors = errors;
            LastOperation = lastOperation;
            SshSettings = sshSettings;
            State = state;
            Subnet = subnet;
            VmSize = vmSize;
        }
    }
}
