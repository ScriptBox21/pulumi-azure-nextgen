// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170601preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The policy set definition.
type PolicySetDefinition struct {
	pulumi.CustomResourceState

	// The policy set definition description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The display name of the policy set definition.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The policy set definition metadata.
	Metadata pulumi.AnyOutput `pulumi:"metadata"`
	// The name of the policy set definition.
	Name pulumi.StringOutput `pulumi:"name"`
	// The policy set definition parameters that can be used in policy definition references.
	Parameters pulumi.AnyOutput `pulumi:"parameters"`
	// An array of policy definition references.
	PolicyDefinitions PolicyDefinitionReferenceResponseArrayOutput `pulumi:"policyDefinitions"`
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType pulumi.StringPtrOutput `pulumi:"policyType"`
	// The type of the resource (Microsoft.Authorization/policySetDefinitions).
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPolicySetDefinition registers a new resource with the given unique name, arguments, and options.
func NewPolicySetDefinition(ctx *pulumi.Context,
	name string, args *PolicySetDefinitionArgs, opts ...pulumi.ResourceOption) (*PolicySetDefinition, error) {
	if args == nil || args.PolicyDefinitions == nil {
		return nil, errors.New("missing required argument 'PolicyDefinitions'")
	}
	if args == nil || args.PolicySetDefinitionName == nil {
		return nil, errors.New("missing required argument 'PolicySetDefinitionName'")
	}
	if args == nil {
		args = &PolicySetDefinitionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:authorization/latest:PolicySetDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20180301:PolicySetDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20180501:PolicySetDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190101:PolicySetDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190601:PolicySetDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190901:PolicySetDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20200301:PolicySetDefinition"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20200901:PolicySetDefinition"),
		},
	})
	opts = append(opts, aliases)
	var resource PolicySetDefinition
	err := ctx.RegisterResource("azure-nextgen:authorization/v20170601preview:PolicySetDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPolicySetDefinition gets an existing PolicySetDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPolicySetDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PolicySetDefinitionState, opts ...pulumi.ResourceOption) (*PolicySetDefinition, error) {
	var resource PolicySetDefinition
	err := ctx.ReadResource("azure-nextgen:authorization/v20170601preview:PolicySetDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PolicySetDefinition resources.
type policySetDefinitionState struct {
	// The policy set definition description.
	Description *string `pulumi:"description"`
	// The display name of the policy set definition.
	DisplayName *string `pulumi:"displayName"`
	// The policy set definition metadata.
	Metadata interface{} `pulumi:"metadata"`
	// The name of the policy set definition.
	Name *string `pulumi:"name"`
	// The policy set definition parameters that can be used in policy definition references.
	Parameters interface{} `pulumi:"parameters"`
	// An array of policy definition references.
	PolicyDefinitions []PolicyDefinitionReferenceResponse `pulumi:"policyDefinitions"`
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType *string `pulumi:"policyType"`
	// The type of the resource (Microsoft.Authorization/policySetDefinitions).
	Type *string `pulumi:"type"`
}

type PolicySetDefinitionState struct {
	// The policy set definition description.
	Description pulumi.StringPtrInput
	// The display name of the policy set definition.
	DisplayName pulumi.StringPtrInput
	// The policy set definition metadata.
	Metadata pulumi.Input
	// The name of the policy set definition.
	Name pulumi.StringPtrInput
	// The policy set definition parameters that can be used in policy definition references.
	Parameters pulumi.Input
	// An array of policy definition references.
	PolicyDefinitions PolicyDefinitionReferenceResponseArrayInput
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType pulumi.StringPtrInput
	// The type of the resource (Microsoft.Authorization/policySetDefinitions).
	Type pulumi.StringPtrInput
}

func (PolicySetDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*policySetDefinitionState)(nil)).Elem()
}

type policySetDefinitionArgs struct {
	// The policy set definition description.
	Description *string `pulumi:"description"`
	// The display name of the policy set definition.
	DisplayName *string `pulumi:"displayName"`
	// The policy set definition metadata.
	Metadata interface{} `pulumi:"metadata"`
	// The policy set definition parameters that can be used in policy definition references.
	Parameters interface{} `pulumi:"parameters"`
	// An array of policy definition references.
	PolicyDefinitions []PolicyDefinitionReference `pulumi:"policyDefinitions"`
	// The name of the policy set definition to create.
	PolicySetDefinitionName string `pulumi:"policySetDefinitionName"`
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType *string `pulumi:"policyType"`
}

// The set of arguments for constructing a PolicySetDefinition resource.
type PolicySetDefinitionArgs struct {
	// The policy set definition description.
	Description pulumi.StringPtrInput
	// The display name of the policy set definition.
	DisplayName pulumi.StringPtrInput
	// The policy set definition metadata.
	Metadata pulumi.Input
	// The policy set definition parameters that can be used in policy definition references.
	Parameters pulumi.Input
	// An array of policy definition references.
	PolicyDefinitions PolicyDefinitionReferenceArrayInput
	// The name of the policy set definition to create.
	PolicySetDefinitionName pulumi.StringInput
	// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
	PolicyType pulumi.StringPtrInput
}

func (PolicySetDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*policySetDefinitionArgs)(nil)).Elem()
}

type PolicySetDefinitionInput interface {
	pulumi.Input

	ToPolicySetDefinitionOutput() PolicySetDefinitionOutput
	ToPolicySetDefinitionOutputWithContext(ctx context.Context) PolicySetDefinitionOutput
}

func (PolicySetDefinition) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicySetDefinition)(nil)).Elem()
}

func (i PolicySetDefinition) ToPolicySetDefinitionOutput() PolicySetDefinitionOutput {
	return i.ToPolicySetDefinitionOutputWithContext(context.Background())
}

func (i PolicySetDefinition) ToPolicySetDefinitionOutputWithContext(ctx context.Context) PolicySetDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicySetDefinitionOutput)
}

type PolicySetDefinitionOutput struct {
	*pulumi.OutputState
}

func (PolicySetDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicySetDefinitionOutput)(nil)).Elem()
}

func (o PolicySetDefinitionOutput) ToPolicySetDefinitionOutput() PolicySetDefinitionOutput {
	return o
}

func (o PolicySetDefinitionOutput) ToPolicySetDefinitionOutputWithContext(ctx context.Context) PolicySetDefinitionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PolicySetDefinitionOutput{})
}
