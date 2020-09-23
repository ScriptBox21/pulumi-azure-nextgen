// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180601.Outputs
{

    [OutputType]
    public sealed class AzureFirewallIPConfigurationResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Reference of the PublicIP resource. This field is a mandatory input.
        /// </summary>
        public readonly Outputs.SubResourceResponse? InternalPublicIpAddress;
        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The Firewall Internal Load Balancer IP to be used as the next hop in User Defined Routes.
        /// </summary>
        public readonly string? PrivateIPAddress;
        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Reference of the PublicIP resource. This field is populated in the output.
        /// </summary>
        public readonly Outputs.SubResourceResponse? PublicIPAddress;
        /// <summary>
        /// Reference of the subnet resource. This resource must be named 'AzureFirewallSubnet'.
        /// </summary>
        public readonly Outputs.SubResourceResponse? Subnet;

        [OutputConstructor]
        private AzureFirewallIPConfigurationResponse(
            string? etag,

            string? id,

            Outputs.SubResourceResponse? internalPublicIpAddress,

            string? name,

            string? privateIPAddress,

            string provisioningState,

            Outputs.SubResourceResponse? publicIPAddress,

            Outputs.SubResourceResponse? subnet)
        {
            Etag = etag;
            Id = id;
            InternalPublicIpAddress = internalPublicIpAddress;
            Name = name;
            PrivateIPAddress = privateIPAddress;
            ProvisioningState = provisioningState;
            PublicIPAddress = publicIPAddress;
            Subnet = subnet;
        }
    }
}
