// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.OperationalInsights.V20200801
{
    /// <summary>
    /// The top level Workspace resource container.
    /// </summary>
    public partial class Workspace : Pulumi.CustomResource
    {
        /// <summary>
        /// This is a read-only property. Represents the ID associated with the workspace.
        /// </summary>
        [Output("customerId")]
        public Output<string> CustomerId { get; private set; } = null!;

        /// <summary>
        /// The ETag of the workspace.
        /// </summary>
        [Output("eTag")]
        public Output<string?> ETag { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of linked private link scope resources.
        /// </summary>
        [Output("privateLinkScopedResources")]
        public Output<ImmutableArray<Outputs.PrivateLinkScopedResourceResponse>> PrivateLinkScopedResources { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the workspace.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The network access type for accessing Log Analytics ingestion.
        /// </summary>
        [Output("publicNetworkAccessForIngestion")]
        public Output<string?> PublicNetworkAccessForIngestion { get; private set; } = null!;

        /// <summary>
        /// The network access type for accessing Log Analytics query.
        /// </summary>
        [Output("publicNetworkAccessForQuery")]
        public Output<string?> PublicNetworkAccessForQuery { get; private set; } = null!;

        /// <summary>
        /// The workspace data retention in days, between 30 and 730.
        /// </summary>
        [Output("retentionInDays")]
        public Output<int?> RetentionInDays { get; private set; } = null!;

        /// <summary>
        /// The SKU of the workspace.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.WorkspaceSkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The daily volume cap for ingestion.
        /// </summary>
        [Output("workspaceCapping")]
        public Output<Outputs.WorkspaceCappingResponse?> WorkspaceCapping { get; private set; } = null!;


        /// <summary>
        /// Create a Workspace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workspace(string name, WorkspaceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:operationalinsights/v20200801:Workspace", name, args ?? new WorkspaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workspace(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:operationalinsights/v20200801:Workspace", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:operationalinsights/latest:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:operationalinsights/v20151101preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:operationalinsights/v20200301preview:Workspace"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Workspace resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workspace Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Workspace(name, id, options);
        }
    }

    public sealed class WorkspaceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ETag of the workspace.
        /// </summary>
        [Input("eTag")]
        public Input<string>? ETag { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The provisioning state of the workspace.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// The network access type for accessing Log Analytics ingestion.
        /// </summary>
        [Input("publicNetworkAccessForIngestion")]
        public Input<string>? PublicNetworkAccessForIngestion { get; set; }

        /// <summary>
        /// The network access type for accessing Log Analytics query.
        /// </summary>
        [Input("publicNetworkAccessForQuery")]
        public Input<string>? PublicNetworkAccessForQuery { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The workspace data retention in days, between 30 and 730.
        /// </summary>
        [Input("retentionInDays")]
        public Input<int>? RetentionInDays { get; set; }

        /// <summary>
        /// The SKU of the workspace.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.WorkspaceSkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The daily volume cap for ingestion.
        /// </summary>
        [Input("workspaceCapping")]
        public Input<Inputs.WorkspaceCappingArgs>? WorkspaceCapping { get; set; }

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public WorkspaceArgs()
        {
        }
    }
}
