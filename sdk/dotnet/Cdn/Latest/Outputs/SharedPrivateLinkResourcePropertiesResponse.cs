// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.Latest.Outputs
{

    [OutputType]
    public sealed class SharedPrivateLinkResourcePropertiesResponse
    {
        /// <summary>
        /// The group id from the provider of resource the shared private link resource is for.
        /// </summary>
        public readonly string? GroupId;
        /// <summary>
        /// The resource id of the resource the shared private link resource is for.
        /// </summary>
        public readonly Outputs.ResourceReferenceResponse? PrivateLink;
        /// <summary>
        /// The location of the shared private link resource
        /// </summary>
        public readonly string? PrivateLinkLocation;
        /// <summary>
        /// The request message for requesting approval of the shared private link resource.
        /// </summary>
        public readonly string? RequestMessage;
        /// <summary>
        /// Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private SharedPrivateLinkResourcePropertiesResponse(
            string? groupId,

            Outputs.ResourceReferenceResponse? privateLink,

            string? privateLinkLocation,

            string? requestMessage,

            string? status)
        {
            GroupId = groupId;
            PrivateLink = privateLink;
            PrivateLinkLocation = privateLinkLocation;
            RequestMessage = requestMessage;
            Status = status;
        }
    }
}
