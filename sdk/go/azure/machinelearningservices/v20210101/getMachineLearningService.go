// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20210101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupMachineLearningService(ctx *pulumi.Context, args *LookupMachineLearningServiceArgs, opts ...pulumi.InvokeOption) (*LookupMachineLearningServiceResult, error) {
	var rv LookupMachineLearningServiceResult
	err := ctx.Invoke("azure-nextgen:machinelearningservices/v20210101:getMachineLearningService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupMachineLearningServiceArgs struct {
	// Set to True to include Model details.
	Expand *bool `pulumi:"expand"`
	// Name of the resource group in which workspace is located.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the Azure Machine Learning service.
	ServiceName string `pulumi:"serviceName"`
	// Name of Azure Machine Learning workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// Machine Learning service object wrapped into ARM resource envelope.
type LookupMachineLearningServiceResult struct {
	// Specifies the resource ID.
	Id string `pulumi:"id"`
	// The identity of the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// Specifies the location of the resource.
	Location *string `pulumi:"location"`
	// Specifies the name of the resource.
	Name string `pulumi:"name"`
	// Service properties
	Properties interface{} `pulumi:"properties"`
	// The sku of the workspace.
	Sku *SkuResponse `pulumi:"sku"`
	// Read only system data
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Contains resource tags defined as key/value pairs.
	Tags map[string]string `pulumi:"tags"`
	// Specifies the type of the resource.
	Type string `pulumi:"type"`
}
