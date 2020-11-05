// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701
{
    public static class GetPrivateLinkServicePrivateEndpointConnection
    {
        public static Task<GetPrivateLinkServicePrivateEndpointConnectionResult> InvokeAsync(GetPrivateLinkServicePrivateEndpointConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrivateLinkServicePrivateEndpointConnectionResult>("azure-nextgen:network/v20200701:getPrivateLinkServicePrivateEndpointConnection", args ?? new GetPrivateLinkServicePrivateEndpointConnectionArgs(), options.WithVersion());
    }


    public sealed class GetPrivateLinkServicePrivateEndpointConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the private end point connection.
        /// </summary>
        [Input("peConnectionName", required: true)]
        public string PeConnectionName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the private link service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetPrivateLinkServicePrivateEndpointConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPrivateLinkServicePrivateEndpointConnectionResult
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The consumer link id.
        /// </summary>
        public readonly string LinkIdentifier;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The resource of private end point.
        /// </summary>
        public readonly Outputs.PrivateEndpointResponse PrivateEndpoint;
        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        public readonly Outputs.PrivateLinkServiceConnectionStateResponse? PrivateLinkServiceConnectionState;
        /// <summary>
        /// The provisioning state of the private endpoint connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPrivateLinkServicePrivateEndpointConnectionResult(
            string etag,

            string linkIdentifier,

            string? name,

            Outputs.PrivateEndpointResponse privateEndpoint,

            Outputs.PrivateLinkServiceConnectionStateResponse? privateLinkServiceConnectionState,

            string provisioningState,

            string type)
        {
            Etag = etag;
            LinkIdentifier = linkIdentifier;
            Name = name;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}