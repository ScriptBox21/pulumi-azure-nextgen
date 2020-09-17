// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200202preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupManagedInstanceAzureADOnlyAuthentication(ctx *pulumi.Context, args *LookupManagedInstanceAzureADOnlyAuthenticationArgs, opts ...pulumi.InvokeOption) (*LookupManagedInstanceAzureADOnlyAuthenticationResult, error) {
	var rv LookupManagedInstanceAzureADOnlyAuthenticationResult
	err := ctx.Invoke("azure-nextgen:sql/v20200202preview:getManagedInstanceAzureADOnlyAuthentication", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupManagedInstanceAzureADOnlyAuthenticationArgs struct {
	// The name of server azure active directory only authentication.
	AuthenticationName string `pulumi:"authenticationName"`
	// The name of the managed instance.
	ManagedInstanceName string `pulumi:"managedInstanceName"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Azure Active Directory only authentication.
type LookupManagedInstanceAzureADOnlyAuthenticationResult struct {
	// Azure Active Directory only Authentication enabled.
	AzureADOnlyAuthentication bool `pulumi:"azureADOnlyAuthentication"`
	// Resource name.
	Name string `pulumi:"name"`
	// Resource type.
	Type string `pulumi:"type"`
}