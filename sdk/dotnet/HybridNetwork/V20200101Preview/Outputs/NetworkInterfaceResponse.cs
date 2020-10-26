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
    public sealed class NetworkInterfaceResponse
    {
        /// <summary>
        /// A list of IP configurations of the network interface.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceIPConfigurationResponse> IpConfigurations;
        /// <summary>
        /// The MAC address of the network interface.
        /// </summary>
        public readonly string? MacAddress;
        /// <summary>
        /// The name of the network interface.
        /// </summary>
        public readonly string? NetworkInterfaceName;
        /// <summary>
        /// The type of the VM switch.
        /// </summary>
        public readonly string? VmSwitchType;

        [OutputConstructor]
        private NetworkInterfaceResponse(
            ImmutableArray<Outputs.NetworkInterfaceIPConfigurationResponse> ipConfigurations,

            string? macAddress,

            string? networkInterfaceName,

            string? vmSwitchType)
        {
            IpConfigurations = ipConfigurations;
            MacAddress = macAddress;
            NetworkInterfaceName = networkInterfaceName;
            VmSwitchType = vmSwitchType;
        }
    }
}
