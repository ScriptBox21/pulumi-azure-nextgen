// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDeploymentAtScope(ctx *pulumi.Context, args *LookupDeploymentAtScopeArgs, opts ...pulumi.InvokeOption) (*LookupDeploymentAtScopeResult, error) {
	var rv LookupDeploymentAtScopeResult
	err := ctx.Invoke("azure-nextgen:resources/v20200801:getDeploymentAtScope", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDeploymentAtScopeArgs struct {
	// The name of the deployment.
	DeploymentName string `pulumi:"deploymentName"`
	// The resource scope.
	Scope string `pulumi:"scope"`
}

// Deployment information.
type LookupDeploymentAtScopeResult struct {
	// the location of the deployment.
	Location *string `pulumi:"location"`
	// The name of the deployment.
	Name string `pulumi:"name"`
	// Deployment properties.
	Properties DeploymentPropertiesExtendedResponse `pulumi:"properties"`
	// Deployment tags
	Tags map[string]string `pulumi:"tags"`
	// The type of the deployment.
	Type string `pulumi:"type"`
}
