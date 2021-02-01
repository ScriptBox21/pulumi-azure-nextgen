// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// String dictionary resource.
type WebApplicationSettingsSlot struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Settings.
	Properties pulumi.StringMapOutput `pulumi:"properties"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebApplicationSettingsSlot registers a new resource with the given unique name, arguments, and options.
func NewWebApplicationSettingsSlot(ctx *pulumi.Context,
	name string, args *WebApplicationSettingsSlotArgs, opts ...pulumi.ResourceOption) (*WebApplicationSettingsSlot, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:WebApplicationSettingsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebApplicationSettingsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebApplicationSettingsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebApplicationSettingsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebApplicationSettingsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebApplicationSettingsSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebApplicationSettingsSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebApplicationSettingsSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20181101:WebApplicationSettingsSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebApplicationSettingsSlot gets an existing WebApplicationSettingsSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebApplicationSettingsSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebApplicationSettingsSlotState, opts ...pulumi.ResourceOption) (*WebApplicationSettingsSlot, error) {
	var resource WebApplicationSettingsSlot
	err := ctx.ReadResource("azure-nextgen:web/v20181101:WebApplicationSettingsSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebApplicationSettingsSlot resources.
type webApplicationSettingsSlotState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebApplicationSettingsSlotState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Settings.
	Properties pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebApplicationSettingsSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webApplicationSettingsSlotState)(nil)).Elem()
}

type webApplicationSettingsSlotArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API will update the application settings for the production slot.
	Slot string `pulumi:"slot"`
}

// The set of arguments for constructing a WebApplicationSettingsSlot resource.
type WebApplicationSettingsSlotArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Settings.
	Properties pulumi.StringMapInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Name of the deployment slot. If a slot is not specified, the API will update the application settings for the production slot.
	Slot pulumi.StringInput
}

func (WebApplicationSettingsSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webApplicationSettingsSlotArgs)(nil)).Elem()
}

type WebApplicationSettingsSlotInput interface {
	pulumi.Input

	ToWebApplicationSettingsSlotOutput() WebApplicationSettingsSlotOutput
	ToWebApplicationSettingsSlotOutputWithContext(ctx context.Context) WebApplicationSettingsSlotOutput
}

func (*WebApplicationSettingsSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebApplicationSettingsSlot)(nil))
}

func (i *WebApplicationSettingsSlot) ToWebApplicationSettingsSlotOutput() WebApplicationSettingsSlotOutput {
	return i.ToWebApplicationSettingsSlotOutputWithContext(context.Background())
}

func (i *WebApplicationSettingsSlot) ToWebApplicationSettingsSlotOutputWithContext(ctx context.Context) WebApplicationSettingsSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebApplicationSettingsSlotOutput)
}

type WebApplicationSettingsSlotOutput struct {
	*pulumi.OutputState
}

func (WebApplicationSettingsSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebApplicationSettingsSlot)(nil))
}

func (o WebApplicationSettingsSlotOutput) ToWebApplicationSettingsSlotOutput() WebApplicationSettingsSlotOutput {
	return o
}

func (o WebApplicationSettingsSlotOutput) ToWebApplicationSettingsSlotOutputWithContext(ctx context.Context) WebApplicationSettingsSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebApplicationSettingsSlotOutput{})
}
