// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.Latest
{
    /// <summary>
    /// ApiRelease details.
    /// </summary>
    public partial class ApiRelease : Pulumi.CustomResource
    {
        /// <summary>
        /// Identifier of the API the release belongs to.
        /// </summary>
        [Output("apiId")]
        public Output<string?> ApiId { get; private set; } = null!;

        /// <summary>
        /// The time the API was released. The date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601 standard.
        /// </summary>
        [Output("createdDateTime")]
        public Output<string> CreatedDateTime { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Release Notes
        /// </summary>
        [Output("notes")]
        public Output<string?> Notes { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The time the API release was updated.
        /// </summary>
        [Output("updatedDateTime")]
        public Output<string> UpdatedDateTime { get; private set; } = null!;


        /// <summary>
        /// Create a ApiRelease resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiRelease(string name, ApiReleaseArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ApiRelease", name, args ?? new ApiReleaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiRelease(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ApiRelease", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:ApiRelease"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180101:ApiRelease"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:ApiRelease"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:ApiRelease"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:ApiRelease"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201preview:ApiRelease"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20200601preview:ApiRelease"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ApiRelease resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiRelease Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ApiRelease(name, id, options);
        }
    }

    public sealed class ApiReleaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Identifier of the API the release belongs to.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        /// <summary>
        /// Release Notes
        /// </summary>
        [Input("notes")]
        public Input<string>? Notes { get; set; }

        /// <summary>
        /// Release identifier within an API. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("releaseId", required: true)]
        public Input<string> ReleaseId { get; set; } = null!;

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

        public ApiReleaseArgs()
        {
        }
    }
}
