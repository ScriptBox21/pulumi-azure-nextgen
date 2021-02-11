// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901
{
    [AzureNextGenResourceType("azure-nextgen:web/v20200901:WebAppAuthSettingsV2Slot")]
    public partial class WebAppAuthSettingsV2Slot : Pulumi.CustomResource
    {
        [Output("globalValidation")]
        public Output<Outputs.GlobalValidationResponse?> GlobalValidation { get; private set; } = null!;

        [Output("httpSettings")]
        public Output<Outputs.HttpSettingsResponse?> HttpSettings { get; private set; } = null!;

        [Output("identityProviders")]
        public Output<Outputs.IdentityProvidersResponse?> IdentityProviders { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        [Output("login")]
        public Output<Outputs.LoginResponse?> Login { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("platform")]
        public Output<Outputs.AuthPlatformResponse?> Platform { get; private set; } = null!;

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
        /// Create a WebAppAuthSettingsV2Slot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppAuthSettingsV2Slot(string name, WebAppAuthSettingsV2SlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppAuthSettingsV2Slot", name, args ?? new WebAppAuthSettingsV2SlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppAuthSettingsV2Slot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200901:WebAppAuthSettingsV2Slot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppAuthSettingsV2Slot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppAuthSettingsV2Slot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:WebAppAuthSettingsV2Slot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppAuthSettingsV2Slot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppAuthSettingsV2Slot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppAuthSettingsV2Slot(name, id, options);
        }
    }

    public sealed class WebAppAuthSettingsV2SlotArgs : Pulumi.ResourceArgs
    {
        [Input("globalValidation")]
        public Input<Inputs.GlobalValidationArgs>? GlobalValidation { get; set; }

        [Input("httpSettings")]
        public Input<Inputs.HttpSettingsArgs>? HttpSettings { get; set; }

        [Input("identityProviders")]
        public Input<Inputs.IdentityProvidersArgs>? IdentityProviders { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("login")]
        public Input<Inputs.LoginArgs>? Login { get; set; }

        /// <summary>
        /// Name of web app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("platform")]
        public Input<Inputs.AuthPlatformArgs>? Platform { get; set; }

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

        public WebAppAuthSettingsV2SlotArgs()
        {
        }
    }
}
