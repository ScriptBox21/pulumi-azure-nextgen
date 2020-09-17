// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20150615.Outputs
{

    [OutputType]
    public sealed class LoadBalancingRuleResponse
    {
        /// <summary>
        /// A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend IPs.
        /// </summary>
        public readonly Outputs.SubResourceResponse? BackendAddressPool;
        /// <summary>
        /// The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535. 
        /// </summary>
        public readonly int? BackendPort;
        /// <summary>
        /// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
        /// </summary>
        public readonly bool? EnableFloatingIP;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// A reference to frontend IP addresses.
        /// </summary>
        public readonly Outputs.SubResourceResponse? FrontendIPConfiguration;
        /// <summary>
        /// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 1 and 65534.
        /// </summary>
        public readonly int FrontendPort;
        /// <summary>
        /// Resource Identifier.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
        /// </summary>
        public readonly int? IdleTimeoutInMinutes;
        /// <summary>
        /// The load distribution policy for this rule. Possible values are 'Default', 'SourceIP', and 'SourceIPProtocol'.
        /// </summary>
        public readonly string? LoadDistribution;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The reference of the load balancer probe used by the load balancing rule.
        /// </summary>
        public readonly Outputs.SubResourceResponse? Probe;
        /// <summary>
        /// The transport protocol for the external endpoint. Possible values are 'Udp' or 'Tcp'
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Gets the provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string? ProvisioningState;

        [OutputConstructor]
        private LoadBalancingRuleResponse(
            Outputs.SubResourceResponse? backendAddressPool,

            int? backendPort,

            bool? enableFloatingIP,

            string? etag,

            Outputs.SubResourceResponse? frontendIPConfiguration,

            int frontendPort,

            string? id,

            int? idleTimeoutInMinutes,

            string? loadDistribution,

            string? name,

            Outputs.SubResourceResponse? probe,

            string protocol,

            string? provisioningState)
        {
            BackendAddressPool = backendAddressPool;
            BackendPort = backendPort;
            EnableFloatingIP = enableFloatingIP;
            Etag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPort = frontendPort;
            Id = id;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            LoadDistribution = loadDistribution;
            Name = name;
            Probe = probe;
            Protocol = protocol;
            ProvisioningState = provisioningState;
        }
    }
}