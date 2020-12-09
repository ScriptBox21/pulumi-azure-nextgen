// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a domain
type Domain struct {
	pulumi.CustomResourceState

	// If true then domain will renewed automatically
	AutoRenew pulumi.BoolPtrOutput `pulumi:"autoRenew"`
	// Legal agreement consent
	Consent DomainPurchaseConsentResponsePtrOutput `pulumi:"consent"`
	// Admin contact information
	ContactAdmin ContactResponsePtrOutput `pulumi:"contactAdmin"`
	// Billing contact information
	ContactBilling ContactResponsePtrOutput `pulumi:"contactBilling"`
	// Registrant contact information
	ContactRegistrant ContactResponsePtrOutput `pulumi:"contactRegistrant"`
	// Technical contact information
	ContactTech ContactResponsePtrOutput `pulumi:"contactTech"`
	// Domain creation timestamp
	CreatedTime pulumi.StringPtrOutput `pulumi:"createdTime"`
	// Reasons why domain is not renewable
	DomainNotRenewableReasons pulumi.StringArrayOutput `pulumi:"domainNotRenewableReasons"`
	// Domain expiration timestamp
	ExpirationTime pulumi.StringPtrOutput `pulumi:"expirationTime"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Timestamp when the domain was renewed last time
	LastRenewedTime pulumi.StringPtrOutput `pulumi:"lastRenewedTime"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// All hostnames derived from the domain and assigned to Azure resources
	ManagedHostNames HostNameResponseArrayOutput `pulumi:"managedHostNames"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Name servers
	NameServers pulumi.StringArrayOutput `pulumi:"nameServers"`
	// If true then domain privacy is enabled for this domain
	Privacy pulumi.BoolPtrOutput `pulumi:"privacy"`
	// Domain provisioning state
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
	ReadyForDnsRecordManagement pulumi.BoolPtrOutput `pulumi:"readyForDnsRecordManagement"`
	// Domain registration status
	RegistrationStatus pulumi.StringPtrOutput `pulumi:"registrationStatus"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewDomain registers a new resource with the given unique name, arguments, and options.
func NewDomain(ctx *pulumi.Context,
	name string, args *DomainArgs, opts ...pulumi.ResourceOption) (*Domain, error) {
	if args == nil || args.DomainName == nil {
		return nil, errors.New("missing required argument 'DomainName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &DomainArgs{}
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
			Type: pulumi.String("azure-nextgen:domainregistration/v20190801:Domain"),
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
	err := ctx.RegisterResource("azure-nextgen:domainregistration/v20150801:Domain", name, args, &resource, opts...)
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
	err := ctx.ReadResource("azure-nextgen:domainregistration/v20150801:Domain", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Domain resources.
type domainState struct {
	// If true then domain will renewed automatically
	AutoRenew *bool `pulumi:"autoRenew"`
	// Legal agreement consent
	Consent *DomainPurchaseConsentResponse `pulumi:"consent"`
	// Admin contact information
	ContactAdmin *ContactResponse `pulumi:"contactAdmin"`
	// Billing contact information
	ContactBilling *ContactResponse `pulumi:"contactBilling"`
	// Registrant contact information
	ContactRegistrant *ContactResponse `pulumi:"contactRegistrant"`
	// Technical contact information
	ContactTech *ContactResponse `pulumi:"contactTech"`
	// Domain creation timestamp
	CreatedTime *string `pulumi:"createdTime"`
	// Reasons why domain is not renewable
	DomainNotRenewableReasons []string `pulumi:"domainNotRenewableReasons"`
	// Domain expiration timestamp
	ExpirationTime *string `pulumi:"expirationTime"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Timestamp when the domain was renewed last time
	LastRenewedTime *string `pulumi:"lastRenewedTime"`
	// Resource Location
	Location *string `pulumi:"location"`
	// All hostnames derived from the domain and assigned to Azure resources
	ManagedHostNames []HostNameResponse `pulumi:"managedHostNames"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Name servers
	NameServers []string `pulumi:"nameServers"`
	// If true then domain privacy is enabled for this domain
	Privacy *bool `pulumi:"privacy"`
	// Domain provisioning state
	ProvisioningState *string `pulumi:"provisioningState"`
	// If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
	ReadyForDnsRecordManagement *bool `pulumi:"readyForDnsRecordManagement"`
	// Domain registration status
	RegistrationStatus *string `pulumi:"registrationStatus"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type DomainState struct {
	// If true then domain will renewed automatically
	AutoRenew pulumi.BoolPtrInput
	// Legal agreement consent
	Consent DomainPurchaseConsentResponsePtrInput
	// Admin contact information
	ContactAdmin ContactResponsePtrInput
	// Billing contact information
	ContactBilling ContactResponsePtrInput
	// Registrant contact information
	ContactRegistrant ContactResponsePtrInput
	// Technical contact information
	ContactTech ContactResponsePtrInput
	// Domain creation timestamp
	CreatedTime pulumi.StringPtrInput
	// Reasons why domain is not renewable
	DomainNotRenewableReasons pulumi.StringArrayInput
	// Domain expiration timestamp
	ExpirationTime pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Timestamp when the domain was renewed last time
	LastRenewedTime pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// All hostnames derived from the domain and assigned to Azure resources
	ManagedHostNames HostNameResponseArrayInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Name servers
	NameServers pulumi.StringArrayInput
	// If true then domain privacy is enabled for this domain
	Privacy pulumi.BoolPtrInput
	// Domain provisioning state
	ProvisioningState pulumi.StringPtrInput
	// If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
	ReadyForDnsRecordManagement pulumi.BoolPtrInput
	// Domain registration status
	RegistrationStatus pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (DomainState) ElementType() reflect.Type {
	return reflect.TypeOf((*domainState)(nil)).Elem()
}

type domainArgs struct {
	// If true then domain will renewed automatically
	AutoRenew *bool `pulumi:"autoRenew"`
	// Legal agreement consent
	Consent *DomainPurchaseConsent `pulumi:"consent"`
	// Admin contact information
	ContactAdmin *Contact `pulumi:"contactAdmin"`
	// Billing contact information
	ContactBilling *Contact `pulumi:"contactBilling"`
	// Registrant contact information
	ContactRegistrant *Contact `pulumi:"contactRegistrant"`
	// Technical contact information
	ContactTech *Contact `pulumi:"contactTech"`
	// Domain creation timestamp
	CreatedTime *string `pulumi:"createdTime"`
	// Name of the domain
	DomainName string `pulumi:"domainName"`
	// Reasons why domain is not renewable
	DomainNotRenewableReasons []string `pulumi:"domainNotRenewableReasons"`
	// Domain expiration timestamp
	ExpirationTime *string `pulumi:"expirationTime"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Timestamp when the domain was renewed last time
	LastRenewedTime *string `pulumi:"lastRenewedTime"`
	// Resource Location
	Location string `pulumi:"location"`
	// All hostnames derived from the domain and assigned to Azure resources
	ManagedHostNames []HostName `pulumi:"managedHostNames"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Name servers
	NameServers []string `pulumi:"nameServers"`
	// If true then domain privacy is enabled for this domain
	Privacy *bool `pulumi:"privacy"`
	// Domain provisioning state
	ProvisioningState *string `pulumi:"provisioningState"`
	// If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
	ReadyForDnsRecordManagement *bool `pulumi:"readyForDnsRecordManagement"`
	// Domain registration status
	RegistrationStatus *string `pulumi:"registrationStatus"`
	// &gt;Name of the resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a Domain resource.
type DomainArgs struct {
	// If true then domain will renewed automatically
	AutoRenew pulumi.BoolPtrInput
	// Legal agreement consent
	Consent DomainPurchaseConsentPtrInput
	// Admin contact information
	ContactAdmin ContactPtrInput
	// Billing contact information
	ContactBilling ContactPtrInput
	// Registrant contact information
	ContactRegistrant ContactPtrInput
	// Technical contact information
	ContactTech ContactPtrInput
	// Domain creation timestamp
	CreatedTime pulumi.StringPtrInput
	// Name of the domain
	DomainName pulumi.StringInput
	// Reasons why domain is not renewable
	DomainNotRenewableReasons pulumi.StringArrayInput
	// Domain expiration timestamp
	ExpirationTime pulumi.StringPtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Timestamp when the domain was renewed last time
	LastRenewedTime pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringInput
	// All hostnames derived from the domain and assigned to Azure resources
	ManagedHostNames HostNameArrayInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Name servers
	NameServers pulumi.StringArrayInput
	// If true then domain privacy is enabled for this domain
	Privacy pulumi.BoolPtrInput
	// Domain provisioning state
	ProvisioningState pulumi.StringPtrInput
	// If true then Azure can assign this domain to Web Apps. This value will be true if domain registration status is active and it is hosted on name servers Azure has programmatic access to
	ReadyForDnsRecordManagement pulumi.BoolPtrInput
	// Domain registration status
	RegistrationStatus pulumi.StringPtrInput
	// &gt;Name of the resource group
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (DomainArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*domainArgs)(nil)).Elem()
}

type DomainInput interface {
	pulumi.Input

	ToDomainOutput() DomainOutput
	ToDomainOutputWithContext(ctx context.Context) DomainOutput
}

func (Domain) ElementType() reflect.Type {
	return reflect.TypeOf((*Domain)(nil)).Elem()
}

func (i Domain) ToDomainOutput() DomainOutput {
	return i.ToDomainOutputWithContext(context.Background())
}

func (i Domain) ToDomainOutputWithContext(ctx context.Context) DomainOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DomainOutput)
}

type DomainOutput struct {
	*pulumi.OutputState
}

func (DomainOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DomainOutput)(nil)).Elem()
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
