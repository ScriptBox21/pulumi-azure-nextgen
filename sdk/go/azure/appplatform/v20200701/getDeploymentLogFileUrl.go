// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetDeploymentLogFileUrl(ctx *pulumi.Context, args *GetDeploymentLogFileUrlArgs, opts ...pulumi.InvokeOption) (*GetDeploymentLogFileUrlResult, error) {
	var rv GetDeploymentLogFileUrlResult
	err := ctx.Invoke("azure-nextgen:appplatform/v20200701:getDeploymentLogFileUrl", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetDeploymentLogFileUrlArgs struct {
	// The name of the App resource.
	AppName string `pulumi:"appName"`
	// The name of the Deployment resource.
	DeploymentName string `pulumi:"deploymentName"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Service resource.
	ServiceName string `pulumi:"serviceName"`
}

// Log file URL payload
type GetDeploymentLogFileUrlResult struct {
	// URL of the log file
	Url string `pulumi:"url"`
}
