// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20181001
{
    /// <summary>
    /// Service End point policy resource.
    /// </summary>
    public partial class ServiceEndpointPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the service endpoint policy. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The resource GUID property of the service endpoint policy resource.
        /// </summary>
        [Output("resourceGuid")]
        public Output<string> ResourceGuid { get; private set; } = null!;

        /// <summary>
        /// A collection of service endpoint policy definitions of the service endpoint policy.
        /// </summary>
        [Output("serviceEndpointPolicyDefinitions")]
        public Output<ImmutableArray<Outputs.ServiceEndpointPolicyDefinitionResponse>> ServiceEndpointPolicyDefinitions { get; private set; } = null!;

        /// <summary>
        /// A collection of references to subnets.
        /// </summary>
        [Output("subnets")]
        public Output<ImmutableArray<Outputs.SubnetResponse>> Subnets { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceEndpointPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceEndpointPolicy(string name, ServiceEndpointPolicyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20181001:ServiceEndpointPolicy", name, args ?? new ServiceEndpointPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceEndpointPolicy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20181001:ServiceEndpointPolicy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:ServiceEndpointPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:ServiceEndpointPolicy"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServiceEndpointPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceEndpointPolicy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServiceEndpointPolicy(name, id, options);
        }
    }

    public sealed class ServiceEndpointPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("serviceEndpointPolicyDefinitions")]
        private InputList<Inputs.ServiceEndpointPolicyDefinitionArgs>? _serviceEndpointPolicyDefinitions;

        /// <summary>
        /// A collection of service endpoint policy definitions of the service endpoint policy.
        /// </summary>
        public InputList<Inputs.ServiceEndpointPolicyDefinitionArgs> ServiceEndpointPolicyDefinitions
        {
            get => _serviceEndpointPolicyDefinitions ?? (_serviceEndpointPolicyDefinitions = new InputList<Inputs.ServiceEndpointPolicyDefinitionArgs>());
            set => _serviceEndpointPolicyDefinitions = value;
        }

        /// <summary>
        /// The name of the service endpoint policy.
        /// </summary>
        [Input("serviceEndpointPolicyName", required: true)]
        public Input<string> ServiceEndpointPolicyName { get; set; } = null!;

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

        public ServiceEndpointPolicyArgs()
        {
        }
    }
}