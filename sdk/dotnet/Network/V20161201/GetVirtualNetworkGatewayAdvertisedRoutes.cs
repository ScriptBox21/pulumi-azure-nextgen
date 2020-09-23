// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20161201
{
    public static class GetVirtualNetworkGatewayAdvertisedRoutes
    {
        public static Task<GetVirtualNetworkGatewayAdvertisedRoutesResult> InvokeAsync(GetVirtualNetworkGatewayAdvertisedRoutesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkGatewayAdvertisedRoutesResult>("azure-nextgen:network/v20161201:getVirtualNetworkGatewayAdvertisedRoutes", args ?? new GetVirtualNetworkGatewayAdvertisedRoutesArgs(), options.WithVersion());
    }


    public sealed class GetVirtualNetworkGatewayAdvertisedRoutesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The IP address of the peer
        /// </summary>
        [Input("peer", required: true)]
        public string Peer { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual network gateway.
        /// </summary>
        [Input("virtualNetworkGatewayName", required: true)]
        public string VirtualNetworkGatewayName { get; set; } = null!;

        public GetVirtualNetworkGatewayAdvertisedRoutesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualNetworkGatewayAdvertisedRoutesResult
    {
        /// <summary>
        /// List of gateway routes
        /// </summary>
        public readonly ImmutableArray<Outputs.GatewayRouteResponseResult> Value;

        [OutputConstructor]
        private GetVirtualNetworkGatewayAdvertisedRoutesResult(ImmutableArray<Outputs.GatewayRouteResponseResult> value)
        {
            Value = value;
        }
    }
}
