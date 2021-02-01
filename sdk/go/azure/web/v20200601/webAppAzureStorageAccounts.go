// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// AzureStorageInfo dictionary resource.
type WebAppAzureStorageAccounts struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Azure storage accounts.
	Properties AzureStorageInfoValueResponseMapOutput `pulumi:"properties"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppAzureStorageAccounts registers a new resource with the given unique name, arguments, and options.
func NewWebAppAzureStorageAccounts(ctx *pulumi.Context,
	name string, args *WebAppAzureStorageAccountsArgs, opts ...pulumi.ResourceOption) (*WebAppAzureStorageAccounts, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:WebAppAzureStorageAccounts"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppAzureStorageAccounts"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppAzureStorageAccounts"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppAzureStorageAccounts"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppAzureStorageAccounts"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppAzureStorageAccounts
	err := ctx.RegisterResource("azure-nextgen:web/v20200601:WebAppAzureStorageAccounts", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppAzureStorageAccounts gets an existing WebAppAzureStorageAccounts resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppAzureStorageAccounts(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppAzureStorageAccountsState, opts ...pulumi.ResourceOption) (*WebAppAzureStorageAccounts, error) {
	var resource WebAppAzureStorageAccounts
	err := ctx.ReadResource("azure-nextgen:web/v20200601:WebAppAzureStorageAccounts", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppAzureStorageAccounts resources.
type webAppAzureStorageAccountsState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Azure storage accounts.
	Properties map[string]AzureStorageInfoValueResponse `pulumi:"properties"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppAzureStorageAccountsState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Azure storage accounts.
	Properties AzureStorageInfoValueResponseMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppAzureStorageAccountsState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppAzureStorageAccountsState)(nil)).Elem()
}

type webAppAzureStorageAccountsArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Azure storage accounts.
	Properties map[string]AzureStorageInfoValue `pulumi:"properties"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a WebAppAzureStorageAccounts resource.
type WebAppAzureStorageAccountsArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Azure storage accounts.
	Properties AzureStorageInfoValueMapInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
}

func (WebAppAzureStorageAccountsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppAzureStorageAccountsArgs)(nil)).Elem()
}

type WebAppAzureStorageAccountsInput interface {
	pulumi.Input

	ToWebAppAzureStorageAccountsOutput() WebAppAzureStorageAccountsOutput
	ToWebAppAzureStorageAccountsOutputWithContext(ctx context.Context) WebAppAzureStorageAccountsOutput
}

func (*WebAppAzureStorageAccounts) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppAzureStorageAccounts)(nil))
}

func (i *WebAppAzureStorageAccounts) ToWebAppAzureStorageAccountsOutput() WebAppAzureStorageAccountsOutput {
	return i.ToWebAppAzureStorageAccountsOutputWithContext(context.Background())
}

func (i *WebAppAzureStorageAccounts) ToWebAppAzureStorageAccountsOutputWithContext(ctx context.Context) WebAppAzureStorageAccountsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppAzureStorageAccountsOutput)
}

type WebAppAzureStorageAccountsOutput struct {
	*pulumi.OutputState
}

func (WebAppAzureStorageAccountsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppAzureStorageAccounts)(nil))
}

func (o WebAppAzureStorageAccountsOutput) ToWebAppAzureStorageAccountsOutput() WebAppAzureStorageAccountsOutput {
	return o
}

func (o WebAppAzureStorageAccountsOutput) ToWebAppAzureStorageAccountsOutputWithContext(ctx context.Context) WebAppAzureStorageAccountsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppAzureStorageAccountsOutput{})
}
