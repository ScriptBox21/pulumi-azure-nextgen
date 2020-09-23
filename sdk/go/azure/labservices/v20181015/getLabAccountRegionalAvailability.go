// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181015

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetLabAccountRegionalAvailability(ctx *pulumi.Context, args *GetLabAccountRegionalAvailabilityArgs, opts ...pulumi.InvokeOption) (*GetLabAccountRegionalAvailabilityResult, error) {
	var rv GetLabAccountRegionalAvailabilityResult
	err := ctx.Invoke("azure-nextgen:labservices/v20181015:getLabAccountRegionalAvailability", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetLabAccountRegionalAvailabilityArgs struct {
	// The name of the lab Account.
	LabAccountName string `pulumi:"labAccountName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The response model from the GetRegionalAvailability action
type GetLabAccountRegionalAvailabilityResult struct {
	// Availability information for different size categories per region
	RegionalAvailability []RegionalAvailabilityResponse `pulumi:"regionalAvailability"`
}
