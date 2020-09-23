// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetImageUploadUrlForEntityType(ctx *pulumi.Context, args *GetImageUploadUrlForEntityTypeArgs, opts ...pulumi.InvokeOption) (*GetImageUploadUrlForEntityTypeResult, error) {
	var rv GetImageUploadUrlForEntityTypeResult
	err := ctx.Invoke("azure-nextgen:customerinsights/latest:getImageUploadUrlForEntityType", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetImageUploadUrlForEntityTypeArgs struct {
	// Type of entity. Can be Profile or Interaction.
	EntityType *string `pulumi:"entityType"`
	// Name of the entity type.
	EntityTypeName *string `pulumi:"entityTypeName"`
	// The name of the hub.
	HubName string `pulumi:"hubName"`
	// Relative path of the image.
	RelativePath *string `pulumi:"relativePath"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The image definition.
type GetImageUploadUrlForEntityTypeResult struct {
	// Content URL for the image blob.
	ContentUrl *string `pulumi:"contentUrl"`
	// Whether image exists already.
	ImageExists *bool `pulumi:"imageExists"`
	// Relative path of the image.
	RelativePath *string `pulumi:"relativePath"`
}
