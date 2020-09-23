// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180601
{
    public static class GetVirtualWAN
    {
        public static Task<GetVirtualWANResult> InvokeAsync(GetVirtualWANArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualWANResult>("azure-nextgen:network/v20180601:getVirtualWAN", args ?? new GetVirtualWANArgs(), options.WithVersion());
    }


    public sealed class GetVirtualWANArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The resource group name of the VirtualWan.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the VirtualWAN being retrieved.
        /// </summary>
        [Input("virtualWANName", required: true)]
        public string VirtualWANName { get; set; } = null!;

        public GetVirtualWANArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualWANResult
    {
        /// <summary>
        /// Vpn encryption to be disabled or not.
        /// </summary>
        public readonly bool? DisableVpnEncryption;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
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
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// List of VirtualHubs in the VirtualWAN.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> VirtualHubs;
        public readonly ImmutableArray<Outputs.SubResourceResponse> VpnSites;

        [OutputConstructor]
        private GetVirtualWANResult(
            bool? disableVpnEncryption,

            string etag,

            string location,

            string name,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<Outputs.SubResourceResponse> virtualHubs,

            ImmutableArray<Outputs.SubResourceResponse> vpnSites)
        {
            DisableVpnEncryption = disableVpnEncryption;
            Etag = etag;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            VirtualHubs = virtualHubs;
            VpnSites = vpnSites;
        }
    }
}
