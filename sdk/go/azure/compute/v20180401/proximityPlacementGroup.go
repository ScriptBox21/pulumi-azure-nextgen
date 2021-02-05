// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180401

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Specifies information about the proximity placement group.
type ProximityPlacementGroup struct {
	pulumi.CustomResourceState

	// A list of references to all availability sets in the proximity placement group.
	AvailabilitySets SubResourceResponseArrayOutput `pulumi:"availabilitySets"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
	ProximityPlacementGroupType pulumi.StringPtrOutput `pulumi:"proximityPlacementGroupType"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// A list of references to all virtual machine scale sets in the proximity placement group.
	VirtualMachineScaleSets SubResourceResponseArrayOutput `pulumi:"virtualMachineScaleSets"`
	// A list of references to all virtual machines in the proximity placement group.
	VirtualMachines SubResourceResponseArrayOutput `pulumi:"virtualMachines"`
}

// NewProximityPlacementGroup registers a new resource with the given unique name, arguments, and options.
func NewProximityPlacementGroup(ctx *pulumi.Context,
	name string, args *ProximityPlacementGroupArgs, opts ...pulumi.ResourceOption) (*ProximityPlacementGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ProximityPlacementGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ProximityPlacementGroupName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:compute/latest:ProximityPlacementGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20180601:ProximityPlacementGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20181001:ProximityPlacementGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190301:ProximityPlacementGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20190701:ProximityPlacementGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20191201:ProximityPlacementGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20200601:ProximityPlacementGroup"),
		},
		{
			Type: pulumi.String("azure-nextgen:compute/v20201201:ProximityPlacementGroup"),
		},
	})
	opts = append(opts, aliases)
	var resource ProximityPlacementGroup
	err := ctx.RegisterResource("azure-nextgen:compute/v20180401:ProximityPlacementGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProximityPlacementGroup gets an existing ProximityPlacementGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProximityPlacementGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProximityPlacementGroupState, opts ...pulumi.ResourceOption) (*ProximityPlacementGroup, error) {
	var resource ProximityPlacementGroup
	err := ctx.ReadResource("azure-nextgen:compute/v20180401:ProximityPlacementGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProximityPlacementGroup resources.
type proximityPlacementGroupState struct {
	// A list of references to all availability sets in the proximity placement group.
	AvailabilitySets []SubResourceResponse `pulumi:"availabilitySets"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
	ProximityPlacementGroupType *string `pulumi:"proximityPlacementGroupType"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// A list of references to all virtual machine scale sets in the proximity placement group.
	VirtualMachineScaleSets []SubResourceResponse `pulumi:"virtualMachineScaleSets"`
	// A list of references to all virtual machines in the proximity placement group.
	VirtualMachines []SubResourceResponse `pulumi:"virtualMachines"`
}

type ProximityPlacementGroupState struct {
	// A list of references to all availability sets in the proximity placement group.
	AvailabilitySets SubResourceResponseArrayInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
	ProximityPlacementGroupType pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// A list of references to all virtual machine scale sets in the proximity placement group.
	VirtualMachineScaleSets SubResourceResponseArrayInput
	// A list of references to all virtual machines in the proximity placement group.
	VirtualMachines SubResourceResponseArrayInput
}

func (ProximityPlacementGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*proximityPlacementGroupState)(nil)).Elem()
}

type proximityPlacementGroupArgs struct {
	// Resource location
	Location string `pulumi:"location"`
	// The name of the proximity placement group.
	ProximityPlacementGroupName string `pulumi:"proximityPlacementGroupName"`
	// Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
	ProximityPlacementGroupType *string `pulumi:"proximityPlacementGroupType"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ProximityPlacementGroup resource.
type ProximityPlacementGroupArgs struct {
	// Resource location
	Location pulumi.StringInput
	// The name of the proximity placement group.
	ProximityPlacementGroupName pulumi.StringInput
	// Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
	ProximityPlacementGroupType pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (ProximityPlacementGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*proximityPlacementGroupArgs)(nil)).Elem()
}

type ProximityPlacementGroupInput interface {
	pulumi.Input

	ToProximityPlacementGroupOutput() ProximityPlacementGroupOutput
	ToProximityPlacementGroupOutputWithContext(ctx context.Context) ProximityPlacementGroupOutput
}

func (*ProximityPlacementGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*ProximityPlacementGroup)(nil))
}

func (i *ProximityPlacementGroup) ToProximityPlacementGroupOutput() ProximityPlacementGroupOutput {
	return i.ToProximityPlacementGroupOutputWithContext(context.Background())
}

func (i *ProximityPlacementGroup) ToProximityPlacementGroupOutputWithContext(ctx context.Context) ProximityPlacementGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProximityPlacementGroupOutput)
}

type ProximityPlacementGroupOutput struct {
	*pulumi.OutputState
}

func (ProximityPlacementGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProximityPlacementGroup)(nil))
}

func (o ProximityPlacementGroupOutput) ToProximityPlacementGroupOutput() ProximityPlacementGroupOutput {
	return o
}

func (o ProximityPlacementGroupOutput) ToProximityPlacementGroupOutputWithContext(ctx context.Context) ProximityPlacementGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ProximityPlacementGroupOutput{})
}
