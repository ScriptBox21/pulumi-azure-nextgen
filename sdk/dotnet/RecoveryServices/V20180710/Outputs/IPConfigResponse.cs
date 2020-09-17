// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20180710.Outputs
{

    [OutputType]
    public sealed class IPConfigResponse
    {
        /// <summary>
        /// The backend address pools associated with the IP configuration.
        /// </summary>
        public readonly ImmutableArray<string> LBBackendAddressPoolIds;
        /// <summary>
        /// The Id of the public IP address associated with the IP configuration.
        /// </summary>
        public readonly string? PublicIpAddressId;
        /// <summary>
        /// The static IP address of the IP configuration.
        /// </summary>
        public readonly string? StaticIPAddress;

        [OutputConstructor]
        private IPConfigResponse(
            ImmutableArray<string> lBBackendAddressPoolIds,

            string? publicIpAddressId,

            string? staticIPAddress)
        {
            LBBackendAddressPoolIds = lBBackendAddressPoolIds;
            PublicIpAddressId = publicIpAddressId;
            StaticIPAddress = staticIPAddress;
        }
    }
}