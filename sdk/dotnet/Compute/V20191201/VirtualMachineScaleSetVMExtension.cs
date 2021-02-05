// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20191201
{
    /// <summary>
    /// Describes a Virtual Machine Extension.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:compute/v20191201:VirtualMachineScaleSetVMExtension")]
    public partial class VirtualMachineScaleSetVMExtension : Pulumi.CustomResource
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Output("autoUpgradeMinorVersion")]
        public Output<bool?> AutoUpgradeMinorVersion { get; private set; } = null!;

        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Output("forceUpdateTag")]
        public Output<string?> ForceUpdateTag { get; private set; } = null!;

        /// <summary>
        /// The virtual machine extension instance view.
        /// </summary>
        [Output("instanceView")]
        public Output<Outputs.VirtualMachineExtensionInstanceViewResponse?> InstanceView { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Output("protectedSettings")]
        public Output<object?> ProtectedSettings { get; private set; } = null!;

        /// <summary>
        /// The provisioning state, which only appears in the response.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The name of the extension handler publisher.
        /// </summary>
        [Output("publisher")]
        public Output<string?> Publisher { get; private set; } = null!;

        /// <summary>
        /// Json formatted public settings for the extension.
        /// </summary>
        [Output("settings")]
        public Output<object?> Settings { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Specifies the version of the script handler.
        /// </summary>
        [Output("typeHandlerVersion")]
        public Output<string?> TypeHandlerVersion { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualMachineScaleSetVMExtension resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualMachineScaleSetVMExtension(string name, VirtualMachineScaleSetVMExtensionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/v20191201:VirtualMachineScaleSetVMExtension", name, args ?? new VirtualMachineScaleSetVMExtensionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualMachineScaleSetVMExtension(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/v20191201:VirtualMachineScaleSetVMExtension", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:compute/latest:VirtualMachineScaleSetVMExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190701:VirtualMachineScaleSetVMExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20200601:VirtualMachineScaleSetVMExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20201201:VirtualMachineScaleSetVMExtension"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualMachineScaleSetVMExtension resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualMachineScaleSetVMExtension Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualMachineScaleSetVMExtension(name, id, options);
        }
    }

    public sealed class VirtualMachineScaleSetVMExtensionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Input("autoUpgradeMinorVersion")]
        public Input<bool>? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Input("forceUpdateTag")]
        public Input<string>? ForceUpdateTag { get; set; }

        /// <summary>
        /// The instance ID of the virtual machine.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// The virtual machine extension instance view.
        /// </summary>
        [Input("instanceView")]
        public Input<Inputs.VirtualMachineExtensionInstanceViewArgs>? InstanceView { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Input("protectedSettings")]
        public Input<object>? ProtectedSettings { get; set; }

        /// <summary>
        /// The name of the extension handler publisher.
        /// </summary>
        [Input("publisher")]
        public Input<string>? Publisher { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Json formatted public settings for the extension.
        /// </summary>
        [Input("settings")]
        public Input<object>? Settings { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the type of the extension; an example is "CustomScriptExtension".
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Specifies the version of the script handler.
        /// </summary>
        [Input("typeHandlerVersion")]
        public Input<string>? TypeHandlerVersion { get; set; }

        /// <summary>
        /// The name of the virtual machine extension.
        /// </summary>
        [Input("vmExtensionName", required: true)]
        public Input<string> VmExtensionName { get; set; } = null!;

        /// <summary>
        /// The name of the VM scale set.
        /// </summary>
        [Input("vmScaleSetName", required: true)]
        public Input<string> VmScaleSetName { get; set; } = null!;

        public VirtualMachineScaleSetVMExtensionArgs()
        {
        }
    }
}
