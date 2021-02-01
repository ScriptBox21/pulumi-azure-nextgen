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
    /// Push settings for the App.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20200901:WebAppSitePushSettingsSlot")]
    public partial class WebAppSitePushSettingsSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
        /// </summary>
        [Output("dynamicTagsJson")]
        public Output<string?> DynamicTagsJson { get; private set; } = null!;

        /// <summary>
        /// Gets or sets a flag indicating whether the Push endpoint is enabled.
        /// </summary>
        [Output("isPushEnabled")]
        public Output<bool> IsPushEnabled { get; private set; } = null!;

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
        /// The system metadata relating to this resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
        /// </summary>
        [Output("tagWhitelistJson")]
        public Output<string?> TagWhitelistJson { get; private set; } = null!;

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'. 
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        [Output("tagsRequiringAuth")]
        public Output<string?> TagsRequiringAuth { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppSitePushSettingsSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppSitePushSettingsSlot(string name, WebAppSitePushSettingsSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppSitePushSettingsSlot", name, args ?? new WebAppSitePushSettingsSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppSitePushSettingsSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppSitePushSettingsSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppSitePushSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppSitePushSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppSitePushSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppSitePushSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppSitePushSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppSitePushSettingsSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppSitePushSettingsSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppSitePushSettingsSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppSitePushSettingsSlot(name, id, options);
        }
    }

    public sealed class WebAppSitePushSettingsSlotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
        /// </summary>
        [Input("dynamicTagsJson")]
        public Input<string>? DynamicTagsJson { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether the Push endpoint is enabled.
        /// </summary>
        [Input("isPushEnabled", required: true)]
        public Input<bool> IsPushEnabled { get; set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Name of web app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of web app slot. If not specified then will default to production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
        /// </summary>
        [Input("tagWhitelistJson")]
        public Input<string>? TagWhitelistJson { get; set; }

        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'. 
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        [Input("tagsRequiringAuth")]
        public Input<string>? TagsRequiringAuth { get; set; }

        public WebAppSitePushSettingsSlotArgs()
        {
        }
    }
}
