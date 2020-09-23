// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170601

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetRegistrationActivationKey(ctx *pulumi.Context, args *GetRegistrationActivationKeyArgs, opts ...pulumi.InvokeOption) (*GetRegistrationActivationKeyResult, error) {
	var rv GetRegistrationActivationKeyResult
	err := ctx.Invoke("azure-nextgen:azurestack/v20170601:getRegistrationActivationKey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetRegistrationActivationKeyArgs struct {
	// Name of the Azure Stack registration.
	RegistrationName string `pulumi:"registrationName"`
	// Name of the resource group.
	ResourceGroup string `pulumi:"resourceGroup"`
}

// The resource containing the Azure Stack activation key.
type GetRegistrationActivationKeyResult struct {
	// Azure Stack activation key.
	ActivationKey *string `pulumi:"activationKey"`
}
