// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190801

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Subnet in a virtual network resource.
type Subnet struct {
	pulumi.CustomResourceState

	// The address prefix for the subnet.
	AddressPrefix pulumi.StringPtrOutput `pulumi:"addressPrefix"`
	// List of address prefixes for the subnet.
	AddressPrefixes pulumi.StringArrayOutput `pulumi:"addressPrefixes"`
	// An array of references to the delegations on the subnet.
	Delegations DelegationResponseArrayOutput `pulumi:"delegations"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrOutput `pulumi:"etag"`
	// Array of IP configuration profiles which reference this subnet.
	IpConfigurationProfiles IPConfigurationProfileResponseArrayOutput `pulumi:"ipConfigurationProfiles"`
	// An array of references to the network interface IP configurations using subnet.
	IpConfigurations IPConfigurationResponseArrayOutput `pulumi:"ipConfigurations"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Nat gateway associated with this subnet.
	NatGateway SubResourceResponsePtrOutput `pulumi:"natGateway"`
	// The reference of the NetworkSecurityGroup resource.
	NetworkSecurityGroup NetworkSecurityGroupResponsePtrOutput `pulumi:"networkSecurityGroup"`
	// Enable or Disable apply network policies on private end point in the subnet.
	PrivateEndpointNetworkPolicies pulumi.StringPtrOutput `pulumi:"privateEndpointNetworkPolicies"`
	// An array of references to private endpoints.
	PrivateEndpoints PrivateEndpointResponseArrayOutput `pulumi:"privateEndpoints"`
	// Enable or Disable apply network policies on private link service in the subnet.
	PrivateLinkServiceNetworkPolicies pulumi.StringPtrOutput `pulumi:"privateLinkServiceNetworkPolicies"`
	// The provisioning state of the subnet resource.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties.
	Purpose pulumi.StringOutput `pulumi:"purpose"`
	// An array of references to the external resources using subnet.
	ResourceNavigationLinks ResourceNavigationLinkResponseArrayOutput `pulumi:"resourceNavigationLinks"`
	// The reference of the RouteTable resource.
	RouteTable RouteTableResponsePtrOutput `pulumi:"routeTable"`
	// An array of references to services injecting into this subnet.
	ServiceAssociationLinks ServiceAssociationLinkResponseArrayOutput `pulumi:"serviceAssociationLinks"`
	// An array of service endpoint policies.
	ServiceEndpointPolicies ServiceEndpointPolicyResponseArrayOutput `pulumi:"serviceEndpointPolicies"`
	// An array of service endpoints.
	ServiceEndpoints ServiceEndpointPropertiesFormatResponseArrayOutput `pulumi:"serviceEndpoints"`
}

// NewSubnet registers a new resource with the given unique name, arguments, and options.
func NewSubnet(ctx *pulumi.Context,
	name string, args *SubnetArgs, opts ...pulumi.ResourceOption) (*Subnet, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SubnetName == nil {
		return nil, errors.New("missing required argument 'SubnetName'")
	}
	if args == nil || args.VirtualNetworkName == nil {
		return nil, errors.New("missing required argument 'VirtualNetworkName'")
	}
	if args == nil {
		args = &SubnetArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:network/latest:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150501preview:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20150615:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160330:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160601:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20160901:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20161201:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170301:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170601:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170801:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20170901:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171001:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20171101:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180101:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180201:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180401:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180601:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180701:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20180801:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181001:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181101:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20181201:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190201:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190401:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190601:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190701:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20190901:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191101:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20191201:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200301:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200401:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200501:Subnet"),
		},
		{
			Type: pulumi.String("azure-nextgen:network/v20200601:Subnet"),
		},
	})
	opts = append(opts, aliases)
	var resource Subnet
	err := ctx.RegisterResource("azure-nextgen:network/v20190801:Subnet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSubnet gets an existing Subnet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubnet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SubnetState, opts ...pulumi.ResourceOption) (*Subnet, error) {
	var resource Subnet
	err := ctx.ReadResource("azure-nextgen:network/v20190801:Subnet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Subnet resources.
type subnetState struct {
	// The address prefix for the subnet.
	AddressPrefix *string `pulumi:"addressPrefix"`
	// List of address prefixes for the subnet.
	AddressPrefixes []string `pulumi:"addressPrefixes"`
	// An array of references to the delegations on the subnet.
	Delegations []DelegationResponse `pulumi:"delegations"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Array of IP configuration profiles which reference this subnet.
	IpConfigurationProfiles []IPConfigurationProfileResponse `pulumi:"ipConfigurationProfiles"`
	// An array of references to the network interface IP configurations using subnet.
	IpConfigurations []IPConfigurationResponse `pulumi:"ipConfigurations"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// Nat gateway associated with this subnet.
	NatGateway *SubResourceResponse `pulumi:"natGateway"`
	// The reference of the NetworkSecurityGroup resource.
	NetworkSecurityGroup *NetworkSecurityGroupResponse `pulumi:"networkSecurityGroup"`
	// Enable or Disable apply network policies on private end point in the subnet.
	PrivateEndpointNetworkPolicies *string `pulumi:"privateEndpointNetworkPolicies"`
	// An array of references to private endpoints.
	PrivateEndpoints []PrivateEndpointResponse `pulumi:"privateEndpoints"`
	// Enable or Disable apply network policies on private link service in the subnet.
	PrivateLinkServiceNetworkPolicies *string `pulumi:"privateLinkServiceNetworkPolicies"`
	// The provisioning state of the subnet resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties.
	Purpose *string `pulumi:"purpose"`
	// An array of references to the external resources using subnet.
	ResourceNavigationLinks []ResourceNavigationLinkResponse `pulumi:"resourceNavigationLinks"`
	// The reference of the RouteTable resource.
	RouteTable *RouteTableResponse `pulumi:"routeTable"`
	// An array of references to services injecting into this subnet.
	ServiceAssociationLinks []ServiceAssociationLinkResponse `pulumi:"serviceAssociationLinks"`
	// An array of service endpoint policies.
	ServiceEndpointPolicies []ServiceEndpointPolicyResponse `pulumi:"serviceEndpointPolicies"`
	// An array of service endpoints.
	ServiceEndpoints []ServiceEndpointPropertiesFormatResponse `pulumi:"serviceEndpoints"`
}

type SubnetState struct {
	// The address prefix for the subnet.
	AddressPrefix pulumi.StringPtrInput
	// List of address prefixes for the subnet.
	AddressPrefixes pulumi.StringArrayInput
	// An array of references to the delegations on the subnet.
	Delegations DelegationResponseArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Array of IP configuration profiles which reference this subnet.
	IpConfigurationProfiles IPConfigurationProfileResponseArrayInput
	// An array of references to the network interface IP configurations using subnet.
	IpConfigurations IPConfigurationResponseArrayInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// Nat gateway associated with this subnet.
	NatGateway SubResourceResponsePtrInput
	// The reference of the NetworkSecurityGroup resource.
	NetworkSecurityGroup NetworkSecurityGroupResponsePtrInput
	// Enable or Disable apply network policies on private end point in the subnet.
	PrivateEndpointNetworkPolicies pulumi.StringPtrInput
	// An array of references to private endpoints.
	PrivateEndpoints PrivateEndpointResponseArrayInput
	// Enable or Disable apply network policies on private link service in the subnet.
	PrivateLinkServiceNetworkPolicies pulumi.StringPtrInput
	// The provisioning state of the subnet resource.
	ProvisioningState pulumi.StringPtrInput
	// A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties.
	Purpose pulumi.StringPtrInput
	// An array of references to the external resources using subnet.
	ResourceNavigationLinks ResourceNavigationLinkResponseArrayInput
	// The reference of the RouteTable resource.
	RouteTable RouteTableResponsePtrInput
	// An array of references to services injecting into this subnet.
	ServiceAssociationLinks ServiceAssociationLinkResponseArrayInput
	// An array of service endpoint policies.
	ServiceEndpointPolicies ServiceEndpointPolicyResponseArrayInput
	// An array of service endpoints.
	ServiceEndpoints ServiceEndpointPropertiesFormatResponseArrayInput
}

func (SubnetState) ElementType() reflect.Type {
	return reflect.TypeOf((*subnetState)(nil)).Elem()
}

type subnetArgs struct {
	// The address prefix for the subnet.
	AddressPrefix *string `pulumi:"addressPrefix"`
	// List of address prefixes for the subnet.
	AddressPrefixes []string `pulumi:"addressPrefixes"`
	// An array of references to the delegations on the subnet.
	Delegations []Delegation `pulumi:"delegations"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name *string `pulumi:"name"`
	// Nat gateway associated with this subnet.
	NatGateway *SubResource `pulumi:"natGateway"`
	// The reference of the NetworkSecurityGroup resource.
	NetworkSecurityGroup *NetworkSecurityGroupType `pulumi:"networkSecurityGroup"`
	// Enable or Disable apply network policies on private end point in the subnet.
	PrivateEndpointNetworkPolicies *string `pulumi:"privateEndpointNetworkPolicies"`
	// Enable or Disable apply network policies on private link service in the subnet.
	PrivateLinkServiceNetworkPolicies *string `pulumi:"privateLinkServiceNetworkPolicies"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// An array of references to the external resources using subnet.
	ResourceNavigationLinks []ResourceNavigationLink `pulumi:"resourceNavigationLinks"`
	// The reference of the RouteTable resource.
	RouteTable *RouteTableType `pulumi:"routeTable"`
	// An array of references to services injecting into this subnet.
	ServiceAssociationLinks []ServiceAssociationLink `pulumi:"serviceAssociationLinks"`
	// An array of service endpoint policies.
	ServiceEndpointPolicies []ServiceEndpointPolicyType `pulumi:"serviceEndpointPolicies"`
	// An array of service endpoints.
	ServiceEndpoints []ServiceEndpointPropertiesFormat `pulumi:"serviceEndpoints"`
	// The name of the subnet.
	SubnetName string `pulumi:"subnetName"`
	// The name of the virtual network.
	VirtualNetworkName string `pulumi:"virtualNetworkName"`
}

// The set of arguments for constructing a Subnet resource.
type SubnetArgs struct {
	// The address prefix for the subnet.
	AddressPrefix pulumi.StringPtrInput
	// List of address prefixes for the subnet.
	AddressPrefixes pulumi.StringArrayInput
	// An array of references to the delegations on the subnet.
	Delegations DelegationArrayInput
	// A unique read-only string that changes whenever the resource is updated.
	Etag pulumi.StringPtrInput
	// Resource ID.
	Id pulumi.StringPtrInput
	// The name of the resource that is unique within a resource group. This name can be used to access the resource.
	Name pulumi.StringPtrInput
	// Nat gateway associated with this subnet.
	NatGateway SubResourcePtrInput
	// The reference of the NetworkSecurityGroup resource.
	NetworkSecurityGroup NetworkSecurityGroupTypePtrInput
	// Enable or Disable apply network policies on private end point in the subnet.
	PrivateEndpointNetworkPolicies pulumi.StringPtrInput
	// Enable or Disable apply network policies on private link service in the subnet.
	PrivateLinkServiceNetworkPolicies pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// An array of references to the external resources using subnet.
	ResourceNavigationLinks ResourceNavigationLinkArrayInput
	// The reference of the RouteTable resource.
	RouteTable RouteTableTypePtrInput
	// An array of references to services injecting into this subnet.
	ServiceAssociationLinks ServiceAssociationLinkArrayInput
	// An array of service endpoint policies.
	ServiceEndpointPolicies ServiceEndpointPolicyTypeArrayInput
	// An array of service endpoints.
	ServiceEndpoints ServiceEndpointPropertiesFormatArrayInput
	// The name of the subnet.
	SubnetName pulumi.StringInput
	// The name of the virtual network.
	VirtualNetworkName pulumi.StringInput
}

func (SubnetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*subnetArgs)(nil)).Elem()
}
