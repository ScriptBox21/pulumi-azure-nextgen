// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001
{
    /// <summary>
    /// String dictionary resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20201001:WebAppMetadata")]
    public partial class WebAppMetadata : Pulumi.CustomResource
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
        /// Settings.
        /// </summary>
        [Output("properties")]
        public Output<ImmutableDictionary<string, string>> Properties { get; private set; } = null!;

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
        /// Create a WebAppMetadata resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppMetadata(string name, WebAppMetadataArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20201001:WebAppMetadata", name, args ?? new WebAppMetadataArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppMetadata(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20201001:WebAppMetadata", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppMetadata"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppMetadata"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppMetadata"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppMetadata"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppMetadata"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppMetadata"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppMetadata"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppMetadata"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppMetadata resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppMetadata Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppMetadata(name, id, options);
        }
    }

    public sealed class WebAppMetadataArgs : Pulumi.ResourceArgs
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

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// Settings.
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public WebAppMetadataArgs()
        {
        }
    }
}
