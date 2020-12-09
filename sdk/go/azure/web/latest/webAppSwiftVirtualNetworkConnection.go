// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Swift Virtual Network Contract. This is used to enable the new Swift way of doing virtual network integration.
type WebAppSwiftVirtualNetworkConnection struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
	SubnetResourceId pulumi.StringPtrOutput `pulumi:"subnetResourceId"`
	// A flag that specifies if the scale unit this Web App is on supports Swift integration.
	SwiftSupported pulumi.BoolPtrOutput `pulumi:"swiftSupported"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppSwiftVirtualNetworkConnection registers a new resource with the given unique name, arguments, and options.
func NewWebAppSwiftVirtualNetworkConnection(ctx *pulumi.Context,
	name string, args *WebAppSwiftVirtualNetworkConnectionArgs, opts ...pulumi.ResourceOption) (*WebAppSwiftVirtualNetworkConnection, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &WebAppSwiftVirtualNetworkConnectionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppSwiftVirtualNetworkConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppSwiftVirtualNetworkConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppSwiftVirtualNetworkConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppSwiftVirtualNetworkConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppSwiftVirtualNetworkConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppSwiftVirtualNetworkConnection
	err := ctx.RegisterResource("azure-nextgen:web/latest:WebAppSwiftVirtualNetworkConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppSwiftVirtualNetworkConnection gets an existing WebAppSwiftVirtualNetworkConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppSwiftVirtualNetworkConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppSwiftVirtualNetworkConnectionState, opts ...pulumi.ResourceOption) (*WebAppSwiftVirtualNetworkConnection, error) {
	var resource WebAppSwiftVirtualNetworkConnection
	err := ctx.ReadResource("azure-nextgen:web/latest:WebAppSwiftVirtualNetworkConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppSwiftVirtualNetworkConnection resources.
type webAppSwiftVirtualNetworkConnectionState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
	SubnetResourceId *string `pulumi:"subnetResourceId"`
	// A flag that specifies if the scale unit this Web App is on supports Swift integration.
	SwiftSupported *bool `pulumi:"swiftSupported"`
	// The system metadata relating to this resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppSwiftVirtualNetworkConnectionState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
	SubnetResourceId pulumi.StringPtrInput
	// A flag that specifies if the scale unit this Web App is on supports Swift integration.
	SwiftSupported pulumi.BoolPtrInput
	// The system metadata relating to this resource.
	SystemData SystemDataResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppSwiftVirtualNetworkConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSwiftVirtualNetworkConnectionState)(nil)).Elem()
}

type webAppSwiftVirtualNetworkConnectionArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
	SubnetResourceId *string `pulumi:"subnetResourceId"`
	// A flag that specifies if the scale unit this Web App is on supports Swift integration.
	SwiftSupported *bool `pulumi:"swiftSupported"`
}

// The set of arguments for constructing a WebAppSwiftVirtualNetworkConnection resource.
type WebAppSwiftVirtualNetworkConnectionArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// The Virtual Network subnet's resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first.
	SubnetResourceId pulumi.StringPtrInput
	// A flag that specifies if the scale unit this Web App is on supports Swift integration.
	SwiftSupported pulumi.BoolPtrInput
}

func (WebAppSwiftVirtualNetworkConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSwiftVirtualNetworkConnectionArgs)(nil)).Elem()
}

type WebAppSwiftVirtualNetworkConnectionInput interface {
	pulumi.Input

	ToWebAppSwiftVirtualNetworkConnectionOutput() WebAppSwiftVirtualNetworkConnectionOutput
	ToWebAppSwiftVirtualNetworkConnectionOutputWithContext(ctx context.Context) WebAppSwiftVirtualNetworkConnectionOutput
}

func (WebAppSwiftVirtualNetworkConnection) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSwiftVirtualNetworkConnection)(nil)).Elem()
}

func (i WebAppSwiftVirtualNetworkConnection) ToWebAppSwiftVirtualNetworkConnectionOutput() WebAppSwiftVirtualNetworkConnectionOutput {
	return i.ToWebAppSwiftVirtualNetworkConnectionOutputWithContext(context.Background())
}

func (i WebAppSwiftVirtualNetworkConnection) ToWebAppSwiftVirtualNetworkConnectionOutputWithContext(ctx context.Context) WebAppSwiftVirtualNetworkConnectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppSwiftVirtualNetworkConnectionOutput)
}

type WebAppSwiftVirtualNetworkConnectionOutput struct {
	*pulumi.OutputState
}

func (WebAppSwiftVirtualNetworkConnectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSwiftVirtualNetworkConnectionOutput)(nil)).Elem()
}

func (o WebAppSwiftVirtualNetworkConnectionOutput) ToWebAppSwiftVirtualNetworkConnectionOutput() WebAppSwiftVirtualNetworkConnectionOutput {
	return o
}

func (o WebAppSwiftVirtualNetworkConnectionOutput) ToWebAppSwiftVirtualNetworkConnectionOutputWithContext(ctx context.Context) WebAppSwiftVirtualNetworkConnectionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppSwiftVirtualNetworkConnectionOutput{})
}
