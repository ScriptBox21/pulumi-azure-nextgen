// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901
{
    /// <summary>
    /// The Data Box Edge/Gateway device.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:databoxedge/v20200901:Device")]
    public partial class Device : Pulumi.CustomResource
    {
        /// <summary>
        /// Type of compute roles configured.
        /// </summary>
        [Output("configuredRoleTypes")]
        public Output<ImmutableArray<string>> ConfiguredRoleTypes { get; private set; } = null!;

        /// <summary>
        /// The Data Box Edge/Gateway device culture.
        /// </summary>
        [Output("culture")]
        public Output<string> Culture { get; private set; } = null!;

        /// <summary>
        /// The status of the Data Box Edge/Gateway device.
        /// </summary>
        [Output("dataBoxEdgeDeviceStatus")]
        public Output<string?> DataBoxEdgeDeviceStatus { get; private set; } = null!;

        /// <summary>
        /// The Description of the Data Box Edge/Gateway device.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The device software version number of the device (eg: 1.2.18105.6).
        /// </summary>
        [Output("deviceHcsVersion")]
        public Output<string> DeviceHcsVersion { get; private set; } = null!;

        /// <summary>
        /// The Data Box Edge/Gateway device local capacity in MB.
        /// </summary>
        [Output("deviceLocalCapacity")]
        public Output<double> DeviceLocalCapacity { get; private set; } = null!;

        /// <summary>
        /// The Data Box Edge/Gateway device model.
        /// </summary>
        [Output("deviceModel")]
        public Output<string> DeviceModel { get; private set; } = null!;

        /// <summary>
        /// The Data Box Edge/Gateway device software version.
        /// </summary>
        [Output("deviceSoftwareVersion")]
        public Output<string> DeviceSoftwareVersion { get; private set; } = null!;

        /// <summary>
        /// The type of the Data Box Edge/Gateway device.
        /// </summary>
        [Output("deviceType")]
        public Output<string> DeviceType { get; private set; } = null!;

        /// <summary>
        /// The details of Edge Profile for this resource
        /// </summary>
        [Output("edgeProfile")]
        public Output<Outputs.EdgeProfileResponse> EdgeProfile { get; private set; } = null!;

        /// <summary>
        /// The etag for the devices.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// The Data Box Edge/Gateway device name.
        /// </summary>
        [Output("friendlyName")]
        public Output<string> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// Msi identity of the resource
        /// </summary>
        [Output("identity")]
        public Output<Outputs.ResourceIdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// The etag for the devices.
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// The location of the device. This is a supported and registered Azure geographical region (for example, West US, East US, or Southeast Asia). The geographical region of a device cannot be changed once it is created, but if an identical geographical region is specified on update, the request will succeed.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The description of the Data Box Edge/Gateway device model.
        /// </summary>
        [Output("modelDescription")]
        public Output<string> ModelDescription { get; private set; } = null!;

        /// <summary>
        /// The object name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The number of nodes in the cluster.
        /// </summary>
        [Output("nodeCount")]
        public Output<int> NodeCount { get; private set; } = null!;

        /// <summary>
        /// The details of the move operation on this resource.
        /// </summary>
        [Output("resourceMoveDetails")]
        public Output<Outputs.ResourceMoveDetailsResponse> ResourceMoveDetails { get; private set; } = null!;

        /// <summary>
        /// The Serial Number of Data Box Edge/Gateway device.
        /// </summary>
        [Output("serialNumber")]
        public Output<string> SerialNumber { get; private set; } = null!;

        /// <summary>
        /// The SKU type.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// DataBoxEdge Resource
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// The list of tags that describe the device. These tags can be used to view and group this device (across resource groups).
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The Data Box Edge/Gateway device timezone.
        /// </summary>
        [Output("timeZone")]
        public Output<string> TimeZone { get; private set; } = null!;

        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Device resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Device(string name, DeviceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:databoxedge/v20200901:Device", name, args ?? new DeviceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Device(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:databoxedge/v20200901:Device", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/latest:Device"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190301:Device"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190701:Device"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190801:Device"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20200501preview:Device"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20200901preview:Device"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Device resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Device Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Device(name, id, options);
        }
    }

    public sealed class DeviceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The status of the Data Box Edge/Gateway device.
        /// </summary>
        [Input("dataBoxEdgeDeviceStatus")]
        public InputUnion<string, Pulumi.AzureNextGen.DataBoxEdge.V20200901.DataBoxEdgeDeviceStatus>? DataBoxEdgeDeviceStatus { get; set; }

        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// The etag for the devices.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Msi identity of the resource
        /// </summary>
        [Input("identity")]
        public Input<Inputs.ResourceIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The location of the device. This is a supported and registered Azure geographical region (for example, West US, East US, or Southeast Asia). The geographical region of a device cannot be changed once it is created, but if an identical geographical region is specified on update, the request will succeed.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU type.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The list of tags that describe the device. These tags can be used to view and group this device (across resource groups).
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public DeviceArgs()
        {
        }
    }
}
