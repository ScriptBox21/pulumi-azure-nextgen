// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201001

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDomain(ctx *pulumi.Context, args *LookupDomainArgs, opts ...pulumi.InvokeOption) (*LookupDomainResult, error) {
	var rv LookupDomainResult
	err := ctx.Invoke("azure-nextgen:domainregistration/v20201001:getDomain", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDomainArgs struct {
	// Name of the domain.
	DomainName string `pulumi:"domainName"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Information about a domain.
type LookupDomainResult struct {
	AuthCode *string `pulumi:"authCode"`
	// <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
	AutoRenew *bool `pulumi:"autoRenew"`
	// Legal agreement consent.
	Consent DomainPurchaseConsentResponse `pulumi:"consent"`
	// Administrative contact.
	ContactAdmin ContactResponse `pulumi:"contactAdmin"`
	// Billing contact.
	ContactBilling ContactResponse `pulumi:"contactBilling"`
	// Registrant contact.
	ContactRegistrant ContactResponse `pulumi:"contactRegistrant"`
	// Technical contact.
	ContactTech ContactResponse `pulumi:"contactTech"`
	// Domain creation timestamp.
	CreatedTime string `pulumi:"createdTime"`
	// Current DNS type
	DnsType *string `pulumi:"dnsType"`
	// Azure DNS Zone to use
	DnsZoneId *string `pulumi:"dnsZoneId"`
	// Reasons why domain is not renewable.
	DomainNotRenewableReasons []string `pulumi:"domainNotRenewableReasons"`
	// Domain expiration timestamp.
	ExpirationTime string `pulumi:"expirationTime"`
	// Resource Id.
	Id string `pulumi:"id"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Timestamp when the domain was renewed last time.
	LastRenewedTime string `pulumi:"lastRenewedTime"`
	// Resource Location.
	Location string `pulumi:"location"`
	// All hostnames derived from the domain and assigned to Azure resources.
	ManagedHostNames []HostNameResponse `pulumi:"managedHostNames"`
	// Resource Name.
	Name string `pulumi:"name"`
	// Name servers.
	NameServers []string `pulumi:"nameServers"`
	// <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
	Privacy *bool `pulumi:"privacy"`
	// Domain provisioning state.
	ProvisioningState string `pulumi:"provisioningState"`
	// <code>true</code> if Azure can assign this domain to App Service apps; otherwise, <code>false</code>. This value will be <code>true</code> if domain registration status is active and
	//  it is hosted on name servers Azure has programmatic access to.
	ReadyForDnsRecordManagement bool `pulumi:"readyForDnsRecordManagement"`
	// Domain registration status.
	RegistrationStatus string `pulumi:"registrationStatus"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Target DNS type (would be used for migration)
	TargetDnsType *string `pulumi:"targetDnsType"`
	// Resource type.
	Type string `pulumi:"type"`
}
