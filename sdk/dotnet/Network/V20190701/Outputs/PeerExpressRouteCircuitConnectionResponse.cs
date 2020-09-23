// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701.Outputs
{

    [OutputType]
    public sealed class PeerExpressRouteCircuitConnectionResponse
    {
        /// <summary>
        /// /29 IP address space to carve out Customer addresses for tunnels.
        /// </summary>
        public readonly string? AddressPrefix;
        /// <summary>
        /// The resource guid of the authorization used for the express route circuit connection.
        /// </summary>
        public readonly string? AuthResourceGuid;
        /// <summary>
        /// Express Route Circuit connection state.
        /// </summary>
        public readonly string CircuitConnectionStatus;
        /// <summary>
        /// The name of the express route circuit connection resource.
        /// </summary>
        public readonly string? ConnectionName;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Reference to Express Route Circuit Private Peering Resource of the circuit.
        /// </summary>
        public readonly Outputs.SubResourceResponse? ExpressRouteCircuitPeering;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Reference to Express Route Circuit Private Peering Resource of the peered circuit.
        /// </summary>
        public readonly Outputs.SubResourceResponse? PeerExpressRouteCircuitPeering;
        /// <summary>
        /// The provisioning state of the peer express route circuit connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PeerExpressRouteCircuitConnectionResponse(
            string? addressPrefix,

            string? authResourceGuid,

            string circuitConnectionStatus,

            string? connectionName,

            string etag,

            Outputs.SubResourceResponse? expressRouteCircuitPeering,

            string? id,

            string? name,

            Outputs.SubResourceResponse? peerExpressRouteCircuitPeering,

            string provisioningState,

            string type)
        {
            AddressPrefix = addressPrefix;
            AuthResourceGuid = authResourceGuid;
            CircuitConnectionStatus = circuitConnectionStatus;
            ConnectionName = connectionName;
            Etag = etag;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            Id = id;
            Name = name;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
