// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListWebAppMetadataSlot(ctx *pulumi.Context, args *ListWebAppMetadataSlotArgs, opts ...pulumi.InvokeOption) (*ListWebAppMetadataSlotResult, error) {
	var rv ListWebAppMetadataSlotResult
	err := ctx.Invoke("azure-nextgen:web/v20200901:listWebAppMetadataSlot", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListWebAppMetadataSlotArgs struct {
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API will get the metadata for the production slot.
	Slot string `pulumi:"slot"`
}

// String dictionary resource.
type ListWebAppMetadataSlotResult struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type string `pulumi:"type"`
}
