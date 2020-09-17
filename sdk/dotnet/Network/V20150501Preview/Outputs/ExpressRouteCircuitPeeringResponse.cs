// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20150501Preview.Outputs
{

    [OutputType]
    public sealed class ExpressRouteCircuitPeeringResponse
    {
        /// <summary>
        /// Gets or sets the azure ASN
        /// </summary>
        public readonly int? AzureASN;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Gets or sets the Microsoft peering config
        /// </summary>
        public readonly Outputs.ExpressRouteCircuitPeeringConfigResponse? MicrosoftPeeringConfig;
        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Gets or sets the peer ASN
        /// </summary>
        public readonly int? PeerASN;
        /// <summary>
        /// Gets or sets PeeringType
        /// </summary>
        public readonly string? PeeringType;
        /// <summary>
        /// Gets or sets the primary port
        /// </summary>
        public readonly string? PrimaryAzurePort;
        /// <summary>
        /// Gets or sets the primary address prefix
        /// </summary>
        public readonly string? PrimaryPeerAddressPrefix;
        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Gets or sets the secondary port
        /// </summary>
        public readonly string? SecondaryAzurePort;
        /// <summary>
        /// Gets or sets the secondary address prefix
        /// </summary>
        public readonly string? SecondaryPeerAddressPrefix;
        /// <summary>
        /// Gets or sets the shared key
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// Gets or sets state of Peering
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// Gets or peering stats
        /// </summary>
        public readonly Outputs.ExpressRouteCircuitStatsResponse? Stats;
        /// <summary>
        /// Gets or sets the vlan id
        /// </summary>
        public readonly int? VlanId;

        [OutputConstructor]
        private ExpressRouteCircuitPeeringResponse(
            int? azureASN,

            string? etag,

            string? id,

            Outputs.ExpressRouteCircuitPeeringConfigResponse? microsoftPeeringConfig,

            string? name,

            int? peerASN,

            string? peeringType,

            string? primaryAzurePort,

            string? primaryPeerAddressPrefix,

            string? provisioningState,

            string? secondaryAzurePort,

            string? secondaryPeerAddressPrefix,

            string? sharedKey,

            string? state,

            Outputs.ExpressRouteCircuitStatsResponse? stats,

            int? vlanId)
        {
            AzureASN = azureASN;
            Etag = etag;
            Id = id;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            Name = name;
            PeerASN = peerASN;
            PeeringType = peeringType;
            PrimaryAzurePort = primaryAzurePort;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            ProvisioningState = provisioningState;
            SecondaryAzurePort = secondaryAzurePort;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            SharedKey = sharedKey;
            State = state;
            Stats = stats;
            VlanId = vlanId;
        }
    }
}