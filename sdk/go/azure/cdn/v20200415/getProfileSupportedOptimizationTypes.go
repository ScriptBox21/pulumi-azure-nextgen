// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200415

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetProfileSupportedOptimizationTypes(ctx *pulumi.Context, args *GetProfileSupportedOptimizationTypesArgs, opts ...pulumi.InvokeOption) (*GetProfileSupportedOptimizationTypesResult, error) {
	var rv GetProfileSupportedOptimizationTypesResult
	err := ctx.Invoke("azure-nextgen:cdn/v20200415:getProfileSupportedOptimizationTypes", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetProfileSupportedOptimizationTypesArgs struct {
	// Name of the CDN profile which is unique within the resource group.
	ProfileName string `pulumi:"profileName"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The result of the GetSupportedOptimizationTypes API
type GetProfileSupportedOptimizationTypesResult struct {
	// Supported optimization types for a profile.
	SupportedOptimizationTypes []string `pulumi:"supportedOptimizationTypes"`
}
