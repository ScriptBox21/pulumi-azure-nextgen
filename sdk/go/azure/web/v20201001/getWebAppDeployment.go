// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201001

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWebAppDeployment(ctx *pulumi.Context, args *LookupWebAppDeploymentArgs, opts ...pulumi.InvokeOption) (*LookupWebAppDeploymentResult, error) {
	var rv LookupWebAppDeploymentResult
	err := ctx.Invoke("azure-nextgen:web/v20201001:getWebAppDeployment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWebAppDeploymentArgs struct {
	// Deployment ID.
	Id string `pulumi:"id"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// User credentials used for publishing activity.
type LookupWebAppDeploymentResult struct {
	// True if deployment is currently active, false if completed and null if not started.
	Active *bool `pulumi:"active"`
	// Who authored the deployment.
	Author *string `pulumi:"author"`
	// Author email.
	AuthorEmail *string `pulumi:"authorEmail"`
	// Who performed the deployment.
	Deployer *string `pulumi:"deployer"`
	// Details on deployment.
	Details *string `pulumi:"details"`
	// End time.
	EndTime *string `pulumi:"endTime"`
	// Resource Id.
	Id string `pulumi:"id"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Details about deployment status.
	Message *string `pulumi:"message"`
	// Resource Name.
	Name string `pulumi:"name"`
	// Start time.
	StartTime *string `pulumi:"startTime"`
	// Deployment status.
	Status *int `pulumi:"status"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type string `pulumi:"type"`
}
