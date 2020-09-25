// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupSnapshotPolicy(ctx *pulumi.Context, args *LookupSnapshotPolicyArgs, opts ...pulumi.InvokeOption) (*LookupSnapshotPolicyResult, error) {
	var rv LookupSnapshotPolicyResult
	err := ctx.Invoke("azure-nextgen:netapp/latest:getSnapshotPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupSnapshotPolicyArgs struct {
	// The name of the NetApp account
	AccountName string `pulumi:"accountName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the snapshot policy target
	SnapshotPolicyName string `pulumi:"snapshotPolicyName"`
}

// Snapshot policy information
type LookupSnapshotPolicyResult struct {
	// Schedule for daily snapshots
	DailySchedule *DailyScheduleResponse `pulumi:"dailySchedule"`
	// The property to decide policy is enabled or not
	Enabled *bool `pulumi:"enabled"`
	// Schedule for hourly snapshots
	HourlySchedule *HourlyScheduleResponse `pulumi:"hourlySchedule"`
	// Resource location
	Location string `pulumi:"location"`
	// Schedule for monthly snapshots
	MonthlySchedule *MonthlyScheduleResponse `pulumi:"monthlySchedule"`
	// Snapshot policy name
	Name string `pulumi:"name"`
	// Azure lifecycle management
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type string `pulumi:"type"`
	// Schedule for weekly snapshots
	WeeklySchedule *WeeklyScheduleResponse `pulumi:"weeklySchedule"`
}
