// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest
{
    /// <summary>
    /// String dictionary resource.
    /// Latest API Version: 2020-09-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/latest:WebAppConnectionStrings")]
    public partial class WebAppConnectionStrings : Pulumi.CustomResource
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
        /// Connection strings.
        /// </summary>
        [Output("properties")]
        public Output<ImmutableDictionary<string, Outputs.ConnStringValueTypePairResponse>> Properties { get; private set; } = null!;

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
        /// Create a WebAppConnectionStrings resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppConnectionStrings(string name, WebAppConnectionStringsArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/latest:WebAppConnectionStrings", name, args ?? new WebAppConnectionStringsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppConnectionStrings(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/latest:WebAppConnectionStrings", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppConnectionStrings"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppConnectionStrings"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppConnectionStrings"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppConnectionStrings"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppConnectionStrings"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppConnectionStrings"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppConnectionStrings"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:WebAppConnectionStrings"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppConnectionStrings resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppConnectionStrings Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppConnectionStrings(name, id, options);
        }
    }

    public sealed class WebAppConnectionStringsArgs : Pulumi.ResourceArgs
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
        private InputMap<Inputs.ConnStringValueTypePairArgs>? _properties;

        /// <summary>
        /// Connection strings.
        /// </summary>
        public InputMap<Inputs.ConnStringValueTypePairArgs> Properties
        {
            get => _properties ?? (_properties = new InputMap<Inputs.ConnStringValueTypePairArgs>());
            set => _properties = value;
        }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public WebAppConnectionStringsArgs()
        {
        }
    }
}
