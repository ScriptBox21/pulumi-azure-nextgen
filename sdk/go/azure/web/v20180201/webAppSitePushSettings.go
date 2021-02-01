// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180201

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Push settings for the App.
type WebAppSitePushSettings struct {
	pulumi.CustomResourceState

	// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
	DynamicTagsJson pulumi.StringPtrOutput `pulumi:"dynamicTagsJson"`
	// Gets or sets a flag indicating whether the Push endpoint is enabled.
	IsPushEnabled pulumi.BoolOutput `pulumi:"isPushEnabled"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
	TagWhitelistJson pulumi.StringPtrOutput `pulumi:"tagWhitelistJson"`
	// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
	// Tags can consist of alphanumeric characters and the following:
	// '_', '@', '#', '.', ':', '-'.
	// Validation should be performed at the PushRequestHandler.
	TagsRequiringAuth pulumi.StringPtrOutput `pulumi:"tagsRequiringAuth"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppSitePushSettings registers a new resource with the given unique name, arguments, and options.
func NewWebAppSitePushSettings(ctx *pulumi.Context,
	name string, args *WebAppSitePushSettingsArgs, opts ...pulumi.ResourceOption) (*WebAppSitePushSettings, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.IsPushEnabled == nil {
		return nil, errors.New("invalid value for required argument 'IsPushEnabled'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppSitePushSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppSitePushSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppSitePushSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppSitePushSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppSitePushSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppSitePushSettings"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppSitePushSettings
	err := ctx.RegisterResource("azure-nextgen:web/v20180201:WebAppSitePushSettings", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppSitePushSettings gets an existing WebAppSitePushSettings resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppSitePushSettings(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppSitePushSettingsState, opts ...pulumi.ResourceOption) (*WebAppSitePushSettings, error) {
	var resource WebAppSitePushSettings
	err := ctx.ReadResource("azure-nextgen:web/v20180201:WebAppSitePushSettings", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppSitePushSettings resources.
type webAppSitePushSettingsState struct {
	// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
	DynamicTagsJson *string `pulumi:"dynamicTagsJson"`
	// Gets or sets a flag indicating whether the Push endpoint is enabled.
	IsPushEnabled *bool `pulumi:"isPushEnabled"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
	TagWhitelistJson *string `pulumi:"tagWhitelistJson"`
	// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
	// Tags can consist of alphanumeric characters and the following:
	// '_', '@', '#', '.', ':', '-'.
	// Validation should be performed at the PushRequestHandler.
	TagsRequiringAuth *string `pulumi:"tagsRequiringAuth"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppSitePushSettingsState struct {
	// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
	DynamicTagsJson pulumi.StringPtrInput
	// Gets or sets a flag indicating whether the Push endpoint is enabled.
	IsPushEnabled pulumi.BoolPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
	TagWhitelistJson pulumi.StringPtrInput
	// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
	// Tags can consist of alphanumeric characters and the following:
	// '_', '@', '#', '.', ':', '-'.
	// Validation should be performed at the PushRequestHandler.
	TagsRequiringAuth pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppSitePushSettingsState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSitePushSettingsState)(nil)).Elem()
}

type webAppSitePushSettingsArgs struct {
	// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
	DynamicTagsJson *string `pulumi:"dynamicTagsJson"`
	// Gets or sets a flag indicating whether the Push endpoint is enabled.
	IsPushEnabled bool `pulumi:"isPushEnabled"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of web app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
	TagWhitelistJson *string `pulumi:"tagWhitelistJson"`
	// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
	// Tags can consist of alphanumeric characters and the following:
	// '_', '@', '#', '.', ':', '-'.
	// Validation should be performed at the PushRequestHandler.
	TagsRequiringAuth *string `pulumi:"tagsRequiringAuth"`
}

// The set of arguments for constructing a WebAppSitePushSettings resource.
type WebAppSitePushSettingsArgs struct {
	// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
	DynamicTagsJson pulumi.StringPtrInput
	// Gets or sets a flag indicating whether the Push endpoint is enabled.
	IsPushEnabled pulumi.BoolInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of web app.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
	TagWhitelistJson pulumi.StringPtrInput
	// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
	// Tags can consist of alphanumeric characters and the following:
	// '_', '@', '#', '.', ':', '-'.
	// Validation should be performed at the PushRequestHandler.
	TagsRequiringAuth pulumi.StringPtrInput
}

func (WebAppSitePushSettingsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSitePushSettingsArgs)(nil)).Elem()
}

type WebAppSitePushSettingsInput interface {
	pulumi.Input

	ToWebAppSitePushSettingsOutput() WebAppSitePushSettingsOutput
	ToWebAppSitePushSettingsOutputWithContext(ctx context.Context) WebAppSitePushSettingsOutput
}

func (*WebAppSitePushSettings) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSitePushSettings)(nil))
}

func (i *WebAppSitePushSettings) ToWebAppSitePushSettingsOutput() WebAppSitePushSettingsOutput {
	return i.ToWebAppSitePushSettingsOutputWithContext(context.Background())
}

func (i *WebAppSitePushSettings) ToWebAppSitePushSettingsOutputWithContext(ctx context.Context) WebAppSitePushSettingsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppSitePushSettingsOutput)
}

type WebAppSitePushSettingsOutput struct {
	*pulumi.OutputState
}

func (WebAppSitePushSettingsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSitePushSettings)(nil))
}

func (o WebAppSitePushSettingsOutput) ToWebAppSitePushSettingsOutput() WebAppSitePushSettingsOutput {
	return o
}

func (o WebAppSitePushSettingsOutput) ToWebAppSitePushSettingsOutputWithContext(ctx context.Context) WebAppSitePushSettingsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppSitePushSettingsOutput{})
}
