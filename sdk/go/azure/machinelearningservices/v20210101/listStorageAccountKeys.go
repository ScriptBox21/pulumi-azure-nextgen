// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20210101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListStorageAccountKeys(ctx *pulumi.Context, args *ListStorageAccountKeysArgs, opts ...pulumi.InvokeOption) (*ListStorageAccountKeysResult, error) {
	var rv ListStorageAccountKeysResult
	err := ctx.Invoke("azure-nextgen:machinelearningservices/v20210101:listStorageAccountKeys", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListStorageAccountKeysArgs struct {
	// Name of the resource group in which workspace is located.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of Azure Machine Learning workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

type ListStorageAccountKeysResult struct {
	UserStorageKey string `pulumi:"userStorageKey"`
}
