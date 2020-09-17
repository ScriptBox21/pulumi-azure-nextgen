// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170501

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupBatchAccount(ctx *pulumi.Context, args *LookupBatchAccountArgs, opts ...pulumi.InvokeOption) (*LookupBatchAccountResult, error) {
	var rv LookupBatchAccountResult
	err := ctx.Invoke("azure-nextgen:batch/v20170501:getBatchAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupBatchAccountArgs struct {
	// The name of the Batch account.
	AccountName string `pulumi:"accountName"`
	// The name of the resource group that contains the Batch account.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Contains information about an Azure Batch account.
type LookupBatchAccountResult struct {
	// The account endpoint used to interact with the Batch service.
	AccountEndpoint              string `pulumi:"accountEndpoint"`
	ActiveJobAndJobScheduleQuota int    `pulumi:"activeJobAndJobScheduleQuota"`
	// Contains information about the auto-storage account associated with a Batch account.
	AutoStorage        AutoStoragePropertiesResponse `pulumi:"autoStorage"`
	DedicatedCoreQuota int                           `pulumi:"dedicatedCoreQuota"`
	// Identifies the Azure key vault associated with a Batch account.
	KeyVaultReference KeyVaultReferenceResponse `pulumi:"keyVaultReference"`
	// The location of the resource.
	Location             string `pulumi:"location"`
	LowPriorityCoreQuota int    `pulumi:"lowPriorityCoreQuota"`
	// The name of the resource.
	Name string `pulumi:"name"`
	// The allocation mode for creating pools in the Batch account.
	PoolAllocationMode string `pulumi:"poolAllocationMode"`
	PoolQuota          int    `pulumi:"poolQuota"`
	// The provisioned state of the resource
	ProvisioningState string `pulumi:"provisioningState"`
	// The tags of the resource.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type string `pulumi:"type"`
}