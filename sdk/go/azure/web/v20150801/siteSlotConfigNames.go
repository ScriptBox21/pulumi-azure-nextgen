// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Slot Config names azure resource
type SiteSlotConfigNames struct {
	pulumi.CustomResourceState

	// List of application settings names
	AppSettingNames pulumi.StringArrayOutput `pulumi:"appSettingNames"`
	// List of connection string names
	ConnectionStringNames pulumi.StringArrayOutput `pulumi:"connectionStringNames"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewSiteSlotConfigNames registers a new resource with the given unique name, arguments, and options.
func NewSiteSlotConfigNames(ctx *pulumi.Context,
	name string, args *SiteSlotConfigNamesArgs, opts ...pulumi.ResourceOption) (*SiteSlotConfigNames, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &SiteSlotConfigNamesArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:SiteSlotConfigNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:SiteSlotConfigNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:SiteSlotConfigNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:SiteSlotConfigNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:SiteSlotConfigNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:SiteSlotConfigNames"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:SiteSlotConfigNames"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteSlotConfigNames
	err := ctx.RegisterResource("azure-nextgen:web/v20150801:SiteSlotConfigNames", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteSlotConfigNames gets an existing SiteSlotConfigNames resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteSlotConfigNames(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteSlotConfigNamesState, opts ...pulumi.ResourceOption) (*SiteSlotConfigNames, error) {
	var resource SiteSlotConfigNames
	err := ctx.ReadResource("azure-nextgen:web/v20150801:SiteSlotConfigNames", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteSlotConfigNames resources.
type siteSlotConfigNamesState struct {
	// List of application settings names
	AppSettingNames []string `pulumi:"appSettingNames"`
	// List of connection string names
	ConnectionStringNames []string `pulumi:"connectionStringNames"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type SiteSlotConfigNamesState struct {
	// List of application settings names
	AppSettingNames pulumi.StringArrayInput
	// List of connection string names
	ConnectionStringNames pulumi.StringArrayInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteSlotConfigNamesState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteSlotConfigNamesState)(nil)).Elem()
}

type siteSlotConfigNamesArgs struct {
	// List of application settings names
	AppSettingNames []string `pulumi:"appSettingNames"`
	// List of connection string names
	ConnectionStringNames []string `pulumi:"connectionStringNames"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location string `pulumi:"location"`
	// Resource Name
	Name string `pulumi:"name"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a SiteSlotConfigNames resource.
type SiteSlotConfigNamesArgs struct {
	// List of application settings names
	AppSettingNames pulumi.StringArrayInput
	// List of connection string names
	ConnectionStringNames pulumi.StringArrayInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringInput
	// Resource Name
	Name pulumi.StringInput
	// Name of resource group
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteSlotConfigNamesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteSlotConfigNamesArgs)(nil)).Elem()
}

type SiteSlotConfigNamesInput interface {
	pulumi.Input

	ToSiteSlotConfigNamesOutput() SiteSlotConfigNamesOutput
	ToSiteSlotConfigNamesOutputWithContext(ctx context.Context) SiteSlotConfigNamesOutput
}

func (SiteSlotConfigNames) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteSlotConfigNames)(nil)).Elem()
}

func (i SiteSlotConfigNames) ToSiteSlotConfigNamesOutput() SiteSlotConfigNamesOutput {
	return i.ToSiteSlotConfigNamesOutputWithContext(context.Background())
}

func (i SiteSlotConfigNames) ToSiteSlotConfigNamesOutputWithContext(ctx context.Context) SiteSlotConfigNamesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteSlotConfigNamesOutput)
}

type SiteSlotConfigNamesOutput struct {
	*pulumi.OutputState
}

func (SiteSlotConfigNamesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteSlotConfigNamesOutput)(nil)).Elem()
}

func (o SiteSlotConfigNamesOutput) ToSiteSlotConfigNamesOutput() SiteSlotConfigNamesOutput {
	return o
}

func (o SiteSlotConfigNamesOutput) ToSiteSlotConfigNamesOutputWithContext(ctx context.Context) SiteSlotConfigNamesOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SiteSlotConfigNamesOutput{})
}
