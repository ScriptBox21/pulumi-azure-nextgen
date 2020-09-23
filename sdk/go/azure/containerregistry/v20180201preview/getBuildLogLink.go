// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180201preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetBuildLogLink(ctx *pulumi.Context, args *GetBuildLogLinkArgs, opts ...pulumi.InvokeOption) (*GetBuildLogLinkResult, error) {
	var rv GetBuildLogLinkResult
	err := ctx.Invoke("azure-nextgen:containerregistry/v20180201preview:getBuildLogLink", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetBuildLogLinkArgs struct {
	// The build ID.
	BuildId string `pulumi:"buildId"`
	// The name of the container registry.
	RegistryName string `pulumi:"registryName"`
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The result of get log link operation.
type GetBuildLogLinkResult struct {
	// The link to logs for a azure container registry build.
	LogLink *string `pulumi:"logLink"`
}
