// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class PrivateLinkConnectionStateResponse
    {
        /// <summary>
        /// ActionsRequired for a private link connection
        /// </summary>
        public readonly string? ActionsRequired;
        /// <summary>
        /// Description of a private link connection
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Status of a private link connection
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private PrivateLinkConnectionStateResponse(
            string? actionsRequired,

            string? description,

            string? status)
        {
            ActionsRequired = actionsRequired;
            Description = description;
            Status = status;
        }
    }
}
