// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.SignalRService.V20200701Preview
{
    public static class ListSignalRKeys
    {
        public static Task<ListSignalRKeysResult> InvokeAsync(ListSignalRKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListSignalRKeysResult>("azure-nextgen:signalrservice/v20200701preview:listSignalRKeys", args ?? new ListSignalRKeysArgs(), options.WithVersion());
    }


    public sealed class ListSignalRKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the SignalR resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public ListSignalRKeysArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListSignalRKeysResult
    {
        /// <summary>
        /// Connection string constructed via the primaryKey
        /// </summary>
        public readonly string? PrimaryConnectionString;
        /// <summary>
        /// The primary access key.
        /// </summary>
        public readonly string? PrimaryKey;
        /// <summary>
        /// Connection string constructed via the secondaryKey
        /// </summary>
        public readonly string? SecondaryConnectionString;
        /// <summary>
        /// The secondary access key.
        /// </summary>
        public readonly string? SecondaryKey;

        [OutputConstructor]
        private ListSignalRKeysResult(
            string? primaryConnectionString,

            string? primaryKey,

            string? secondaryConnectionString,

            string? secondaryKey)
        {
            PrimaryConnectionString = primaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryConnectionString = secondaryConnectionString;
            SecondaryKey = secondaryKey;
        }
    }
}
