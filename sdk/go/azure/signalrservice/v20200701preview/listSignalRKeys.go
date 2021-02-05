// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200701preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListSignalRKeys(ctx *pulumi.Context, args *ListSignalRKeysArgs, opts ...pulumi.InvokeOption) (*ListSignalRKeysResult, error) {
	var rv ListSignalRKeysResult
	err := ctx.Invoke("azure-nextgen:signalrservice/v20200701preview:listSignalRKeys", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListSignalRKeysArgs struct {
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the SignalR resource.
	ResourceName string `pulumi:"resourceName"`
}

// A class represents the access keys of the resource.
type ListSignalRKeysResult struct {
	// Connection string constructed via the primaryKey
	PrimaryConnectionString *string `pulumi:"primaryConnectionString"`
	// The primary access key.
	PrimaryKey *string `pulumi:"primaryKey"`
	// Connection string constructed via the secondaryKey
	SecondaryConnectionString *string `pulumi:"secondaryConnectionString"`
	// The secondary access key.
	SecondaryKey *string `pulumi:"secondaryKey"`
}
