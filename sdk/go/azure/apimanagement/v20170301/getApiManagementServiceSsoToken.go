// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170301

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetApiManagementServiceSsoToken(ctx *pulumi.Context, args *GetApiManagementServiceSsoTokenArgs, opts ...pulumi.InvokeOption) (*GetApiManagementServiceSsoTokenResult, error) {
	var rv GetApiManagementServiceSsoTokenResult
	err := ctx.Invoke("azure-nextgen:apimanagement/v20170301:getApiManagementServiceSsoToken", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetApiManagementServiceSsoTokenArgs struct {
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
}

// The response of the GetSsoToken operation.
type GetApiManagementServiceSsoTokenResult struct {
	// Redirect URL to the Publisher Portal containing the SSO token.
	RedirectUri *string `pulumi:"redirectUri"`
}
