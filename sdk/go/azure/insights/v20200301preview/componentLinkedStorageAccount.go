// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Application Insights component linked storage accounts
type ComponentLinkedStorageAccount struct {
	pulumi.CustomResourceState

	// Linked storage account resource ID
	LinkedStorageAccount pulumi.StringPtrOutput `pulumi:"linkedStorageAccount"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewComponentLinkedStorageAccount registers a new resource with the given unique name, arguments, and options.
func NewComponentLinkedStorageAccount(ctx *pulumi.Context,
	name string, args *ComponentLinkedStorageAccountArgs, opts ...pulumi.ResourceOption) (*ComponentLinkedStorageAccount, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ResourceName == nil {
		return nil, errors.New("missing required argument 'ResourceName'")
	}
	if args == nil || args.StorageType == nil {
		return nil, errors.New("missing required argument 'StorageType'")
	}
	if args == nil {
		args = &ComponentLinkedStorageAccountArgs{}
	}
	var resource ComponentLinkedStorageAccount
	err := ctx.RegisterResource("azure-nextgen:insights/v20200301preview:ComponentLinkedStorageAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComponentLinkedStorageAccount gets an existing ComponentLinkedStorageAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComponentLinkedStorageAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComponentLinkedStorageAccountState, opts ...pulumi.ResourceOption) (*ComponentLinkedStorageAccount, error) {
	var resource ComponentLinkedStorageAccount
	err := ctx.ReadResource("azure-nextgen:insights/v20200301preview:ComponentLinkedStorageAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComponentLinkedStorageAccount resources.
type componentLinkedStorageAccountState struct {
	// Linked storage account resource ID
	LinkedStorageAccount *string `pulumi:"linkedStorageAccount"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type ComponentLinkedStorageAccountState struct {
	// Linked storage account resource ID
	LinkedStorageAccount pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (ComponentLinkedStorageAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*componentLinkedStorageAccountState)(nil)).Elem()
}

type componentLinkedStorageAccountArgs struct {
	// Linked storage account resource ID
	LinkedStorageAccount *string `pulumi:"linkedStorageAccount"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Application Insights component resource.
	ResourceName string `pulumi:"resourceName"`
	// The type of the Application Insights component data source for the linked storage account.
	StorageType string `pulumi:"storageType"`
}

// The set of arguments for constructing a ComponentLinkedStorageAccount resource.
type ComponentLinkedStorageAccountArgs struct {
	// Linked storage account resource ID
	LinkedStorageAccount pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the Application Insights component resource.
	ResourceName pulumi.StringInput
	// The type of the Application Insights component data source for the linked storage account.
	StorageType pulumi.StringInput
}

func (ComponentLinkedStorageAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*componentLinkedStorageAccountArgs)(nil)).Elem()
}
