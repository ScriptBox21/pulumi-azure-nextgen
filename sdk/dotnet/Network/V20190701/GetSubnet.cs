// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701
{
    public static class GetSubnet
    {
        public static Task<GetSubnetResult> InvokeAsync(GetSubnetArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSubnetResult>("azure-nextgen:network/v20190701:getSubnet", args ?? new GetSubnetArgs(), options.WithVersion());
    }


    public sealed class GetSubnetArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the subnet.
        /// </summary>
        [Input("subnetName", required: true)]
        public string SubnetName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual network.
        /// </summary>
        [Input("virtualNetworkName", required: true)]
        public string VirtualNetworkName { get; set; } = null!;

        public GetSubnetArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSubnetResult
    {
        /// <summary>
        /// The address prefix for the subnet.
        /// </summary>
        public readonly string? AddressPrefix;
        /// <summary>
        /// List of address prefixes for the subnet.
        /// </summary>
        public readonly ImmutableArray<string> AddressPrefixes;
        /// <summary>
        /// An array of references to the delegations on the subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.DelegationResponse> Delegations;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Array of IP configuration profiles which reference this subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.IPConfigurationProfileResponse> IpConfigurationProfiles;
        /// <summary>
        /// An array of references to the network interface IP configurations using subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.IPConfigurationResponse> IpConfigurations;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Nat gateway associated with this subnet.
        /// </summary>
        public readonly Outputs.SubResourceResponse? NatGateway;
        /// <summary>
        /// The reference of the NetworkSecurityGroup resource.
        /// </summary>
        public readonly Outputs.NetworkSecurityGroupResponse? NetworkSecurityGroup;
        /// <summary>
        /// Enable or Disable apply network policies on private end point in the subnet.
        /// </summary>
        public readonly string? PrivateEndpointNetworkPolicies;
        /// <summary>
        /// An array of references to private endpoints.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateEndpointResponse> PrivateEndpoints;
        /// <summary>
        /// Enable or Disable apply network policies on private link service in the subnet.
        /// </summary>
        public readonly string? PrivateLinkServiceNetworkPolicies;
        /// <summary>
        /// The provisioning state of the subnet resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties.
        /// </summary>
        public readonly string Purpose;
        /// <summary>
        /// An array of references to the external resources using subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.ResourceNavigationLinkResponse> ResourceNavigationLinks;
        /// <summary>
        /// The reference of the RouteTable resource.
        /// </summary>
        public readonly Outputs.RouteTableResponse? RouteTable;
        /// <summary>
        /// An array of references to services injecting into this subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.ServiceAssociationLinkResponse> ServiceAssociationLinks;
        /// <summary>
        /// An array of service endpoint policies.
        /// </summary>
        public readonly ImmutableArray<Outputs.ServiceEndpointPolicyResponse> ServiceEndpointPolicies;
        /// <summary>
        /// An array of service endpoints.
        /// </summary>
        public readonly ImmutableArray<Outputs.ServiceEndpointPropertiesFormatResponse> ServiceEndpoints;

        [OutputConstructor]
        private GetSubnetResult(
            string? addressPrefix,

            ImmutableArray<string> addressPrefixes,

            ImmutableArray<Outputs.DelegationResponse> delegations,

            string? etag,

            ImmutableArray<Outputs.IPConfigurationProfileResponse> ipConfigurationProfiles,

            ImmutableArray<Outputs.IPConfigurationResponse> ipConfigurations,

            string? name,

            Outputs.SubResourceResponse? natGateway,

            Outputs.NetworkSecurityGroupResponse? networkSecurityGroup,

            string? privateEndpointNetworkPolicies,

            ImmutableArray<Outputs.PrivateEndpointResponse> privateEndpoints,

            string? privateLinkServiceNetworkPolicies,

            string provisioningState,

            string purpose,

            ImmutableArray<Outputs.ResourceNavigationLinkResponse> resourceNavigationLinks,

            Outputs.RouteTableResponse? routeTable,

            ImmutableArray<Outputs.ServiceAssociationLinkResponse> serviceAssociationLinks,

            ImmutableArray<Outputs.ServiceEndpointPolicyResponse> serviceEndpointPolicies,

            ImmutableArray<Outputs.ServiceEndpointPropertiesFormatResponse> serviceEndpoints)
        {
            AddressPrefix = addressPrefix;
            AddressPrefixes = addressPrefixes;
            Delegations = delegations;
            Etag = etag;
            IpConfigurationProfiles = ipConfigurationProfiles;
            IpConfigurations = ipConfigurations;
            Name = name;
            NatGateway = natGateway;
            NetworkSecurityGroup = networkSecurityGroup;
            PrivateEndpointNetworkPolicies = privateEndpointNetworkPolicies;
            PrivateEndpoints = privateEndpoints;
            PrivateLinkServiceNetworkPolicies = privateLinkServiceNetworkPolicies;
            ProvisioningState = provisioningState;
            Purpose = purpose;
            ResourceNavigationLinks = resourceNavigationLinks;
            RouteTable = routeTable;
            ServiceAssociationLinks = serviceAssociationLinks;
            ServiceEndpointPolicies = serviceEndpointPolicies;
            ServiceEndpoints = serviceEndpoints;
        }
    }
}
