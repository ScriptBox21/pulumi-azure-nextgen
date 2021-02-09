// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20210101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Defines the move resource.
type MoveResource struct {
	pulumi.CustomResourceState

	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Defines the move resource properties.
	Properties MoveResourcePropertiesResponseOutput `pulumi:"properties"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewMoveResource registers a new resource with the given unique name, arguments, and options.
func NewMoveResource(ctx *pulumi.Context,
	name string, args *MoveResourceArgs, opts ...pulumi.ResourceOption) (*MoveResource, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.MoveCollectionName == nil {
		return nil, errors.New("invalid value for required argument 'MoveCollectionName'")
	}
	if args.MoveResourceName == nil {
		return nil, errors.New("invalid value for required argument 'MoveResourceName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:migrate/latest:MoveResource"),
		},
		{
			Type: pulumi.String("azure-nextgen:migrate/v20191001preview:MoveResource"),
		},
	})
	opts = append(opts, aliases)
	var resource MoveResource
	err := ctx.RegisterResource("azure-nextgen:migrate/v20210101:MoveResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMoveResource gets an existing MoveResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMoveResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MoveResourceState, opts ...pulumi.ResourceOption) (*MoveResource, error) {
	var resource MoveResource
	err := ctx.ReadResource("azure-nextgen:migrate/v20210101:MoveResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MoveResource resources.
type moveResourceState struct {
	// The name of the resource
	Name *string `pulumi:"name"`
	// Defines the move resource properties.
	Properties *MoveResourcePropertiesResponse `pulumi:"properties"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type MoveResourceState struct {
	// The name of the resource
	Name pulumi.StringPtrInput
	// Defines the move resource properties.
	Properties MoveResourcePropertiesResponsePtrInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (MoveResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*moveResourceState)(nil)).Elem()
}

type moveResourceArgs struct {
	// The Move Collection Name.
	MoveCollectionName string `pulumi:"moveCollectionName"`
	// The Move Resource Name.
	MoveResourceName string `pulumi:"moveResourceName"`
	// Defines the move resource properties.
	Properties *MoveResourceProperties `pulumi:"properties"`
	// The Resource Group Name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a MoveResource resource.
type MoveResourceArgs struct {
	// The Move Collection Name.
	MoveCollectionName pulumi.StringInput
	// The Move Resource Name.
	MoveResourceName pulumi.StringInput
	// Defines the move resource properties.
	Properties MoveResourcePropertiesPtrInput
	// The Resource Group Name.
	ResourceGroupName pulumi.StringInput
}

func (MoveResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*moveResourceArgs)(nil)).Elem()
}

type MoveResourceInput interface {
	pulumi.Input

	ToMoveResourceOutput() MoveResourceOutput
	ToMoveResourceOutputWithContext(ctx context.Context) MoveResourceOutput
}

func (*MoveResource) ElementType() reflect.Type {
	return reflect.TypeOf((*MoveResource)(nil))
}

func (i *MoveResource) ToMoveResourceOutput() MoveResourceOutput {
	return i.ToMoveResourceOutputWithContext(context.Background())
}

func (i *MoveResource) ToMoveResourceOutputWithContext(ctx context.Context) MoveResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MoveResourceOutput)
}

type MoveResourceOutput struct {
	*pulumi.OutputState
}

func (MoveResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MoveResource)(nil))
}

func (o MoveResourceOutput) ToMoveResourceOutput() MoveResourceOutput {
	return o
}

func (o MoveResourceOutput) ToMoveResourceOutputWithContext(ctx context.Context) MoveResourceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MoveResourceOutput{})
}
