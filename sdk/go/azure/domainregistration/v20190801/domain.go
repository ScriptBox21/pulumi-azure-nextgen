// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about a domain.
type Domain struct {
	pulumi.CustomResourceState

	AuthCode pulumi.StringPtrOutput `pulumi:"authCode"`
	// <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
	AutoRenew pulumi.BoolPtrOutput `pulumi:"autoRenew"`
	// Legal agreement consent.
	Consent DomainPurchaseConsentResponseOutput `pulumi:"consent"`
	// Administrative contact.
	ContactAdmin ContactResponseOutput `pulumi:"contactAdmin"`
	// Billing contact.
	ContactBilling ContactResponseOutput `pulumi:"contactBilling"`
	// Registrant contact.
	ContactRegistrant ContactResponseOutput `pulumi:"contactRegistrant"`
	// Technical contact.
	ContactTech ContactResponseOutput `pulumi:"contactTech"`
	// Domain creation timestamp.
	CreatedTime pulumi.StringOutput `pulumi:"createdTime"`
	// Current DNS type
	DnsType pulumi.StringPtrOutput `pulumi:"dnsType"`
	// Azure DNS Zone to use
	DnsZoneId pulumi.StringPtrOutput `pulumi:"dnsZoneId"`
	// Reasons why domain is not renewable.
	DomainNotRenewableReasons pulumi.StringArrayOutput `pulumi:"domainNotRenewableReasons"`
	// Domain expiration timestamp.
	ExpirationTime pulumi.StringOutput `pulumi:"expirationTime"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Timestamp when the domain was renewed last time.
	LastRenewedTime pulumi.StringOutput `pulumi:"lastRenewedTime"`
	// Resource Location.
	Location pulumi.StringOutput `pulumi:"location"`
	// All hostnames derived from the domain and assigned to Azure resources.
	ManagedHostNames HostNameResponseArrayOutput `pulumi:"managedHostNames"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Name servers.
	NameServers pulumi.StringArrayOutput `pulumi:"nameServers"`
	// <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
	Privacy pulumi.BoolPtrOutput `pulumi:"privacy"`
	// Domain provisioning state.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// <code>true</code> if Azure can assign this domain to App Service apps; otherwise, <code>false</code>. This value will be <code>true</code> if domain registration status is active and
	//  it is hosted on name servers Azure has programmatic access to.
	ReadyForDnsRecordManagement pulumi.BoolOutput `pulumi:"readyForDnsRecordManagement"`
	// Domain registration status.
	RegistrationStatus pulumi.StringOutput `pulumi:"registrationStatus"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Target DNS type (would be used for migration)
	TargetDnsType pulumi.StringPtrOutput `pulumi:"targetDnsType"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDomain registers a new resource with the given unique name, arguments, and options.
func NewDomain(ctx *pulumi.Context,
	name string, args *DomainArgs, opts ...pulumi.ResourceOption) (*Domain, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Consent == nil {
		return nil, errors.New("invalid value for required argument 'Consent'")
	}
	if args.ContactAdmin == nil {
		return nil, errors.New("invalid value for required argument 'ContactAdmin'")
	}
	if args.ContactBilling == nil {
		return nil, errors.New("invalid value for required argument 'ContactBilling'")
	}
	if args.ContactRegistrant == nil {
		return nil, errors.New("invalid value for required argument 'ContactRegistrant'")
	}
	if args.ContactTech == nil {
		return nil, errors.New("invalid value for required argument 'ContactTech'")
	}
	if args.DomainName == nil {
		return nil, errors.New("invalid value for required argument 'DomainName'")
	}
	if args.Location == nil {
		return nil, errors.New("invalid value for required argument 'Location'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.AutoRenew == nil {
		args.AutoRenew = pulumi.BoolPtr(true)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:domainregistration/latest:Domain"),
		},
		{
			Type: pulumi.String("azure-nextgen:domainregistration/v20150401:Domain"),
		},
		{
			Type: pulumi.String("azure-nextgen:domainregistration/v20180201:Domain"),
		},
		{
			Type: pulumi.String("azure-nextgen:domainregistration/v20200601:Domain"),
		},
		{
			Type: pulumi.String("azure-nextgen:domainregistration/v20200901:Domain"),
		},
	})
	opts = append(opts, aliases)
	var resource Domain
	err := ctx.RegisterResource("azure-nextgen:domainregistration/v20190801:Domain", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDomain gets an existing Domain resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDomain(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DomainState, opts ...pulumi.ResourceOption) (*Domain, error) {
	var resource Domain
	err := ctx.ReadResource("azure-nextgen:domainregistration/v20190801:Domain", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Domain resources.
type domainState struct {
	AuthCode *string `pulumi:"authCode"`
	// <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
	AutoRenew *bool `pulumi:"autoRenew"`
	// Legal agreement consent.
	Consent *DomainPurchaseConsentResponse `pulumi:"consent"`
	// Administrative contact.
	ContactAdmin *ContactResponse `pulumi:"contactAdmin"`
	// Billing contact.
	ContactBilling *ContactResponse `pulumi:"contactBilling"`
	// Registrant contact.
	ContactRegistrant *ContactResponse `pulumi:"contactRegistrant"`
	// Technical contact.
	ContactTech *ContactResponse `pulumi:"contactTech"`
	// Domain creation timestamp.
	CreatedTime *string `pulumi:"createdTime"`
	// Current DNS type
	DnsType *string `pulumi:"dnsType"`
	// Azure DNS Zone to use
	DnsZoneId *string `pulumi:"dnsZoneId"`
	// Reasons why domain is not renewable.
	DomainNotRenewableReasons []string `pulumi:"domainNotRenewableReasons"`
	// Domain expiration timestamp.
	ExpirationTime *string `pulumi:"expirationTime"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Timestamp when the domain was renewed last time.
	LastRenewedTime *string `pulumi:"lastRenewedTime"`
	// Resource Location.
	Location *string `pulumi:"location"`
	// All hostnames derived from the domain and assigned to Azure resources.
	ManagedHostNames []HostNameResponse `pulumi:"managedHostNames"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Name servers.
	NameServers []string `pulumi:"nameServers"`
	// <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
	Privacy *bool `pulumi:"privacy"`
	// Domain provisioning state.
	ProvisioningState *string `pulumi:"provisioningState"`
	// <code>true</code> if Azure can assign this domain to App Service apps; otherwise, <code>false</code>. This value will be <code>true</code> if domain registration status is active and
	//  it is hosted on name servers Azure has programmatic access to.
	ReadyForDnsRecordManagement *bool `pulumi:"readyForDnsRecordManagement"`
	// Domain registration status.
	RegistrationStatus *string `pulumi:"registrationStatus"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Target DNS type (would be used for migration)
	TargetDnsType *string `pulumi:"targetDnsType"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type DomainState struct {
	AuthCode pulumi.StringPtrInput
	// <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
	AutoRenew pulumi.BoolPtrInput
	// Legal agreement consent.
	Consent DomainPurchaseConsentResponsePtrInput
	// Administrative contact.
	ContactAdmin ContactResponsePtrInput
	// Billing contact.
	ContactBilling ContactResponsePtrInput
	// Registrant contact.
	ContactRegistrant ContactResponsePtrInput
	// Technical contact.
	ContactTech ContactResponsePtrInput
	// Domain creation timestamp.
	CreatedTime pulumi.StringPtrInput
	// Current DNS type
	DnsType pulumi.StringPtrInput
	// Azure DNS Zone to use
	DnsZoneId pulumi.StringPtrInput
	// Reasons why domain is not renewable.
	DomainNotRenewableReasons pulumi.StringArrayInput
	// Domain expiration timestamp.
	ExpirationTime pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Timestamp when the domain was renewed last time.
	LastRenewedTime pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringPtrInput
	// All hostnames derived from the domain and assigned to Azure resources.
	ManagedHostNames HostNameResponseArrayInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Name servers.
	NameServers pulumi.StringArrayInput
	// <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
	Privacy pulumi.BoolPtrInput
	// Domain provisioning state.
	ProvisioningState pulumi.StringPtrInput
	// <code>true</code> if Azure can assign this domain to App Service apps; otherwise, <code>false</code>. This value will be <code>true</code> if domain registration status is active and
	//  it is hosted on name servers Azure has programmatic access to.
	ReadyForDnsRecordManagement pulumi.BoolPtrInput
	// Domain registration status.
	RegistrationStatus pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Target DNS type (would be used for migration)
	TargetDnsType pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (DomainState) ElementType() reflect.Type {
	return reflect.TypeOf((*domainState)(nil)).Elem()
}

type domainArgs struct {
	AuthCode *string `pulumi:"authCode"`
	// <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
	AutoRenew *bool `pulumi:"autoRenew"`
	// Legal agreement consent.
	Consent DomainPurchaseConsent `pulumi:"consent"`
	// Administrative contact.
	ContactAdmin Contact `pulumi:"contactAdmin"`
	// Billing contact.
	ContactBilling Contact `pulumi:"contactBilling"`
	// Registrant contact.
	ContactRegistrant Contact `pulumi:"contactRegistrant"`
	// Technical contact.
	ContactTech Contact `pulumi:"contactTech"`
	// Current DNS type
	DnsType *string `pulumi:"dnsType"`
	// Azure DNS Zone to use
	DnsZoneId *string `pulumi:"dnsZoneId"`
	// Name of the domain.
	DomainName string `pulumi:"domainName"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location string `pulumi:"location"`
	// <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
	Privacy *bool `pulumi:"privacy"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Target DNS type (would be used for migration)
	TargetDnsType *string `pulumi:"targetDnsType"`
}

// The set of arguments for constructing a Domain resource.
type DomainArgs struct {
	AuthCode pulumi.StringPtrInput
	// <code>true</code> if the domain should be automatically renewed; otherwise, <code>false</code>.
	AutoRenew pulumi.BoolPtrInput
	// Legal agreement consent.
	Consent DomainPurchaseConsentInput
	// Administrative contact.
	ContactAdmin ContactInput
	// Billing contact.
	ContactBilling ContactInput
	// Registrant contact.
	ContactRegistrant ContactInput
	// Technical contact.
	ContactTech ContactInput
	// Current DNS type
	DnsType DnsType
	// Azure DNS Zone to use
	DnsZoneId pulumi.StringPtrInput
	// Name of the domain.
	DomainName pulumi.StringInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringInput
	// <code>true</code> if domain privacy is enabled for this domain; otherwise, <code>false</code>.
	Privacy pulumi.BoolPtrInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Target DNS type (would be used for migration)
	TargetDnsType DnsType
}

func (DomainArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*domainArgs)(nil)).Elem()
}

type DomainInput interface {
	pulumi.Input

	ToDomainOutput() DomainOutput
	ToDomainOutputWithContext(ctx context.Context) DomainOutput
}

func (*Domain) ElementType() reflect.Type {
	return reflect.TypeOf((*Domain)(nil))
}

func (i *Domain) ToDomainOutput() DomainOutput {
	return i.ToDomainOutputWithContext(context.Background())
}

func (i *Domain) ToDomainOutputWithContext(ctx context.Context) DomainOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DomainOutput)
}

type DomainOutput struct {
	*pulumi.OutputState
}

func (DomainOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Domain)(nil))
}

func (o DomainOutput) ToDomainOutput() DomainOutput {
	return o
}

func (o DomainOutput) ToDomainOutputWithContext(ctx context.Context) DomainOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DomainOutput{})
}
