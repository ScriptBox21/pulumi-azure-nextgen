// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180601
{
    public static class GetVirtualNetworkGatewayBgpPeerStatus
    {
        public static Task<GetVirtualNetworkGatewayBgpPeerStatusResult> InvokeAsync(GetVirtualNetworkGatewayBgpPeerStatusArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkGatewayBgpPeerStatusResult>("azure-nextgen:network/v20180601:getVirtualNetworkGatewayBgpPeerStatus", args ?? new GetVirtualNetworkGatewayBgpPeerStatusArgs(), options.WithVersion());
    }


    public sealed class GetVirtualNetworkGatewayBgpPeerStatusArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The IP address of the peer to retrieve the status of.
        /// </summary>
        [Input("peer")]
        public string? Peer { get; set; }

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

        public GetVirtualNetworkGatewayBgpPeerStatusArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualNetworkGatewayBgpPeerStatusResult
    {
        /// <summary>
        /// List of BGP peers
        /// </summary>
        public readonly ImmutableArray<Outputs.BgpPeerStatusResponseResult> Value;

        [OutputConstructor]
        private GetVirtualNetworkGatewayBgpPeerStatusResult(ImmutableArray<Outputs.BgpPeerStatusResponseResult> value)
        {
            Value = value;
        }
    }
}
