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
type WebApplicationSettings struct {
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

// NewWebApplicationSettings registers a new resource with the given unique name, arguments, and options.
func NewWebApplicationSettings(ctx *pulumi.Context,
	name string, args *WebApplicationSettingsArgs, opts ...pulumi.ResourceOption) (*WebApplicationSettings, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:WebApplicationSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebApplicationSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebApplicationSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebApplicationSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebApplicationSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebApplicationSettings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebApplicationSettings"),
		},
	})
	opts = append(opts, aliases)
	var resource WebApplicationSettings
	err := ctx.RegisterResource("azure-nextgen:web/v20181101:WebApplicationSettings", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebApplicationSettings gets an existing WebApplicationSettings resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebApplicationSettings(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebApplicationSettingsState, opts ...pulumi.ResourceOption) (*WebApplicationSettings, error) {
	var resource WebApplicationSettings
	err := ctx.ReadResource("azure-nextgen:web/v20181101:WebApplicationSettings", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebApplicationSettings resources.
type webApplicationSettingsState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebApplicationSettingsState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Settings.
	Properties pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebApplicationSettingsState) ElementType() reflect.Type {
	return reflect.TypeOf((*webApplicationSettingsState)(nil)).Elem()
}

type webApplicationSettingsArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a WebApplicationSettings resource.
type WebApplicationSettingsArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Settings.
	Properties pulumi.StringMapInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
}

func (WebApplicationSettingsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webApplicationSettingsArgs)(nil)).Elem()
}

type WebApplicationSettingsInput interface {
	pulumi.Input

	ToWebApplicationSettingsOutput() WebApplicationSettingsOutput
	ToWebApplicationSettingsOutputWithContext(ctx context.Context) WebApplicationSettingsOutput
}

func (*WebApplicationSettings) ElementType() reflect.Type {
	return reflect.TypeOf((*WebApplicationSettings)(nil))
}

func (i *WebApplicationSettings) ToWebApplicationSettingsOutput() WebApplicationSettingsOutput {
	return i.ToWebApplicationSettingsOutputWithContext(context.Background())
}

func (i *WebApplicationSettings) ToWebApplicationSettingsOutputWithContext(ctx context.Context) WebApplicationSettingsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebApplicationSettingsOutput)
}

type WebApplicationSettingsOutput struct {
	*pulumi.OutputState
}

func (WebApplicationSettingsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebApplicationSettings)(nil))
}

func (o WebApplicationSettingsOutput) ToWebApplicationSettingsOutput() WebApplicationSettingsOutput {
	return o
}

func (o WebApplicationSettingsOutput) ToWebApplicationSettingsOutputWithContext(ctx context.Context) WebApplicationSettingsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebApplicationSettingsOutput{})
}
