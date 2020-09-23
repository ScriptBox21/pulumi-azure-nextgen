// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190601.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayBackendHealthServerResponseResult
    {
        /// <summary>
        /// IP address or FQDN of backend server.
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// Health of backend server.
        /// </summary>
        public readonly string? Health;
        /// <summary>
        /// Health Probe Log.
        /// </summary>
        public readonly string? HealthProbeLog;
        /// <summary>
        /// Reference of IP configuration of backend server.
        /// </summary>
        public readonly Outputs.NetworkInterfaceIPConfigurationResponse? IpConfiguration;

        [OutputConstructor]
        private ApplicationGatewayBackendHealthServerResponseResult(
            string? address,

            string? health,

            string? healthProbeLog,

            Outputs.NetworkInterfaceIPConfigurationResponse? ipConfiguration)
        {
            Address = address;
            Health = health;
            HealthProbeLog = healthProbeLog;
            IpConfiguration = ipConfiguration;
        }
    }
}
