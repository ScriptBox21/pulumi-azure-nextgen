// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200401.Outputs
{

    [OutputType]
    public sealed class VpnClientConnectionHealthDetailResponseResult
    {
        /// <summary>
        /// The egress bytes per second.
        /// </summary>
        public readonly int EgressBytesTransferred;
        /// <summary>
        /// The egress packets per second.
        /// </summary>
        public readonly int EgressPacketsTransferred;
        /// <summary>
        /// The ingress bytes per second.
        /// </summary>
        public readonly int IngressBytesTransferred;
        /// <summary>
        /// The ingress packets per second.
        /// </summary>
        public readonly int IngressPacketsTransferred;
        /// <summary>
        /// The max band width.
        /// </summary>
        public readonly int MaxBandwidth;
        /// <summary>
        /// The max packets transferred per second.
        /// </summary>
        public readonly int MaxPacketsPerSecond;
        /// <summary>
        /// The assigned private Ip of a connected vpn client.
        /// </summary>
        public readonly string PrivateIpAddress;
        /// <summary>
        /// The public Ip of a connected vpn client.
        /// </summary>
        public readonly string PublicIpAddress;
        /// <summary>
        /// The duration time of a connected vpn client.
        /// </summary>
        public readonly int VpnConnectionDuration;
        /// <summary>
        /// The vpn client Id.
        /// </summary>
        public readonly string VpnConnectionId;
        /// <summary>
        /// The start time of a connected vpn client.
        /// </summary>
        public readonly string VpnConnectionTime;
        /// <summary>
        /// The user name of a connected vpn client.
        /// </summary>
        public readonly string VpnUserName;

        [OutputConstructor]
        private VpnClientConnectionHealthDetailResponseResult(
            int egressBytesTransferred,

            int egressPacketsTransferred,

            int ingressBytesTransferred,

            int ingressPacketsTransferred,

            int maxBandwidth,

            int maxPacketsPerSecond,

            string privateIpAddress,

            string publicIpAddress,

            int vpnConnectionDuration,

            string vpnConnectionId,

            string vpnConnectionTime,

            string vpnUserName)
        {
            EgressBytesTransferred = egressBytesTransferred;
            EgressPacketsTransferred = egressPacketsTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            IngressPacketsTransferred = ingressPacketsTransferred;
            MaxBandwidth = maxBandwidth;
            MaxPacketsPerSecond = maxPacketsPerSecond;
            PrivateIpAddress = privateIpAddress;
            PublicIpAddress = publicIpAddress;
            VpnConnectionDuration = vpnConnectionDuration;
            VpnConnectionId = vpnConnectionId;
            VpnConnectionTime = vpnConnectionTime;
            VpnUserName = vpnUserName;
        }
    }
}
