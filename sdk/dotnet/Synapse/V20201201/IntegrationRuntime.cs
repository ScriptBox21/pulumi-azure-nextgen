// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20201201
{
    /// <summary>
    /// Integration runtime resource type.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:synapse/v20201201:IntegrationRuntime")]
    public partial class IntegrationRuntime : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource Etag.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Integration runtime properties.
        /// </summary>
        [Output("properties")]
        public Output<Union<Outputs.ManagedIntegrationRuntimeResponse, Outputs.SelfHostedIntegrationRuntimeResponse>> Properties { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a IntegrationRuntime resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IntegrationRuntime(string name, IntegrationRuntimeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20201201:IntegrationRuntime", name, args ?? new IntegrationRuntimeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IntegrationRuntime(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20201201:IntegrationRuntime", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:synapse/latest:IntegrationRuntime"},
                    new Pulumi.Alias { Type = "azure-nextgen:synapse/v20190601preview:IntegrationRuntime"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IntegrationRuntime resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IntegrationRuntime Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new IntegrationRuntime(name, id, options);
        }
    }

    public sealed class IntegrationRuntimeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Integration runtime name
        /// </summary>
        [Input("integrationRuntimeName", required: true)]
        public Input<string> IntegrationRuntimeName { get; set; } = null!;

        /// <summary>
        /// Integration runtime properties.
        /// </summary>
        [Input("properties", required: true)]
        public InputUnion<Inputs.ManagedIntegrationRuntimeArgs, Inputs.SelfHostedIntegrationRuntimeArgs> Properties { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public IntegrationRuntimeArgs()
        {
        }
    }
}
