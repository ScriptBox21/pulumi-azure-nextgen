// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Description of a backup which will be performed.
type WebAppBackupConfigurationSlot struct {
	pulumi.CustomResourceState

	// Name of the backup.
	BackupName pulumi.StringPtrOutput `pulumi:"backupName"`
	// Schedule for the backup if it is executed periodically.
	BackupSchedule BackupScheduleResponsePtrOutput `pulumi:"backupSchedule"`
	// Databases included in the backup.
	Databases DatabaseBackupSettingResponseArrayOutput `pulumi:"databases"`
	// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// SAS URL to the container.
	StorageAccountUrl pulumi.StringOutput `pulumi:"storageAccountUrl"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppBackupConfigurationSlot registers a new resource with the given unique name, arguments, and options.
func NewWebAppBackupConfigurationSlot(ctx *pulumi.Context,
	name string, args *WebAppBackupConfigurationSlotArgs, opts ...pulumi.ResourceOption) (*WebAppBackupConfigurationSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Slot == nil {
		return nil, errors.New("invalid value for required argument 'Slot'")
	}
	if args.StorageAccountUrl == nil {
		return nil, errors.New("invalid value for required argument 'StorageAccountUrl'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppBackupConfigurationSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppBackupConfigurationSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppBackupConfigurationSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppBackupConfigurationSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppBackupConfigurationSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppBackupConfigurationSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppBackupConfigurationSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppBackupConfigurationSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppBackupConfigurationSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20181101:WebAppBackupConfigurationSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppBackupConfigurationSlot gets an existing WebAppBackupConfigurationSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppBackupConfigurationSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppBackupConfigurationSlotState, opts ...pulumi.ResourceOption) (*WebAppBackupConfigurationSlot, error) {
	var resource WebAppBackupConfigurationSlot
	err := ctx.ReadResource("azure-nextgen:web/v20181101:WebAppBackupConfigurationSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppBackupConfigurationSlot resources.
type webAppBackupConfigurationSlotState struct {
	// Name of the backup.
	BackupName *string `pulumi:"backupName"`
	// Schedule for the backup if it is executed periodically.
	BackupSchedule *BackupScheduleResponse `pulumi:"backupSchedule"`
	// Databases included in the backup.
	Databases []DatabaseBackupSettingResponse `pulumi:"databases"`
	// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
	Enabled *bool `pulumi:"enabled"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// SAS URL to the container.
	StorageAccountUrl *string `pulumi:"storageAccountUrl"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppBackupConfigurationSlotState struct {
	// Name of the backup.
	BackupName pulumi.StringPtrInput
	// Schedule for the backup if it is executed periodically.
	BackupSchedule BackupScheduleResponsePtrInput
	// Databases included in the backup.
	Databases DatabaseBackupSettingResponseArrayInput
	// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
	Enabled pulumi.BoolPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// SAS URL to the container.
	StorageAccountUrl pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppBackupConfigurationSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppBackupConfigurationSlotState)(nil)).Elem()
}

type webAppBackupConfigurationSlotArgs struct {
	// Name of the backup.
	BackupName *string `pulumi:"backupName"`
	// Schedule for the backup if it is executed periodically.
	BackupSchedule *BackupSchedule `pulumi:"backupSchedule"`
	// Databases included in the backup.
	Databases []DatabaseBackupSetting `pulumi:"databases"`
	// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
	Enabled *bool `pulumi:"enabled"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API will update the backup configuration for the production slot.
	Slot string `pulumi:"slot"`
	// SAS URL to the container.
	StorageAccountUrl string `pulumi:"storageAccountUrl"`
}

// The set of arguments for constructing a WebAppBackupConfigurationSlot resource.
type WebAppBackupConfigurationSlotArgs struct {
	// Name of the backup.
	BackupName pulumi.StringPtrInput
	// Schedule for the backup if it is executed periodically.
	BackupSchedule BackupSchedulePtrInput
	// Databases included in the backup.
	Databases DatabaseBackupSettingArrayInput
	// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
	Enabled pulumi.BoolPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Name of the deployment slot. If a slot is not specified, the API will update the backup configuration for the production slot.
	Slot pulumi.StringInput
	// SAS URL to the container.
	StorageAccountUrl pulumi.StringInput
}

func (WebAppBackupConfigurationSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppBackupConfigurationSlotArgs)(nil)).Elem()
}

type WebAppBackupConfigurationSlotInput interface {
	pulumi.Input

	ToWebAppBackupConfigurationSlotOutput() WebAppBackupConfigurationSlotOutput
	ToWebAppBackupConfigurationSlotOutputWithContext(ctx context.Context) WebAppBackupConfigurationSlotOutput
}

func (*WebAppBackupConfigurationSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppBackupConfigurationSlot)(nil))
}

func (i *WebAppBackupConfigurationSlot) ToWebAppBackupConfigurationSlotOutput() WebAppBackupConfigurationSlotOutput {
	return i.ToWebAppBackupConfigurationSlotOutputWithContext(context.Background())
}

func (i *WebAppBackupConfigurationSlot) ToWebAppBackupConfigurationSlotOutputWithContext(ctx context.Context) WebAppBackupConfigurationSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppBackupConfigurationSlotOutput)
}

type WebAppBackupConfigurationSlotOutput struct {
	*pulumi.OutputState
}

func (WebAppBackupConfigurationSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppBackupConfigurationSlot)(nil))
}

func (o WebAppBackupConfigurationSlotOutput) ToWebAppBackupConfigurationSlotOutput() WebAppBackupConfigurationSlotOutput {
	return o
}

func (o WebAppBackupConfigurationSlotOutput) ToWebAppBackupConfigurationSlotOutputWithContext(ctx context.Context) WebAppBackupConfigurationSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppBackupConfigurationSlotOutput{})
}
