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
type WebAppMetadata struct {
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

// NewWebAppMetadata registers a new resource with the given unique name, arguments, and options.
func NewWebAppMetadata(ctx *pulumi.Context,
	name string, args *WebAppMetadataArgs, opts ...pulumi.ResourceOption) (*WebAppMetadata, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:WebAppMetadata"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppMetadata"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppMetadata"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppMetadata"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppMetadata"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppMetadata"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppMetadata"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppMetadata
	err := ctx.RegisterResource("azure-nextgen:web/v20200901:WebAppMetadata", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppMetadata gets an existing WebAppMetadata resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppMetadata(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppMetadataState, opts ...pulumi.ResourceOption) (*WebAppMetadata, error) {
	var resource WebAppMetadata
	err := ctx.ReadResource("azure-nextgen:web/v20200901:WebAppMetadata", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppMetadata resources.
type webAppMetadataState struct {
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

type WebAppMetadataState struct {
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

func (WebAppMetadataState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppMetadataState)(nil)).Elem()
}

type webAppMetadataArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Settings.
	Properties map[string]string `pulumi:"properties"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a WebAppMetadata resource.
type WebAppMetadataArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Settings.
	Properties pulumi.StringMapInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
}

func (WebAppMetadataArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppMetadataArgs)(nil)).Elem()
}

type WebAppMetadataInput interface {
	pulumi.Input

	ToWebAppMetadataOutput() WebAppMetadataOutput
	ToWebAppMetadataOutputWithContext(ctx context.Context) WebAppMetadataOutput
}

func (*WebAppMetadata) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppMetadata)(nil))
}

func (i *WebAppMetadata) ToWebAppMetadataOutput() WebAppMetadataOutput {
	return i.ToWebAppMetadataOutputWithContext(context.Background())
}

func (i *WebAppMetadata) ToWebAppMetadataOutputWithContext(ctx context.Context) WebAppMetadataOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppMetadataOutput)
}

type WebAppMetadataOutput struct {
	*pulumi.OutputState
}

func (WebAppMetadataOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppMetadata)(nil))
}

func (o WebAppMetadataOutput) ToWebAppMetadataOutput() WebAppMetadataOutput {
	return o
}

func (o WebAppMetadataOutput) ToWebAppMetadataOutputWithContext(ctx context.Context) WebAppMetadataOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppMetadataOutput{})
}
