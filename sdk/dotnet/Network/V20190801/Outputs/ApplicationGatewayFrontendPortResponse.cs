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
    public sealed class ApplicationGatewayFrontendPortResponse
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
        /// Name of the frontend port that is unique within an Application Gateway.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Frontend port.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// The provisioning state of the frontend port resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ApplicationGatewayFrontendPortResponse(
            string? etag,

            string? id,

            string? name,

            int? port,

            string provisioningState,

            string? type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            Port = port;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
