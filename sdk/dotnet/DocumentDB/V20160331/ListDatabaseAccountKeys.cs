// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20160331
{
    public static class ListDatabaseAccountKeys
    {
        public static Task<ListDatabaseAccountKeysResult> InvokeAsync(ListDatabaseAccountKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListDatabaseAccountKeysResult>("azure-nextgen:documentdb/v20160331:listDatabaseAccountKeys", args ?? new ListDatabaseAccountKeysArgs(), options.WithVersion());
    }


    public sealed class ListDatabaseAccountKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cosmos DB database account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// Name of an Azure resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListDatabaseAccountKeysArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListDatabaseAccountKeysResult
    {
        /// <summary>
        /// Base 64 encoded value of the primary read-write key.
        /// </summary>
        public readonly string PrimaryMasterKey;
        /// <summary>
        /// Base 64 encoded value of the primary read-only key.
        /// </summary>
        public readonly string PrimaryReadonlyMasterKey;
        /// <summary>
        /// Base 64 encoded value of the secondary read-write key.
        /// </summary>
        public readonly string SecondaryMasterKey;
        /// <summary>
        /// Base 64 encoded value of the secondary read-only key.
        /// </summary>
        public readonly string SecondaryReadonlyMasterKey;

        [OutputConstructor]
        private ListDatabaseAccountKeysResult(
            string primaryMasterKey,

            string primaryReadonlyMasterKey,

            string secondaryMasterKey,

            string secondaryReadonlyMasterKey)
        {
            PrimaryMasterKey = primaryMasterKey;
            PrimaryReadonlyMasterKey = primaryReadonlyMasterKey;
            SecondaryMasterKey = secondaryMasterKey;
            SecondaryReadonlyMasterKey = secondaryReadonlyMasterKey;
        }
    }
}