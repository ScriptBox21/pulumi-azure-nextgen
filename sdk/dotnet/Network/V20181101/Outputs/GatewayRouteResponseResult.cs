// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20181101.Outputs
{

    [OutputType]
    public sealed class GatewayRouteResponseResult
    {
        /// <summary>
        /// The route's AS path sequence
        /// </summary>
        public readonly string AsPath;
        /// <summary>
        /// The gateway's local address
        /// </summary>
        public readonly string LocalAddress;
        /// <summary>
        /// The route's network prefix
        /// </summary>
        public readonly string Network;
        /// <summary>
        /// The route's next hop
        /// </summary>
        public readonly string NextHop;
        /// <summary>
        /// The source this route was learned from
        /// </summary>
        public readonly string Origin;
        /// <summary>
        /// The peer this route was learned from
        /// </summary>
        public readonly string SourcePeer;
        /// <summary>
        /// The route's weight
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private GatewayRouteResponseResult(
            string asPath,

            string localAddress,

            string network,

            string nextHop,

            string origin,

            string sourcePeer,

            int weight)
        {
            AsPath = asPath;
            LocalAddress = localAddress;
            Network = network;
            NextHop = nextHop;
            Origin = origin;
            SourcePeer = sourcePeer;
            Weight = weight;
        }
    }
}
