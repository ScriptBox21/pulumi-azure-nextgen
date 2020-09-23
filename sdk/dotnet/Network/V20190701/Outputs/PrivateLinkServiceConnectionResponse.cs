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
    public sealed class PrivateLinkServiceConnectionResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        public readonly ImmutableArray<string> GroupIds;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// A collection of read-only information about the state of the connection to the remote resource.
        /// </summary>
        public readonly Outputs.PrivateLinkServiceConnectionStateResponse? PrivateLinkServiceConnectionState;
        /// <summary>
        /// The resource id of private link service.
        /// </summary>
        public readonly string? PrivateLinkServiceId;
        /// <summary>
        /// The provisioning state of the private link service connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars.
        /// </summary>
        public readonly string? RequestMessage;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PrivateLinkServiceConnectionResponse(
            string etag,

            ImmutableArray<string> groupIds,

            string? id,

            string? name,

            Outputs.PrivateLinkServiceConnectionStateResponse? privateLinkServiceConnectionState,

            string? privateLinkServiceId,

            string provisioningState,

            string? requestMessage,

            string type)
        {
            Etag = etag;
            GroupIds = groupIds;
            Id = id;
            Name = name;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            PrivateLinkServiceId = privateLinkServiceId;
            ProvisioningState = provisioningState;
            RequestMessage = requestMessage;
            Type = type;
        }
    }
}
