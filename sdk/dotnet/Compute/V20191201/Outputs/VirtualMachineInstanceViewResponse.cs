// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20191201.Outputs
{

    [OutputType]
    public sealed class VirtualMachineInstanceViewResponse
    {
        /// <summary>
        /// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor.
        /// </summary>
        public readonly Outputs.BootDiagnosticsInstanceViewResponse? BootDiagnostics;
        /// <summary>
        /// The computer name assigned to the virtual machine.
        /// </summary>
        public readonly string? ComputerName;
        /// <summary>
        /// The virtual machine disk information.
        /// </summary>
        public readonly ImmutableArray<Outputs.DiskInstanceViewResponse> Disks;
        /// <summary>
        /// The extensions information.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualMachineExtensionInstanceViewResponse> Extensions;
        /// <summary>
        /// Specifies the HyperVGeneration Type associated with a resource
        /// </summary>
        public readonly string? HyperVGeneration;
        /// <summary>
        /// The Maintenance Operation status on the virtual machine.
        /// </summary>
        public readonly Outputs.MaintenanceRedeployStatusResponse? MaintenanceRedeployStatus;
        /// <summary>
        /// The Operating System running on the virtual machine.
        /// </summary>
        public readonly string? OsName;
        /// <summary>
        /// The version of Operating System running on the virtual machine.
        /// </summary>
        public readonly string? OsVersion;
        /// <summary>
        /// Specifies the fault domain of the virtual machine.
        /// </summary>
        public readonly int? PlatformFaultDomain;
        /// <summary>
        /// Specifies the update domain of the virtual machine.
        /// </summary>
        public readonly int? PlatformUpdateDomain;
        /// <summary>
        /// The Remote desktop certificate thumbprint.
        /// </summary>
        public readonly string? RdpThumbPrint;
        /// <summary>
        /// The resource status information.
        /// </summary>
        public readonly ImmutableArray<Outputs.InstanceViewStatusResponse> Statuses;
        /// <summary>
        /// The VM Agent running on the virtual machine.
        /// </summary>
        public readonly Outputs.VirtualMachineAgentInstanceViewResponse? VmAgent;

        [OutputConstructor]
        private VirtualMachineInstanceViewResponse(
            Outputs.BootDiagnosticsInstanceViewResponse? bootDiagnostics,

            string? computerName,

            ImmutableArray<Outputs.DiskInstanceViewResponse> disks,

            ImmutableArray<Outputs.VirtualMachineExtensionInstanceViewResponse> extensions,

            string? hyperVGeneration,

            Outputs.MaintenanceRedeployStatusResponse? maintenanceRedeployStatus,

            string? osName,

            string? osVersion,

            int? platformFaultDomain,

            int? platformUpdateDomain,

            string? rdpThumbPrint,

            ImmutableArray<Outputs.InstanceViewStatusResponse> statuses,

            Outputs.VirtualMachineAgentInstanceViewResponse? vmAgent)
        {
            BootDiagnostics = bootDiagnostics;
            ComputerName = computerName;
            Disks = disks;
            Extensions = extensions;
            HyperVGeneration = hyperVGeneration;
            MaintenanceRedeployStatus = maintenanceRedeployStatus;
            OsName = osName;
            OsVersion = osVersion;
            PlatformFaultDomain = platformFaultDomain;
            PlatformUpdateDomain = platformUpdateDomain;
            RdpThumbPrint = rdpThumbPrint;
            Statuses = statuses;
            VmAgent = vmAgent;
        }
    }
}