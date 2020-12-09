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
    /// Function information.
    /// </summary>
    public partial class WebAppInstanceFunctionSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// Config information.
        /// </summary>
        [Output("config")]
        public Output<object?> Config { get; private set; } = null!;

        /// <summary>
        /// Config URI.
        /// </summary>
        [Output("configHref")]
        public Output<string?> ConfigHref { get; private set; } = null!;

        /// <summary>
        /// File list.
        /// </summary>
        [Output("files")]
        public Output<ImmutableDictionary<string, string>?> Files { get; private set; } = null!;

        /// <summary>
        /// Function App ID.
        /// </summary>
        [Output("functionAppId")]
        public Output<string?> FunctionAppId { get; private set; } = null!;

        /// <summary>
        /// Function URI.
        /// </summary>
        [Output("href")]
        public Output<string?> Href { get; private set; } = null!;

        /// <summary>
        /// The invocation URL
        /// </summary>
        [Output("invokeUrlTemplate")]
        public Output<string?> InvokeUrlTemplate { get; private set; } = null!;

        /// <summary>
        /// Gets or sets a value indicating whether the function is disabled
        /// </summary>
        [Output("isDisabled")]
        public Output<bool?> IsDisabled { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// The function language
        /// </summary>
        [Output("language")]
        public Output<string?> Language { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Script URI.
        /// </summary>
        [Output("scriptHref")]
        public Output<string?> ScriptHref { get; private set; } = null!;

        /// <summary>
        /// Script root path URI.
        /// </summary>
        [Output("scriptRootPathHref")]
        public Output<string?> ScriptRootPathHref { get; private set; } = null!;

        /// <summary>
        /// Secrets file URI.
        /// </summary>
        [Output("secretsFileHref")]
        public Output<string?> SecretsFileHref { get; private set; } = null!;

        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Test data used when testing via the Azure Portal.
        /// </summary>
        [Output("testData")]
        public Output<string?> TestData { get; private set; } = null!;

        /// <summary>
        /// Test data URI.
        /// </summary>
        [Output("testDataHref")]
        public Output<string?> TestDataHref { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppInstanceFunctionSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppInstanceFunctionSlot(string name, WebAppInstanceFunctionSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/latest:WebAppInstanceFunctionSlot", name, args ?? new WebAppInstanceFunctionSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppInstanceFunctionSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/latest:WebAppInstanceFunctionSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppInstanceFunctionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppInstanceFunctionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppInstanceFunctionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppInstanceFunctionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppInstanceFunctionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppInstanceFunctionSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppInstanceFunctionSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppInstanceFunctionSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppInstanceFunctionSlot(name, id, options);
        }
    }

    public sealed class WebAppInstanceFunctionSlotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Config information.
        /// </summary>
        [Input("config")]
        public Input<object>? Config { get; set; }

        /// <summary>
        /// Config URI.
        /// </summary>
        [Input("configHref")]
        public Input<string>? ConfigHref { get; set; }

        [Input("files")]
        private InputMap<string>? _files;

        /// <summary>
        /// File list.
        /// </summary>
        public InputMap<string> Files
        {
            get => _files ?? (_files = new InputMap<string>());
            set => _files = value;
        }

        /// <summary>
        /// Function App ID.
        /// </summary>
        [Input("functionAppId")]
        public Input<string>? FunctionAppId { get; set; }

        /// <summary>
        /// Function name.
        /// </summary>
        [Input("functionName", required: true)]
        public Input<string> FunctionName { get; set; } = null!;

        /// <summary>
        /// Function URI.
        /// </summary>
        [Input("href")]
        public Input<string>? Href { get; set; }

        /// <summary>
        /// The invocation URL
        /// </summary>
        [Input("invokeUrlTemplate")]
        public Input<string>? InvokeUrlTemplate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the function is disabled
        /// </summary>
        [Input("isDisabled")]
        public Input<bool>? IsDisabled { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// The function language
        /// </summary>
        [Input("language")]
        public Input<string>? Language { get; set; }

        /// <summary>
        /// Site name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Script URI.
        /// </summary>
        [Input("scriptHref")]
        public Input<string>? ScriptHref { get; set; }

        /// <summary>
        /// Script root path URI.
        /// </summary>
        [Input("scriptRootPathHref")]
        public Input<string>? ScriptRootPathHref { get; set; }

        /// <summary>
        /// Secrets file URI.
        /// </summary>
        [Input("secretsFileHref")]
        public Input<string>? SecretsFileHref { get; set; }

        /// <summary>
        /// Name of the deployment slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        /// <summary>
        /// Test data used when testing via the Azure Portal.
        /// </summary>
        [Input("testData")]
        public Input<string>? TestData { get; set; }

        /// <summary>
        /// Test data URI.
        /// </summary>
        [Input("testDataHref")]
        public Input<string>? TestDataHref { get; set; }

        public WebAppInstanceFunctionSlotArgs()
        {
        }
    }
}
