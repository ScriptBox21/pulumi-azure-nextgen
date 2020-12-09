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
    /// Site Extension Information.
    /// </summary>
    public partial class WebAppSiteExtension : Pulumi.CustomResource
    {
        /// <summary>
        /// List of authors.
        /// </summary>
        [Output("authors")]
        public Output<ImmutableArray<string>> Authors { get; private set; } = null!;

        /// <summary>
        /// Site Extension comment.
        /// </summary>
        [Output("comment")]
        public Output<string?> Comment { get; private set; } = null!;

        /// <summary>
        /// Detailed description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Count of downloads.
        /// </summary>
        [Output("downloadCount")]
        public Output<int?> DownloadCount { get; private set; } = null!;

        /// <summary>
        /// Site extension ID.
        /// </summary>
        [Output("extensionId")]
        public Output<string?> ExtensionId { get; private set; } = null!;

        /// <summary>
        /// Site extension type.
        /// </summary>
        [Output("extensionType")]
        public Output<string?> ExtensionType { get; private set; } = null!;

        /// <summary>
        /// Extension URL.
        /// </summary>
        [Output("extensionUrl")]
        public Output<string?> ExtensionUrl { get; private set; } = null!;

        /// <summary>
        /// Feed URL.
        /// </summary>
        [Output("feedUrl")]
        public Output<string?> FeedUrl { get; private set; } = null!;

        /// <summary>
        /// Icon URL.
        /// </summary>
        [Output("iconUrl")]
        public Output<string?> IconUrl { get; private set; } = null!;

        /// <summary>
        /// Installed timestamp.
        /// </summary>
        [Output("installedDateTime")]
        public Output<string?> InstalledDateTime { get; private set; } = null!;

        /// <summary>
        /// Installer command line parameters.
        /// </summary>
        [Output("installerCommandLineParams")]
        public Output<string?> InstallerCommandLineParams { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// License URL.
        /// </summary>
        [Output("licenseUrl")]
        public Output<string?> LicenseUrl { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the local version is the latest version; &lt;code&gt;false&lt;/code&gt; otherwise.
        /// </summary>
        [Output("localIsLatestVersion")]
        public Output<bool?> LocalIsLatestVersion { get; private set; } = null!;

        /// <summary>
        /// Local path.
        /// </summary>
        [Output("localPath")]
        public Output<string?> LocalPath { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Project URL.
        /// </summary>
        [Output("projectUrl")]
        public Output<string?> ProjectUrl { get; private set; } = null!;

        /// <summary>
        /// Provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Published timestamp.
        /// </summary>
        [Output("publishedDateTime")]
        public Output<string?> PublishedDateTime { get; private set; } = null!;

        /// <summary>
        /// Summary description.
        /// </summary>
        [Output("summary")]
        public Output<string?> Summary { get; private set; } = null!;

        [Output("title")]
        public Output<string?> Title { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Version information.
        /// </summary>
        [Output("version")]
        public Output<string?> Version { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppSiteExtension resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppSiteExtension(string name, WebAppSiteExtensionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200601:WebAppSiteExtension", name, args ?? new WebAppSiteExtensionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppSiteExtension(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20200601:WebAppSiteExtension", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppSiteExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppSiteExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppSiteExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppSiteExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppSiteExtension"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppSiteExtension"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppSiteExtension resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppSiteExtension Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppSiteExtension(name, id, options);
        }
    }

    public sealed class WebAppSiteExtensionArgs : Pulumi.ResourceArgs
    {
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
        /// Site extension name.
        /// </summary>
        [Input("siteExtensionId", required: true)]
        public Input<string> SiteExtensionId { get; set; } = null!;

        public WebAppSiteExtensionArgs()
        {
        }
    }
}
