// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201030preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Definition of the EnterprisePolicy.
type EnterprisePolicy struct {
	pulumi.CustomResourceState

	// The encryption settings for a configuration store.
	Encryption PropertiesResponseEncryptionPtrOutput `pulumi:"encryption"`
	// The identity of the EnterprisePolicy.
	Identity EnterprisePolicyIdentityResponsePtrOutput `pulumi:"identity"`
	// Region where the EnterprisePolicy is located.
	Location pulumi.StringOutput `pulumi:"location"`
	// Settings concerning lockbox.
	Lockbox PropertiesResponseLockboxPtrOutput `pulumi:"lockbox"`
	// Name of the EnterprisePolicy.
	Name pulumi.StringOutput `pulumi:"name"`
	// Metadata pertaining to creation and last modification of the resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewEnterprisePolicy registers a new resource with the given unique name, arguments, and options.
func NewEnterprisePolicy(ctx *pulumi.Context,
	name string, args *EnterprisePolicyArgs, opts ...pulumi.ResourceOption) (*EnterprisePolicy, error) {
	if args == nil || args.EnterprisePolicyName == nil {
		return nil, errors.New("missing required argument 'EnterprisePolicyName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &EnterprisePolicyArgs{}
	}
	var resource EnterprisePolicy
	err := ctx.RegisterResource("azure-nextgen:powerplatform/v20201030preview:EnterprisePolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEnterprisePolicy gets an existing EnterprisePolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEnterprisePolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EnterprisePolicyState, opts ...pulumi.ResourceOption) (*EnterprisePolicy, error) {
	var resource EnterprisePolicy
	err := ctx.ReadResource("azure-nextgen:powerplatform/v20201030preview:EnterprisePolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EnterprisePolicy resources.
type enterprisePolicyState struct {
	// The encryption settings for a configuration store.
	Encryption *PropertiesResponseEncryption `pulumi:"encryption"`
	// The identity of the EnterprisePolicy.
	Identity *EnterprisePolicyIdentityResponse `pulumi:"identity"`
	// Region where the EnterprisePolicy is located.
	Location *string `pulumi:"location"`
	// Settings concerning lockbox.
	Lockbox *PropertiesResponseLockbox `pulumi:"lockbox"`
	// Name of the EnterprisePolicy.
	Name *string `pulumi:"name"`
	// Metadata pertaining to creation and last modification of the resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type *string `pulumi:"type"`
}

type EnterprisePolicyState struct {
	// The encryption settings for a configuration store.
	Encryption PropertiesResponseEncryptionPtrInput
	// The identity of the EnterprisePolicy.
	Identity EnterprisePolicyIdentityResponsePtrInput
	// Region where the EnterprisePolicy is located.
	Location pulumi.StringPtrInput
	// Settings concerning lockbox.
	Lockbox PropertiesResponseLockboxPtrInput
	// Name of the EnterprisePolicy.
	Name pulumi.StringPtrInput
	// Metadata pertaining to creation and last modification of the resource.
	SystemData SystemDataResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource.
	Type pulumi.StringPtrInput
}

func (EnterprisePolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*enterprisePolicyState)(nil)).Elem()
}

type enterprisePolicyArgs struct {
	// The encryption settings for a configuration store.
	Encryption *PropertiesEncryption `pulumi:"encryption"`
	// Name of the EnterprisePolicy.
	EnterprisePolicyName string `pulumi:"enterprisePolicyName"`
	// The identity of the EnterprisePolicy.
	Identity *EnterprisePolicyIdentity `pulumi:"identity"`
	// The Azure Region where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a EnterprisePolicy resource.
type EnterprisePolicyArgs struct {
	// The encryption settings for a configuration store.
	Encryption PropertiesEncryptionPtrInput
	// Name of the EnterprisePolicy.
	EnterprisePolicyName pulumi.StringInput
	// The identity of the EnterprisePolicy.
	Identity EnterprisePolicyIdentityPtrInput
	// The Azure Region where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (EnterprisePolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*enterprisePolicyArgs)(nil)).Elem()
}