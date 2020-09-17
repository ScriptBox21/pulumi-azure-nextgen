// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListRunLogSasUrl(ctx *pulumi.Context, args *ListRunLogSasUrlArgs, opts ...pulumi.InvokeOption) (*ListRunLogSasUrlResult, error) {
	var rv ListRunLogSasUrlResult
	err := ctx.Invoke("azure-nextgen:containerregistry/v20180901:listRunLogSasUrl", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListRunLogSasUrlArgs struct {
	// The name of the container registry.
	RegistryName string `pulumi:"registryName"`
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The run ID.
	RunId string `pulumi:"runId"`
}

// The result of get log link operation.
type ListRunLogSasUrlResult struct {
	// The link to logs for a run on a azure container registry.
	LogLink *string `pulumi:"logLink"`
}