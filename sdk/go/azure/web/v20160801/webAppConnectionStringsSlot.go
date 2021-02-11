// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// String dictionary resource.
type WebAppConnectionStringsSlot struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Connection strings.
	Properties ConnStringValueTypePairResponseMapOutput `pulumi:"properties"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppConnectionStringsSlot registers a new resource with the given unique name, arguments, and options.
func NewWebAppConnectionStringsSlot(ctx *pulumi.Context,
	name string, args *WebAppConnectionStringsSlotArgs, opts ...pulumi.ResourceOption) (*WebAppConnectionStringsSlot, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:WebAppConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppConnectionStringsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppConnectionStringsSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppConnectionStringsSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20160801:WebAppConnectionStringsSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppConnectionStringsSlot gets an existing WebAppConnectionStringsSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppConnectionStringsSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppConnectionStringsSlotState, opts ...pulumi.ResourceOption) (*WebAppConnectionStringsSlot, error) {
	var resource WebAppConnectionStringsSlot
	err := ctx.ReadResource("azure-nextgen:web/v20160801:WebAppConnectionStringsSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppConnectionStringsSlot resources.
type webAppConnectionStringsSlotState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Connection strings.
	Properties map[string]ConnStringValueTypePairResponse `pulumi:"properties"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppConnectionStringsSlotState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Connection strings.
	Properties ConnStringValueTypePairResponseMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppConnectionStringsSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppConnectionStringsSlotState)(nil)).Elem()
}

type webAppConnectionStringsSlotArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Connection strings.
	Properties map[string]ConnStringValueTypePair `pulumi:"properties"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API will update the connection settings for the production slot.
	Slot string `pulumi:"slot"`
}

// The set of arguments for constructing a WebAppConnectionStringsSlot resource.
type WebAppConnectionStringsSlotArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Connection strings.
	Properties ConnStringValueTypePairMapInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Name of the deployment slot. If a slot is not specified, the API will update the connection settings for the production slot.
	Slot pulumi.StringInput
}

func (WebAppConnectionStringsSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppConnectionStringsSlotArgs)(nil)).Elem()
}

type WebAppConnectionStringsSlotInput interface {
	pulumi.Input

	ToWebAppConnectionStringsSlotOutput() WebAppConnectionStringsSlotOutput
	ToWebAppConnectionStringsSlotOutputWithContext(ctx context.Context) WebAppConnectionStringsSlotOutput
}

func (*WebAppConnectionStringsSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppConnectionStringsSlot)(nil))
}

func (i *WebAppConnectionStringsSlot) ToWebAppConnectionStringsSlotOutput() WebAppConnectionStringsSlotOutput {
	return i.ToWebAppConnectionStringsSlotOutputWithContext(context.Background())
}

func (i *WebAppConnectionStringsSlot) ToWebAppConnectionStringsSlotOutputWithContext(ctx context.Context) WebAppConnectionStringsSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppConnectionStringsSlotOutput)
}

type WebAppConnectionStringsSlotOutput struct {
	*pulumi.OutputState
}

func (WebAppConnectionStringsSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppConnectionStringsSlot)(nil))
}

func (o WebAppConnectionStringsSlotOutput) ToWebAppConnectionStringsSlotOutput() WebAppConnectionStringsSlotOutput {
	return o
}

func (o WebAppConnectionStringsSlotOutput) ToWebAppConnectionStringsSlotOutputWithContext(ctx context.Context) WebAppConnectionStringsSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppConnectionStringsSlotOutput{})
}
