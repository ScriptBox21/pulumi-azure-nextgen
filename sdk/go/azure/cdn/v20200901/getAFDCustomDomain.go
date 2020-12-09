// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAFDCustomDomain(ctx *pulumi.Context, args *LookupAFDCustomDomainArgs, opts ...pulumi.InvokeOption) (*LookupAFDCustomDomainResult, error) {
	var rv LookupAFDCustomDomainResult
	err := ctx.Invoke("azure-nextgen:cdn/v20200901:getAFDCustomDomain", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAFDCustomDomainArgs struct {
	// Name of the domain under the profile which is unique globally.
	CustomDomainName string `pulumi:"customDomainName"`
	// Name of the CDN profile which is unique within the resource group.
	ProfileName string `pulumi:"profileName"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
type LookupAFDCustomDomainResult struct {
	// Resource reference to the Azure DNS zone
	AzureDnsZone     *ResourceReferenceResponse `pulumi:"azureDnsZone"`
	DeploymentStatus string                     `pulumi:"deploymentStatus"`
	// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
	DomainValidationState string `pulumi:"domainValidationState"`
	// The host name of the domain. Must be a domain name.
	HostName string `pulumi:"hostName"`
	// Resource name.
	Name string `pulumi:"name"`
	// Provisioning status
	ProvisioningState string `pulumi:"provisioningState"`
	// Read only system data
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default.
	TlsSettings *AFDDomainHttpsParametersResponse `pulumi:"tlsSettings"`
	// Resource type.
	Type string `pulumi:"type"`
	// Values the customer needs to validate domain ownership
	ValidationProperties DomainValidationPropertiesResponse `pulumi:"validationProperties"`
}
