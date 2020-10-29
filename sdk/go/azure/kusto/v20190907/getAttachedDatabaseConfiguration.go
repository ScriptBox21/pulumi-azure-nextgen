// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190907

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAttachedDatabaseConfiguration(ctx *pulumi.Context, args *LookupAttachedDatabaseConfigurationArgs, opts ...pulumi.InvokeOption) (*LookupAttachedDatabaseConfigurationResult, error) {
	var rv LookupAttachedDatabaseConfigurationResult
	err := ctx.Invoke("azure-nextgen:kusto/v20190907:getAttachedDatabaseConfiguration", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAttachedDatabaseConfigurationArgs struct {
	// The name of the attached database configuration.
	AttachedDatabaseConfigurationName string `pulumi:"attachedDatabaseConfigurationName"`
	// The name of the Kusto cluster.
	ClusterName string `pulumi:"clusterName"`
	// The name of the resource group containing the Kusto cluster.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Class representing an attached database configuration.
type LookupAttachedDatabaseConfigurationResult struct {
	// The list of databases from the clusterResourceId which are currently attached to the cluster.
	AttachedDatabaseNames []string `pulumi:"attachedDatabaseNames"`
	// The resource id of the cluster where the databases you would like to attach reside.
	ClusterResourceId string `pulumi:"clusterResourceId"`
	// The name of the database which you would like to attach, use * if you want to follow all current and future databases.
	DatabaseName string `pulumi:"databaseName"`
	// The default principals modification kind
	DefaultPrincipalsModificationKind string `pulumi:"defaultPrincipalsModificationKind"`
	// Resource location.
	Location *string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The provisioned state of the resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
