// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListStaticSiteBuildFunctionAppSettings(ctx *pulumi.Context, args *ListStaticSiteBuildFunctionAppSettingsArgs, opts ...pulumi.InvokeOption) (*ListStaticSiteBuildFunctionAppSettingsResult, error) {
	var rv ListStaticSiteBuildFunctionAppSettingsResult
	err := ctx.Invoke("azure-nextgen:web/v20190801:listStaticSiteBuildFunctionAppSettings", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListStaticSiteBuildFunctionAppSettingsArgs struct {
	// Name of the static site.
	Name string `pulumi:"name"`
	// The stage site identifier.
	PrId string `pulumi:"prId"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// String dictionary resource.
type ListStaticSiteBuildFunctionAppSettingsResult struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// Resource type.
	Type string `pulumi:"type"`
}
