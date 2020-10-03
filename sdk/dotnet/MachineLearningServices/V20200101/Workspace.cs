// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200101
{
    /// <summary>
    /// An object that represents a machine learning workspace.
    /// </summary>
    public partial class Workspace : Pulumi.CustomResource
    {
        /// <summary>
        /// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Output("applicationInsights")]
        public Output<string?> ApplicationInsights { get; private set; } = null!;

        /// <summary>
        /// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Output("containerRegistry")]
        public Output<string?> ContainerRegistry { get; private set; } = null!;

        /// <summary>
        /// The creation time of the machine learning workspace in ISO8601 format.
        /// </summary>
        [Output("creationTime")]
        public Output<string> CreationTime { get; private set; } = null!;

        /// <summary>
        /// The description of this workspace.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Url for the discovery service to identify regional endpoints for machine learning experimentation services
        /// </summary>
        [Output("discoveryUrl")]
        public Output<string?> DiscoveryUrl { get; private set; } = null!;

        /// <summary>
        /// The encryption settings of Azure ML workspace.
        /// </summary>
        [Output("encryption")]
        public Output<Outputs.EncryptionPropertyResponse?> Encryption { get; private set; } = null!;

        /// <summary>
        /// The friendly name for this workspace. This name in mutable
        /// </summary>
        [Output("friendlyName")]
        public Output<string?> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
        /// </summary>
        [Output("hbiWorkspace")]
        public Output<bool?> HbiWorkspace { get; private set; } = null!;

        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.IdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Output("keyVault")]
        public Output<string?> KeyVault { get; private set; } = null!;

        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The current deployment state of workspace resource. The provisioningState is to indicate states for resource provisioning.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The name of the managed resource group created by workspace RP in customer subscription if the workspace is CMK workspace
        /// </summary>
        [Output("serviceProvisionedResourceGroup")]
        public Output<string> ServiceProvisionedResourceGroup { get; private set; } = null!;

        /// <summary>
        /// The sku of the workspace.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Output("storageAccount")]
        public Output<string?> StorageAccount { get; private set; } = null!;

        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Specifies the type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The immutable id associated with this workspace.
        /// </summary>
        [Output("workspaceId")]
        public Output<string> WorkspaceId { get; private set; } = null!;


        /// <summary>
        /// Create a Workspace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workspace(string name, WorkspaceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200101:Workspace", name, args ?? new WorkspaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workspace(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200101:Workspace", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/latest:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20180301preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20181119:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20190501:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20190601:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20191101:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200218preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200301:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200401:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200501preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200515preview:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200601:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200801:Workspace"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200901preview:Workspace"},
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
        /// ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Input("applicationInsights")]
        public Input<string>? ApplicationInsights { get; set; }

        /// <summary>
        /// ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Input("containerRegistry")]
        public Input<string>? ContainerRegistry { get; set; }

        /// <summary>
        /// The description of this workspace.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Url for the discovery service to identify regional endpoints for machine learning experimentation services
        /// </summary>
        [Input("discoveryUrl")]
        public Input<string>? DiscoveryUrl { get; set; }

        /// <summary>
        /// The encryption settings of Azure ML workspace.
        /// </summary>
        [Input("encryption")]
        public Input<Inputs.EncryptionPropertyArgs>? Encryption { get; set; }

        /// <summary>
        /// The friendly name for this workspace. This name in mutable
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service
        /// </summary>
        [Input("hbiWorkspace")]
        public Input<bool>? HbiWorkspace { get; set; }

        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.IdentityArgs>? Identity { get; set; }

        /// <summary>
        /// ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Input("keyVault")]
        public Input<string>? KeyVault { get; set; }

        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The sku of the workspace.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        /// <summary>
        /// ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created
        /// </summary>
        [Input("storageAccount")]
        public Input<string>? StorageAccount { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public WorkspaceArgs()
        {
        }
    }
}
