// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupLinkedStorageAccount(ctx *pulumi.Context, args *LookupLinkedStorageAccountArgs, opts ...pulumi.InvokeOption) (*LookupLinkedStorageAccountResult, error) {
	var rv LookupLinkedStorageAccountResult
	err := ctx.Invoke("azure-nextgen:operationalinsights/v20200301preview:getLinkedStorageAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupLinkedStorageAccountArgs struct {
	// Linked storage accounts type.
	DataSourceType string `pulumi:"dataSourceType"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// Linked storage accounts top level resource container.
type LookupLinkedStorageAccountResult struct {
	// Linked storage accounts type.
	DataSourceType string `pulumi:"dataSourceType"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Linked storage accounts resources ids.
	StorageAccountIds []string `pulumi:"storageAccountIds"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
