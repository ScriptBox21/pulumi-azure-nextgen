// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Web Job Information.
type WebAppInstanceFunctionSlot struct {
	pulumi.CustomResourceState

	// Config information.
	Config pulumi.AnyOutput `pulumi:"config"`
	// Config URI.
	ConfigHref pulumi.StringPtrOutput `pulumi:"configHref"`
	// File list.
	Files pulumi.StringMapOutput `pulumi:"files"`
	// Function App ID.
	FunctionAppId pulumi.StringPtrOutput `pulumi:"functionAppId"`
	// Function URI.
	Href pulumi.StringPtrOutput `pulumi:"href"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Script URI.
	ScriptHref pulumi.StringPtrOutput `pulumi:"scriptHref"`
	// Script root path URI.
	ScriptRootPathHref pulumi.StringPtrOutput `pulumi:"scriptRootPathHref"`
	// Secrets file URI.
	SecretsFileHref pulumi.StringPtrOutput `pulumi:"secretsFileHref"`
	// Test data used when testing via the Azure Portal.
	TestData pulumi.StringPtrOutput `pulumi:"testData"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppInstanceFunctionSlot registers a new resource with the given unique name, arguments, and options.
func NewWebAppInstanceFunctionSlot(ctx *pulumi.Context,
	name string, args *WebAppInstanceFunctionSlotArgs, opts ...pulumi.ResourceOption) (*WebAppInstanceFunctionSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FunctionName == nil {
		return nil, errors.New("invalid value for required argument 'FunctionName'")
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
			Type: pulumi.String("azure-nextgen:web/latest:WebAppInstanceFunctionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppInstanceFunctionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppInstanceFunctionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppInstanceFunctionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppInstanceFunctionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppInstanceFunctionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppInstanceFunctionSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppInstanceFunctionSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20181101:WebAppInstanceFunctionSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppInstanceFunctionSlot gets an existing WebAppInstanceFunctionSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppInstanceFunctionSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppInstanceFunctionSlotState, opts ...pulumi.ResourceOption) (*WebAppInstanceFunctionSlot, error) {
	var resource WebAppInstanceFunctionSlot
	err := ctx.ReadResource("azure-nextgen:web/v20181101:WebAppInstanceFunctionSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppInstanceFunctionSlot resources.
type webAppInstanceFunctionSlotState struct {
	// Config information.
	Config interface{} `pulumi:"config"`
	// Config URI.
	ConfigHref *string `pulumi:"configHref"`
	// File list.
	Files map[string]string `pulumi:"files"`
	// Function App ID.
	FunctionAppId *string `pulumi:"functionAppId"`
	// Function URI.
	Href *string `pulumi:"href"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Script URI.
	ScriptHref *string `pulumi:"scriptHref"`
	// Script root path URI.
	ScriptRootPathHref *string `pulumi:"scriptRootPathHref"`
	// Secrets file URI.
	SecretsFileHref *string `pulumi:"secretsFileHref"`
	// Test data used when testing via the Azure Portal.
	TestData *string `pulumi:"testData"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppInstanceFunctionSlotState struct {
	// Config information.
	Config pulumi.Input
	// Config URI.
	ConfigHref pulumi.StringPtrInput
	// File list.
	Files pulumi.StringMapInput
	// Function App ID.
	FunctionAppId pulumi.StringPtrInput
	// Function URI.
	Href pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Script URI.
	ScriptHref pulumi.StringPtrInput
	// Script root path URI.
	ScriptRootPathHref pulumi.StringPtrInput
	// Secrets file URI.
	SecretsFileHref pulumi.StringPtrInput
	// Test data used when testing via the Azure Portal.
	TestData pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppInstanceFunctionSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppInstanceFunctionSlotState)(nil)).Elem()
}

type webAppInstanceFunctionSlotArgs struct {
	// Config information.
	Config interface{} `pulumi:"config"`
	// Config URI.
	ConfigHref *string `pulumi:"configHref"`
	// File list.
	Files map[string]string `pulumi:"files"`
	// Function App ID.
	FunctionAppId *string `pulumi:"functionAppId"`
	// Function name.
	FunctionName string `pulumi:"functionName"`
	// Function URI.
	Href *string `pulumi:"href"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Site name.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Script URI.
	ScriptHref *string `pulumi:"scriptHref"`
	// Script root path URI.
	ScriptRootPathHref *string `pulumi:"scriptRootPathHref"`
	// Secrets file URI.
	SecretsFileHref *string `pulumi:"secretsFileHref"`
	// Name of the deployment slot. If a slot is not specified, the API deletes a deployment for the production slot.
	Slot string `pulumi:"slot"`
	// Test data used when testing via the Azure Portal.
	TestData *string `pulumi:"testData"`
}

// The set of arguments for constructing a WebAppInstanceFunctionSlot resource.
type WebAppInstanceFunctionSlotArgs struct {
	// Config information.
	Config pulumi.Input
	// Config URI.
	ConfigHref pulumi.StringPtrInput
	// File list.
	Files pulumi.StringMapInput
	// Function App ID.
	FunctionAppId pulumi.StringPtrInput
	// Function name.
	FunctionName pulumi.StringInput
	// Function URI.
	Href pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Site name.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Script URI.
	ScriptHref pulumi.StringPtrInput
	// Script root path URI.
	ScriptRootPathHref pulumi.StringPtrInput
	// Secrets file URI.
	SecretsFileHref pulumi.StringPtrInput
	// Name of the deployment slot. If a slot is not specified, the API deletes a deployment for the production slot.
	Slot pulumi.StringInput
	// Test data used when testing via the Azure Portal.
	TestData pulumi.StringPtrInput
}

func (WebAppInstanceFunctionSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppInstanceFunctionSlotArgs)(nil)).Elem()
}

type WebAppInstanceFunctionSlotInput interface {
	pulumi.Input

	ToWebAppInstanceFunctionSlotOutput() WebAppInstanceFunctionSlotOutput
	ToWebAppInstanceFunctionSlotOutputWithContext(ctx context.Context) WebAppInstanceFunctionSlotOutput
}

func (*WebAppInstanceFunctionSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppInstanceFunctionSlot)(nil))
}

func (i *WebAppInstanceFunctionSlot) ToWebAppInstanceFunctionSlotOutput() WebAppInstanceFunctionSlotOutput {
	return i.ToWebAppInstanceFunctionSlotOutputWithContext(context.Background())
}

func (i *WebAppInstanceFunctionSlot) ToWebAppInstanceFunctionSlotOutputWithContext(ctx context.Context) WebAppInstanceFunctionSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppInstanceFunctionSlotOutput)
}

type WebAppInstanceFunctionSlotOutput struct {
	*pulumi.OutputState
}

func (WebAppInstanceFunctionSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppInstanceFunctionSlot)(nil))
}

func (o WebAppInstanceFunctionSlotOutput) ToWebAppInstanceFunctionSlotOutput() WebAppInstanceFunctionSlotOutput {
	return o
}

func (o WebAppInstanceFunctionSlotOutput) ToWebAppInstanceFunctionSlotOutputWithContext(ctx context.Context) WebAppInstanceFunctionSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppInstanceFunctionSlotOutput{})
}
