// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20171201

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupServerAdministrator(ctx *pulumi.Context, args *LookupServerAdministratorArgs, opts ...pulumi.InvokeOption) (*LookupServerAdministratorResult, error) {
	var rv LookupServerAdministratorResult
	err := ctx.Invoke("azure-nextgen:dbformysql/v20171201:getServerAdministrator", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupServerAdministratorArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
}

// Represents a and external administrator to be created.
type LookupServerAdministratorResult struct {
	// The type of administrator.
	AdministratorType string `pulumi:"administratorType"`
	// The server administrator login account name.
	Login string `pulumi:"login"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The server administrator Sid (Secure ID).
	Sid string `pulumi:"sid"`
	// The server Active Directory Administrator tenant id.
	TenantId string `pulumi:"tenantId"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
