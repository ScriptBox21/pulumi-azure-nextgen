// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A hostname binding object.
// Latest API Version: 2020-09-01.
type WebAppHostNameBinding struct {
	pulumi.CustomResourceState

	// Azure resource name.
	AzureResourceName pulumi.StringPtrOutput `pulumi:"azureResourceName"`
	// Azure resource type.
	AzureResourceType pulumi.StringPtrOutput `pulumi:"azureResourceType"`
	// Custom DNS record type.
	CustomHostNameDnsRecordType pulumi.StringPtrOutput `pulumi:"customHostNameDnsRecordType"`
	// Fully qualified ARM domain resource URI.
	DomainId pulumi.StringPtrOutput `pulumi:"domainId"`
	// Hostname type.
	HostNameType pulumi.StringPtrOutput `pulumi:"hostNameType"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// App Service app name.
	SiteName pulumi.StringPtrOutput `pulumi:"siteName"`
	// SSL type
	SslState pulumi.StringPtrOutput `pulumi:"sslState"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// SSL certificate thumbprint
	Thumbprint pulumi.StringPtrOutput `pulumi:"thumbprint"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// Virtual IP address assigned to the hostname if IP based SSL is enabled.
	VirtualIP pulumi.StringOutput `pulumi:"virtualIP"`
}

// NewWebAppHostNameBinding registers a new resource with the given unique name, arguments, and options.
func NewWebAppHostNameBinding(ctx *pulumi.Context,
	name string, args *WebAppHostNameBindingArgs, opts ...pulumi.ResourceOption) (*WebAppHostNameBinding, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.HostName == nil {
		return nil, errors.New("invalid value for required argument 'HostName'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppHostNameBinding"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppHostNameBinding"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppHostNameBinding"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppHostNameBinding"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppHostNameBinding"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppHostNameBinding"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppHostNameBinding"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppHostNameBinding"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppHostNameBinding
	err := ctx.RegisterResource("azure-nextgen:web/latest:WebAppHostNameBinding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppHostNameBinding gets an existing WebAppHostNameBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppHostNameBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppHostNameBindingState, opts ...pulumi.ResourceOption) (*WebAppHostNameBinding, error) {
	var resource WebAppHostNameBinding
	err := ctx.ReadResource("azure-nextgen:web/latest:WebAppHostNameBinding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppHostNameBinding resources.
type webAppHostNameBindingState struct {
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
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// App Service app name.
	SiteName *string `pulumi:"siteName"`
	// SSL type
	SslState *string `pulumi:"sslState"`
	// The system metadata relating to this resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// SSL certificate thumbprint
	Thumbprint *string `pulumi:"thumbprint"`
	// Resource type.
	Type *string `pulumi:"type"`
	// Virtual IP address assigned to the hostname if IP based SSL is enabled.
	VirtualIP *string `pulumi:"virtualIP"`
}

type WebAppHostNameBindingState struct {
	// Azure resource name.
	AzureResourceName pulumi.StringPtrInput
	// Azure resource type.
	AzureResourceType pulumi.StringPtrInput
	// Custom DNS record type.
	CustomHostNameDnsRecordType pulumi.StringPtrInput
	// Fully qualified ARM domain resource URI.
	DomainId pulumi.StringPtrInput
	// Hostname type.
	HostNameType pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// App Service app name.
	SiteName pulumi.StringPtrInput
	// SSL type
	SslState pulumi.StringPtrInput
	// The system metadata relating to this resource.
	SystemData SystemDataResponsePtrInput
	// SSL certificate thumbprint
	Thumbprint pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
	// Virtual IP address assigned to the hostname if IP based SSL is enabled.
	VirtualIP pulumi.StringPtrInput
}

func (WebAppHostNameBindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppHostNameBindingState)(nil)).Elem()
}

type webAppHostNameBindingArgs struct {
	// Azure resource name.
	AzureResourceName *string `pulumi:"azureResourceName"`
	// Azure resource type.
	AzureResourceType *string `pulumi:"azureResourceType"`
	// Custom DNS record type.
	CustomHostNameDnsRecordType *string `pulumi:"customHostNameDnsRecordType"`
	// Fully qualified ARM domain resource URI.
	DomainId *string `pulumi:"domainId"`
	// Hostname in the hostname binding.
	HostName string `pulumi:"hostName"`
	// Hostname type.
	HostNameType *string `pulumi:"hostNameType"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// App Service app name.
	SiteName *string `pulumi:"siteName"`
	// SSL type
	SslState *string `pulumi:"sslState"`
	// SSL certificate thumbprint
	Thumbprint *string `pulumi:"thumbprint"`
}

// The set of arguments for constructing a WebAppHostNameBinding resource.
type WebAppHostNameBindingArgs struct {
	// Azure resource name.
	AzureResourceName pulumi.StringPtrInput
	// Azure resource type.
	AzureResourceType *AzureResourceType
	// Custom DNS record type.
	CustomHostNameDnsRecordType *CustomHostNameDnsRecordType
	// Fully qualified ARM domain resource URI.
	DomainId pulumi.StringPtrInput
	// Hostname in the hostname binding.
	HostName pulumi.StringInput
	// Hostname type.
	HostNameType *HostNameType
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// App Service app name.
	SiteName pulumi.StringPtrInput
	// SSL type
	SslState *SslState
	// SSL certificate thumbprint
	Thumbprint pulumi.StringPtrInput
}

func (WebAppHostNameBindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppHostNameBindingArgs)(nil)).Elem()
}

type WebAppHostNameBindingInput interface {
	pulumi.Input

	ToWebAppHostNameBindingOutput() WebAppHostNameBindingOutput
	ToWebAppHostNameBindingOutputWithContext(ctx context.Context) WebAppHostNameBindingOutput
}

func (*WebAppHostNameBinding) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppHostNameBinding)(nil))
}

func (i *WebAppHostNameBinding) ToWebAppHostNameBindingOutput() WebAppHostNameBindingOutput {
	return i.ToWebAppHostNameBindingOutputWithContext(context.Background())
}

func (i *WebAppHostNameBinding) ToWebAppHostNameBindingOutputWithContext(ctx context.Context) WebAppHostNameBindingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppHostNameBindingOutput)
}

type WebAppHostNameBindingOutput struct {
	*pulumi.OutputState
}

func (WebAppHostNameBindingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppHostNameBinding)(nil))
}

func (o WebAppHostNameBindingOutput) ToWebAppHostNameBindingOutput() WebAppHostNameBindingOutput {
	return o
}

func (o WebAppHostNameBindingOutput) ToWebAppHostNameBindingOutputWithContext(ctx context.Context) WebAppHostNameBindingOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppHostNameBindingOutput{})
}
