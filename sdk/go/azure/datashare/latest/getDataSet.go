// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDataSet(ctx *pulumi.Context, args *LookupDataSetArgs, opts ...pulumi.InvokeOption) (*LookupDataSetResult, error) {
	var rv LookupDataSetResult
	err := ctx.Invoke("azure-nextgen:datashare/latest:getDataSet", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDataSetArgs struct {
	// The name of the share account.
	AccountName string `pulumi:"accountName"`
	// The name of the dataSet.
	DataSetName string `pulumi:"dataSetName"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the share.
	ShareName string `pulumi:"shareName"`
}

// A DataSet data transfer object.
type LookupDataSetResult struct {
	// Kind of data set.
	Kind string `pulumi:"kind"`
	// Name of the azure resource
	Name string `pulumi:"name"`
	// Type of the azure resource
	Type string `pulumi:"type"`
}