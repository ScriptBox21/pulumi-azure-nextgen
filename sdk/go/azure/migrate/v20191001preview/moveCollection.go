// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191001preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Define the move collection.
type MoveCollection struct {
	pulumi.CustomResourceState

	// The etag of the resource.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// Defines the MSI properties of the Move Collection.
	Identity IdentityResponsePtrOutput `pulumi:"identity"`
	// The geo-location where the resource lives.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Defines the move collection properties.
	Properties MoveCollectionPropertiesResponseOutput `pulumi:"properties"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewMoveCollection registers a new resource with the given unique name, arguments, and options.
func NewMoveCollection(ctx *pulumi.Context,
	name string, args *MoveCollectionArgs, opts ...pulumi.ResourceOption) (*MoveCollection, error) {
	if args == nil || args.MoveCollectionName == nil {
		return nil, errors.New("missing required argument 'MoveCollectionName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &MoveCollectionArgs{}
	}
	var resource MoveCollection
	err := ctx.RegisterResource("azure-nextgen:migrate/v20191001preview:MoveCollection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMoveCollection gets an existing MoveCollection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMoveCollection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MoveCollectionState, opts ...pulumi.ResourceOption) (*MoveCollection, error) {
	var resource MoveCollection
	err := ctx.ReadResource("azure-nextgen:migrate/v20191001preview:MoveCollection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MoveCollection resources.
type moveCollectionState struct {
	// The etag of the resource.
	Etag *string `pulumi:"etag"`
	// Defines the MSI properties of the Move Collection.
	Identity *IdentityResponse `pulumi:"identity"`
	// The geo-location where the resource lives.
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Defines the move collection properties.
	Properties *MoveCollectionPropertiesResponse `pulumi:"properties"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type MoveCollectionState struct {
	// The etag of the resource.
	Etag pulumi.StringPtrInput
	// Defines the MSI properties of the Move Collection.
	Identity IdentityResponsePtrInput
	// The geo-location where the resource lives.
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Defines the move collection properties.
	Properties MoveCollectionPropertiesResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (MoveCollectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*moveCollectionState)(nil)).Elem()
}

type moveCollectionArgs struct {
	// Defines the MSI properties of the Move Collection.
	Identity *Identity `pulumi:"identity"`
	// The geo-location where the resource lives.
	Location *string `pulumi:"location"`
	// The Move Collection Name.
	MoveCollectionName string `pulumi:"moveCollectionName"`
	// Defines the move collection properties.
	Properties *MoveCollectionProperties `pulumi:"properties"`
	// The Resource Group Name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a MoveCollection resource.
type MoveCollectionArgs struct {
	// Defines the MSI properties of the Move Collection.
	Identity IdentityPtrInput
	// The geo-location where the resource lives.
	Location pulumi.StringPtrInput
	// The Move Collection Name.
	MoveCollectionName pulumi.StringInput
	// Defines the move collection properties.
	Properties MoveCollectionPropertiesPtrInput
	// The Resource Group Name.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (MoveCollectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*moveCollectionArgs)(nil)).Elem()
}

type MoveCollectionInput interface {
	pulumi.Input

	ToMoveCollectionOutput() MoveCollectionOutput
	ToMoveCollectionOutputWithContext(ctx context.Context) MoveCollectionOutput
}

func (MoveCollection) ElementType() reflect.Type {
	return reflect.TypeOf((*MoveCollection)(nil)).Elem()
}

func (i MoveCollection) ToMoveCollectionOutput() MoveCollectionOutput {
	return i.ToMoveCollectionOutputWithContext(context.Background())
}

func (i MoveCollection) ToMoveCollectionOutputWithContext(ctx context.Context) MoveCollectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MoveCollectionOutput)
}

type MoveCollectionOutput struct {
	*pulumi.OutputState
}

func (MoveCollectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MoveCollectionOutput)(nil)).Elem()
}

func (o MoveCollectionOutput) ToMoveCollectionOutput() MoveCollectionOutput {
	return o
}

func (o MoveCollectionOutput) ToMoveCollectionOutputWithContext(ctx context.Context) MoveCollectionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MoveCollectionOutput{})
}
