// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20210101.Outputs
{

    [OutputType]
    public sealed class SharedPrivateLinkResourceResponse
    {
        /// <summary>
        /// The private link resource group id.
        /// </summary>
        public readonly string? GroupId;
        /// <summary>
        /// Unique name of the private link.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The resource id that private link links to.
        /// </summary>
        public readonly string? PrivateLinkResourceId;
        /// <summary>
        /// Request message.
        /// </summary>
        public readonly string? RequestMessage;
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private SharedPrivateLinkResourceResponse(
            string? groupId,

            string? name,

            string? privateLinkResourceId,

            string? requestMessage,

            string? status)
        {
            GroupId = groupId;
            Name = name;
            PrivateLinkResourceId = privateLinkResourceId;
            RequestMessage = requestMessage;
            Status = status;
        }
    }
}
