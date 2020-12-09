// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Slot Config names azure resource.
type WebAppSlotConfigurationNames struct {
	pulumi.CustomResourceState

	// List of application settings names.
	AppSettingNames pulumi.StringArrayOutput `pulumi:"appSettingNames"`
	// List of external Azure storage account identifiers.
	AzureStorageConfigNames pulumi.StringArrayOutput `pulumi:"azureStorageConfigNames"`
	// List of connection string names.
	ConnectionStringNames pulumi.StringArrayOutput `pulumi:"connectionStringNames"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppSlotConfigurationNames registers a new resource with the given unique name, arguments, and options.
func NewWebAppSlotConfigurationNames(ctx *pulumi.Context,
	name string, args *WebAppSlotConfigurationNamesArgs, opts ...pulumi.ResourceOption) (*WebAppSlotConfigurationNames, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &WebAppSlotConfigurationNamesArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppSlotConfigurationNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppSlotConfigurationNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppSlotConfigurationNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppSlotConfigurationNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppSlotConfigurationNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppSlotConfigurationNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppSlotConfigurationNames"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppSlotConfigurationNames
	err := ctx.RegisterResource("azure-nextgen:web/v20200601:WebAppSlotConfigurationNames", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppSlotConfigurationNames gets an existing WebAppSlotConfigurationNames resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppSlotConfigurationNames(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppSlotConfigurationNamesState, opts ...pulumi.ResourceOption) (*WebAppSlotConfigurationNames, error) {
	var resource WebAppSlotConfigurationNames
	err := ctx.ReadResource("azure-nextgen:web/v20200601:WebAppSlotConfigurationNames", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppSlotConfigurationNames resources.
type webAppSlotConfigurationNamesState struct {
	// List of application settings names.
	AppSettingNames []string `pulumi:"appSettingNames"`
	// List of external Azure storage account identifiers.
	AzureStorageConfigNames []string `pulumi:"azureStorageConfigNames"`
	// List of connection string names.
	ConnectionStringNames []string `pulumi:"connectionStringNames"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppSlotConfigurationNamesState struct {
	// List of application settings names.
	AppSettingNames pulumi.StringArrayInput
	// List of external Azure storage account identifiers.
	AzureStorageConfigNames pulumi.StringArrayInput
	// List of connection string names.
	ConnectionStringNames pulumi.StringArrayInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppSlotConfigurationNamesState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSlotConfigurationNamesState)(nil)).Elem()
}

type webAppSlotConfigurationNamesArgs struct {
	// List of application settings names.
	AppSettingNames []string `pulumi:"appSettingNames"`
	// List of external Azure storage account identifiers.
	AzureStorageConfigNames []string `pulumi:"azureStorageConfigNames"`
	// List of connection string names.
	ConnectionStringNames []string `pulumi:"connectionStringNames"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a WebAppSlotConfigurationNames resource.
type WebAppSlotConfigurationNamesArgs struct {
	// List of application settings names.
	AppSettingNames pulumi.StringArrayInput
	// List of external Azure storage account identifiers.
	AzureStorageConfigNames pulumi.StringArrayInput
	// List of connection string names.
	ConnectionStringNames pulumi.StringArrayInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
}

func (WebAppSlotConfigurationNamesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSlotConfigurationNamesArgs)(nil)).Elem()
}

type WebAppSlotConfigurationNamesInput interface {
	pulumi.Input

	ToWebAppSlotConfigurationNamesOutput() WebAppSlotConfigurationNamesOutput
	ToWebAppSlotConfigurationNamesOutputWithContext(ctx context.Context) WebAppSlotConfigurationNamesOutput
}

func (WebAppSlotConfigurationNames) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSlotConfigurationNames)(nil)).Elem()
}

func (i WebAppSlotConfigurationNames) ToWebAppSlotConfigurationNamesOutput() WebAppSlotConfigurationNamesOutput {
	return i.ToWebAppSlotConfigurationNamesOutputWithContext(context.Background())
}

func (i WebAppSlotConfigurationNames) ToWebAppSlotConfigurationNamesOutputWithContext(ctx context.Context) WebAppSlotConfigurationNamesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppSlotConfigurationNamesOutput)
}

type WebAppSlotConfigurationNamesOutput struct {
	*pulumi.OutputState
}

func (WebAppSlotConfigurationNamesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSlotConfigurationNamesOutput)(nil)).Elem()
}

func (o WebAppSlotConfigurationNamesOutput) ToWebAppSlotConfigurationNamesOutput() WebAppSlotConfigurationNamesOutput {
	return o
}

func (o WebAppSlotConfigurationNamesOutput) ToWebAppSlotConfigurationNamesOutputWithContext(ctx context.Context) WebAppSlotConfigurationNamesOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppSlotConfigurationNamesOutput{})
}
