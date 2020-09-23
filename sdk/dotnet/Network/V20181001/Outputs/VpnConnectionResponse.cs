// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20181001.Outputs
{

    [OutputType]
    public sealed class VpnConnectionResponse
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
        /// Egress bytes transferred.
        /// </summary>
        public readonly int EgressBytesTransferred;
        /// <summary>
        /// EnableBgp flag
        /// </summary>
        public readonly bool? EnableBgp;
        /// <summary>
        /// Enable internet security
        /// </summary>
        public readonly bool? EnableInternetSecurity;
        /// <summary>
        /// EnableBgp flag
        /// </summary>
        public readonly bool? EnableRateLimiting;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
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
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Id of the connected vpn site.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RemoteVpnSite;
        /// <summary>
        /// routing weight for vpn connection.
        /// </summary>
        public readonly int? RoutingWeight;
        /// <summary>
        /// SharedKey for the vpn connection.
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// Connection protocol used for this connection
        /// </summary>
        public readonly string? VpnConnectionProtocolType;

        [OutputConstructor]
        private VpnConnectionResponse(
            int? connectionBandwidth,

            string connectionStatus,

            int egressBytesTransferred,

            bool? enableBgp,

            bool? enableInternetSecurity,

            bool? enableRateLimiting,

            string etag,

            string? id,

            int ingressBytesTransferred,

            ImmutableArray<Outputs.IpsecPolicyResponse> ipsecPolicies,

            string? name,

            string provisioningState,

            Outputs.SubResourceResponse? remoteVpnSite,

            int? routingWeight,

            string? sharedKey,

            string? vpnConnectionProtocolType)
        {
            ConnectionBandwidth = connectionBandwidth;
            ConnectionStatus = connectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            EnableBgp = enableBgp;
            EnableInternetSecurity = enableInternetSecurity;
            EnableRateLimiting = enableRateLimiting;
            Etag = etag;
            Id = id;
            IngressBytesTransferred = ingressBytesTransferred;
            IpsecPolicies = ipsecPolicies;
            Name = name;
            ProvisioningState = provisioningState;
            RemoteVpnSite = remoteVpnSite;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
        }
    }
}
