// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190701

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupBastionHost(ctx *pulumi.Context, args *LookupBastionHostArgs, opts ...pulumi.InvokeOption) (*LookupBastionHostResult, error) {
	var rv LookupBastionHostResult
	err := ctx.Invoke("azure-nextgen:network/v20190701:getBastionHost", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupBastionHostArgs struct {
	// The name of the Bastion Host.
	BastionHostName string `pulumi:"bastionHostName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Bastion Host resource.
type LookupBastionHostResult struct {
	// FQDN for the endpoint on which bastion host is accessible.
	DnsName *string `pulumi:"dnsName"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// IP configuration of the Bastion Host resource.
	IpConfigurations []BastionHostIPConfigurationResponse `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name string `pulumi:"name"`
	// The provisioning state of the bastion host resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type string `pulumi:"type"`
}
