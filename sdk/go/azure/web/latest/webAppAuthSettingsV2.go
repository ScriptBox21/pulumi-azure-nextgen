// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Latest API Version: 2020-09-01.
type WebAppAuthSettingsV2 struct {
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
	// The system metadata relating to this resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppAuthSettingsV2 registers a new resource with the given unique name, arguments, and options.
func NewWebAppAuthSettingsV2(ctx *pulumi.Context,
	name string, args *WebAppAuthSettingsV2Args, opts ...pulumi.ResourceOption) (*WebAppAuthSettingsV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppAuthSettingsV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppAuthSettingsV2"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppAuthSettingsV2"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppAuthSettingsV2
	err := ctx.RegisterResource("azure-nextgen:web/latest:WebAppAuthSettingsV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppAuthSettingsV2 gets an existing WebAppAuthSettingsV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppAuthSettingsV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppAuthSettingsV2State, opts ...pulumi.ResourceOption) (*WebAppAuthSettingsV2, error) {
	var resource WebAppAuthSettingsV2
	err := ctx.ReadResource("azure-nextgen:web/latest:WebAppAuthSettingsV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppAuthSettingsV2 resources.
type webAppAuthSettingsV2State struct {
	GlobalValidation  *GlobalValidationResponse  `pulumi:"globalValidation"`
	HttpSettings      *HttpSettingsResponse      `pulumi:"httpSettings"`
	IdentityProviders *IdentityProvidersResponse `pulumi:"identityProviders"`
	// Kind of resource.
	Kind  *string        `pulumi:"kind"`
	Login *LoginResponse `pulumi:"login"`
	// Resource Name.
	Name     *string               `pulumi:"name"`
	Platform *AuthPlatformResponse `pulumi:"platform"`
	// The system metadata relating to this resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppAuthSettingsV2State struct {
	GlobalValidation  GlobalValidationResponsePtrInput
	HttpSettings      HttpSettingsResponsePtrInput
	IdentityProviders IdentityProvidersResponsePtrInput
	// Kind of resource.
	Kind  pulumi.StringPtrInput
	Login LoginResponsePtrInput
	// Resource Name.
	Name     pulumi.StringPtrInput
	Platform AuthPlatformResponsePtrInput
	// The system metadata relating to this resource.
	SystemData SystemDataResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppAuthSettingsV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppAuthSettingsV2State)(nil)).Elem()
}

type webAppAuthSettingsV2Args struct {
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
}

// The set of arguments for constructing a WebAppAuthSettingsV2 resource.
type WebAppAuthSettingsV2Args struct {
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
}

func (WebAppAuthSettingsV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppAuthSettingsV2Args)(nil)).Elem()
}

type WebAppAuthSettingsV2Input interface {
	pulumi.Input

	ToWebAppAuthSettingsV2Output() WebAppAuthSettingsV2Output
	ToWebAppAuthSettingsV2OutputWithContext(ctx context.Context) WebAppAuthSettingsV2Output
}

func (*WebAppAuthSettingsV2) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppAuthSettingsV2)(nil))
}

func (i *WebAppAuthSettingsV2) ToWebAppAuthSettingsV2Output() WebAppAuthSettingsV2Output {
	return i.ToWebAppAuthSettingsV2OutputWithContext(context.Background())
}

func (i *WebAppAuthSettingsV2) ToWebAppAuthSettingsV2OutputWithContext(ctx context.Context) WebAppAuthSettingsV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppAuthSettingsV2Output)
}

type WebAppAuthSettingsV2Output struct {
	*pulumi.OutputState
}

func (WebAppAuthSettingsV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppAuthSettingsV2)(nil))
}

func (o WebAppAuthSettingsV2Output) ToWebAppAuthSettingsV2Output() WebAppAuthSettingsV2Output {
	return o
}

func (o WebAppAuthSettingsV2Output) ToWebAppAuthSettingsV2OutputWithContext(ctx context.Context) WebAppAuthSettingsV2Output {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppAuthSettingsV2Output{})
}
