// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HealthcareApis.V20200330.Outputs
{

    [OutputType]
    public sealed class ServicesPropertiesResponse
    {
        /// <summary>
        /// The access policies of the service instance.
        /// </summary>
        public readonly ImmutableArray<Outputs.ServiceAccessPolicyEntryResponse> AccessPolicies;
        /// <summary>
        /// The authentication configuration for the service instance.
        /// </summary>
        public readonly Outputs.ServiceAuthenticationConfigurationInfoResponse? AuthenticationConfiguration;
        /// <summary>
        /// The settings for the CORS configuration of the service instance.
        /// </summary>
        public readonly Outputs.ServiceCorsConfigurationInfoResponse? CorsConfiguration;
        /// <summary>
        /// The settings for the Cosmos DB database backing the service.
        /// </summary>
        public readonly Outputs.ServiceCosmosDbConfigurationInfoResponse? CosmosDbConfiguration;
        /// <summary>
        /// The settings for the export operation of the service instance.
        /// </summary>
        public readonly Outputs.ServiceExportConfigurationInfoResponse? ExportConfiguration;
        /// <summary>
        /// The list of private endpoint connections that are set up for this resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateEndpointConnectionResponse> PrivateEndpointConnections;
        /// <summary>
        /// The provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Control permission for data plane traffic coming from public networks while private endpoint is enabled.
        /// </summary>
        public readonly string? PublicNetworkAccess;

        [OutputConstructor]
        private ServicesPropertiesResponse(
            ImmutableArray<Outputs.ServiceAccessPolicyEntryResponse> accessPolicies,

            Outputs.ServiceAuthenticationConfigurationInfoResponse? authenticationConfiguration,

            Outputs.ServiceCorsConfigurationInfoResponse? corsConfiguration,

            Outputs.ServiceCosmosDbConfigurationInfoResponse? cosmosDbConfiguration,

            Outputs.ServiceExportConfigurationInfoResponse? exportConfiguration,

            ImmutableArray<Outputs.PrivateEndpointConnectionResponse> privateEndpointConnections,

            string provisioningState,

            string? publicNetworkAccess)
        {
            AccessPolicies = accessPolicies;
            AuthenticationConfiguration = authenticationConfiguration;
            CorsConfiguration = corsConfiguration;
            CosmosDbConfiguration = cosmosDbConfiguration;
            ExportConfiguration = exportConfiguration;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            PublicNetworkAccess = publicNetworkAccess;
        }
    }
}