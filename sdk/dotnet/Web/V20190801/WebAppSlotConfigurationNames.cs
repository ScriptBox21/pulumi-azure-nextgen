// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20190801
{
    /// <summary>
    /// Slot Config names azure resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20190801:WebAppSlotConfigurationNames")]
    public partial class WebAppSlotConfigurationNames : Pulumi.CustomResource
    {
        /// <summary>
        /// List of application settings names.
        /// </summary>
        [Output("appSettingNames")]
        public Output<ImmutableArray<string>> AppSettingNames { get; private set; } = null!;

        /// <summary>
        /// List of external Azure storage account identifiers.
        /// </summary>
        [Output("azureStorageConfigNames")]
        public Output<ImmutableArray<string>> AzureStorageConfigNames { get; private set; } = null!;

        /// <summary>
        /// List of connection string names.
        /// </summary>
        [Output("connectionStringNames")]
        public Output<ImmutableArray<string>> ConnectionStringNames { get; private set; } = null!;

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
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppSlotConfigurationNames resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppSlotConfigurationNames(string name, WebAppSlotConfigurationNamesArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20190801:WebAppSlotConfigurationNames", name, args ?? new WebAppSlotConfigurationNamesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppSlotConfigurationNames(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20190801:WebAppSlotConfigurationNames", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppSlotConfigurationNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppSlotConfigurationNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppSlotConfigurationNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppSlotConfigurationNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppSlotConfigurationNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppSlotConfigurationNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppSlotConfigurationNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:WebAppSlotConfigurationNames"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppSlotConfigurationNames resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppSlotConfigurationNames Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppSlotConfigurationNames(name, id, options);
        }
    }

    public sealed class WebAppSlotConfigurationNamesArgs : Pulumi.ResourceArgs
    {
        [Input("appSettingNames")]
        private InputList<string>? _appSettingNames;

        /// <summary>
        /// List of application settings names.
        /// </summary>
        public InputList<string> AppSettingNames
        {
            get => _appSettingNames ?? (_appSettingNames = new InputList<string>());
            set => _appSettingNames = value;
        }

        [Input("azureStorageConfigNames")]
        private InputList<string>? _azureStorageConfigNames;

        /// <summary>
        /// List of external Azure storage account identifiers.
        /// </summary>
        public InputList<string> AzureStorageConfigNames
        {
            get => _azureStorageConfigNames ?? (_azureStorageConfigNames = new InputList<string>());
            set => _azureStorageConfigNames = value;
        }

        [Input("connectionStringNames")]
        private InputList<string>? _connectionStringNames;

        /// <summary>
        /// List of connection string names.
        /// </summary>
        public InputList<string> ConnectionStringNames
        {
            get => _connectionStringNames ?? (_connectionStringNames = new InputList<string>());
            set => _connectionStringNames = value;
        }

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

        public WebAppSlotConfigurationNamesArgs()
        {
        }
    }
}
