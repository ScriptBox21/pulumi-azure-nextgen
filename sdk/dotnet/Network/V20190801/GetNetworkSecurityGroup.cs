// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190801
{
    public static class GetNetworkSecurityGroup
    {
        public static Task<GetNetworkSecurityGroupResult> InvokeAsync(GetNetworkSecurityGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNetworkSecurityGroupResult>("azure-nextgen:network/v20190801:getNetworkSecurityGroup", args ?? new GetNetworkSecurityGroupArgs(), options.WithVersion());
    }


    public sealed class GetNetworkSecurityGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the network security group.
        /// </summary>
        [Input("networkSecurityGroupName", required: true)]
        public string NetworkSecurityGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetNetworkSecurityGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetNetworkSecurityGroupResult
    {
        /// <summary>
        /// The default security rules of network security group.
        /// </summary>
        public readonly ImmutableArray<Outputs.SecurityRuleResponse> DefaultSecurityRules;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A collection of references to network interfaces.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceResponse> NetworkInterfaces;
        /// <summary>
        /// The provisioning state of the network security group resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource GUID property of the network security group resource.
        /// </summary>
        public readonly string? ResourceGuid;
        /// <summary>
        /// A collection of security rules of the network security group.
        /// </summary>
        public readonly ImmutableArray<Outputs.SecurityRuleResponse> SecurityRules;
        /// <summary>
        /// A collection of references to subnets.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubnetResponse> Subnets;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetNetworkSecurityGroupResult(
            ImmutableArray<Outputs.SecurityRuleResponse> defaultSecurityRules,

            string? etag,

            string? location,

            string name,

            ImmutableArray<Outputs.NetworkInterfaceResponse> networkInterfaces,

            string provisioningState,

            string? resourceGuid,

            ImmutableArray<Outputs.SecurityRuleResponse> securityRules,

            ImmutableArray<Outputs.SubnetResponse> subnets,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            DefaultSecurityRules = defaultSecurityRules;
            Etag = etag;
            Location = location;
            Name = name;
            NetworkInterfaces = networkInterfaces;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            SecurityRules = securityRules;
            Subnets = subnets;
            Tags = tags;
            Type = type;
        }
    }
}
