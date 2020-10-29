// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a and external administrator to be created.
type ServerAdministrator struct {
	pulumi.CustomResourceState

	// The type of administrator.
	AdministratorType pulumi.StringOutput `pulumi:"administratorType"`
	// The server administrator login account name.
	Login pulumi.StringOutput `pulumi:"login"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The server administrator Sid (Secure ID).
	Sid pulumi.StringOutput `pulumi:"sid"`
	// The server Active Directory Administrator tenant id.
	TenantId pulumi.StringOutput `pulumi:"tenantId"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewServerAdministrator registers a new resource with the given unique name, arguments, and options.
func NewServerAdministrator(ctx *pulumi.Context,
	name string, args *ServerAdministratorArgs, opts ...pulumi.ResourceOption) (*ServerAdministrator, error) {
	if args == nil || args.AdministratorType == nil {
		return nil, errors.New("missing required argument 'AdministratorType'")
	}
	if args == nil || args.Login == nil {
		return nil, errors.New("missing required argument 'Login'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil || args.Sid == nil {
		return nil, errors.New("missing required argument 'Sid'")
	}
	if args == nil || args.TenantId == nil {
		return nil, errors.New("missing required argument 'TenantId'")
	}
	if args == nil {
		args = &ServerAdministratorArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:dbformysql/v20171201:ServerAdministrator"),
		},
		{
			Type: pulumi.String("azure-nextgen:dbformysql/v20171201preview:ServerAdministrator"),
		},
	})
	opts = append(opts, aliases)
	var resource ServerAdministrator
	err := ctx.RegisterResource("azure-nextgen:dbformysql/latest:ServerAdministrator", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerAdministrator gets an existing ServerAdministrator resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerAdministrator(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerAdministratorState, opts ...pulumi.ResourceOption) (*ServerAdministrator, error) {
	var resource ServerAdministrator
	err := ctx.ReadResource("azure-nextgen:dbformysql/latest:ServerAdministrator", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerAdministrator resources.
type serverAdministratorState struct {
	// The type of administrator.
	AdministratorType *string `pulumi:"administratorType"`
	// The server administrator login account name.
	Login *string `pulumi:"login"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The server administrator Sid (Secure ID).
	Sid *string `pulumi:"sid"`
	// The server Active Directory Administrator tenant id.
	TenantId *string `pulumi:"tenantId"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type ServerAdministratorState struct {
	// The type of administrator.
	AdministratorType pulumi.StringPtrInput
	// The server administrator login account name.
	Login pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The server administrator Sid (Secure ID).
	Sid pulumi.StringPtrInput
	// The server Active Directory Administrator tenant id.
	TenantId pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (ServerAdministratorState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverAdministratorState)(nil)).Elem()
}

type serverAdministratorArgs struct {
	// The type of administrator.
	AdministratorType string `pulumi:"administratorType"`
	// The server administrator login account name.
	Login string `pulumi:"login"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
	// The server administrator Sid (Secure ID).
	Sid string `pulumi:"sid"`
	// The server Active Directory Administrator tenant id.
	TenantId string `pulumi:"tenantId"`
}

// The set of arguments for constructing a ServerAdministrator resource.
type ServerAdministratorArgs struct {
	// The type of administrator.
	AdministratorType pulumi.StringInput
	// The server administrator login account name.
	Login pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The name of the server.
	ServerName pulumi.StringInput
	// The server administrator Sid (Secure ID).
	Sid pulumi.StringInput
	// The server Active Directory Administrator tenant id.
	TenantId pulumi.StringInput
}

func (ServerAdministratorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverAdministratorArgs)(nil)).Elem()
}
