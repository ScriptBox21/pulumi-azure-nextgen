// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200401
{
    public static class GetVpnConnection
    {
        public static Task<GetVpnConnectionResult> InvokeAsync(GetVpnConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVpnConnectionResult>("azure-nextgen:network/v20200401:getVpnConnection", args ?? new GetVpnConnectionArgs(), options.WithVersion());
    }


    public sealed class GetVpnConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the vpn connection.
        /// </summary>
        [Input("connectionName", required: true)]
        public string ConnectionName { get; set; } = null!;

        /// <summary>
        /// The name of the gateway.
        /// </summary>
        [Input("gatewayName", required: true)]
        public string GatewayName { get; set; } = null!;

        /// <summary>
        /// The resource group name of the VpnGateway.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetVpnConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVpnConnectionResult
    {
        /// <summary>
        /// Expected bandwidth in MBPS.
        /// </summary>
        public readonly int? ConnectionBandwidth;
        /// <summary>
        /// The connection status.
        /// </summary>
        public readonly string ConnectionStatus;
        /// <summary>
        /// The dead peer detection timeout for a vpn connection in seconds.
        /// </summary>
        public readonly int? DpdTimeoutSeconds;
        /// <summary>
        /// Egress bytes transferred.
        /// </summary>
        public readonly int EgressBytesTransferred;
        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        public readonly bool? EnableBgp;
        /// <summary>
        /// Enable internet security.
        /// </summary>
        public readonly bool? EnableInternetSecurity;
        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        public readonly bool? EnableRateLimiting;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Ingress bytes transferred.
        /// </summary>
        public readonly int IngressBytesTransferred;
        /// <summary>
        /// The IPSec Policies to be considered by this connection.
        /// </summary>
        public readonly ImmutableArray<Outputs.IpsecPolicyResponse> IpsecPolicies;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The provisioning state of the VPN connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Id of the connected vpn site.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RemoteVpnSite;
        /// <summary>
        /// The Routing Configuration indicating the associated and propagated route tables on this connection.
        /// </summary>
        public readonly Outputs.RoutingConfigurationResponse? RoutingConfiguration;
        /// <summary>
        /// Routing weight for vpn connection.
        /// </summary>
        public readonly int? RoutingWeight;
        /// <summary>
        /// SharedKey for the vpn connection.
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// Use local azure ip to initiate connection.
        /// </summary>
        public readonly bool? UseLocalAzureIpAddress;
        /// <summary>
        /// Enable policy-based traffic selectors.
        /// </summary>
        public readonly bool? UsePolicyBasedTrafficSelectors;
        /// <summary>
        /// Connection protocol used for this connection.
        /// </summary>
        public readonly string? VpnConnectionProtocolType;
        /// <summary>
        /// List of all vpn site link connections to the gateway.
        /// </summary>
        public readonly ImmutableArray<Outputs.VpnSiteLinkConnectionResponse> VpnLinkConnections;

        [OutputConstructor]
        private GetVpnConnectionResult(
            int? connectionBandwidth,

            string connectionStatus,

            int? dpdTimeoutSeconds,

            int egressBytesTransferred,

            bool? enableBgp,

            bool? enableInternetSecurity,

            bool? enableRateLimiting,

            string etag,

            int ingressBytesTransferred,

            ImmutableArray<Outputs.IpsecPolicyResponse> ipsecPolicies,

            string? name,

            string provisioningState,

            Outputs.SubResourceResponse? remoteVpnSite,

            Outputs.RoutingConfigurationResponse? routingConfiguration,

            int? routingWeight,

            string? sharedKey,

            bool? useLocalAzureIpAddress,

            bool? usePolicyBasedTrafficSelectors,

            string? vpnConnectionProtocolType,

            ImmutableArray<Outputs.VpnSiteLinkConnectionResponse> vpnLinkConnections)
        {
            ConnectionBandwidth = connectionBandwidth;
            ConnectionStatus = connectionStatus;
            DpdTimeoutSeconds = dpdTimeoutSeconds;
            EgressBytesTransferred = egressBytesTransferred;
            EnableBgp = enableBgp;
            EnableInternetSecurity = enableInternetSecurity;
            EnableRateLimiting = enableRateLimiting;
            Etag = etag;
            IngressBytesTransferred = ingressBytesTransferred;
            IpsecPolicies = ipsecPolicies;
            Name = name;
            ProvisioningState = provisioningState;
            RemoteVpnSite = remoteVpnSite;
            RoutingConfiguration = routingConfiguration;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            UseLocalAzureIpAddress = useLocalAzureIpAddress;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
            VpnLinkConnections = vpnLinkConnections;
        }
    }
}
