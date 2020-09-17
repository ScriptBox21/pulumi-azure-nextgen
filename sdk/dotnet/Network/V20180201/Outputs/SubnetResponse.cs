// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180201.Outputs
{

    [OutputType]
    public sealed class SubnetResponse
    {
        /// <summary>
        /// The address prefix for the subnet.
        /// </summary>
        public readonly string? AddressPrefix;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Gets an array of references to the network interface IP configurations using subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.IPConfigurationResponse> IpConfigurations;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The reference of the NetworkSecurityGroup resource.
        /// </summary>
        public readonly Outputs.NetworkSecurityGroupResponse? NetworkSecurityGroup;
        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Gets an array of references to the external resources using subnet.
        /// </summary>
        public readonly ImmutableArray<Outputs.ResourceNavigationLinkResponse> ResourceNavigationLinks;
        /// <summary>
        /// The reference of the RouteTable resource.
        /// </summary>
        public readonly Outputs.RouteTableResponse? RouteTable;
        /// <summary>
        /// An array of service endpoints.
        /// </summary>
        public readonly ImmutableArray<Outputs.ServiceEndpointPropertiesFormatResponse> ServiceEndpoints;

        [OutputConstructor]
        private SubnetResponse(
            string? addressPrefix,

            string? etag,

            string? id,

            ImmutableArray<Outputs.IPConfigurationResponse> ipConfigurations,

            string? name,

            Outputs.NetworkSecurityGroupResponse? networkSecurityGroup,

            string? provisioningState,

            ImmutableArray<Outputs.ResourceNavigationLinkResponse> resourceNavigationLinks,

            Outputs.RouteTableResponse? routeTable,

            ImmutableArray<Outputs.ServiceEndpointPropertiesFormatResponse> serviceEndpoints)
        {
            AddressPrefix = addressPrefix;
            Etag = etag;
            Id = id;
            IpConfigurations = ipConfigurations;
            Name = name;
            NetworkSecurityGroup = networkSecurityGroup;
            ProvisioningState = provisioningState;
            ResourceNavigationLinks = resourceNavigationLinks;
            RouteTable = routeTable;
            ServiceEndpoints = serviceEndpoints;
        }
    }
}