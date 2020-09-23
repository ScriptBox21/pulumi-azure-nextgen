// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190801
{
    public static class GetVirtualNetworkGatewayVpnclientConnectionHealth
    {
        public static Task<GetVirtualNetworkGatewayVpnclientConnectionHealthResult> InvokeAsync(GetVirtualNetworkGatewayVpnclientConnectionHealthArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkGatewayVpnclientConnectionHealthResult>("azure-nextgen:network/v20190801:getVirtualNetworkGatewayVpnclientConnectionHealth", args ?? new GetVirtualNetworkGatewayVpnclientConnectionHealthArgs(), options.WithVersion());
    }


    public sealed class GetVirtualNetworkGatewayVpnclientConnectionHealthArgs : Pulumi.InvokeArgs
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

        public GetVirtualNetworkGatewayVpnclientConnectionHealthArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualNetworkGatewayVpnclientConnectionHealthResult
    {
        /// <summary>
        /// List of vpn client connection health.
        /// </summary>
        public readonly ImmutableArray<Outputs.VpnClientConnectionHealthDetailResponseResult> Value;

        [OutputConstructor]
        private GetVirtualNetworkGatewayVpnclientConnectionHealthResult(ImmutableArray<Outputs.VpnClientConnectionHealthDetailResponseResult> value)
        {
            Value = value;
        }
    }
}
