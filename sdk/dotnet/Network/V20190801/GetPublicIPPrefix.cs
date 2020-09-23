// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190801
{
    public static class GetPublicIPPrefix
    {
        public static Task<GetPublicIPPrefixResult> InvokeAsync(GetPublicIPPrefixArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPublicIPPrefixResult>("azure-nextgen:network/v20190801:getPublicIPPrefix", args ?? new GetPublicIPPrefixArgs(), options.WithVersion());
    }


    public sealed class GetPublicIPPrefixArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the public IP prefix.
        /// </summary>
        [Input("publicIpPrefixName", required: true)]
        public string PublicIpPrefixName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPublicIPPrefixArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPublicIPPrefixResult
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// The allocated Prefix.
        /// </summary>
        public readonly string? IpPrefix;
        /// <summary>
        /// The list of tags associated with the public IP prefix.
        /// </summary>
        public readonly ImmutableArray<Outputs.IpTagResponse> IpTags;
        /// <summary>
        /// The reference to load balancer frontend IP configuration associated with the public IP prefix.
        /// </summary>
        public readonly Outputs.SubResourceResponse LoadBalancerFrontendIpConfiguration;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The Length of the Public IP Prefix.
        /// </summary>
        public readonly int? PrefixLength;
        /// <summary>
        /// The provisioning state of the public IP prefix resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The public IP address version.
        /// </summary>
        public readonly string? PublicIPAddressVersion;
        /// <summary>
        /// The list of all referenced PublicIPAddresses.
        /// </summary>
        public readonly ImmutableArray<Outputs.ReferencedPublicIpAddressResponse> PublicIPAddresses;
        /// <summary>
        /// The resource GUID property of the public IP prefix resource.
        /// </summary>
        public readonly string? ResourceGuid;
        /// <summary>
        /// The public IP prefix SKU.
        /// </summary>
        public readonly Outputs.PublicIPPrefixSkuResponse? Sku;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// A list of availability zones denoting the IP allocated for the resource needs to come from.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetPublicIPPrefixResult(
            string? etag,

            string? ipPrefix,

            ImmutableArray<Outputs.IpTagResponse> ipTags,

            Outputs.SubResourceResponse loadBalancerFrontendIpConfiguration,

            string? location,

            string name,

            int? prefixLength,

            string provisioningState,

            string? publicIPAddressVersion,

            ImmutableArray<Outputs.ReferencedPublicIpAddressResponse> publicIPAddresses,

            string? resourceGuid,

            Outputs.PublicIPPrefixSkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type,

            ImmutableArray<string> zones)
        {
            Etag = etag;
            IpPrefix = ipPrefix;
            IpTags = ipTags;
            LoadBalancerFrontendIpConfiguration = loadBalancerFrontendIpConfiguration;
            Location = location;
            Name = name;
            PrefixLength = prefixLength;
            ProvisioningState = provisioningState;
            PublicIPAddressVersion = publicIPAddressVersion;
            PublicIPAddresses = publicIPAddresses;
            ResourceGuid = resourceGuid;
            Sku = sku;
            Tags = tags;
            Type = type;
            Zones = zones;
        }
    }
}
