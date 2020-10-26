// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20191201Preview
{
    /// <summary>
    /// Policy Contract details.
    /// </summary>
    public partial class Policy : Pulumi.CustomResource
    {
        /// <summary>
        /// Format of the policyContent.
        /// </summary>
        [Output("format")]
        public Output<string?> Format { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Contents of the Policy as defined by the format.
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a Policy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Policy(string name, PolicyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201preview:Policy", name, args ?? new PolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Policy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201preview:Policy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/latest:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180101:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20200601preview:Policy"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Policy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Policy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Policy(name, id, options);
        }
    }

    public sealed class PolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Format of the policyContent.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The identifier of the Policy.
        /// </summary>
        [Input("policyId", required: true)]
        public Input<string> PolicyId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// Contents of the Policy as defined by the format.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public PolicyArgs()
        {
        }
    }
}
