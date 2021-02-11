// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest
{
    /// <summary>
    /// A Job resource type. The progress and state can be obtained by polling a Job or subscribing to events using EventGrid.
    /// Latest API Version: 2020-05-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:media/latest:Job")]
    public partial class Job : Pulumi.CustomResource
    {
        /// <summary>
        /// Customer provided key, value pairs that will be returned in Job and JobOutput state events.
        /// </summary>
        [Output("correlationData")]
        public Output<ImmutableDictionary<string, string>?> CorrelationData { get; private set; } = null!;

        /// <summary>
        /// The UTC date and time when the customer has created the Job, in 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        [Output("created")]
        public Output<string> Created { get; private set; } = null!;

        /// <summary>
        /// Optional customer supplied description of the Job.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The UTC date and time at which this Job finished processing.
        /// </summary>
        [Output("endTime")]
        public Output<string> EndTime { get; private set; } = null!;

        /// <summary>
        /// The inputs for the Job.
        /// </summary>
        [Output("input")]
        public Output<object> Input { get; private set; } = null!;

        /// <summary>
        /// The UTC date and time when the customer has last updated the Job, in 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        [Output("lastModified")]
        public Output<string> LastModified { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The outputs for the Job.
        /// </summary>
        [Output("outputs")]
        public Output<ImmutableArray<Outputs.JobOutputAssetResponse>> Outputs { get; private set; } = null!;

        /// <summary>
        /// Priority with which the job should be processed. Higher priority jobs are processed before lower priority jobs. If not set, the default is normal.
        /// </summary>
        [Output("priority")]
        public Output<string?> Priority { get; private set; } = null!;

        /// <summary>
        /// The UTC date and time at which this Job began processing.
        /// </summary>
        [Output("startTime")]
        public Output<string> StartTime { get; private set; } = null!;

        /// <summary>
        /// The current state of the job.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Job resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Job(string name, JobArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:media/latest:Job", name, args ?? new JobArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Job(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:media/latest:Job", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20180330preview:Job"},
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20180601preview:Job"},
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20180701:Job"},
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20200501:Job"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Job resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Job Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Job(name, id, options);
        }
    }

    public sealed class JobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        [Input("correlationData")]
        private InputMap<string>? _correlationData;

        /// <summary>
        /// Customer provided key, value pairs that will be returned in Job and JobOutput state events.
        /// </summary>
        public InputMap<string> CorrelationData
        {
            get => _correlationData ?? (_correlationData = new InputMap<string>());
            set => _correlationData = value;
        }

        /// <summary>
        /// Optional customer supplied description of the Job.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The inputs for the Job.
        /// </summary>
        [Input("input", required: true)]
        public Input<object> Input { get; set; } = null!;

        /// <summary>
        /// The Job name.
        /// </summary>
        [Input("jobName", required: true)]
        public Input<string> JobName { get; set; } = null!;

        [Input("outputs", required: true)]
        private InputList<Inputs.JobOutputAssetArgs>? _outputs;

        /// <summary>
        /// The outputs for the Job.
        /// </summary>
        public InputList<Inputs.JobOutputAssetArgs> Outputs
        {
            get => _outputs ?? (_outputs = new InputList<Inputs.JobOutputAssetArgs>());
            set => _outputs = value;
        }

        /// <summary>
        /// Priority with which the job should be processed. Higher priority jobs are processed before lower priority jobs. If not set, the default is normal.
        /// </summary>
        [Input("priority")]
        public InputUnion<string, Pulumi.AzureNextGen.Media.Latest.Priority>? Priority { get; set; }

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Transform name.
        /// </summary>
        [Input("transformName", required: true)]
        public Input<string> TransformName { get; set; } = null!;

        public JobArgs()
        {
        }
    }
}
