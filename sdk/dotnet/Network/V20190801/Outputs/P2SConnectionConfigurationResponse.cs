// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190801.Outputs
{

    [OutputType]
    public sealed class P2SConnectionConfigurationResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The provisioning state of the P2SConnectionConfiguration resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The reference of the address space resource which represents Address space for P2S VpnClient.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? VpnClientAddressPool;

        [OutputConstructor]
        private P2SConnectionConfigurationResponse(
            string etag,

            string? id,

            string? name,

            string provisioningState,

            Outputs.AddressSpaceResponse? vpnClientAddressPool)
        {
            Etag = etag;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            VpnClientAddressPool = vpnClientAddressPool;
        }
    }
}
