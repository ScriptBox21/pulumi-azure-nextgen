// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The Get Storage Account ManagementPolicies operation response.
type ManagementPolicy struct {
	pulumi.CustomResourceState

	// Returns the date and time the ManagementPolicies was last modified.
	LastModifiedTime pulumi.StringOutput `pulumi:"lastModifiedTime"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
	Policy ManagementPolicySchemaResponseOutput `pulumi:"policy"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewManagementPolicy registers a new resource with the given unique name, arguments, and options.
func NewManagementPolicy(ctx *pulumi.Context,
	name string, args *ManagementPolicyArgs, opts ...pulumi.ResourceOption) (*ManagementPolicy, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.ManagementPolicyName == nil {
		return nil, errors.New("missing required argument 'ManagementPolicyName'")
	}
	if args == nil || args.Policy == nil {
		return nil, errors.New("missing required argument 'Policy'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ManagementPolicyArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storage/latest:ManagementPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20180301preview:ManagementPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20181101:ManagementPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190401:ManagementPolicy"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190601:ManagementPolicy"),
		},
	})
	opts = append(opts, aliases)
	var resource ManagementPolicy
	err := ctx.RegisterResource("azure-nextgen:storage/v20200801preview:ManagementPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagementPolicy gets an existing ManagementPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagementPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagementPolicyState, opts ...pulumi.ResourceOption) (*ManagementPolicy, error) {
	var resource ManagementPolicy
	err := ctx.ReadResource("azure-nextgen:storage/v20200801preview:ManagementPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagementPolicy resources.
type managementPolicyState struct {
	// Returns the date and time the ManagementPolicies was last modified.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
	Policy *ManagementPolicySchemaResponse `pulumi:"policy"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type ManagementPolicyState struct {
	// Returns the date and time the ManagementPolicies was last modified.
	LastModifiedTime pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
	Policy ManagementPolicySchemaResponsePtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (ManagementPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*managementPolicyState)(nil)).Elem()
}

type managementPolicyArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// The name of the Storage Account Management Policy. It should always be 'default'
	ManagementPolicyName string `pulumi:"managementPolicyName"`
	// The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
	Policy ManagementPolicySchema `pulumi:"policy"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a ManagementPolicy resource.
type ManagementPolicyArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName pulumi.StringInput
	// The name of the Storage Account Management Policy. It should always be 'default'
	ManagementPolicyName pulumi.StringInput
	// The Storage Account ManagementPolicy, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
	Policy ManagementPolicySchemaInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
}

func (ManagementPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managementPolicyArgs)(nil)).Elem()
}
