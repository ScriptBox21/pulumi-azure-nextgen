// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.KeyVault.Latest.Outputs
{

    [OutputType]
    public sealed class PrivateEndpointConnectionItemResponse
    {
        /// <summary>
        /// Properties of the private endpoint object.
        /// </summary>
        public readonly Outputs.PrivateEndpointResponse? PrivateEndpoint;
        /// <summary>
        /// Approval state of the private link connection.
        /// </summary>
        public readonly Outputs.PrivateLinkServiceConnectionStateResponse? PrivateLinkServiceConnectionState;
        /// <summary>
        /// Provisioning state of the private endpoint connection.
        /// </summary>
        public readonly string ProvisioningState;

        [OutputConstructor]
        private PrivateEndpointConnectionItemResponse(
            Outputs.PrivateEndpointResponse? privateEndpoint,

            Outputs.PrivateLinkServiceConnectionStateResponse? privateLinkServiceConnectionState,

            string provisioningState)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }
    }
}
