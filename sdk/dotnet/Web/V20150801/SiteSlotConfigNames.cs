// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801
{
    /// <summary>
    /// Slot Config names azure resource
    /// </summary>
    public partial class SiteSlotConfigNames : Pulumi.CustomResource
    {
        /// <summary>
        /// List of application settings names
        /// </summary>
        [Output("appSettingNames")]
        public Output<ImmutableArray<string>> AppSettingNames { get; private set; } = null!;

        /// <summary>
        /// List of connection string names
        /// </summary>
        [Output("connectionStringNames")]
        public Output<ImmutableArray<string>> ConnectionStringNames { get; private set; } = null!;

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SiteSlotConfigNames resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SiteSlotConfigNames(string name, SiteSlotConfigNamesArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:SiteSlotConfigNames", name, args ?? new SiteSlotConfigNamesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SiteSlotConfigNames(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:SiteSlotConfigNames", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:SiteSlotConfigNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:SiteSlotConfigNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:SiteSlotConfigNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:SiteSlotConfigNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:SiteSlotConfigNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:SiteSlotConfigNames"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:SiteSlotConfigNames"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SiteSlotConfigNames resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SiteSlotConfigNames Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SiteSlotConfigNames(name, id, options);
        }
    }

    public sealed class SiteSlotConfigNamesArgs : Pulumi.ResourceArgs
    {
        [Input("appSettingNames")]
        private InputList<string>? _appSettingNames;

        /// <summary>
        /// List of application settings names
        /// </summary>
        public InputList<string> AppSettingNames
        {
            get => _appSettingNames ?? (_appSettingNames = new InputList<string>());
            set => _appSettingNames = value;
        }

        [Input("connectionStringNames")]
        private InputList<string>? _connectionStringNames;

        /// <summary>
        /// List of connection string names
        /// </summary>
        public InputList<string> ConnectionStringNames
        {
            get => _connectionStringNames ?? (_connectionStringNames = new InputList<string>());
            set => _connectionStringNames = value;
        }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Resource type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public SiteSlotConfigNamesArgs()
        {
        }
    }
}
