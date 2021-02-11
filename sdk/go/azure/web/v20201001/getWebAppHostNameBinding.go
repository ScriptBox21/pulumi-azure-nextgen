// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201001

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWebAppHostNameBinding(ctx *pulumi.Context, args *LookupWebAppHostNameBindingArgs, opts ...pulumi.InvokeOption) (*LookupWebAppHostNameBindingResult, error) {
	var rv LookupWebAppHostNameBindingResult
	err := ctx.Invoke("azure-nextgen:web/v20201001:getWebAppHostNameBinding", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWebAppHostNameBindingArgs struct {
	// Hostname in the hostname binding.
	HostName string `pulumi:"hostName"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// A hostname binding object.
type LookupWebAppHostNameBindingResult struct {
	// Azure resource name.
	AzureResourceName *string `pulumi:"azureResourceName"`
	// Azure resource type.
	AzureResourceType *string `pulumi:"azureResourceType"`
	// Custom DNS record type.
	CustomHostNameDnsRecordType *string `pulumi:"customHostNameDnsRecordType"`
	// Fully qualified ARM domain resource URI.
	DomainId *string `pulumi:"domainId"`
	// Hostname type.
	HostNameType *string `pulumi:"hostNameType"`
	// Resource Id.
	Id string `pulumi:"id"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name string `pulumi:"name"`
	// App Service app name.
	SiteName *string `pulumi:"siteName"`
	// SSL type
	SslState *string `pulumi:"sslState"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// SSL certificate thumbprint
	Thumbprint *string `pulumi:"thumbprint"`
	// Resource type.
	Type string `pulumi:"type"`
	// Virtual IP address assigned to the hostname if IP based SSL is enabled.
	VirtualIP string `pulumi:"virtualIP"`
}
