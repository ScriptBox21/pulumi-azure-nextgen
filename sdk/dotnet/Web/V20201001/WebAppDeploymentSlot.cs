// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001
{
    /// <summary>
    /// User credentials used for publishing activity.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20201001:WebAppDeploymentSlot")]
    public partial class WebAppDeploymentSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// True if deployment is currently active, false if completed and null if not started.
        /// </summary>
        [Output("active")]
        public Output<bool?> Active { get; private set; } = null!;

        /// <summary>
        /// Who authored the deployment.
        /// </summary>
        [Output("author")]
        public Output<string?> Author { get; private set; } = null!;

        /// <summary>
        /// Author email.
        /// </summary>
        [Output("authorEmail")]
        public Output<string?> AuthorEmail { get; private set; } = null!;

        /// <summary>
        /// Who performed the deployment.
        /// </summary>
        [Output("deployer")]
        public Output<string?> Deployer { get; private set; } = null!;

        /// <summary>
        /// Details on deployment.
        /// </summary>
        [Output("details")]
        public Output<string?> Details { get; private set; } = null!;

        /// <summary>
        /// End time.
        /// </summary>
        [Output("endTime")]
        public Output<string?> EndTime { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Details about deployment status.
        /// </summary>
        [Output("message")]
        public Output<string?> Message { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Start time.
        /// </summary>
        [Output("startTime")]
        public Output<string?> StartTime { get; private set; } = null!;

        /// <summary>
        /// Deployment status.
        /// </summary>
        [Output("status")]
        public Output<int?> Status { get; private set; } = null!;

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
        /// Create a WebAppDeploymentSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppDeploymentSlot(string name, WebAppDeploymentSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20201001:WebAppDeploymentSlot", name, args ?? new WebAppDeploymentSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppDeploymentSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20201001:WebAppDeploymentSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppDeploymentSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppDeploymentSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppDeploymentSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppDeploymentSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppDeploymentSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppDeploymentSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppDeploymentSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppDeploymentSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppDeploymentSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppDeploymentSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppDeploymentSlot(name, id, options);
        }
    }

    public sealed class WebAppDeploymentSlotArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// True if deployment is currently active, false if completed and null if not started.
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// Who authored the deployment.
        /// </summary>
        [Input("author")]
        public Input<string>? Author { get; set; }

        /// <summary>
        /// Author email.
        /// </summary>
        [Input("authorEmail")]
        public Input<string>? AuthorEmail { get; set; }

        /// <summary>
        /// Who performed the deployment.
        /// </summary>
        [Input("deployer")]
        public Input<string>? Deployer { get; set; }

        /// <summary>
        /// Details on deployment.
        /// </summary>
        [Input("details")]
        public Input<string>? Details { get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// ID of an existing deployment.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Details about deployment status.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

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

        /// <summary>
        /// Name of the deployment slot. If a slot is not specified, the API creates a deployment for the production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        /// <summary>
        /// Start time.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        /// <summary>
        /// Deployment status.
        /// </summary>
        [Input("status")]
        public Input<int>? Status { get; set; }

        public WebAppDeploymentSlotArgs()
        {
        }
    }
}
