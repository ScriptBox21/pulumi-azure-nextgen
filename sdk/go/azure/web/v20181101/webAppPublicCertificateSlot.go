// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Public certificate object
type WebAppPublicCertificateSlot struct {
	pulumi.CustomResourceState

	// Public Certificate byte array
	Blob pulumi.StringPtrOutput `pulumi:"blob"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Public Certificate Location
	PublicCertificateLocation pulumi.StringPtrOutput `pulumi:"publicCertificateLocation"`
	// Certificate Thumbprint
	Thumbprint pulumi.StringOutput `pulumi:"thumbprint"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppPublicCertificateSlot registers a new resource with the given unique name, arguments, and options.
func NewWebAppPublicCertificateSlot(ctx *pulumi.Context,
	name string, args *WebAppPublicCertificateSlotArgs, opts ...pulumi.ResourceOption) (*WebAppPublicCertificateSlot, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.PublicCertificateName == nil {
		return nil, errors.New("missing required argument 'PublicCertificateName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Slot == nil {
		return nil, errors.New("missing required argument 'Slot'")
	}
	if args == nil {
		args = &WebAppPublicCertificateSlotArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppPublicCertificateSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppPublicCertificateSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppPublicCertificateSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppPublicCertificateSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppPublicCertificateSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppPublicCertificateSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppPublicCertificateSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20181101:WebAppPublicCertificateSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppPublicCertificateSlot gets an existing WebAppPublicCertificateSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppPublicCertificateSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppPublicCertificateSlotState, opts ...pulumi.ResourceOption) (*WebAppPublicCertificateSlot, error) {
	var resource WebAppPublicCertificateSlot
	err := ctx.ReadResource("azure-nextgen:web/v20181101:WebAppPublicCertificateSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppPublicCertificateSlot resources.
type webAppPublicCertificateSlotState struct {
	// Public Certificate byte array
	Blob *string `pulumi:"blob"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Public Certificate Location
	PublicCertificateLocation *string `pulumi:"publicCertificateLocation"`
	// Certificate Thumbprint
	Thumbprint *string `pulumi:"thumbprint"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppPublicCertificateSlotState struct {
	// Public Certificate byte array
	Blob pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Public Certificate Location
	PublicCertificateLocation pulumi.StringPtrInput
	// Certificate Thumbprint
	Thumbprint pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppPublicCertificateSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppPublicCertificateSlotState)(nil)).Elem()
}

type webAppPublicCertificateSlotArgs struct {
	// Public Certificate byte array
	Blob *string `pulumi:"blob"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Public Certificate Location
	PublicCertificateLocation *string `pulumi:"publicCertificateLocation"`
	// Public certificate name.
	PublicCertificateName string `pulumi:"publicCertificateName"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API will create a binding for the production slot.
	Slot string `pulumi:"slot"`
}

// The set of arguments for constructing a WebAppPublicCertificateSlot resource.
type WebAppPublicCertificateSlotArgs struct {
	// Public Certificate byte array
	Blob pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Public Certificate Location
	PublicCertificateLocation pulumi.StringPtrInput
	// Public certificate name.
	PublicCertificateName pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Name of the deployment slot. If a slot is not specified, the API will create a binding for the production slot.
	Slot pulumi.StringInput
}

func (WebAppPublicCertificateSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppPublicCertificateSlotArgs)(nil)).Elem()
}

type WebAppPublicCertificateSlotInput interface {
	pulumi.Input

	ToWebAppPublicCertificateSlotOutput() WebAppPublicCertificateSlotOutput
	ToWebAppPublicCertificateSlotOutputWithContext(ctx context.Context) WebAppPublicCertificateSlotOutput
}

func (WebAppPublicCertificateSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppPublicCertificateSlot)(nil)).Elem()
}

func (i WebAppPublicCertificateSlot) ToWebAppPublicCertificateSlotOutput() WebAppPublicCertificateSlotOutput {
	return i.ToWebAppPublicCertificateSlotOutputWithContext(context.Background())
}

func (i WebAppPublicCertificateSlot) ToWebAppPublicCertificateSlotOutputWithContext(ctx context.Context) WebAppPublicCertificateSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppPublicCertificateSlotOutput)
}

type WebAppPublicCertificateSlotOutput struct {
	*pulumi.OutputState
}

func (WebAppPublicCertificateSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppPublicCertificateSlotOutput)(nil)).Elem()
}

func (o WebAppPublicCertificateSlotOutput) ToWebAppPublicCertificateSlotOutput() WebAppPublicCertificateSlotOutput {
	return o
}

func (o WebAppPublicCertificateSlotOutput) ToWebAppPublicCertificateSlotOutputWithContext(ctx context.Context) WebAppPublicCertificateSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppPublicCertificateSlotOutput{})
}
