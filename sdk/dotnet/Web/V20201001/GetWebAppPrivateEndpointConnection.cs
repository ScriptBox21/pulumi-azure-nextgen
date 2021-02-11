// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001
{
    public static class GetWebAppPrivateEndpointConnection
    {
        public static Task<GetWebAppPrivateEndpointConnectionResult> InvokeAsync(GetWebAppPrivateEndpointConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWebAppPrivateEndpointConnectionResult>("azure-nextgen:web/v20201001:getWebAppPrivateEndpointConnection", args ?? new GetWebAppPrivateEndpointConnectionArgs(), options.WithVersion());
    }


    public sealed class GetWebAppPrivateEndpointConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the site.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("privateEndpointConnectionName", required: true)]
        public string PrivateEndpointConnectionName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetWebAppPrivateEndpointConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWebAppPrivateEndpointConnectionResult
    {
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// PrivateEndpoint of a remote private endpoint connection
        /// </summary>
        public readonly Outputs.ArmIdWrapperResponse? PrivateEndpoint;
        /// <summary>
        /// The state of a private link connection
        /// </summary>
        public readonly Outputs.PrivateLinkConnectionStateResponse? PrivateLinkServiceConnectionState;
        public readonly string ProvisioningState;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetWebAppPrivateEndpointConnectionResult(
            string id,

            string? kind,

            string name,

            Outputs.ArmIdWrapperResponse? privateEndpoint,

            Outputs.PrivateLinkConnectionStateResponse? privateLinkServiceConnectionState,

            string provisioningState,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Kind = kind;
            Name = name;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            Type = type;
        }
    }
}
