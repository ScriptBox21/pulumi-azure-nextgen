// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20190601.Outputs
{

    [OutputType]
    public sealed class ContainerServiceNetworkProfileResponse
    {
        /// <summary>
        /// An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr.
        /// </summary>
        public readonly string? DnsServiceIP;
        /// <summary>
        /// A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the Kubernetes service address range.
        /// </summary>
        public readonly string? DockerBridgeCidr;
        /// <summary>
        /// The load balancer sku for the managed cluster.
        /// </summary>
        public readonly string? LoadBalancerSku;
        /// <summary>
        /// Network plugin used for building Kubernetes network.
        /// </summary>
        public readonly string? NetworkPlugin;
        /// <summary>
        /// Network policy used for building Kubernetes network.
        /// </summary>
        public readonly string? NetworkPolicy;
        /// <summary>
        /// A CIDR notation IP range from which to assign pod IPs when kubenet is used.
        /// </summary>
        public readonly string? PodCidr;
        /// <summary>
        /// A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges.
        /// </summary>
        public readonly string? ServiceCidr;

        [OutputConstructor]
        private ContainerServiceNetworkProfileResponse(
            string? dnsServiceIP,

            string? dockerBridgeCidr,

            string? loadBalancerSku,

            string? networkPlugin,

            string? networkPolicy,

            string? podCidr,

            string? serviceCidr)
        {
            DnsServiceIP = dnsServiceIP;
            DockerBridgeCidr = dockerBridgeCidr;
            LoadBalancerSku = loadBalancerSku;
            NetworkPlugin = networkPlugin;
            NetworkPolicy = networkPolicy;
            PodCidr = podCidr;
            ServiceCidr = serviceCidr;
        }
    }
}