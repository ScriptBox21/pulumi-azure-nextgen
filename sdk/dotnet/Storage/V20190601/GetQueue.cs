// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20190601
{
    public static class GetQueue
    {
        public static Task<GetQueueResult> InvokeAsync(GetQueueArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetQueueResult>("azure-nextgen:storage/v20190601:getQueue", args ?? new GetQueueArgs(), options.WithVersion());
    }


    public sealed class GetQueueArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters.
        /// </summary>
        [Input("queueName", required: true)]
        public string QueueName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetQueueArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetQueueResult
    {
        /// <summary>
        /// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
        /// </summary>
        public readonly int ApproximateMessageCount;
        /// <summary>
        /// A name-value pair that represents queue metadata.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Metadata;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetQueueResult(
            int approximateMessageCount,

            ImmutableDictionary<string, string>? metadata,

            string name,

            string type)
        {
            ApproximateMessageCount = approximateMessageCount;
            Metadata = metadata;
            Name = name;
            Type = type;
        }
    }
}
