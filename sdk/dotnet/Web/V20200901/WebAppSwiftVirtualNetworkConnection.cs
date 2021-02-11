// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901
{
    /// <summary>
    /// Swift Virtual Network Contract. This is used to enable the new Swift way of doing virtual network integration.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20200901:WebAppSwiftVirtualNetworkConnection")]
    public partial class WebAppSwiftVirtualNetworkConnection : Pulumi.CustomResource
    {
        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
        /// </summary>
        [Output("subnetResourceId")]
        public Output<string?> SubnetResourceId { get; private set; } = null!;

        /// <summary>
        /// A flag that specifies if the scale unit this Web App is on supports Swift integration.
        /// </summary>
        [Output("swiftSupported")]
        public Output<bool?> SwiftSupported { get; private set; } = null!;

        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppSwiftVirtualNetworkConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppSwiftVirtualNetworkConnection(string name, WebAppSwiftVirtualNetworkConnectionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppSwiftVirtualNetworkConnection", name, args ?? new WebAppSwiftVirtualNetworkConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppSwiftVirtualNetworkConnection(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppSwiftVirtualNetworkConnection", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppSwiftVirtualNetworkConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppSwiftVirtualNetworkConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppSwiftVirtualNetworkConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppSwiftVirtualNetworkConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppSwiftVirtualNetworkConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:WebAppSwiftVirtualNetworkConnection"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppSwiftVirtualNetworkConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppSwiftVirtualNetworkConnection Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppSwiftVirtualNetworkConnection(name, id, options);
        }
    }

    public sealed class WebAppSwiftVirtualNetworkConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
        /// </summary>
        [Input("subnetResourceId")]
        public Input<string>? SubnetResourceId { get; set; }

        /// <summary>
        /// A flag that specifies if the scale unit this Web App is on supports Swift integration.
        /// </summary>
        [Input("swiftSupported")]
        public Input<bool>? SwiftSupported { get; set; }

        public WebAppSwiftVirtualNetworkConnectionArgs()
        {
        }
    }
}
