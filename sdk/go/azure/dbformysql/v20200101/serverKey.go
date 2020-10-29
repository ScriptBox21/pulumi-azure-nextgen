// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200101

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A MySQL Server key.
type ServerKey struct {
	pulumi.CustomResourceState

	// The key creation date.
	CreationDate pulumi.StringOutput `pulumi:"creationDate"`
	// Kind of encryption protector used to protect the key.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The key type like 'AzureKeyVault'.
	ServerKeyType pulumi.StringOutput `pulumi:"serverKeyType"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
	// The URI of the key.
	Uri pulumi.StringPtrOutput `pulumi:"uri"`
}

// NewServerKey registers a new resource with the given unique name, arguments, and options.
func NewServerKey(ctx *pulumi.Context,
	name string, args *ServerKeyArgs, opts ...pulumi.ResourceOption) (*ServerKey, error) {
	if args == nil || args.KeyName == nil {
		return nil, errors.New("missing required argument 'KeyName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerKeyType == nil {
		return nil, errors.New("missing required argument 'ServerKeyType'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil {
		args = &ServerKeyArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:dbformysql/latest:ServerKey"),
		},
		{
			Type: pulumi.String("azure-nextgen:dbformysql/v20200101privatepreview:ServerKey"),
		},
	})
	opts = append(opts, aliases)
	var resource ServerKey
	err := ctx.RegisterResource("azure-nextgen:dbformysql/v20200101:ServerKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServerKey gets an existing ServerKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServerKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServerKeyState, opts ...pulumi.ResourceOption) (*ServerKey, error) {
	var resource ServerKey
	err := ctx.ReadResource("azure-nextgen:dbformysql/v20200101:ServerKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServerKey resources.
type serverKeyState struct {
	// The key creation date.
	CreationDate *string `pulumi:"creationDate"`
	// Kind of encryption protector used to protect the key.
	Kind *string `pulumi:"kind"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The key type like 'AzureKeyVault'.
	ServerKeyType *string `pulumi:"serverKeyType"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
	// The URI of the key.
	Uri *string `pulumi:"uri"`
}

type ServerKeyState struct {
	// The key creation date.
	CreationDate pulumi.StringPtrInput
	// Kind of encryption protector used to protect the key.
	Kind pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The key type like 'AzureKeyVault'.
	ServerKeyType pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
	// The URI of the key.
	Uri pulumi.StringPtrInput
}

func (ServerKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*serverKeyState)(nil)).Elem()
}

type serverKeyArgs struct {
	// The name of the MySQL Server key to be operated on (updated or created).
	KeyName string `pulumi:"keyName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The key type like 'AzureKeyVault'.
	ServerKeyType string `pulumi:"serverKeyType"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
	// The URI of the key.
	Uri *string `pulumi:"uri"`
}

// The set of arguments for constructing a ServerKey resource.
type ServerKeyArgs struct {
	// The name of the MySQL Server key to be operated on (updated or created).
	KeyName pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// The key type like 'AzureKeyVault'.
	ServerKeyType pulumi.StringInput
	// The name of the server.
	ServerName pulumi.StringInput
	// The URI of the key.
	Uri pulumi.StringPtrInput
}

func (ServerKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serverKeyArgs)(nil)).Elem()
}
