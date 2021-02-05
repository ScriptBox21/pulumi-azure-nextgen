// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170815

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Snapshot of a Volume
type Snapshot struct {
	pulumi.CustomResourceState

	// The creation date of the snapshot
	CreationDate pulumi.StringOutput `pulumi:"creationDate"`
	// UUID v4 used to identify the FileSystem
	FileSystemId pulumi.StringOutput `pulumi:"fileSystemId"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Azure lifecycle management
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// UUID v4 used to identify the Snapshot
	SnapshotId pulumi.StringOutput `pulumi:"snapshotId"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSnapshot registers a new resource with the given unique name, arguments, and options.
func NewSnapshot(ctx *pulumi.Context,
	name string, args *SnapshotArgs, opts ...pulumi.ResourceOption) (*Snapshot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.FileSystemId == nil {
		return nil, errors.New("invalid value for required argument 'FileSystemId'")
	}
	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.PoolName == nil {
		return nil, errors.New("invalid value for required argument 'PoolName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.SnapshotName == nil {
		return nil, errors.New("invalid value for required argument 'SnapshotName'")
	}
	if args.VolumeName == nil {
		return nil, errors.New("invalid value for required argument 'VolumeName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:netapp/latest:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20190501:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20190601:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20190701:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20190801:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20191001:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20191101:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20200201:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20200301:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20200501:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20200601:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20200701:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20200801:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20200901:Snapshot"),
		},
		{
			Type: pulumi.String("azure-nextgen:netapp/v20201101:Snapshot"),
		},
	})
	opts = append(opts, aliases)
	var resource Snapshot
	err := ctx.RegisterResource("azure-nextgen:netapp/v20170815:Snapshot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSnapshot gets an existing Snapshot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSnapshot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SnapshotState, opts ...pulumi.ResourceOption) (*Snapshot, error) {
	var resource Snapshot
	err := ctx.ReadResource("azure-nextgen:netapp/v20170815:Snapshot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Snapshot resources.
type snapshotState struct {
	// The creation date of the snapshot
	CreationDate *string `pulumi:"creationDate"`
	// UUID v4 used to identify the FileSystem
	FileSystemId *string `pulumi:"fileSystemId"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// Azure lifecycle management
	ProvisioningState *string `pulumi:"provisioningState"`
	// UUID v4 used to identify the Snapshot
	SnapshotId *string `pulumi:"snapshotId"`
	// Resource type
	Type *string `pulumi:"type"`
}

type SnapshotState struct {
	// The creation date of the snapshot
	CreationDate pulumi.StringPtrInput
	// UUID v4 used to identify the FileSystem
	FileSystemId pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Azure lifecycle management
	ProvisioningState pulumi.StringPtrInput
	// UUID v4 used to identify the Snapshot
	SnapshotId pulumi.StringPtrInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SnapshotState) ElementType() reflect.Type {
	return reflect.TypeOf((*snapshotState)(nil)).Elem()
}

type snapshotArgs struct {
	// The name of the NetApp account
	AccountName string `pulumi:"accountName"`
	// UUID v4 used to identify the FileSystem
	FileSystemId string `pulumi:"fileSystemId"`
	// Resource location
	Location string `pulumi:"location"`
	// The name of the capacity pool
	PoolName string `pulumi:"poolName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the mount target
	SnapshotName string `pulumi:"snapshotName"`
	// The name of the volume
	VolumeName string `pulumi:"volumeName"`
}

// The set of arguments for constructing a Snapshot resource.
type SnapshotArgs struct {
	// The name of the NetApp account
	AccountName pulumi.StringInput
	// UUID v4 used to identify the FileSystem
	FileSystemId pulumi.StringInput
	// Resource location
	Location pulumi.StringInput
	// The name of the capacity pool
	PoolName pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the mount target
	SnapshotName pulumi.StringInput
	// The name of the volume
	VolumeName pulumi.StringInput
}

func (SnapshotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*snapshotArgs)(nil)).Elem()
}

type SnapshotInput interface {
	pulumi.Input

	ToSnapshotOutput() SnapshotOutput
	ToSnapshotOutputWithContext(ctx context.Context) SnapshotOutput
}

func (*Snapshot) ElementType() reflect.Type {
	return reflect.TypeOf((*Snapshot)(nil))
}

func (i *Snapshot) ToSnapshotOutput() SnapshotOutput {
	return i.ToSnapshotOutputWithContext(context.Background())
}

func (i *Snapshot) ToSnapshotOutputWithContext(ctx context.Context) SnapshotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SnapshotOutput)
}

type SnapshotOutput struct {
	*pulumi.OutputState
}

func (SnapshotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Snapshot)(nil))
}

func (o SnapshotOutput) ToSnapshotOutput() SnapshotOutput {
	return o
}

func (o SnapshotOutput) ToSnapshotOutputWithContext(ctx context.Context) SnapshotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SnapshotOutput{})
}
