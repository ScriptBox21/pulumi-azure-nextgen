// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180501

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The policy assignment.
type PolicyAssignment struct {
	pulumi.CustomResourceState

	// This message will be part of response in case of policy violation.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The display name of the policy assignment.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The managed identity associated with the policy assignment.
	Identity IdentityResponsePtrOutput `pulumi:"identity"`
	// The location of the policy assignment. Only required when utilizing managed identity.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The policy assignment metadata.
	Metadata pulumi.AnyOutput `pulumi:"metadata"`
	// The name of the policy assignment.
	Name pulumi.StringOutput `pulumi:"name"`
	// The policy's excluded scopes.
	NotScopes pulumi.StringArrayOutput `pulumi:"notScopes"`
	// Required if a parameter is used in policy rule.
	Parameters pulumi.AnyOutput `pulumi:"parameters"`
	// The ID of the policy definition or policy set definition being assigned.
	PolicyDefinitionId pulumi.StringPtrOutput `pulumi:"policyDefinitionId"`
	// The scope for the policy assignment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
	// The policy sku. This property is optional, obsolete, and will be ignored.
	Sku PolicySkuResponsePtrOutput `pulumi:"sku"`
	// The type of the policy assignment.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPolicyAssignment registers a new resource with the given unique name, arguments, and options.
func NewPolicyAssignment(ctx *pulumi.Context,
	name string, args *PolicyAssignmentArgs, opts ...pulumi.ResourceOption) (*PolicyAssignment, error) {
	if args == nil || args.PolicyAssignmentName == nil {
		return nil, errors.New("missing required argument 'PolicyAssignmentName'")
	}
	if args == nil || args.Scope == nil {
		return nil, errors.New("missing required argument 'Scope'")
	}
	if args == nil {
		args = &PolicyAssignmentArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:authorization/latest:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20151001preview:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20151101:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20160401:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20161201:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20170601preview:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20180301:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190101:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190601:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20190901:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20200301:PolicyAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:authorization/v20200901:PolicyAssignment"),
		},
	})
	opts = append(opts, aliases)
	var resource PolicyAssignment
	err := ctx.RegisterResource("azure-nextgen:authorization/v20180501:PolicyAssignment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPolicyAssignment gets an existing PolicyAssignment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPolicyAssignment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PolicyAssignmentState, opts ...pulumi.ResourceOption) (*PolicyAssignment, error) {
	var resource PolicyAssignment
	err := ctx.ReadResource("azure-nextgen:authorization/v20180501:PolicyAssignment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PolicyAssignment resources.
type policyAssignmentState struct {
	// This message will be part of response in case of policy violation.
	Description *string `pulumi:"description"`
	// The display name of the policy assignment.
	DisplayName *string `pulumi:"displayName"`
	// The managed identity associated with the policy assignment.
	Identity *IdentityResponse `pulumi:"identity"`
	// The location of the policy assignment. Only required when utilizing managed identity.
	Location *string `pulumi:"location"`
	// The policy assignment metadata.
	Metadata interface{} `pulumi:"metadata"`
	// The name of the policy assignment.
	Name *string `pulumi:"name"`
	// The policy's excluded scopes.
	NotScopes []string `pulumi:"notScopes"`
	// Required if a parameter is used in policy rule.
	Parameters interface{} `pulumi:"parameters"`
	// The ID of the policy definition or policy set definition being assigned.
	PolicyDefinitionId *string `pulumi:"policyDefinitionId"`
	// The scope for the policy assignment.
	Scope *string `pulumi:"scope"`
	// The policy sku. This property is optional, obsolete, and will be ignored.
	Sku *PolicySkuResponse `pulumi:"sku"`
	// The type of the policy assignment.
	Type *string `pulumi:"type"`
}

type PolicyAssignmentState struct {
	// This message will be part of response in case of policy violation.
	Description pulumi.StringPtrInput
	// The display name of the policy assignment.
	DisplayName pulumi.StringPtrInput
	// The managed identity associated with the policy assignment.
	Identity IdentityResponsePtrInput
	// The location of the policy assignment. Only required when utilizing managed identity.
	Location pulumi.StringPtrInput
	// The policy assignment metadata.
	Metadata pulumi.Input
	// The name of the policy assignment.
	Name pulumi.StringPtrInput
	// The policy's excluded scopes.
	NotScopes pulumi.StringArrayInput
	// Required if a parameter is used in policy rule.
	Parameters pulumi.Input
	// The ID of the policy definition or policy set definition being assigned.
	PolicyDefinitionId pulumi.StringPtrInput
	// The scope for the policy assignment.
	Scope pulumi.StringPtrInput
	// The policy sku. This property is optional, obsolete, and will be ignored.
	Sku PolicySkuResponsePtrInput
	// The type of the policy assignment.
	Type pulumi.StringPtrInput
}

func (PolicyAssignmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*policyAssignmentState)(nil)).Elem()
}

type policyAssignmentArgs struct {
	// This message will be part of response in case of policy violation.
	Description *string `pulumi:"description"`
	// The display name of the policy assignment.
	DisplayName *string `pulumi:"displayName"`
	// The managed identity associated with the policy assignment.
	Identity *Identity `pulumi:"identity"`
	// The location of the policy assignment. Only required when utilizing managed identity.
	Location *string `pulumi:"location"`
	// The policy assignment metadata.
	Metadata interface{} `pulumi:"metadata"`
	// The policy's excluded scopes.
	NotScopes []string `pulumi:"notScopes"`
	// Required if a parameter is used in policy rule.
	Parameters interface{} `pulumi:"parameters"`
	// The name of the policy assignment.
	PolicyAssignmentName string `pulumi:"policyAssignmentName"`
	// The ID of the policy definition or policy set definition being assigned.
	PolicyDefinitionId *string `pulumi:"policyDefinitionId"`
	// The scope for the policy assignment.
	Scope string `pulumi:"scope"`
	// The policy sku. This property is optional, obsolete, and will be ignored.
	Sku *PolicySku `pulumi:"sku"`
}

// The set of arguments for constructing a PolicyAssignment resource.
type PolicyAssignmentArgs struct {
	// This message will be part of response in case of policy violation.
	Description pulumi.StringPtrInput
	// The display name of the policy assignment.
	DisplayName pulumi.StringPtrInput
	// The managed identity associated with the policy assignment.
	Identity IdentityPtrInput
	// The location of the policy assignment. Only required when utilizing managed identity.
	Location pulumi.StringPtrInput
	// The policy assignment metadata.
	Metadata pulumi.Input
	// The policy's excluded scopes.
	NotScopes pulumi.StringArrayInput
	// Required if a parameter is used in policy rule.
	Parameters pulumi.Input
	// The name of the policy assignment.
	PolicyAssignmentName pulumi.StringInput
	// The ID of the policy definition or policy set definition being assigned.
	PolicyDefinitionId pulumi.StringPtrInput
	// The scope for the policy assignment.
	Scope pulumi.StringInput
	// The policy sku. This property is optional, obsolete, and will be ignored.
	Sku PolicySkuPtrInput
}

func (PolicyAssignmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*policyAssignmentArgs)(nil)).Elem()
}

type PolicyAssignmentInput interface {
	pulumi.Input

	ToPolicyAssignmentOutput() PolicyAssignmentOutput
	ToPolicyAssignmentOutputWithContext(ctx context.Context) PolicyAssignmentOutput
}

func (PolicyAssignment) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyAssignment)(nil)).Elem()
}

func (i PolicyAssignment) ToPolicyAssignmentOutput() PolicyAssignmentOutput {
	return i.ToPolicyAssignmentOutputWithContext(context.Background())
}

func (i PolicyAssignment) ToPolicyAssignmentOutputWithContext(ctx context.Context) PolicyAssignmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyAssignmentOutput)
}

type PolicyAssignmentOutput struct {
	*pulumi.OutputState
}

func (PolicyAssignmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyAssignmentOutput)(nil)).Elem()
}

func (o PolicyAssignmentOutput) ToPolicyAssignmentOutput() PolicyAssignmentOutput {
	return o
}

func (o PolicyAssignmentOutput) ToPolicyAssignmentOutputWithContext(ctx context.Context) PolicyAssignmentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PolicyAssignmentOutput{})
}
