// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200918

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Class representing a database principal assignment.
type DatabasePrincipalAssignment struct {
	pulumi.CustomResourceState

	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
	PrincipalId pulumi.StringOutput `pulumi:"principalId"`
	// The principal name
	PrincipalName pulumi.StringOutput `pulumi:"principalName"`
	// Principal type.
	PrincipalType pulumi.StringOutput `pulumi:"principalType"`
	// The provisioned state of the resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Database principal role.
	Role pulumi.StringOutput `pulumi:"role"`
	// The tenant id of the principal
	TenantId pulumi.StringPtrOutput `pulumi:"tenantId"`
	// The tenant name of the principal
	TenantName pulumi.StringOutput `pulumi:"tenantName"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDatabasePrincipalAssignment registers a new resource with the given unique name, arguments, and options.
func NewDatabasePrincipalAssignment(ctx *pulumi.Context,
	name string, args *DatabasePrincipalAssignmentArgs, opts ...pulumi.ResourceOption) (*DatabasePrincipalAssignment, error) {
	if args == nil || args.ClusterName == nil {
		return nil, errors.New("missing required argument 'ClusterName'")
	}
	if args == nil || args.DatabaseName == nil {
		return nil, errors.New("missing required argument 'DatabaseName'")
	}
	if args == nil || args.PrincipalAssignmentName == nil {
		return nil, errors.New("missing required argument 'PrincipalAssignmentName'")
	}
	if args == nil || args.PrincipalId == nil {
		return nil, errors.New("missing required argument 'PrincipalId'")
	}
	if args == nil || args.PrincipalType == nil {
		return nil, errors.New("missing required argument 'PrincipalType'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Role == nil {
		return nil, errors.New("missing required argument 'Role'")
	}
	if args == nil {
		args = &DatabasePrincipalAssignmentArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:kusto/latest:DatabasePrincipalAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:kusto/v20191109:DatabasePrincipalAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:kusto/v20200215:DatabasePrincipalAssignment"),
		},
		{
			Type: pulumi.String("azure-nextgen:kusto/v20200614:DatabasePrincipalAssignment"),
		},
	})
	opts = append(opts, aliases)
	var resource DatabasePrincipalAssignment
	err := ctx.RegisterResource("azure-nextgen:kusto/v20200918:DatabasePrincipalAssignment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabasePrincipalAssignment gets an existing DatabasePrincipalAssignment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabasePrincipalAssignment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabasePrincipalAssignmentState, opts ...pulumi.ResourceOption) (*DatabasePrincipalAssignment, error) {
	var resource DatabasePrincipalAssignment
	err := ctx.ReadResource("azure-nextgen:kusto/v20200918:DatabasePrincipalAssignment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatabasePrincipalAssignment resources.
type databasePrincipalAssignmentState struct {
	// The name of the resource
	Name *string `pulumi:"name"`
	// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
	PrincipalId *string `pulumi:"principalId"`
	// The principal name
	PrincipalName *string `pulumi:"principalName"`
	// Principal type.
	PrincipalType *string `pulumi:"principalType"`
	// The provisioned state of the resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Database principal role.
	Role *string `pulumi:"role"`
	// The tenant id of the principal
	TenantId *string `pulumi:"tenantId"`
	// The tenant name of the principal
	TenantName *string `pulumi:"tenantName"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type DatabasePrincipalAssignmentState struct {
	// The name of the resource
	Name pulumi.StringPtrInput
	// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
	PrincipalId pulumi.StringPtrInput
	// The principal name
	PrincipalName pulumi.StringPtrInput
	// Principal type.
	PrincipalType pulumi.StringPtrInput
	// The provisioned state of the resource.
	ProvisioningState pulumi.StringPtrInput
	// Database principal role.
	Role pulumi.StringPtrInput
	// The tenant id of the principal
	TenantId pulumi.StringPtrInput
	// The tenant name of the principal
	TenantName pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (DatabasePrincipalAssignmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*databasePrincipalAssignmentState)(nil)).Elem()
}

type databasePrincipalAssignmentArgs struct {
	// The name of the Kusto cluster.
	ClusterName string `pulumi:"clusterName"`
	// The name of the database in the Kusto cluster.
	DatabaseName string `pulumi:"databaseName"`
	// The name of the Kusto principalAssignment.
	PrincipalAssignmentName string `pulumi:"principalAssignmentName"`
	// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
	PrincipalId string `pulumi:"principalId"`
	// Principal type.
	PrincipalType string `pulumi:"principalType"`
	// The name of the resource group containing the Kusto cluster.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Database principal role.
	Role string `pulumi:"role"`
	// The tenant id of the principal
	TenantId *string `pulumi:"tenantId"`
}

// The set of arguments for constructing a DatabasePrincipalAssignment resource.
type DatabasePrincipalAssignmentArgs struct {
	// The name of the Kusto cluster.
	ClusterName pulumi.StringInput
	// The name of the database in the Kusto cluster.
	DatabaseName pulumi.StringInput
	// The name of the Kusto principalAssignment.
	PrincipalAssignmentName pulumi.StringInput
	// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
	PrincipalId pulumi.StringInput
	// Principal type.
	PrincipalType pulumi.StringInput
	// The name of the resource group containing the Kusto cluster.
	ResourceGroupName pulumi.StringInput
	// Database principal role.
	Role pulumi.StringInput
	// The tenant id of the principal
	TenantId pulumi.StringPtrInput
}

func (DatabasePrincipalAssignmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databasePrincipalAssignmentArgs)(nil)).Elem()
}
