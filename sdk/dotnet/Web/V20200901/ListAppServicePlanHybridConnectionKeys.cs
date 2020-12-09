// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901
{
    public static class ListAppServicePlanHybridConnectionKeys
    {
        public static Task<ListAppServicePlanHybridConnectionKeysResult> InvokeAsync(ListAppServicePlanHybridConnectionKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListAppServicePlanHybridConnectionKeysResult>("azure-nextgen:web/v20200901:listAppServicePlanHybridConnectionKeys", args ?? new ListAppServicePlanHybridConnectionKeysArgs(), options.WithVersion());
    }


    public sealed class ListAppServicePlanHybridConnectionKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the App Service plan.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the Service Bus namespace.
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// The name of the Service Bus relay.
        /// </summary>
        [Input("relayName", required: true)]
        public string RelayName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListAppServicePlanHybridConnectionKeysArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListAppServicePlanHybridConnectionKeysResult
    {
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The name of the send key.
        /// </summary>
        public readonly string SendKeyName;
        /// <summary>
        /// The value of the send key.
        /// </summary>
        public readonly string SendKeyValue;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListAppServicePlanHybridConnectionKeysResult(
            string? kind,

            string name,

            string sendKeyName,

            string sendKeyValue,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Kind = kind;
            Name = name;
            SendKeyName = sendKeyName;
            SendKeyValue = sendKeyValue;
            SystemData = systemData;
            Type = type;
        }
    }
}
