// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDataExport(ctx *pulumi.Context, args *LookupDataExportArgs, opts ...pulumi.InvokeOption) (*LookupDataExportResult, error) {
	var rv LookupDataExportResult
	err := ctx.Invoke("azure-nextgen:operationalinsights/latest:getDataExport", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDataExportArgs struct {
	// The data export rule name.
	DataExportName string `pulumi:"dataExportName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the workspace.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The top level data export resource container.
type LookupDataExportResult struct {
	// When ‘true’, all workspace's tables are exported.
	AllTables *bool `pulumi:"allTables"`
	// The latest data export rule modification time.
	CreatedDate *string `pulumi:"createdDate"`
	// The data export rule ID.
	DataExportId *string `pulumi:"dataExportId"`
	// Active when enabled.
	Enable *bool `pulumi:"enable"`
	// Optional. Allows to define an Event Hub name. Not applicable when destination is Storage Account.
	EventHubName *string `pulumi:"eventHubName"`
	// Date and time when the export was last modified.
	LastModifiedDate *string `pulumi:"lastModifiedDate"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The destination resource ID. This can be copied from the Properties entry of the destination resource in Azure.
	ResourceId string `pulumi:"resourceId"`
	// An array of tables to export, for example: [“Heartbeat, SecurityEvent”].
	TableNames []string `pulumi:"tableNames"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
