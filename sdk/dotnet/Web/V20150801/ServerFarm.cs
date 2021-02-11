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
    /// App Service Plan Model
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20150801:ServerFarm")]
    public partial class ServerFarm : Pulumi.CustomResource
    {
        /// <summary>
        /// App Service Plan administration site
        /// </summary>
        [Output("adminSiteName")]
        public Output<string?> AdminSiteName { get; private set; } = null!;

        /// <summary>
        /// Geographical location for the App Service Plan
        /// </summary>
        [Output("geoRegion")]
        public Output<string> GeoRegion { get; private set; } = null!;

        /// <summary>
        /// Specification for the hosting environment (App Service Environment) to use for the App Service Plan
        /// </summary>
        [Output("hostingEnvironmentProfile")]
        public Output<Outputs.HostingEnvironmentProfileResponse?> HostingEnvironmentProfile { get; private set; } = null!;

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
        /// Maximum number of instances that can be assigned to this App Service Plan
        /// </summary>
        [Output("maximumNumberOfWorkers")]
        public Output<int?> MaximumNumberOfWorkers { get; private set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Number of web apps assigned to this App Service Plan
        /// </summary>
        [Output("numberOfSites")]
        public Output<int> NumberOfSites { get; private set; } = null!;

        /// <summary>
        /// If True apps assigned to this App Service Plan can be scaled independently
        ///             If False apps assigned to this App Service Plan will scale to all instances of the plan
        /// </summary>
        [Output("perSiteScaling")]
        public Output<bool?> PerSiteScaling { get; private set; } = null!;

        /// <summary>
        /// Enables creation of a Linux App Service Plan
        /// </summary>
        [Output("reserved")]
        public Output<bool?> Reserved { get; private set; } = null!;

        /// <summary>
        /// Resource group of the server farm
        /// </summary>
        [Output("resourceGroup")]
        public Output<string> ResourceGroup { get; private set; } = null!;

        /// <summary>
        /// Describes a sku for a scalable resource
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuDescriptionResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// App Service Plan Status
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// App Service Plan Subscription
        /// </summary>
        [Output("subscription")]
        public Output<string> Subscription { get; private set; } = null!;

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
        /// Target worker tier assigned to the App Service Plan
        /// </summary>
        [Output("workerTierName")]
        public Output<string?> WorkerTierName { get; private set; } = null!;


        /// <summary>
        /// Create a ServerFarm resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServerFarm(string name, ServerFarmArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:ServerFarm", name, args ?? new ServerFarmArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServerFarm(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20150801:ServerFarm", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:ServerFarm"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160901:ServerFarm"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:ServerFarm"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:ServerFarm"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:ServerFarm"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:ServerFarm"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:ServerFarm"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServerFarm resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServerFarm Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServerFarm(name, id, options);
        }
    }

    public sealed class ServerFarmArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// App Service Plan administration site
        /// </summary>
        [Input("adminSiteName")]
        public Input<string>? AdminSiteName { get; set; }

        /// <summary>
        /// OBSOLETE: If true, allow pending state for App Service Plan
        /// </summary>
        [Input("allowPendingState")]
        public Input<bool>? AllowPendingState { get; set; }

        /// <summary>
        /// Specification for the hosting environment (App Service Environment) to use for the App Service Plan
        /// </summary>
        [Input("hostingEnvironmentProfile")]
        public Input<Inputs.HostingEnvironmentProfileArgs>? HostingEnvironmentProfile { get; set; }

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
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Maximum number of instances that can be assigned to this App Service Plan
        /// </summary>
        [Input("maximumNumberOfWorkers")]
        public Input<int>? MaximumNumberOfWorkers { get; set; }

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// If True apps assigned to this App Service Plan can be scaled independently
        ///             If False apps assigned to this App Service Plan will scale to all instances of the plan
        /// </summary>
        [Input("perSiteScaling")]
        public Input<bool>? PerSiteScaling { get; set; }

        /// <summary>
        /// Enables creation of a Linux App Service Plan
        /// </summary>
        [Input("reserved")]
        public Input<bool>? Reserved { get; set; }

        /// <summary>
        /// Name of resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Describes a sku for a scalable resource
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuDescriptionArgs>? Sku { get; set; }

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

        /// <summary>
        /// Target worker tier assigned to the App Service Plan
        /// </summary>
        [Input("workerTierName")]
        public Input<string>? WorkerTierName { get; set; }

        public ServerFarmArgs()
        {
        }
    }
}
