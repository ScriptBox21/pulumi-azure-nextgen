// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20200301Preview
{
    public static class GetComponentLinkedStorageAccount
    {
        public static Task<GetComponentLinkedStorageAccountResult> InvokeAsync(GetComponentLinkedStorageAccountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComponentLinkedStorageAccountResult>("azure-nextgen:insights/v20200301preview:getComponentLinkedStorageAccount", args ?? new GetComponentLinkedStorageAccountArgs(), options.WithVersion());
    }


    public sealed class GetComponentLinkedStorageAccountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Application Insights component resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        /// <summary>
        /// The type of the Application Insights component data source for the linked storage account.
        /// </summary>
        [Input("storageType", required: true)]
        public string StorageType { get; set; } = null!;

        public GetComponentLinkedStorageAccountArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComponentLinkedStorageAccountResult
    {
        /// <summary>
        /// Linked storage account resource ID
        /// </summary>
        public readonly string? LinkedStorageAccount;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetComponentLinkedStorageAccountResult(
            string? linkedStorageAccount,

            string name,

            string type)
        {
            LinkedStorageAccount = linkedStorageAccount;
            Name = name;
            Type = type;
        }
    }
}
