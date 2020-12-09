// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.Latest
{
    public static class GetAFDOrigin
    {
        public static Task<GetAFDOriginResult> InvokeAsync(GetAFDOriginArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAFDOriginResult>("azure-nextgen:cdn/latest:getAFDOrigin", args ?? new GetAFDOriginArgs(), options.WithVersion());
    }


    public sealed class GetAFDOriginArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the origin group which is unique within the profile.
        /// </summary>
        [Input("originGroupName", required: true)]
        public string OriginGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the origin which is unique within the profile.
        /// </summary>
        [Input("originName", required: true)]
        public string OriginName { get; set; } = null!;

        /// <summary>
        /// Name of the CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public string ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAFDOriginArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAFDOriginResult
    {
        /// <summary>
        /// Resource reference to the Azure origin resource.
        /// </summary>
        public readonly Outputs.ResourceReferenceResponse? AzureOrigin;
        public readonly string DeploymentStatus;
        /// <summary>
        /// Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled if there is a single enabled backend in single enabled backend pool.
        /// </summary>
        public readonly string? EnabledState;
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.
        /// </summary>
        public readonly string HostName;
        /// <summary>
        /// The value of the HTTP port. Must be between 1 and 65535.
        /// </summary>
        public readonly int? HttpPort;
        /// <summary>
        /// The value of the HTTPS port. Must be between 1 and 65535.
        /// </summary>
        public readonly int? HttpsPort;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        public readonly string? OriginHostHeader;
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// Provisioning status
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The properties of the private link resource for private origin.
        /// </summary>
        public readonly ImmutableArray<Outputs.SharedPrivateLinkResourcePropertiesResponse> SharedPrivateLinkResource;
        /// <summary>
        /// Read only system data
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        public readonly int? Weight;

        [OutputConstructor]
        private GetAFDOriginResult(
            Outputs.ResourceReferenceResponse? azureOrigin,

            string deploymentStatus,

            string? enabledState,

            string hostName,

            int? httpPort,

            int? httpsPort,

            string name,

            string? originHostHeader,

            int? priority,

            string provisioningState,

            ImmutableArray<Outputs.SharedPrivateLinkResourcePropertiesResponse> sharedPrivateLinkResource,

            Outputs.SystemDataResponse systemData,

            string type,

            int? weight)
        {
            AzureOrigin = azureOrigin;
            DeploymentStatus = deploymentStatus;
            EnabledState = enabledState;
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            Name = name;
            OriginHostHeader = originHostHeader;
            Priority = priority;
            ProvisioningState = provisioningState;
            SharedPrivateLinkResource = sharedPrivateLinkResource;
            SystemData = systemData;
            Type = type;
            Weight = weight;
        }
    }
}
