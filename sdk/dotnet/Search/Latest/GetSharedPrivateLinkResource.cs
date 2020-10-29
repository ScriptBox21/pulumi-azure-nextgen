// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Search.Latest
{
    public static class GetSharedPrivateLinkResource
    {
        public static Task<GetSharedPrivateLinkResourceResult> InvokeAsync(GetSharedPrivateLinkResourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSharedPrivateLinkResourceResult>("azure-nextgen:search/latest:getSharedPrivateLinkResource", args ?? new GetSharedPrivateLinkResourceArgs(), options.WithVersion());
    }


    public sealed class GetSharedPrivateLinkResourceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Azure Cognitive Search service associated with the specified resource group.
        /// </summary>
        [Input("searchServiceName", required: true)]
        public string SearchServiceName { get; set; } = null!;

        /// <summary>
        /// The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group.
        /// </summary>
        [Input("sharedPrivateLinkResourceName", required: true)]
        public string SharedPrivateLinkResourceName { get; set; } = null!;

        public GetSharedPrivateLinkResourceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSharedPrivateLinkResourceResult
    {
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Describes the properties of a Shared Private Link Resource managed by the Azure Cognitive Search service.
        /// </summary>
        public readonly Outputs.SharedPrivateLinkResourcePropertiesResponse Properties;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetSharedPrivateLinkResourceResult(
            string name,

            Outputs.SharedPrivateLinkResourcePropertiesResponse properties,

            string type)
        {
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
