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
    /// String dictionary resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20200901:WebAppConnectionStringsSlot")]
    public partial class WebAppConnectionStringsSlot : Pulumi.CustomResource
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
        /// Create a WebAppConnectionStringsSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppConnectionStringsSlot(string name, WebAppConnectionStringsSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppConnectionStringsSlot", name, args ?? new WebAppConnectionStringsSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppConnectionStringsSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppConnectionStringsSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppConnectionStringsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppConnectionStringsSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppConnectionStringsSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppConnectionStringsSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppConnectionStringsSlot(name, id, options);
        }
    }

    public sealed class WebAppConnectionStringsSlotArgs : Pulumi.ResourceArgs
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

        /// <summary>
        /// Name of the deployment slot. If a slot is not specified, the API will update the connection settings for the production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        public WebAppConnectionStringsSlotArgs()
        {
        }
    }
}
