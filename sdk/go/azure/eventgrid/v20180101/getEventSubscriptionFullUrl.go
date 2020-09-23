// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetEventSubscriptionFullUrl(ctx *pulumi.Context, args *GetEventSubscriptionFullUrlArgs, opts ...pulumi.InvokeOption) (*GetEventSubscriptionFullUrlResult, error) {
	var rv GetEventSubscriptionFullUrlResult
	err := ctx.Invoke("azure-nextgen:eventgrid/v20180101:getEventSubscriptionFullUrl", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetEventSubscriptionFullUrlArgs struct {
	// Name of the event subscription
	EventSubscriptionName string `pulumi:"eventSubscriptionName"`
	// The scope of the event subscription. The scope can be a subscription, or a resource group, or a top level resource belonging to a resource provider namespace, or an EventGrid topic. For example, use '/subscriptions/{subscriptionId}/' for a subscription, '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for a resource group, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}' for a resource, and '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}' for an EventGrid topic.
	Scope string `pulumi:"scope"`
}

// Full endpoint url of an event subscription
type GetEventSubscriptionFullUrlResult struct {
	// The URL that represents the endpoint of the destination of an event subscription.
	EndpointUrl *string `pulumi:"endpointUrl"`
}
