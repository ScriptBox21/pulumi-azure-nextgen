// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridNetwork.V20200101Preview.Outputs
{

    [OutputType]
    public sealed class NetworkFunctionUserConfigurationResponse
    {
        /// <summary>
        /// The network interface configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceResponse> NetworkInterfaces;
        /// <summary>
        /// Specifies the operating system settings for the role instance.
        /// </summary>
        public readonly Outputs.NetworkFunctionUserConfigurationResponseOsProfile? OsProfile;
        /// <summary>
        /// The name of the network function role.
        /// </summary>
        public readonly string? RoleName;
        /// <summary>
        /// The user data parameters from the customer.
        /// </summary>
        public readonly object? UserDataParameters;

        [OutputConstructor]
        private NetworkFunctionUserConfigurationResponse(
            ImmutableArray<Outputs.NetworkInterfaceResponse> networkInterfaces,

            Outputs.NetworkFunctionUserConfigurationResponseOsProfile? osProfile,

            string? roleName,

            object? userDataParameters)
        {
            NetworkInterfaces = networkInterfaces;
            OsProfile = osProfile;
            RoleName = roleName;
            UserDataParameters = userDataParameters;
        }
    }
}