// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200201preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetApiKeyDefaultKey(ctx *pulumi.Context, args *GetApiKeyDefaultKeyArgs, opts ...pulumi.InvokeOption) (*GetApiKeyDefaultKeyResult, error) {
	var rv GetApiKeyDefaultKeyResult
	err := ctx.Invoke("azure-nextgen:datadog/v20200201preview:getApiKeyDefaultKey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetApiKeyDefaultKeyArgs struct {
	// Monitor resource name
	MonitorName string `pulumi:"monitorName"`
	// The name of the resource group to which the Datadog resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

type GetApiKeyDefaultKeyResult struct {
	// The time of creation of the API key.
	Created *string `pulumi:"created"`
	// The user that created the API key.
	CreatedBy *string `pulumi:"createdBy"`
	// The value of the API key.
	Key string `pulumi:"key"`
	// The name of the API key.
	Name *string `pulumi:"name"`
}
