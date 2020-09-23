// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190201
{
    public static class GetVirtualNetworkGatewayLearnedRoutes
    {
        public static Task<GetVirtualNetworkGatewayLearnedRoutesResult> InvokeAsync(GetVirtualNetworkGatewayLearnedRoutesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkGatewayLearnedRoutesResult>("azure-nextgen:network/v20190201:getVirtualNetworkGatewayLearnedRoutes", args ?? new GetVirtualNetworkGatewayLearnedRoutesArgs(), options.WithVersion());
    }


    public sealed class GetVirtualNetworkGatewayLearnedRoutesArgs : Pulumi.InvokeArgs
    {
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

        public GetVirtualNetworkGatewayLearnedRoutesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualNetworkGatewayLearnedRoutesResult
    {
        /// <summary>
        /// List of gateway routes
        /// </summary>
        public readonly ImmutableArray<Outputs.GatewayRouteResponseResult> Value;

        [OutputConstructor]
        private GetVirtualNetworkGatewayLearnedRoutesResult(ImmutableArray<Outputs.GatewayRouteResponseResult> value)
        {
            Value = value;
        }
    }
}
