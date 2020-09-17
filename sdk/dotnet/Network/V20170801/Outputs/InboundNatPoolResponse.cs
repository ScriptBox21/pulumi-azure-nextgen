// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20170801.Outputs
{

    [OutputType]
    public sealed class InboundNatPoolResponse
    {
        /// <summary>
        /// The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.
        /// </summary>
        public readonly int BackendPort;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// A reference to frontend IP addresses.
        /// </summary>
        public readonly Outputs.SubResourceResponse? FrontendIPConfiguration;
        /// <summary>
        /// The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65535.
        /// </summary>
        public readonly int FrontendPortRangeEnd;
        /// <summary>
        /// The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65534.
        /// </summary>
        public readonly int FrontendPortRangeStart;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The transport protocol for the endpoint. Possible values are: 'Udp' or 'Tcp'.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Gets the provisioning state of the PublicIP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string? ProvisioningState;

        [OutputConstructor]
        private InboundNatPoolResponse(
            int backendPort,

            string? etag,

            Outputs.SubResourceResponse? frontendIPConfiguration,

            int frontendPortRangeEnd,

            int frontendPortRangeStart,

            string? id,

            string? name,

            string protocol,

            string? provisioningState)
        {
            BackendPort = backendPort;
            Etag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            FrontendPortRangeStart = frontendPortRangeStart;
            Id = id;
            Name = name;
            Protocol = protocol;
            ProvisioningState = provisioningState;
        }
    }
}