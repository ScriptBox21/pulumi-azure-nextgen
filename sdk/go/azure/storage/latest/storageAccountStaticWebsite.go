// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Enables the static website feature of a storage account.
type StorageAccountStaticWebsite struct {
	pulumi.CustomResourceState

	// The name of the container to upload blobs to.
	ContainerName pulumi.StringOutput `pulumi:"containerName"`
	// The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.
	Error404Document pulumi.StringPtrOutput `pulumi:"error404Document"`
	// The webpage that Azure Storage serves for requests to the root of a website or any sub-folder. For example, 'index.html'. The value is case-sensitive.
	IndexDocument pulumi.StringPtrOutput `pulumi:"indexDocument"`
}

// NewStorageAccountStaticWebsite registers a new resource with the given unique name, arguments, and options.
func NewStorageAccountStaticWebsite(ctx *pulumi.Context,
	name string, args *StorageAccountStaticWebsiteArgs, opts ...pulumi.ResourceOption) (*StorageAccountStaticWebsite, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	var resource StorageAccountStaticWebsite
	err := ctx.RegisterResource("azure-nextgen:storage/latest:StorageAccountStaticWebsite", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStorageAccountStaticWebsite gets an existing StorageAccountStaticWebsite resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStorageAccountStaticWebsite(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StorageAccountStaticWebsiteState, opts ...pulumi.ResourceOption) (*StorageAccountStaticWebsite, error) {
	var resource StorageAccountStaticWebsite
	err := ctx.ReadResource("azure-nextgen:storage/latest:StorageAccountStaticWebsite", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StorageAccountStaticWebsite resources.
type storageAccountStaticWebsiteState struct {
	// The name of the container to upload blobs to.
	ContainerName *string `pulumi:"containerName"`
	// The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.
	Error404Document *string `pulumi:"error404Document"`
	// The webpage that Azure Storage serves for requests to the root of a website or any sub-folder. For example, 'index.html'. The value is case-sensitive.
	IndexDocument *string `pulumi:"indexDocument"`
}

type StorageAccountStaticWebsiteState struct {
	// The name of the container to upload blobs to.
	ContainerName pulumi.StringPtrInput
	// The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.
	Error404Document pulumi.StringPtrInput
	// The webpage that Azure Storage serves for requests to the root of a website or any sub-folder. For example, 'index.html'. The value is case-sensitive.
	IndexDocument pulumi.StringPtrInput
}

func (StorageAccountStaticWebsiteState) ElementType() reflect.Type {
	return reflect.TypeOf((*storageAccountStaticWebsiteState)(nil)).Elem()
}

type storageAccountStaticWebsiteArgs struct {
	// The name of the storage account within the specified resource group.
	AccountName string `pulumi:"accountName"`
	// The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.
	Error404Document *string `pulumi:"error404Document"`
	// The webpage that Azure Storage serves for requests to the root of a website or any sub-folder. For example, 'index.html'. The value is case-sensitive.
	IndexDocument *string `pulumi:"indexDocument"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a StorageAccountStaticWebsite resource.
type StorageAccountStaticWebsiteArgs struct {
	// The name of the storage account within the specified resource group.
	AccountName pulumi.StringInput
	// The absolute path to a custom webpage that should be used when a request is made which does not correspond to an existing file.
	Error404Document pulumi.StringPtrInput
	// The webpage that Azure Storage serves for requests to the root of a website or any sub-folder. For example, 'index.html'. The value is case-sensitive.
	IndexDocument pulumi.StringPtrInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
}

func (StorageAccountStaticWebsiteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*storageAccountStaticWebsiteArgs)(nil)).Elem()
}

type StorageAccountStaticWebsiteInput interface {
	pulumi.Input

	ToStorageAccountStaticWebsiteOutput() StorageAccountStaticWebsiteOutput
	ToStorageAccountStaticWebsiteOutputWithContext(ctx context.Context) StorageAccountStaticWebsiteOutput
}

func (*StorageAccountStaticWebsite) ElementType() reflect.Type {
	return reflect.TypeOf((*StorageAccountStaticWebsite)(nil))
}

func (i *StorageAccountStaticWebsite) ToStorageAccountStaticWebsiteOutput() StorageAccountStaticWebsiteOutput {
	return i.ToStorageAccountStaticWebsiteOutputWithContext(context.Background())
}

func (i *StorageAccountStaticWebsite) ToStorageAccountStaticWebsiteOutputWithContext(ctx context.Context) StorageAccountStaticWebsiteOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StorageAccountStaticWebsiteOutput)
}

type StorageAccountStaticWebsiteOutput struct {
	*pulumi.OutputState
}

func (StorageAccountStaticWebsiteOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StorageAccountStaticWebsite)(nil))
}

func (o StorageAccountStaticWebsiteOutput) ToStorageAccountStaticWebsiteOutput() StorageAccountStaticWebsiteOutput {
	return o
}

func (o StorageAccountStaticWebsiteOutput) ToStorageAccountStaticWebsiteOutputWithContext(ctx context.Context) StorageAccountStaticWebsiteOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(StorageAccountStaticWebsiteOutput{})
}
