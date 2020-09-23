// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701
{
    public static class GetP2sVpnGatewayP2sVpnConnectionHealth
    {
        public static Task<GetP2sVpnGatewayP2sVpnConnectionHealthResult> InvokeAsync(GetP2sVpnGatewayP2sVpnConnectionHealthArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetP2sVpnGatewayP2sVpnConnectionHealthResult>("azure-nextgen:network/v20190701:getP2sVpnGatewayP2sVpnConnectionHealth", args ?? new GetP2sVpnGatewayP2sVpnConnectionHealthArgs(), options.WithVersion());
    }


    public sealed class GetP2sVpnGatewayP2sVpnConnectionHealthArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the P2SVpnGateway.
        /// </summary>
        [Input("gatewayName", required: true)]
        public string GatewayName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetP2sVpnGatewayP2sVpnConnectionHealthArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetP2sVpnGatewayP2sVpnConnectionHealthResult
    {
        /// <summary>
        /// The reference of the address space resource which represents the custom routes specified by the customer for P2SVpnGateway and P2S VpnClient.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? CustomRoutes;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The P2SVpnServerConfiguration to which the p2sVpnGateway is attached to.
        /// </summary>
        public readonly Outputs.SubResourceResponse? P2SVpnServerConfiguration;
        /// <summary>
        /// The provisioning state of the P2S VPN gateway resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The VirtualHub to which the gateway belongs.
        /// </summary>
        public readonly Outputs.SubResourceResponse? VirtualHub;
        /// <summary>
        /// The reference of the address space resource which represents Address space for P2S VpnClient.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? VpnClientAddressPool;
        /// <summary>
        /// All P2S VPN clients' connection health status.
        /// </summary>
        public readonly Outputs.VpnClientConnectionHealthResponse VpnClientConnectionHealth;
        /// <summary>
        /// The scale unit for this p2s vpn gateway.
        /// </summary>
        public readonly int? VpnGatewayScaleUnit;

        [OutputConstructor]
        private GetP2sVpnGatewayP2sVpnConnectionHealthResult(
            Outputs.AddressSpaceResponse? customRoutes,

            string etag,

            string location,

            string name,

            Outputs.SubResourceResponse? p2SVpnServerConfiguration,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.SubResourceResponse? virtualHub,

            Outputs.AddressSpaceResponse? vpnClientAddressPool,

            Outputs.VpnClientConnectionHealthResponse vpnClientConnectionHealth,

            int? vpnGatewayScaleUnit)
        {
            CustomRoutes = customRoutes;
            Etag = etag;
            Location = location;
            Name = name;
            P2SVpnServerConfiguration = p2SVpnServerConfiguration;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            VirtualHub = virtualHub;
            VpnClientAddressPool = vpnClientAddressPool;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
        }
    }
}
