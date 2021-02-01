// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// String dictionary resource.
type WebAppMetadataSlot struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Settings.
	Properties pulumi.StringMapOutput `pulumi:"properties"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppMetadataSlot registers a new resource with the given unique name, arguments, and options.
func NewWebAppMetadataSlot(ctx *pulumi.Context,
	name string, args *WebAppMetadataSlotArgs, opts ...pulumi.ResourceOption) (*WebAppMetadataSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Slot == nil {
		return nil, errors.New("invalid value for required argument 'Slot'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppMetadataSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppMetadataSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppMetadataSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20200901:WebAppMetadataSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppMetadataSlot gets an existing WebAppMetadataSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppMetadataSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppMetadataSlotState, opts ...pulumi.ResourceOption) (*WebAppMetadataSlot, error) {
	var resource WebAppMetadataSlot
	err := ctx.ReadResource("azure-nextgen:web/v20200901:WebAppMetadataSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppMetadataSlot resources.
type webAppMetadataSlotState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// The system metadata relating to this resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppMetadataSlotState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Settings.
	Properties pulumi.StringMapInput
	// The system metadata relating to this resource.
	SystemData SystemDataResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppMetadataSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppMetadataSlotState)(nil)).Elem()
}

type webAppMetadataSlotArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API will update the metadata for the production slot.
	Slot string `pulumi:"slot"`
}

// The set of arguments for constructing a WebAppMetadataSlot resource.
type WebAppMetadataSlotArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Settings.
	Properties pulumi.StringMapInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Name of the deployment slot. If a slot is not specified, the API will update the metadata for the production slot.
	Slot pulumi.StringInput
}

func (WebAppMetadataSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppMetadataSlotArgs)(nil)).Elem()
}

type WebAppMetadataSlotInput interface {
	pulumi.Input

	ToWebAppMetadataSlotOutput() WebAppMetadataSlotOutput
	ToWebAppMetadataSlotOutputWithContext(ctx context.Context) WebAppMetadataSlotOutput
}

func (*WebAppMetadataSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppMetadataSlot)(nil))
}

func (i *WebAppMetadataSlot) ToWebAppMetadataSlotOutput() WebAppMetadataSlotOutput {
	return i.ToWebAppMetadataSlotOutputWithContext(context.Background())
}

func (i *WebAppMetadataSlot) ToWebAppMetadataSlotOutputWithContext(ctx context.Context) WebAppMetadataSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppMetadataSlotOutput)
}

type WebAppMetadataSlotOutput struct {
	*pulumi.OutputState
}

func (WebAppMetadataSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppMetadataSlot)(nil))
}

func (o WebAppMetadataSlotOutput) ToWebAppMetadataSlotOutput() WebAppMetadataSlotOutput {
	return o
}

func (o WebAppMetadataSlotOutput) ToWebAppMetadataSlotOutputWithContext(ctx context.Context) WebAppMetadataSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppMetadataSlotOutput{})
}
