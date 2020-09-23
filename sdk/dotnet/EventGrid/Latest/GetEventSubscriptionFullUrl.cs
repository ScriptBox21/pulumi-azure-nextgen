// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.EventGrid.Latest
{
    public static class GetEventSubscriptionFullUrl
    {
        public static Task<GetEventSubscriptionFullUrlResult> InvokeAsync(GetEventSubscriptionFullUrlArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEventSubscriptionFullUrlResult>("azure-nextgen:eventgrid/latest:getEventSubscriptionFullUrl", args ?? new GetEventSubscriptionFullUrlArgs(), options.WithVersion());
    }


    public sealed class GetEventSubscriptionFullUrlArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the event subscription.
        /// </summary>
        [Input("eventSubscriptionName", required: true)]
        public string EventSubscriptionName { get; set; } = null!;

        /// <summary>
        /// The scope of the event subscription. The scope can be a subscription, or a resource group, or a top level resource belonging to a resource provider namespace, or an EventGrid topic. For example, use '/subscriptions/{subscriptionId}/' for a subscription, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for a resource group, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}' for a resource, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}' for an EventGrid topic.
        /// </summary>
        [Input("scope", required: true)]
        public string Scope { get; set; } = null!;

        public GetEventSubscriptionFullUrlArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEventSubscriptionFullUrlResult
    {
        /// <summary>
        /// The URL that represents the endpoint of the destination of an event subscription.
        /// </summary>
        public readonly string? EndpointUrl;

        [OutputConstructor]
        private GetEventSubscriptionFullUrlResult(string? endpointUrl)
        {
            EndpointUrl = endpointUrl;
        }
    }
}
