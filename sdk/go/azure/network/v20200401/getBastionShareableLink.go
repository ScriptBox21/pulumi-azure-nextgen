// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200401

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetBastionShareableLink(ctx *pulumi.Context, args *GetBastionShareableLinkArgs, opts ...pulumi.InvokeOption) (*GetBastionShareableLinkResult, error) {
	var rv GetBastionShareableLinkResult
	err := ctx.Invoke("azure-nextgen:network/v20200401:getBastionShareableLink", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetBastionShareableLinkArgs struct {
	// The name of the Bastion Host.
	BastionHostName string `pulumi:"bastionHostName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// List of VM references.
	Vms []BastionShareableLink `pulumi:"vms"`
}

// Response for all the Bastion Shareable Link endpoints.
type GetBastionShareableLinkResult struct {
	// The URL to get the next set of results.
	NextLink *string `pulumi:"nextLink"`
	// List of Bastion Shareable Links for the request.
	Value []BastionShareableLinkResponse `pulumi:"value"`
}
