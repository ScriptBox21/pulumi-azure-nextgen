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
type WebAppConnectionStrings struct {
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

// NewWebAppConnectionStrings registers a new resource with the given unique name, arguments, and options.
func NewWebAppConnectionStrings(ctx *pulumi.Context,
	name string, args *WebAppConnectionStringsArgs, opts ...pulumi.ResourceOption) (*WebAppConnectionStrings, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:WebAppConnectionStrings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppConnectionStrings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppConnectionStrings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppConnectionStrings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppConnectionStrings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppConnectionStrings"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppConnectionStrings"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppConnectionStrings
	err := ctx.RegisterResource("azure-nextgen:web/v20160801:WebAppConnectionStrings", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppConnectionStrings gets an existing WebAppConnectionStrings resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppConnectionStrings(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppConnectionStringsState, opts ...pulumi.ResourceOption) (*WebAppConnectionStrings, error) {
	var resource WebAppConnectionStrings
	err := ctx.ReadResource("azure-nextgen:web/v20160801:WebAppConnectionStrings", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppConnectionStrings resources.
type webAppConnectionStringsState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Connection strings.
	Properties map[string]ConnStringValueTypePairResponse `pulumi:"properties"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppConnectionStringsState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Connection strings.
	Properties ConnStringValueTypePairResponseMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppConnectionStringsState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppConnectionStringsState)(nil)).Elem()
}

type webAppConnectionStringsArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Connection strings.
	Properties map[string]ConnStringValueTypePair `pulumi:"properties"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a WebAppConnectionStrings resource.
type WebAppConnectionStringsArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Connection strings.
	Properties ConnStringValueTypePairMapInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
}

func (WebAppConnectionStringsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppConnectionStringsArgs)(nil)).Elem()
}

type WebAppConnectionStringsInput interface {
	pulumi.Input

	ToWebAppConnectionStringsOutput() WebAppConnectionStringsOutput
	ToWebAppConnectionStringsOutputWithContext(ctx context.Context) WebAppConnectionStringsOutput
}

func (*WebAppConnectionStrings) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppConnectionStrings)(nil))
}

func (i *WebAppConnectionStrings) ToWebAppConnectionStringsOutput() WebAppConnectionStringsOutput {
	return i.ToWebAppConnectionStringsOutputWithContext(context.Background())
}

func (i *WebAppConnectionStrings) ToWebAppConnectionStringsOutputWithContext(ctx context.Context) WebAppConnectionStringsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppConnectionStringsOutput)
}

type WebAppConnectionStringsOutput struct {
	*pulumi.OutputState
}

func (WebAppConnectionStringsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppConnectionStrings)(nil))
}

func (o WebAppConnectionStringsOutput) ToWebAppConnectionStringsOutput() WebAppConnectionStringsOutput {
	return o
}

func (o WebAppConnectionStringsOutput) ToWebAppConnectionStringsOutputWithContext(ctx context.Context) WebAppConnectionStringsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppConnectionStringsOutput{})
}
