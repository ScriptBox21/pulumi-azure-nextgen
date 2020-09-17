// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20191201
{
    public static class GetVirtualMachineScaleSetVM
    {
        public static Task<GetVirtualMachineScaleSetVMResult> InvokeAsync(GetVirtualMachineScaleSetVMArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachineScaleSetVMResult>("azure-nextgen:compute/v20191201:getVirtualMachineScaleSetVM", args ?? new GetVirtualMachineScaleSetVMArgs(), options.WithVersion());
    }


    public sealed class GetVirtualMachineScaleSetVMArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The expand expression to apply on the operation.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The instance ID of the virtual machine.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the VM scale set.
        /// </summary>
        [Input("vmScaleSetName", required: true)]
        public string VmScaleSetName { get; set; } = null!;

        public GetVirtualMachineScaleSetVMArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualMachineScaleSetVMResult
    {
        /// <summary>
        /// Specifies additional capabilities enabled or disabled on the virtual machine in the scale set. For instance: whether the virtual machine has the capability to support attaching managed data disks with UltraSSD_LRS storage account type.
        /// </summary>
        public readonly Outputs.AdditionalCapabilitiesResponse? AdditionalCapabilities;
        /// <summary>
        /// Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. An existing VM cannot be added to an availability set.
        /// </summary>
        public readonly Outputs.SubResourceResponse? AvailabilitySet;
        /// <summary>
        /// Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15.
        /// </summary>
        public readonly Outputs.DiagnosticsProfileResponse? DiagnosticsProfile;
        /// <summary>
        /// Specifies the hardware settings for the virtual machine.
        /// </summary>
        public readonly Outputs.HardwareProfileResponse? HardwareProfile;
        /// <summary>
        /// The virtual machine instance ID.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// The virtual machine instance view.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetVMInstanceViewResponse InstanceView;
        /// <summary>
        /// Specifies whether the latest model has been applied to the virtual machine.
        /// </summary>
        public readonly bool LatestModelApplied;
        /// <summary>
        /// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15
        /// </summary>
        public readonly string? LicenseType;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Specifies whether the model applied to the virtual machine is the model of the virtual machine scale set or the customized model for the virtual machine.
        /// </summary>
        public readonly string ModelDefinitionApplied;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specifies the network interfaces of the virtual machine.
        /// </summary>
        public readonly Outputs.NetworkProfileResponse? NetworkProfile;
        /// <summary>
        /// Specifies the network profile configuration of the virtual machine.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetVMNetworkProfileConfigurationResponse? NetworkProfileConfiguration;
        /// <summary>
        /// Specifies the operating system settings for the virtual machine.
        /// </summary>
        public readonly Outputs.OSProfileResponse? OsProfile;
        /// <summary>
        /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**.
        /// </summary>
        public readonly Outputs.PlanResponse? Plan;
        /// <summary>
        /// Specifies the protection policy of the virtual machine.
        /// </summary>
        public readonly Outputs.VirtualMachineScaleSetVMProtectionPolicyResponse? ProtectionPolicy;
        /// <summary>
        /// The provisioning state, which only appears in the response.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The virtual machine child extension resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualMachineExtensionResponse> Resources;
        /// <summary>
        /// The virtual machine SKU.
        /// </summary>
        public readonly Outputs.SkuResponse Sku;
        /// <summary>
        /// Specifies the storage settings for the virtual machine disks.
        /// </summary>
        public readonly Outputs.StorageProfileResponse? StorageProfile;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Azure VM unique ID.
        /// </summary>
        public readonly string VmId;
        /// <summary>
        /// The virtual machine zones.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetVirtualMachineScaleSetVMResult(
            Outputs.AdditionalCapabilitiesResponse? additionalCapabilities,

            Outputs.SubResourceResponse? availabilitySet,

            Outputs.DiagnosticsProfileResponse? diagnosticsProfile,

            Outputs.HardwareProfileResponse? hardwareProfile,

            string instanceId,

            Outputs.VirtualMachineScaleSetVMInstanceViewResponse instanceView,

            bool latestModelApplied,

            string? licenseType,

            string location,

            string modelDefinitionApplied,

            string name,

            Outputs.NetworkProfileResponse? networkProfile,

            Outputs.VirtualMachineScaleSetVMNetworkProfileConfigurationResponse? networkProfileConfiguration,

            Outputs.OSProfileResponse? osProfile,

            Outputs.PlanResponse? plan,

            Outputs.VirtualMachineScaleSetVMProtectionPolicyResponse? protectionPolicy,

            string provisioningState,

            ImmutableArray<Outputs.VirtualMachineExtensionResponse> resources,

            Outputs.SkuResponse sku,

            Outputs.StorageProfileResponse? storageProfile,

            ImmutableDictionary<string, string>? tags,

            string type,

            string vmId,

            ImmutableArray<string> zones)
        {
            AdditionalCapabilities = additionalCapabilities;
            AvailabilitySet = availabilitySet;
            DiagnosticsProfile = diagnosticsProfile;
            HardwareProfile = hardwareProfile;
            InstanceId = instanceId;
            InstanceView = instanceView;
            LatestModelApplied = latestModelApplied;
            LicenseType = licenseType;
            Location = location;
            ModelDefinitionApplied = modelDefinitionApplied;
            Name = name;
            NetworkProfile = networkProfile;
            NetworkProfileConfiguration = networkProfileConfiguration;
            OsProfile = osProfile;
            Plan = plan;
            ProtectionPolicy = protectionPolicy;
            ProvisioningState = provisioningState;
            Resources = resources;
            Sku = sku;
            StorageProfile = storageProfile;
            Tags = tags;
            Type = type;
            VmId = vmId;
            Zones = zones;
        }
    }
}