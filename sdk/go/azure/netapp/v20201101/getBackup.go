// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupBackup(ctx *pulumi.Context, args *LookupBackupArgs, opts ...pulumi.InvokeOption) (*LookupBackupResult, error) {
	var rv LookupBackupResult
	err := ctx.Invoke("azure-nextgen:netapp/v20201101:getBackup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupBackupArgs struct {
	// The name of the NetApp account
	AccountName string `pulumi:"accountName"`
	// The name of the backup
	BackupName string `pulumi:"backupName"`
	// The name of the capacity pool
	PoolName string `pulumi:"poolName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the volume
	VolumeName string `pulumi:"volumeName"`
}

// Backup of a Volume
type LookupBackupResult struct {
	// UUID v4 used to identify the Backup
	BackupId string `pulumi:"backupId"`
	// Type of backup adhoc or scheduled
	BackupType string `pulumi:"backupType"`
	// The creation date of the backup
	CreationDate string `pulumi:"creationDate"`
	// Failure reason
	FailureReason string `pulumi:"failureReason"`
	// Resource Id
	Id string `pulumi:"id"`
	// Label for backup
	Label *string `pulumi:"label"`
	// Resource location
	Location string `pulumi:"location"`
	// Resource name
	Name string `pulumi:"name"`
	// Azure lifecycle management
	ProvisioningState string `pulumi:"provisioningState"`
	// Size of backup
	Size float64 `pulumi:"size"`
	// Resource type
	Type string `pulumi:"type"`
}
