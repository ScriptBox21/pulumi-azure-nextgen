// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type WebAppAuthSettingsV2Slot struct {
	pulumi.CustomResourceState

	GlobalValidation  GlobalValidationResponsePtrOutput  `pulumi:"globalValidation"`
	HttpSettings      HttpSettingsResponsePtrOutput      `pulumi:"httpSettings"`
	IdentityProviders IdentityProvidersResponsePtrOutput `pulumi:"identityProviders"`
	// Kind of resource.
	Kind  pulumi.StringPtrOutput `pulumi:"kind"`
	Login LoginResponsePtrOutput `pulumi:"login"`
	// Resource Name.
	Name     pulumi.StringOutput           `pulumi:"name"`
	Platform AuthPlatformResponsePtrOutput `pulumi:"platform"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppAuthSettingsV2Slot registers a new resource with the given unique name, arguments, and options.
func NewWebAppAuthSettingsV2Slot(ctx *pulumi.Context,
	name string, args *WebAppAuthSettingsV2SlotArgs, opts ...pulumi.ResourceOption) (*WebAppAuthSettingsV2Slot, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:WebAppAuthSettingsV2Slot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppAuthSettingsV2Slot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppAuthSettingsV2Slot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppAuthSettingsV2Slot
	err := ctx.RegisterResource("azure-nextgen:web/v20200601:WebAppAuthSettingsV2Slot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppAuthSettingsV2Slot gets an existing WebAppAuthSettingsV2Slot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppAuthSettingsV2Slot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppAuthSettingsV2SlotState, opts ...pulumi.ResourceOption) (*WebAppAuthSettingsV2Slot, error) {
	var resource WebAppAuthSettingsV2Slot
	err := ctx.ReadResource("azure-nextgen:web/v20200601:WebAppAuthSettingsV2Slot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppAuthSettingsV2Slot resources.
type webAppAuthSettingsV2SlotState struct {
	GlobalValidation  *GlobalValidationResponse  `pulumi:"globalValidation"`
	HttpSettings      *HttpSettingsResponse      `pulumi:"httpSettings"`
	IdentityProviders *IdentityProvidersResponse `pulumi:"identityProviders"`
	// Kind of resource.
	Kind  *string        `pulumi:"kind"`
	Login *LoginResponse `pulumi:"login"`
	// Resource Name.
	Name     *string               `pulumi:"name"`
	Platform *AuthPlatformResponse `pulumi:"platform"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppAuthSettingsV2SlotState struct {
	GlobalValidation  GlobalValidationResponsePtrInput
	HttpSettings      HttpSettingsResponsePtrInput
	IdentityProviders IdentityProvidersResponsePtrInput
	// Kind of resource.
	Kind  pulumi.StringPtrInput
	Login LoginResponsePtrInput
	// Resource Name.
	Name     pulumi.StringPtrInput
	Platform AuthPlatformResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppAuthSettingsV2SlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppAuthSettingsV2SlotState)(nil)).Elem()
}

type webAppAuthSettingsV2SlotArgs struct {
	GlobalValidation  *GlobalValidation  `pulumi:"globalValidation"`
	HttpSettings      *HttpSettings      `pulumi:"httpSettings"`
	IdentityProviders *IdentityProviders `pulumi:"identityProviders"`
	// Kind of resource.
	Kind  *string `pulumi:"kind"`
	Login *Login  `pulumi:"login"`
	// Name of web app.
	Name     string        `pulumi:"name"`
	Platform *AuthPlatform `pulumi:"platform"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of web app slot. If not specified then will default to production slot.
	Slot string `pulumi:"slot"`
}

// The set of arguments for constructing a WebAppAuthSettingsV2Slot resource.
type WebAppAuthSettingsV2SlotArgs struct {
	GlobalValidation  GlobalValidationPtrInput
	HttpSettings      HttpSettingsPtrInput
	IdentityProviders IdentityProvidersPtrInput
	// Kind of resource.
	Kind  pulumi.StringPtrInput
	Login LoginPtrInput
	// Name of web app.
	Name     pulumi.StringInput
	Platform AuthPlatformPtrInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Name of web app slot. If not specified then will default to production slot.
	Slot pulumi.StringInput
}

func (WebAppAuthSettingsV2SlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppAuthSettingsV2SlotArgs)(nil)).Elem()
}

type WebAppAuthSettingsV2SlotInput interface {
	pulumi.Input

	ToWebAppAuthSettingsV2SlotOutput() WebAppAuthSettingsV2SlotOutput
	ToWebAppAuthSettingsV2SlotOutputWithContext(ctx context.Context) WebAppAuthSettingsV2SlotOutput
}

func (*WebAppAuthSettingsV2Slot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppAuthSettingsV2Slot)(nil))
}

func (i *WebAppAuthSettingsV2Slot) ToWebAppAuthSettingsV2SlotOutput() WebAppAuthSettingsV2SlotOutput {
	return i.ToWebAppAuthSettingsV2SlotOutputWithContext(context.Background())
}

func (i *WebAppAuthSettingsV2Slot) ToWebAppAuthSettingsV2SlotOutputWithContext(ctx context.Context) WebAppAuthSettingsV2SlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppAuthSettingsV2SlotOutput)
}

type WebAppAuthSettingsV2SlotOutput struct {
	*pulumi.OutputState
}

func (WebAppAuthSettingsV2SlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppAuthSettingsV2Slot)(nil))
}

func (o WebAppAuthSettingsV2SlotOutput) ToWebAppAuthSettingsV2SlotOutput() WebAppAuthSettingsV2SlotOutput {
	return o
}

func (o WebAppAuthSettingsV2SlotOutput) ToWebAppAuthSettingsV2SlotOutputWithContext(ctx context.Context) WebAppAuthSettingsV2SlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppAuthSettingsV2SlotOutput{})
}
