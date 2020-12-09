// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// VNETInfo contract. This contract is public and is a stripped down version of VNETInfoInternal
type SiteVNETConnection struct {
	pulumi.CustomResourceState

	// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
	//             Point-To-Site VPN connection.
	CertBlob pulumi.StringPtrOutput `pulumi:"certBlob"`
	// The client certificate thumbprint
	CertThumbprint pulumi.StringPtrOutput `pulumi:"certThumbprint"`
	// Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
	DnsServers pulumi.StringPtrOutput `pulumi:"dnsServers"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Flag to determine if a resync is required
	ResyncRequired pulumi.BoolPtrOutput `pulumi:"resyncRequired"`
	// The routes that this virtual network connection uses.
	Routes VnetRouteResponseArrayOutput `pulumi:"routes"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// The vnet resource id
	VnetResourceId pulumi.StringPtrOutput `pulumi:"vnetResourceId"`
}

// NewSiteVNETConnection registers a new resource with the given unique name, arguments, and options.
func NewSiteVNETConnection(ctx *pulumi.Context,
	name string, args *SiteVNETConnectionArgs, opts ...pulumi.ResourceOption) (*SiteVNETConnection, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.VnetName == nil {
		return nil, errors.New("missing required argument 'VnetName'")
	}
	if args == nil {
		args = &SiteVNETConnectionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:SiteVNETConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:SiteVNETConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:SiteVNETConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:SiteVNETConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:SiteVNETConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:SiteVNETConnection"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:SiteVNETConnection"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteVNETConnection
	err := ctx.RegisterResource("azure-nextgen:web/v20150801:SiteVNETConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteVNETConnection gets an existing SiteVNETConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteVNETConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteVNETConnectionState, opts ...pulumi.ResourceOption) (*SiteVNETConnection, error) {
	var resource SiteVNETConnection
	err := ctx.ReadResource("azure-nextgen:web/v20150801:SiteVNETConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteVNETConnection resources.
type siteVNETConnectionState struct {
	// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
	//             Point-To-Site VPN connection.
	CertBlob *string `pulumi:"certBlob"`
	// The client certificate thumbprint
	CertThumbprint *string `pulumi:"certThumbprint"`
	// Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
	DnsServers *string `pulumi:"dnsServers"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Flag to determine if a resync is required
	ResyncRequired *bool `pulumi:"resyncRequired"`
	// The routes that this virtual network connection uses.
	Routes []VnetRouteResponse `pulumi:"routes"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// The vnet resource id
	VnetResourceId *string `pulumi:"vnetResourceId"`
}

type SiteVNETConnectionState struct {
	// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
	//             Point-To-Site VPN connection.
	CertBlob pulumi.StringPtrInput
	// The client certificate thumbprint
	CertThumbprint pulumi.StringPtrInput
	// Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
	DnsServers pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Flag to determine if a resync is required
	ResyncRequired pulumi.BoolPtrInput
	// The routes that this virtual network connection uses.
	Routes VnetRouteResponseArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// The vnet resource id
	VnetResourceId pulumi.StringPtrInput
}

func (SiteVNETConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteVNETConnectionState)(nil)).Elem()
}

type siteVNETConnectionArgs struct {
	// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
	//             Point-To-Site VPN connection.
	CertBlob *string `pulumi:"certBlob"`
	// The client certificate thumbprint
	CertThumbprint *string `pulumi:"certThumbprint"`
	// Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
	DnsServers *string `pulumi:"dnsServers"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location string `pulumi:"location"`
	// Resource Name
	Name string `pulumi:"name"`
	// The resource group name
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Flag to determine if a resync is required
	ResyncRequired *bool `pulumi:"resyncRequired"`
	// The routes that this virtual network connection uses.
	Routes []VnetRoute `pulumi:"routes"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// The name of the Virtual Network
	VnetName string `pulumi:"vnetName"`
	// The vnet resource id
	VnetResourceId *string `pulumi:"vnetResourceId"`
}

// The set of arguments for constructing a SiteVNETConnection resource.
type SiteVNETConnectionArgs struct {
	// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
	//             Point-To-Site VPN connection.
	CertBlob pulumi.StringPtrInput
	// The client certificate thumbprint
	CertThumbprint pulumi.StringPtrInput
	// Dns servers to be used by this VNET. This should be a comma-separated list of IP addresses.
	DnsServers pulumi.StringPtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringInput
	// Resource Name
	Name pulumi.StringInput
	// The resource group name
	ResourceGroupName pulumi.StringInput
	// Flag to determine if a resync is required
	ResyncRequired pulumi.BoolPtrInput
	// The routes that this virtual network connection uses.
	Routes VnetRouteArrayInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// The name of the Virtual Network
	VnetName pulumi.StringInput
	// The vnet resource id
	VnetResourceId pulumi.StringPtrInput
}

func (SiteVNETConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteVNETConnectionArgs)(nil)).Elem()
}

type SiteVNETConnectionInput interface {
	pulumi.Input

	ToSiteVNETConnectionOutput() SiteVNETConnectionOutput
	ToSiteVNETConnectionOutputWithContext(ctx context.Context) SiteVNETConnectionOutput
}

func (SiteVNETConnection) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteVNETConnection)(nil)).Elem()
}

func (i SiteVNETConnection) ToSiteVNETConnectionOutput() SiteVNETConnectionOutput {
	return i.ToSiteVNETConnectionOutputWithContext(context.Background())
}

func (i SiteVNETConnection) ToSiteVNETConnectionOutputWithContext(ctx context.Context) SiteVNETConnectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteVNETConnectionOutput)
}

type SiteVNETConnectionOutput struct {
	*pulumi.OutputState
}

func (SiteVNETConnectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteVNETConnectionOutput)(nil)).Elem()
}

func (o SiteVNETConnectionOutput) ToSiteVNETConnectionOutput() SiteVNETConnectionOutput {
	return o
}

func (o SiteVNETConnectionOutput) ToSiteVNETConnectionOutputWithContext(ctx context.Context) SiteVNETConnectionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SiteVNETConnectionOutput{})
}
