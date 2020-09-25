// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupBackupPolicy(ctx *pulumi.Context, args *LookupBackupPolicyArgs, opts ...pulumi.InvokeOption) (*LookupBackupPolicyResult, error) {
	var rv LookupBackupPolicyResult
	err := ctx.Invoke("azure-nextgen:netapp/v20200601:getBackupPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupBackupPolicyArgs struct {
	// The name of the NetApp account
	AccountName string `pulumi:"accountName"`
	// Backup policy Name which uniquely identify backup policy.
	BackupPolicyName string `pulumi:"backupPolicyName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Backup policy information
type LookupBackupPolicyResult struct {
	// Daily backups count to keep
	DailyBackupsToKeep *int `pulumi:"dailyBackupsToKeep"`
	// The property to decide policy is enabled or not
	Enabled *bool `pulumi:"enabled"`
	// Resource location
	Location string `pulumi:"location"`
	// Monthly backups count to keep
	MonthlyBackupsToKeep *int `pulumi:"monthlyBackupsToKeep"`
	// Name of backup policy
	Name string `pulumi:"name"`
	// Azure lifecycle management
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type string `pulumi:"type"`
	// A list of volumes assigned to this policy
	VolumeBackups []VolumeBackupsResponse `pulumi:"volumeBackups"`
	// Volumes using current backup policy
	VolumesAssigned *int `pulumi:"volumesAssigned"`
	// Weekly backups count to keep
	WeeklyBackupsToKeep *int `pulumi:"weeklyBackupsToKeep"`
	// Yearly backups count to keep
	YearlyBackupsToKeep *int `pulumi:"yearlyBackupsToKeep"`
}
