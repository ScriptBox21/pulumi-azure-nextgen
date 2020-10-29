// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The policy exemption.
type PolicyExemption struct {
	pulumi.CustomResourceState

	// The description of the policy exemption.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The display name of the policy exemption.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// The policy exemption category. Possible values are Waiver and Mitigated.
	ExemptionCategory pulumi.StringOutput `pulumi:"exemptionCategory"`
	// The expiration date and time (in UTC ISO 8601 format yyyy-MM-ddTHH:mm:ssZ) of the policy exemption.
	ExpiresOn pulumi.StringPtrOutput `pulumi:"expiresOn"`
	// The policy exemption metadata. Metadata is an open ended object and is typically a collection of key value pairs.
	Metadata pulumi.AnyOutput `pulumi:"metadata"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the policy assignment that is being exempted.
	PolicyAssignmentId pulumi.StringOutput `pulumi:"policyAssignmentId"`
	// The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.
	PolicyDefinitionReferenceIds pulumi.StringArrayOutput `pulumi:"policyDefinitionReferenceIds"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPolicyExemption registers a new resource with the given unique name, arguments, and options.
func NewPolicyExemption(ctx *pulumi.Context,
	name string, args *PolicyExemptionArgs, opts ...pulumi.ResourceOption) (*PolicyExemption, error) {
	if args == nil || args.ExemptionCategory == nil {
		return nil, errors.New("missing required argument 'ExemptionCategory'")
	}
	if args == nil || args.PolicyAssignmentId == nil {
		return nil, errors.New("missing required argument 'PolicyAssignmentId'")
	}
	if args == nil || args.PolicyExemptionName == nil {
		return nil, errors.New("missing required argument 'PolicyExemptionName'")
	}
	if args == nil || args.Scope == nil {
		return nil, errors.New("missing required argument 'Scope'")
	}
	if args == nil {
		args = &PolicyExemptionArgs{}
	}
	var resource PolicyExemption
	err := ctx.RegisterResource("azure-nextgen:authorization/v20200701preview:PolicyExemption", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPolicyExemption gets an existing PolicyExemption resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPolicyExemption(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PolicyExemptionState, opts ...pulumi.ResourceOption) (*PolicyExemption, error) {
	var resource PolicyExemption
	err := ctx.ReadResource("azure-nextgen:authorization/v20200701preview:PolicyExemption", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PolicyExemption resources.
type policyExemptionState struct {
	// The description of the policy exemption.
	Description *string `pulumi:"description"`
	// The display name of the policy exemption.
	DisplayName *string `pulumi:"displayName"`
	// The policy exemption category. Possible values are Waiver and Mitigated.
	ExemptionCategory *string `pulumi:"exemptionCategory"`
	// The expiration date and time (in UTC ISO 8601 format yyyy-MM-ddTHH:mm:ssZ) of the policy exemption.
	ExpiresOn *string `pulumi:"expiresOn"`
	// The policy exemption metadata. Metadata is an open ended object and is typically a collection of key value pairs.
	Metadata interface{} `pulumi:"metadata"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The ID of the policy assignment that is being exempted.
	PolicyAssignmentId *string `pulumi:"policyAssignmentId"`
	// The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.
	PolicyDefinitionReferenceIds []string `pulumi:"policyDefinitionReferenceIds"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type PolicyExemptionState struct {
	// The description of the policy exemption.
	Description pulumi.StringPtrInput
	// The display name of the policy exemption.
	DisplayName pulumi.StringPtrInput
	// The policy exemption category. Possible values are Waiver and Mitigated.
	ExemptionCategory pulumi.StringPtrInput
	// The expiration date and time (in UTC ISO 8601 format yyyy-MM-ddTHH:mm:ssZ) of the policy exemption.
	ExpiresOn pulumi.StringPtrInput
	// The policy exemption metadata. Metadata is an open ended object and is typically a collection of key value pairs.
	Metadata pulumi.Input
	// The name of the resource
	Name pulumi.StringPtrInput
	// The ID of the policy assignment that is being exempted.
	PolicyAssignmentId pulumi.StringPtrInput
	// The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.
	PolicyDefinitionReferenceIds pulumi.StringArrayInput
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponsePtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (PolicyExemptionState) ElementType() reflect.Type {
	return reflect.TypeOf((*policyExemptionState)(nil)).Elem()
}

type policyExemptionArgs struct {
	// The description of the policy exemption.
	Description *string `pulumi:"description"`
	// The display name of the policy exemption.
	DisplayName *string `pulumi:"displayName"`
	// The policy exemption category. Possible values are Waiver and Mitigated.
	ExemptionCategory string `pulumi:"exemptionCategory"`
	// The expiration date and time (in UTC ISO 8601 format yyyy-MM-ddTHH:mm:ssZ) of the policy exemption.
	ExpiresOn *string `pulumi:"expiresOn"`
	// The policy exemption metadata. Metadata is an open ended object and is typically a collection of key value pairs.
	Metadata interface{} `pulumi:"metadata"`
	// The ID of the policy assignment that is being exempted.
	PolicyAssignmentId string `pulumi:"policyAssignmentId"`
	// The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.
	PolicyDefinitionReferenceIds []string `pulumi:"policyDefinitionReferenceIds"`
	// The name of the policy exemption to delete.
	PolicyExemptionName string `pulumi:"policyExemptionName"`
	// The scope of the policy exemption. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
	Scope string `pulumi:"scope"`
}

// The set of arguments for constructing a PolicyExemption resource.
type PolicyExemptionArgs struct {
	// The description of the policy exemption.
	Description pulumi.StringPtrInput
	// The display name of the policy exemption.
	DisplayName pulumi.StringPtrInput
	// The policy exemption category. Possible values are Waiver and Mitigated.
	ExemptionCategory pulumi.StringInput
	// The expiration date and time (in UTC ISO 8601 format yyyy-MM-ddTHH:mm:ssZ) of the policy exemption.
	ExpiresOn pulumi.StringPtrInput
	// The policy exemption metadata. Metadata is an open ended object and is typically a collection of key value pairs.
	Metadata pulumi.Input
	// The ID of the policy assignment that is being exempted.
	PolicyAssignmentId pulumi.StringInput
	// The policy definition reference ID list when the associated policy assignment is an assignment of a policy set definition.
	PolicyDefinitionReferenceIds pulumi.StringArrayInput
	// The name of the policy exemption to delete.
	PolicyExemptionName pulumi.StringInput
	// The scope of the policy exemption. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
	Scope pulumi.StringInput
}

func (PolicyExemptionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*policyExemptionArgs)(nil)).Elem()
}
