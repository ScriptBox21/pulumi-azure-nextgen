// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListWebAppHostKeysSlot(ctx *pulumi.Context, args *ListWebAppHostKeysSlotArgs, opts ...pulumi.InvokeOption) (*ListWebAppHostKeysSlotResult, error) {
	var rv ListWebAppHostKeysSlotResult
	err := ctx.Invoke("azure-nextgen:web/v20200901:listWebAppHostKeysSlot", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListWebAppHostKeysSlotArgs struct {
	// Site name.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot.
	Slot string `pulumi:"slot"`
}

// Functions host level keys.
type ListWebAppHostKeysSlotResult struct {
	// Host level function keys.
	FunctionKeys map[string]string `pulumi:"functionKeys"`
	// Secret key.
	MasterKey *string `pulumi:"masterKey"`
	// System keys.
	SystemKeys map[string]string `pulumi:"systemKeys"`
}
