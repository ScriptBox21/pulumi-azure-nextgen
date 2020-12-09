// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A host name binding object
type SiteHostNameBindingSlot struct {
	pulumi.CustomResourceState

	// Azure resource name
	AzureResourceName pulumi.StringPtrOutput `pulumi:"azureResourceName"`
	// Azure resource type
	AzureResourceType pulumi.StringPtrOutput `pulumi:"azureResourceType"`
	// Custom DNS record type
	CustomHostNameDnsRecordType pulumi.StringPtrOutput `pulumi:"customHostNameDnsRecordType"`
	// Fully qualified ARM domain resource URI
	DomainId pulumi.StringPtrOutput `pulumi:"domainId"`
	// Host name type
	HostNameType pulumi.StringPtrOutput `pulumi:"hostNameType"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Web app name
	SiteName pulumi.StringPtrOutput `pulumi:"siteName"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewSiteHostNameBindingSlot registers a new resource with the given unique name, arguments, and options.
func NewSiteHostNameBindingSlot(ctx *pulumi.Context,
	name string, args *SiteHostNameBindingSlotArgs, opts ...pulumi.ResourceOption) (*SiteHostNameBindingSlot, error) {
	if args == nil || args.HostName == nil {
		return nil, errors.New("missing required argument 'HostName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Slot == nil {
		return nil, errors.New("missing required argument 'Slot'")
	}
	if args == nil {
		args = &SiteHostNameBindingSlotArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:SiteHostNameBindingSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:SiteHostNameBindingSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:SiteHostNameBindingSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:SiteHostNameBindingSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:SiteHostNameBindingSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:SiteHostNameBindingSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:SiteHostNameBindingSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteHostNameBindingSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20150801:SiteHostNameBindingSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteHostNameBindingSlot gets an existing SiteHostNameBindingSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteHostNameBindingSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteHostNameBindingSlotState, opts ...pulumi.ResourceOption) (*SiteHostNameBindingSlot, error) {
	var resource SiteHostNameBindingSlot
	err := ctx.ReadResource("azure-nextgen:web/v20150801:SiteHostNameBindingSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteHostNameBindingSlot resources.
type siteHostNameBindingSlotState struct {
	// Azure resource name
	AzureResourceName *string `pulumi:"azureResourceName"`
	// Azure resource type
	AzureResourceType *string `pulumi:"azureResourceType"`
	// Custom DNS record type
	CustomHostNameDnsRecordType *string `pulumi:"customHostNameDnsRecordType"`
	// Fully qualified ARM domain resource URI
	DomainId *string `pulumi:"domainId"`
	// Host name type
	HostNameType *string `pulumi:"hostNameType"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Web app name
	SiteName *string `pulumi:"siteName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type SiteHostNameBindingSlotState struct {
	// Azure resource name
	AzureResourceName pulumi.StringPtrInput
	// Azure resource type
	AzureResourceType pulumi.StringPtrInput
	// Custom DNS record type
	CustomHostNameDnsRecordType pulumi.StringPtrInput
	// Fully qualified ARM domain resource URI
	DomainId pulumi.StringPtrInput
	// Host name type
	HostNameType pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Web app name
	SiteName pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteHostNameBindingSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteHostNameBindingSlotState)(nil)).Elem()
}

type siteHostNameBindingSlotArgs struct {
	// Azure resource name
	AzureResourceName *string `pulumi:"azureResourceName"`
	// Azure resource type
	AzureResourceType *string `pulumi:"azureResourceType"`
	// Custom DNS record type
	CustomHostNameDnsRecordType *string `pulumi:"customHostNameDnsRecordType"`
	// Fully qualified ARM domain resource URI
	DomainId *string `pulumi:"domainId"`
	// Name of host
	HostName string `pulumi:"hostName"`
	// Host name type
	HostNameType *string `pulumi:"hostNameType"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location string `pulumi:"location"`
	// Resource Name
	Name string `pulumi:"name"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Web app name
	SiteName *string `pulumi:"siteName"`
	// Name of web app slot. If not specified then will default to production slot.
	Slot string `pulumi:"slot"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a SiteHostNameBindingSlot resource.
type SiteHostNameBindingSlotArgs struct {
	// Azure resource name
	AzureResourceName pulumi.StringPtrInput
	// Azure resource type
	AzureResourceType pulumi.StringPtrInput
	// Custom DNS record type
	CustomHostNameDnsRecordType pulumi.StringPtrInput
	// Fully qualified ARM domain resource URI
	DomainId pulumi.StringPtrInput
	// Name of host
	HostName pulumi.StringInput
	// Host name type
	HostNameType pulumi.StringPtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringInput
	// Resource Name
	Name pulumi.StringInput
	// Name of resource group
	ResourceGroupName pulumi.StringInput
	// Web app name
	SiteName pulumi.StringPtrInput
	// Name of web app slot. If not specified then will default to production slot.
	Slot pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteHostNameBindingSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteHostNameBindingSlotArgs)(nil)).Elem()
}

type SiteHostNameBindingSlotInput interface {
	pulumi.Input

	ToSiteHostNameBindingSlotOutput() SiteHostNameBindingSlotOutput
	ToSiteHostNameBindingSlotOutputWithContext(ctx context.Context) SiteHostNameBindingSlotOutput
}

func (SiteHostNameBindingSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteHostNameBindingSlot)(nil)).Elem()
}

func (i SiteHostNameBindingSlot) ToSiteHostNameBindingSlotOutput() SiteHostNameBindingSlotOutput {
	return i.ToSiteHostNameBindingSlotOutputWithContext(context.Background())
}

func (i SiteHostNameBindingSlot) ToSiteHostNameBindingSlotOutputWithContext(ctx context.Context) SiteHostNameBindingSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteHostNameBindingSlotOutput)
}

type SiteHostNameBindingSlotOutput struct {
	*pulumi.OutputState
}

func (SiteHostNameBindingSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteHostNameBindingSlotOutput)(nil)).Elem()
}

func (o SiteHostNameBindingSlotOutput) ToSiteHostNameBindingSlotOutput() SiteHostNameBindingSlotOutput {
	return o
}

func (o SiteHostNameBindingSlotOutput) ToSiteHostNameBindingSlotOutputWithContext(ctx context.Context) SiteHostNameBindingSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SiteHostNameBindingSlotOutput{})
}
