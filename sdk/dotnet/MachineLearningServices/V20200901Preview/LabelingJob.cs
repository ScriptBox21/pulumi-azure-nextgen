// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200901Preview
{
    /// <summary>
    /// Machine Learning labeling job object wrapped into ARM resource envelope.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:machinelearningservices/v20200901preview:LabelingJob")]
    public partial class LabelingJob : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the resource entity.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Definition of a labeling job.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.LabelingJobPropertiesResponse> Properties { get; private set; } = null!;

        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// The resource provider and type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a LabelingJob resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LabelingJob(string name, LabelingJobArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200901preview:LabelingJob", name, args ?? new LabelingJobArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LabelingJob(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200901preview:LabelingJob", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LabelingJob resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LabelingJob Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LabelingJob(name, id, options);
        }
    }

    public sealed class LabelingJobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name and identifier for LabelingJob.
        /// </summary>
        [Input("labelingJobId", required: true)]
        public Input<string> LabelingJobId { get; set; } = null!;

        /// <summary>
        /// Definition of a labeling job.
        /// </summary>
        [Input("properties")]
        public Input<Inputs.LabelingJobPropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public LabelingJobArgs()
        {
        }
    }
}
