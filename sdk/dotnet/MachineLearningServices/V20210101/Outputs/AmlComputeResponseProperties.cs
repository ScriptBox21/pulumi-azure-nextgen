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
    public sealed class AmlComputeResponseProperties
    {
        /// <summary>
        /// Allocation state of the compute. Possible values are: steady - Indicates that the compute is not resizing. There are no changes to the number of compute nodes in the compute in progress. A compute enters this state when it is created and when no operations are being performed on the compute to change the number of compute nodes. resizing - Indicates that the compute is resizing; that is, compute nodes are being added to or removed from the compute.
        /// </summary>
        public readonly string AllocationState;
        /// <summary>
        /// The time at which the compute entered its current allocation state.
        /// </summary>
        public readonly string AllocationStateTransitionTime;
        /// <summary>
        /// The number of compute nodes currently assigned to the compute.
        /// </summary>
        public readonly int CurrentNodeCount;
        /// <summary>
        /// Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs.
        /// </summary>
        public readonly bool? EnableNodePublicIp;
        /// <summary>
        /// Collection of errors encountered by various compute nodes during node setup.
        /// </summary>
        public readonly ImmutableArray<Outputs.MachineLearningServiceErrorResponse> Errors;
        /// <summary>
        /// Network is isolated or not
        /// </summary>
        public readonly bool? IsolatedNetwork;
        /// <summary>
        /// Counts of various node states on the compute.
        /// </summary>
        public readonly Outputs.NodeStateCountsResponse NodeStateCounts;
        /// <summary>
        /// Compute OS Type
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined, else is open all public nodes. It can be default only during cluster creation time, after creation it will be either enabled or disabled.
        /// </summary>
        public readonly string? RemoteLoginPortPublicAccess;
        /// <summary>
        /// Scale settings for AML Compute
        /// </summary>
        public readonly Outputs.ScaleSettingsResponse? ScaleSettings;
        /// <summary>
        /// Virtual network subnet resource ID the compute nodes belong to.
        /// </summary>
        public readonly Outputs.ResourceIdResponse? Subnet;
        /// <summary>
        /// The target number of compute nodes for the compute. If the allocationState is resizing, this property denotes the target node count for the ongoing resize operation. If the allocationState is steady, this property denotes the target node count for the previous resize operation.
        /// </summary>
        public readonly int TargetNodeCount;
        /// <summary>
        /// Credentials for an administrator user account that will be created on each compute node.
        /// </summary>
        public readonly Outputs.UserAccountCredentialsResponse? UserAccountCredentials;
        /// <summary>
        /// Virtual Machine image for AML Compute - windows only
        /// </summary>
        public readonly Outputs.VirtualMachineImageResponse? VirtualMachineImage;
        /// <summary>
        /// Virtual Machine priority
        /// </summary>
        public readonly string? VmPriority;
        /// <summary>
        /// Virtual Machine Size
        /// </summary>
        public readonly string? VmSize;

        [OutputConstructor]
        private AmlComputeResponseProperties(
            string allocationState,

            string allocationStateTransitionTime,

            int currentNodeCount,

            bool? enableNodePublicIp,

            ImmutableArray<Outputs.MachineLearningServiceErrorResponse> errors,

            bool? isolatedNetwork,

            Outputs.NodeStateCountsResponse nodeStateCounts,

            string? osType,

            string? remoteLoginPortPublicAccess,

            Outputs.ScaleSettingsResponse? scaleSettings,

            Outputs.ResourceIdResponse? subnet,

            int targetNodeCount,

            Outputs.UserAccountCredentialsResponse? userAccountCredentials,

            Outputs.VirtualMachineImageResponse? virtualMachineImage,

            string? vmPriority,

            string? vmSize)
        {
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            CurrentNodeCount = currentNodeCount;
            EnableNodePublicIp = enableNodePublicIp;
            Errors = errors;
            IsolatedNetwork = isolatedNetwork;
            NodeStateCounts = nodeStateCounts;
            OsType = osType;
            RemoteLoginPortPublicAccess = remoteLoginPortPublicAccess;
            ScaleSettings = scaleSettings;
            Subnet = subnet;
            TargetNodeCount = targetNodeCount;
            UserAccountCredentials = userAccountCredentials;
            VirtualMachineImage = virtualMachineImage;
            VmPriority = vmPriority;
            VmSize = vmSize;
        }
    }
}
