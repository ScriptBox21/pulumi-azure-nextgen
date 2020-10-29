// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200113preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A private endpoint connection
type PrivateEndpointConnection struct {
	pulumi.CustomResourceState

	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Private endpoint which the connection belongs to.
	PrivateEndpoint PrivateEndpointPropertyResponsePtrOutput `pulumi:"privateEndpoint"`
	// Connection State of the Private Endpoint Connection.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStatePropertyResponsePtrOutput `pulumi:"privateLinkServiceConnectionState"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewPrivateEndpointConnection registers a new resource with the given unique name, arguments, and options.
func NewPrivateEndpointConnection(ctx *pulumi.Context,
	name string, args *PrivateEndpointConnectionArgs, opts ...pulumi.ResourceOption) (*PrivateEndpointConnection, error) {
	if args == nil || args.AutomationAccountName == nil {
		return nil, errors.New("missing required argument 'AutomationAccountName'")
	}
	if args == nil || args.PrivateEndpointConnectionName == nil {
		return nil, errors.New("missing required argument 'PrivateEndpointConnectionName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &PrivateEndpointConnectionArgs{}
	}
	var resource PrivateEndpointConnection
	err := ctx.RegisterResource("azure-nextgen:automation/v20200113preview:PrivateEndpointConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPrivateEndpointConnection gets an existing PrivateEndpointConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPrivateEndpointConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PrivateEndpointConnectionState, opts ...pulumi.ResourceOption) (*PrivateEndpointConnection, error) {
	var resource PrivateEndpointConnection
	err := ctx.ReadResource("azure-nextgen:automation/v20200113preview:PrivateEndpointConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PrivateEndpointConnection resources.
type privateEndpointConnectionState struct {
	// The name of the resource
	Name *string `pulumi:"name"`
	// Private endpoint which the connection belongs to.
	PrivateEndpoint *PrivateEndpointPropertyResponse `pulumi:"privateEndpoint"`
	// Connection State of the Private Endpoint Connection.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionStatePropertyResponse `pulumi:"privateLinkServiceConnectionState"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type PrivateEndpointConnectionState struct {
	// The name of the resource
	Name pulumi.StringPtrInput
	// Private endpoint which the connection belongs to.
	PrivateEndpoint PrivateEndpointPropertyResponsePtrInput
	// Connection State of the Private Endpoint Connection.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStatePropertyResponsePtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (PrivateEndpointConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*privateEndpointConnectionState)(nil)).Elem()
}

type privateEndpointConnectionArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// Private endpoint which the connection belongs to.
	PrivateEndpoint *PrivateEndpointProperty `pulumi:"privateEndpoint"`
	// The name of the private endpoint connection.
	PrivateEndpointConnectionName string `pulumi:"privateEndpointConnectionName"`
	// Connection State of the Private Endpoint Connection.
	PrivateLinkServiceConnectionState *PrivateLinkServiceConnectionStateProperty `pulumi:"privateLinkServiceConnectionState"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a PrivateEndpointConnection resource.
type PrivateEndpointConnectionArgs struct {
	// The name of the automation account.
	AutomationAccountName pulumi.StringInput
	// Private endpoint which the connection belongs to.
	PrivateEndpoint PrivateEndpointPropertyPtrInput
	// The name of the private endpoint connection.
	PrivateEndpointConnectionName pulumi.StringInput
	// Connection State of the Private Endpoint Connection.
	PrivateLinkServiceConnectionState PrivateLinkServiceConnectionStatePropertyPtrInput
	// Name of an Azure Resource group.
	ResourceGroupName pulumi.StringInput
}

func (PrivateEndpointConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*privateEndpointConnectionArgs)(nil)).Elem()
}
