// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20200801
{
    /// <summary>
    /// Deployment information.
    /// </summary>
    public partial class Deployment : Pulumi.CustomResource
    {
        /// <summary>
        /// the location of the deployment.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Deployment properties.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.DeploymentPropertiesExtendedResponse> Properties { get; private set; } = null!;

        /// <summary>
        /// Deployment tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the deployment.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Deployment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Deployment(string name, DeploymentArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:resources/v20200801:Deployment", name, args ?? new DeploymentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Deployment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:resources/v20200801:Deployment", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:resources/latest:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20151101:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20160201:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20160701:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20160901:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20170510:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20180201:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20180501:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20190301:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20190501:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20190510:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20190701:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20190801:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20191001:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20200601:Deployment"},
                    new Pulumi.Alias { Type = "azure-nextgen:resources/v20201001:Deployment"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Deployment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Deployment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Deployment(name, id, options);
        }
    }

    public sealed class DeploymentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [Input("deploymentName", required: true)]
        public Input<string> DeploymentName { get; set; } = null!;

        /// <summary>
        /// The location to store the deployment data.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The deployment properties.
        /// </summary>
        [Input("properties", required: true)]
        public Input<Inputs.DeploymentPropertiesArgs> Properties { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to deploy the resources to. The name is case insensitive. The resource group must already exist.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Deployment tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public DeploymentArgs()
        {
        }
    }
}
