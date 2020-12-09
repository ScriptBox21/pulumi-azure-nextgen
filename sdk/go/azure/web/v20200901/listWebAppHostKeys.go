// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListWebAppHostKeys(ctx *pulumi.Context, args *ListWebAppHostKeysArgs, opts ...pulumi.InvokeOption) (*ListWebAppHostKeysResult, error) {
	var rv ListWebAppHostKeysResult
	err := ctx.Invoke("azure-nextgen:web/v20200901:listWebAppHostKeys", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListWebAppHostKeysArgs struct {
	// Site name.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Functions host level keys.
type ListWebAppHostKeysResult struct {
	// Host level function keys.
	FunctionKeys map[string]string `pulumi:"functionKeys"`
	// Secret key.
	MasterKey *string `pulumi:"masterKey"`
	// System keys.
	SystemKeys map[string]string `pulumi:"systemKeys"`
}
