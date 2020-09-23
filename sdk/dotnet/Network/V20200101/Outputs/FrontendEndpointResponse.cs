// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200101.Outputs
{

    [OutputType]
    public sealed class FrontendEndpointResponse
    {
        /// <summary>
        /// The configuration specifying how to enable HTTPS
        /// </summary>
        public readonly Outputs.CustomHttpsConfigurationResponse CustomHttpsConfiguration;
        /// <summary>
        /// Provisioning status of Custom Https of the frontendEndpoint.
        /// </summary>
        public readonly string CustomHttpsProvisioningState;
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step.
        /// </summary>
        public readonly string CustomHttpsProvisioningSubstate;
        /// <summary>
        /// The host name of the frontendEndpoint. Must be a domain name.
        /// </summary>
        public readonly string? HostName;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Resource status.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'
        /// </summary>
        public readonly string? SessionAffinityEnabledState;
        /// <summary>
        /// UNUSED. This field will be ignored. The TTL to use in seconds for session affinity, if applicable.
        /// </summary>
        public readonly int? SessionAffinityTtlSeconds;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Defines the Web Application Firewall policy for each host (if applicable)
        /// </summary>
        public readonly Outputs.FrontendEndpointUpdateParametersResponseWebApplicationFirewallPolicyLink? WebApplicationFirewallPolicyLink;

        [OutputConstructor]
        private FrontendEndpointResponse(
            Outputs.CustomHttpsConfigurationResponse customHttpsConfiguration,

            string customHttpsProvisioningState,

            string customHttpsProvisioningSubstate,

            string? hostName,

            string? id,

            string? name,

            string resourceState,

            string? sessionAffinityEnabledState,

            int? sessionAffinityTtlSeconds,

            string type,

            Outputs.FrontendEndpointUpdateParametersResponseWebApplicationFirewallPolicyLink? webApplicationFirewallPolicyLink)
        {
            CustomHttpsConfiguration = customHttpsConfiguration;
            CustomHttpsProvisioningState = customHttpsProvisioningState;
            CustomHttpsProvisioningSubstate = customHttpsProvisioningSubstate;
            HostName = hostName;
            Id = id;
            Name = name;
            ResourceState = resourceState;
            SessionAffinityEnabledState = sessionAffinityEnabledState;
            SessionAffinityTtlSeconds = sessionAffinityTtlSeconds;
            Type = type;
            WebApplicationFirewallPolicyLink = webApplicationFirewallPolicyLink;
        }
    }
}
