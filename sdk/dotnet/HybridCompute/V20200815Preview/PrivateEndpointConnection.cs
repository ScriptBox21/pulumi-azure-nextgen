// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridCompute.V20200815Preview
{
    /// <summary>
    /// A private endpoint connection
    /// </summary>
    public partial class PrivateEndpointConnection : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Private endpoint which the connection belongs to.
        /// </summary>
        [Output("privateEndpoint")]
        public Output<Outputs.PrivateEndpointPropertyResponse?> PrivateEndpoint { get; private set; } = null!;

        /// <summary>
        /// Connection state of the private endpoint connection.
        /// </summary>
        [Output("privateLinkServiceConnectionState")]
        public Output<Outputs.PrivateLinkServiceConnectionStatePropertyResponse?> PrivateLinkServiceConnectionState { get; private set; } = null!;

        /// <summary>
        /// State of the private endpoint connection.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a PrivateEndpointConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PrivateEndpointConnection(string name, PrivateEndpointConnectionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:hybridcompute/v20200815preview:PrivateEndpointConnection", name, args ?? new PrivateEndpointConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PrivateEndpointConnection(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:hybridcompute/v20200815preview:PrivateEndpointConnection", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing PrivateEndpointConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PrivateEndpointConnection Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PrivateEndpointConnection(name, id, options);
        }
    }

    public sealed class PrivateEndpointConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Private endpoint which the connection belongs to.
        /// </summary>
        [Input("privateEndpoint")]
        public Input<Inputs.PrivateEndpointPropertyArgs>? PrivateEndpoint { get; set; }

        /// <summary>
        /// The name of the private endpoint connection.
        /// </summary>
        [Input("privateEndpointConnectionName", required: true)]
        public Input<string> PrivateEndpointConnectionName { get; set; } = null!;

        /// <summary>
        /// Connection state of the private endpoint connection.
        /// </summary>
        [Input("privateLinkServiceConnectionState")]
        public Input<Inputs.PrivateLinkServiceConnectionStatePropertyArgs>? PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Azure Arc PrivateLinkScope resource.
        /// </summary>
        [Input("scopeName", required: true)]
        public Input<string> ScopeName { get; set; } = null!;

        public PrivateEndpointConnectionArgs()
        {
        }
    }
}
