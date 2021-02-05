// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupImage(ctx *pulumi.Context, args *LookupImageArgs, opts ...pulumi.InvokeOption) (*LookupImageResult, error) {
	var rv LookupImageResult
	err := ctx.Invoke("azure-nextgen:compute/latest:getImage", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupImageArgs struct {
	// The expand expression to apply on the operation.
	Expand *string `pulumi:"expand"`
	// The name of the image.
	ImageName string `pulumi:"imageName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
type LookupImageResult struct {
	// The extended location of the Image.
	ExtendedLocation *ExtendedLocationResponse `pulumi:"extendedLocation"`
	// Gets the HyperVGenerationType of the VirtualMachine created from the image
	HyperVGeneration *string `pulumi:"hyperVGeneration"`
	// Resource Id
	Id string `pulumi:"id"`
	// Resource location
	Location string `pulumi:"location"`
	// Resource name
	Name string `pulumi:"name"`
	// The provisioning state.
	ProvisioningState string `pulumi:"provisioningState"`
	// The source virtual machine from which Image is created.
	SourceVirtualMachine *SubResourceResponse `pulumi:"sourceVirtualMachine"`
	// Specifies the storage settings for the virtual machine disks.
	StorageProfile *ImageStorageProfileResponse `pulumi:"storageProfile"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type string `pulumi:"type"`
}
