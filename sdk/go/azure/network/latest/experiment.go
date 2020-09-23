// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Defines the properties of an Experiment
type Experiment struct {
	pulumi.CustomResourceState

	// The description of the details or intents of the Experiment
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The state of the Experiment
	EnabledState pulumi.StringPtrOutput `pulumi:"enabledState"`
	// The endpoint A of an experiment
	EndpointA EndpointResponsePtrOutput `pulumi:"endpointA"`
	// The endpoint B of an experiment
	EndpointB EndpointResponsePtrOutput `pulumi:"endpointB"`
	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Resource status.
	ResourceState pulumi.StringOutput `pulumi:"resourceState"`
	// The uri to the Script used in the Experiment
	ScriptFileUri pulumi.StringOutput `pulumi:"scriptFileUri"`
	// The description of Experiment status from the server side
	Status pulumi.StringOutput `pulumi:"status"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewExperiment registers a new resource with the given unique name, arguments, and options.
func NewExperiment(ctx *pulumi.Context,
	name string, args *ExperimentArgs, opts ...pulumi.ResourceOption) (*Experiment, error) {
	if args == nil || args.ExperimentName == nil {
		return nil, errors.New("missing required argument 'ExperimentName'")
	}
	if args == nil || args.ProfileName == nil {
		return nil, errors.New("missing required argument 'ProfileName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ExperimentArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:Experiment"),
		},
	})
	opts = append(opts, aliases)
	var resource Experiment
	err := ctx.RegisterResource("azure-nextgen:network/latest:Experiment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExperiment gets an existing Experiment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExperiment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExperimentState, opts ...pulumi.ResourceOption) (*Experiment, error) {
	var resource Experiment
	err := ctx.ReadResource("azure-nextgen:network/latest:Experiment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Experiment resources.
type experimentState struct {
	// The description of the details or intents of the Experiment
	Description *string `pulumi:"description"`
	// The state of the Experiment
	EnabledState *string `pulumi:"enabledState"`
	// The endpoint A of an experiment
	EndpointA *EndpointResponse `pulumi:"endpointA"`
	// The endpoint B of an experiment
	EndpointB *EndpointResponse `pulumi:"endpointB"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Resource status.
	ResourceState *string `pulumi:"resourceState"`
	// The uri to the Script used in the Experiment
	ScriptFileUri *string `pulumi:"scriptFileUri"`
	// The description of Experiment status from the server side
	Status *string `pulumi:"status"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ExperimentState struct {
	// The description of the details or intents of the Experiment
	Description pulumi.StringPtrInput
	// The state of the Experiment
	EnabledState pulumi.StringPtrInput
	// The endpoint A of an experiment
	EndpointA EndpointResponsePtrInput
	// The endpoint B of an experiment
	EndpointB EndpointResponsePtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Resource status.
	ResourceState pulumi.StringPtrInput
	// The uri to the Script used in the Experiment
	ScriptFileUri pulumi.StringPtrInput
	// The description of Experiment status from the server side
	Status pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ExperimentState) ElementType() reflect.Type {
	return reflect.TypeOf((*experimentState)(nil)).Elem()
}

type experimentArgs struct {
	// The description of the details or intents of the Experiment
	Description *string `pulumi:"description"`
	// The state of the Experiment
	EnabledState *string `pulumi:"enabledState"`
	// The endpoint A of an experiment
	EndpointA *EndpointType `pulumi:"endpointA"`
	// The endpoint B of an experiment
	EndpointB *EndpointType `pulumi:"endpointB"`
	// The Experiment identifier associated with the Experiment
	ExperimentName string `pulumi:"experimentName"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The Profile identifier associated with the Tenant and Partner
	ProfileName string `pulumi:"profileName"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Experiment resource.
type ExperimentArgs struct {
	// The description of the details or intents of the Experiment
	Description pulumi.StringPtrInput
	// The state of the Experiment
	EnabledState pulumi.StringPtrInput
	// The endpoint A of an experiment
	EndpointA EndpointTypePtrInput
	// The endpoint B of an experiment
	EndpointB EndpointTypePtrInput
	// The Experiment identifier associated with the Experiment
	ExperimentName pulumi.StringInput
	// Resource location.
	Location pulumi.StringPtrInput
	// The Profile identifier associated with the Tenant and Partner
	ProfileName pulumi.StringInput
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ExperimentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*experimentArgs)(nil)).Elem()
}
