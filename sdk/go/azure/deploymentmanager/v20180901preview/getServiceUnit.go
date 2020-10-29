// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180901preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupServiceUnit(ctx *pulumi.Context, args *LookupServiceUnitArgs, opts ...pulumi.InvokeOption) (*LookupServiceUnitResult, error) {
	var rv LookupServiceUnitResult
	err := ctx.Invoke("azure-nextgen:deploymentmanager/v20180901preview:getServiceUnit", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupServiceUnitArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the service resource.
	ServiceName string `pulumi:"serviceName"`
	// The name of the service topology .
	ServiceTopologyName string `pulumi:"serviceTopologyName"`
	// The name of the service unit resource.
	ServiceUnitName string `pulumi:"serviceUnitName"`
}

// Represents the response of a service unit resource.
type LookupServiceUnitResult struct {
	// The artifacts for the service unit.
	Artifacts *ServiceUnitArtifactsResponse `pulumi:"artifacts"`
	// Describes the type of ARM deployment to be performed on the resource.
	DeploymentMode string `pulumi:"deploymentMode"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The Azure Resource Group to which the resources in the service unit belong to or should be deployed to.
	TargetResourceGroup string `pulumi:"targetResourceGroup"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
