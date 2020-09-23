// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180801
{
    public static class GetVpnSite
    {
        public static Task<GetVpnSiteResult> InvokeAsync(GetVpnSiteArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVpnSiteResult>("azure-nextgen:network/v20180801:getVpnSite", args ?? new GetVpnSiteArgs(), options.WithVersion());
    }


    public sealed class GetVpnSiteArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The resource group name of the VpnSite.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the VpnSite being retrieved.
        /// </summary>
        [Input("vpnSiteName", required: true)]
        public string VpnSiteName { get; set; } = null!;

        public GetVpnSiteArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVpnSiteResult
    {
        /// <summary>
        /// The AddressSpace that contains an array of IP address ranges.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? AddressSpace;
        /// <summary>
        /// The set of bgp properties.
        /// </summary>
        public readonly Outputs.BgpSettingsResponse? BgpProperties;
        /// <summary>
        /// The device properties
        /// </summary>
        public readonly Outputs.DevicePropertiesResponse? DeviceProperties;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The ip-address for the vpn-site.
        /// </summary>
        public readonly string? IpAddress;
        /// <summary>
        /// IsSecuritySite flag
        /// </summary>
        public readonly bool? IsSecuritySite;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The key for vpn-site that can be used for connections.
        /// </summary>
        public readonly string? SiteKey;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The VirtualWAN to which the vpnSite belongs
        /// </summary>
        public readonly Outputs.SubResourceResponse? VirtualWan;

        [OutputConstructor]
        private GetVpnSiteResult(
            Outputs.AddressSpaceResponse? addressSpace,

            Outputs.BgpSettingsResponse? bgpProperties,

            Outputs.DevicePropertiesResponse? deviceProperties,

            string etag,

            string? ipAddress,

            bool? isSecuritySite,

            string location,

            string name,

            string provisioningState,

            string? siteKey,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.SubResourceResponse? virtualWan)
        {
            AddressSpace = addressSpace;
            BgpProperties = bgpProperties;
            DeviceProperties = deviceProperties;
            Etag = etag;
            IpAddress = ipAddress;
            IsSecuritySite = isSecuritySite;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            SiteKey = siteKey;
            Tags = tags;
            Type = type;
            VirtualWan = virtualWan;
        }
    }
}
