// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// App Service Plan Model
type ServerFarm struct {
	pulumi.CustomResourceState

	// App Service Plan administration site
	AdminSiteName pulumi.StringPtrOutput `pulumi:"adminSiteName"`
	// Geographical location for the App Service Plan
	GeoRegion pulumi.StringOutput `pulumi:"geoRegion"`
	// Specification for the hosting environment (App Service Environment) to use for the App Service Plan
	HostingEnvironmentProfile HostingEnvironmentProfileResponsePtrOutput `pulumi:"hostingEnvironmentProfile"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Maximum number of instances that can be assigned to this App Service Plan
	MaximumNumberOfWorkers pulumi.IntPtrOutput `pulumi:"maximumNumberOfWorkers"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Number of web apps assigned to this App Service Plan
	NumberOfSites pulumi.IntOutput `pulumi:"numberOfSites"`
	// If True apps assigned to this App Service Plan can be scaled independently
	//             If False apps assigned to this App Service Plan will scale to all instances of the plan
	PerSiteScaling pulumi.BoolPtrOutput `pulumi:"perSiteScaling"`
	// Enables creation of a Linux App Service Plan
	Reserved pulumi.BoolPtrOutput `pulumi:"reserved"`
	// Resource group of the server farm
	ResourceGroup pulumi.StringOutput `pulumi:"resourceGroup"`
	// Describes a sku for a scalable resource
	Sku SkuDescriptionResponsePtrOutput `pulumi:"sku"`
	// App Service Plan Status
	Status pulumi.StringOutput `pulumi:"status"`
	// App Service Plan Subscription
	Subscription pulumi.StringOutput `pulumi:"subscription"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// Target worker tier assigned to the App Service Plan
	WorkerTierName pulumi.StringPtrOutput `pulumi:"workerTierName"`
}

// NewServerFarm registers a new resource with the given unique name, arguments, and options.
func NewServerFarm(ctx *pulumi.Context,
	name string, args *ServerFarmArgs, opts ...pulumi.ResourceOption) (*ServerFarm, error) {
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
			Type: pulumi.String("azure-nextgen:web/latest:ServerFarm"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160901:ServerFarm"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:ServerFarm"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:ServerFarm"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:ServerFarm"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:ServerFarm"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:ServerFarm"),
		},
	})
	opts = append(opts, aliases)
	var resource ServerFarm
	err := ctx.RegisterResource("azure-nextgen:web/v20150801:ServerFarm", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerFarm gets an existing ServerFarm resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerFarm(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerFarmState, opts ...pulumi.ResourceOption) (*ServerFarm, error) {
	var resource ServerFarm
	err := ctx.ReadResource("azure-nextgen:web/v20150801:ServerFarm", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerFarm resources.
type serverFarmState struct {
	// App Service Plan administration site
	AdminSiteName *string `pulumi:"adminSiteName"`
	// Geographical location for the App Service Plan
	GeoRegion *string `pulumi:"geoRegion"`
	// Specification for the hosting environment (App Service Environment) to use for the App Service Plan
	HostingEnvironmentProfile *HostingEnvironmentProfileResponse `pulumi:"hostingEnvironmentProfile"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Maximum number of instances that can be assigned to this App Service Plan
	MaximumNumberOfWorkers *int `pulumi:"maximumNumberOfWorkers"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Number of web apps assigned to this App Service Plan
	NumberOfSites *int `pulumi:"numberOfSites"`
	// If True apps assigned to this App Service Plan can be scaled independently
	//             If False apps assigned to this App Service Plan will scale to all instances of the plan
	PerSiteScaling *bool `pulumi:"perSiteScaling"`
	// Enables creation of a Linux App Service Plan
	Reserved *bool `pulumi:"reserved"`
	// Resource group of the server farm
	ResourceGroup *string `pulumi:"resourceGroup"`
	// Describes a sku for a scalable resource
	Sku *SkuDescriptionResponse `pulumi:"sku"`
	// App Service Plan Status
	Status *string `pulumi:"status"`
	// App Service Plan Subscription
	Subscription *string `pulumi:"subscription"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// Target worker tier assigned to the App Service Plan
	WorkerTierName *string `pulumi:"workerTierName"`
}

type ServerFarmState struct {
	// App Service Plan administration site
	AdminSiteName pulumi.StringPtrInput
	// Geographical location for the App Service Plan
	GeoRegion pulumi.StringPtrInput
	// Specification for the hosting environment (App Service Environment) to use for the App Service Plan
	HostingEnvironmentProfile HostingEnvironmentProfileResponsePtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Maximum number of instances that can be assigned to this App Service Plan
	MaximumNumberOfWorkers pulumi.IntPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Number of web apps assigned to this App Service Plan
	NumberOfSites pulumi.IntPtrInput
	// If True apps assigned to this App Service Plan can be scaled independently
	//             If False apps assigned to this App Service Plan will scale to all instances of the plan
	PerSiteScaling pulumi.BoolPtrInput
	// Enables creation of a Linux App Service Plan
	Reserved pulumi.BoolPtrInput
	// Resource group of the server farm
	ResourceGroup pulumi.StringPtrInput
	// Describes a sku for a scalable resource
	Sku SkuDescriptionResponsePtrInput
	// App Service Plan Status
	Status pulumi.StringPtrInput
	// App Service Plan Subscription
	Subscription pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// Target worker tier assigned to the App Service Plan
	WorkerTierName pulumi.StringPtrInput
}

func (ServerFarmState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverFarmState)(nil)).Elem()
}

type serverFarmArgs struct {
	// App Service Plan administration site
	AdminSiteName *string `pulumi:"adminSiteName"`
	// OBSOLETE: If true, allow pending state for App Service Plan
	AllowPendingState *bool `pulumi:"allowPendingState"`
	// Specification for the hosting environment (App Service Environment) to use for the App Service Plan
	HostingEnvironmentProfile *HostingEnvironmentProfile `pulumi:"hostingEnvironmentProfile"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Maximum number of instances that can be assigned to this App Service Plan
	MaximumNumberOfWorkers *int `pulumi:"maximumNumberOfWorkers"`
	// Resource Name
	Name string `pulumi:"name"`
	// If True apps assigned to this App Service Plan can be scaled independently
	//             If False apps assigned to this App Service Plan will scale to all instances of the plan
	PerSiteScaling *bool `pulumi:"perSiteScaling"`
	// Enables creation of a Linux App Service Plan
	Reserved *bool `pulumi:"reserved"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Describes a sku for a scalable resource
	Sku *SkuDescription `pulumi:"sku"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// Target worker tier assigned to the App Service Plan
	WorkerTierName *string `pulumi:"workerTierName"`
}

// The set of arguments for constructing a ServerFarm resource.
type ServerFarmArgs struct {
	// App Service Plan administration site
	AdminSiteName pulumi.StringPtrInput
	// OBSOLETE: If true, allow pending state for App Service Plan
	AllowPendingState pulumi.BoolPtrInput
	// Specification for the hosting environment (App Service Environment) to use for the App Service Plan
	HostingEnvironmentProfile HostingEnvironmentProfilePtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Maximum number of instances that can be assigned to this App Service Plan
	MaximumNumberOfWorkers pulumi.IntPtrInput
	// Resource Name
	Name pulumi.StringInput
	// If True apps assigned to this App Service Plan can be scaled independently
	//             If False apps assigned to this App Service Plan will scale to all instances of the plan
	PerSiteScaling pulumi.BoolPtrInput
	// Enables creation of a Linux App Service Plan
	Reserved pulumi.BoolPtrInput
	// Name of resource group
	ResourceGroupName pulumi.StringInput
	// Describes a sku for a scalable resource
	Sku SkuDescriptionPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// Target worker tier assigned to the App Service Plan
	WorkerTierName pulumi.StringPtrInput
}

func (ServerFarmArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverFarmArgs)(nil)).Elem()
}

type ServerFarmInput interface {
	pulumi.Input

	ToServerFarmOutput() ServerFarmOutput
	ToServerFarmOutputWithContext(ctx context.Context) ServerFarmOutput
}

func (*ServerFarm) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerFarm)(nil))
}

func (i *ServerFarm) ToServerFarmOutput() ServerFarmOutput {
	return i.ToServerFarmOutputWithContext(context.Background())
}

func (i *ServerFarm) ToServerFarmOutputWithContext(ctx context.Context) ServerFarmOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerFarmOutput)
}

type ServerFarmOutput struct {
	*pulumi.OutputState
}

func (ServerFarmOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerFarm)(nil))
}

func (o ServerFarmOutput) ToServerFarmOutput() ServerFarmOutput {
	return o
}

func (o ServerFarmOutput) ToServerFarmOutputWithContext(ctx context.Context) ServerFarmOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ServerFarmOutput{})
}
