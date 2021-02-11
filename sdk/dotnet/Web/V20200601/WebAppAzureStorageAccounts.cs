// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200601
{
    /// <summary>
    /// AzureStorageInfo dictionary resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20200601:WebAppAzureStorageAccounts")]
    public partial class WebAppAzureStorageAccounts : Pulumi.CustomResource
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
        /// Azure storage accounts.
        /// </summary>
        [Output("properties")]
        public Output<ImmutableDictionary<string, Outputs.AzureStorageInfoValueResponse>> Properties { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppAzureStorageAccounts resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppAzureStorageAccounts(string name, WebAppAzureStorageAccountsArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200601:WebAppAzureStorageAccounts", name, args ?? new WebAppAzureStorageAccountsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppAzureStorageAccounts(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200601:WebAppAzureStorageAccounts", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppAzureStorageAccounts"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppAzureStorageAccounts"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppAzureStorageAccounts"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppAzureStorageAccounts"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppAzureStorageAccounts"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:WebAppAzureStorageAccounts"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppAzureStorageAccounts resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppAzureStorageAccounts Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppAzureStorageAccounts(name, id, options);
        }
    }

    public sealed class WebAppAzureStorageAccountsArgs : Pulumi.ResourceArgs
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
        private InputMap<Inputs.AzureStorageInfoValueArgs>? _properties;

        /// <summary>
        /// Azure storage accounts.
        /// </summary>
        public InputMap<Inputs.AzureStorageInfoValueArgs> Properties
        {
            get => _properties ?? (_properties = new InputMap<Inputs.AzureStorageInfoValueArgs>());
            set => _properties = value;
        }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public WebAppAzureStorageAccountsArgs()
        {
        }
    }
}
