// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150401

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Azure Cosmos DB database account.
type DatabaseAccount struct {
	pulumi.CustomResourceState

	// List of Cosmos DB capabilities for the account
	Capabilities CapabilityResponseArrayOutput `pulumi:"capabilities"`
	// The cassandra connector offer type for the Cosmos DB database C* account.
	ConnectorOffer pulumi.StringPtrOutput `pulumi:"connectorOffer"`
	// The consistency policy for the Cosmos DB database account.
	ConsistencyPolicy ConsistencyPolicyResponsePtrOutput `pulumi:"consistencyPolicy"`
	// The offer type for the Cosmos DB database account. Default value: Standard.
	DatabaseAccountOfferType pulumi.StringOutput `pulumi:"databaseAccountOfferType"`
	// The connection endpoint for the Cosmos DB database account.
	DocumentEndpoint pulumi.StringOutput `pulumi:"documentEndpoint"`
	// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
	EnableAutomaticFailover pulumi.BoolPtrOutput `pulumi:"enableAutomaticFailover"`
	// Enables the cassandra connector on the Cosmos DB C* account
	EnableCassandraConnector pulumi.BoolPtrOutput `pulumi:"enableCassandraConnector"`
	// Enables the account to write in multiple locations
	EnableMultipleWriteLocations pulumi.BoolPtrOutput `pulumi:"enableMultipleWriteLocations"`
	// An array that contains the regions ordered by their failover priorities.
	FailoverPolicies FailoverPolicyResponseArrayOutput `pulumi:"failoverPolicies"`
	// Cosmos DB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
	IpRangeFilter pulumi.StringPtrOutput `pulumi:"ipRangeFilter"`
	// Flag to indicate whether to enable/disable Virtual Network ACL rules.
	IsVirtualNetworkFilterEnabled pulumi.BoolPtrOutput `pulumi:"isVirtualNetworkFilterEnabled"`
	// Indicates the type of database account. This can only be set at database account creation.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the database account.
	Name pulumi.StringOutput `pulumi:"name"`
	// The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'Offline' - the Cosmos DB account is not active. 'DeletionFailed' – the Cosmos DB account deletion failed.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// An array that contains of the read locations enabled for the Cosmos DB account.
	ReadLocations LocationResponseArrayOutput `pulumi:"readLocations"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of Azure resource.
	Type pulumi.StringOutput `pulumi:"type"`
	// List of Virtual Network ACL rules configured for the Cosmos DB account.
	VirtualNetworkRules VirtualNetworkRuleResponseArrayOutput `pulumi:"virtualNetworkRules"`
	// An array that contains the write location for the Cosmos DB account.
	WriteLocations LocationResponseArrayOutput `pulumi:"writeLocations"`
}

// NewDatabaseAccount registers a new resource with the given unique name, arguments, and options.
func NewDatabaseAccount(ctx *pulumi.Context,
	name string, args *DatabaseAccountArgs, opts ...pulumi.ResourceOption) (*DatabaseAccount, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.DatabaseAccountOfferType == nil {
		return nil, errors.New("missing required argument 'DatabaseAccountOfferType'")
	}
	if args == nil || args.Locations == nil {
		return nil, errors.New("missing required argument 'Locations'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &DatabaseAccountArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:documentdb/latest:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20150408:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20151106:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20160319:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20160331:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20190801:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20191212:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200301:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200401:DatabaseAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:documentdb/v20200601preview:DatabaseAccount"),
		},
	})
	opts = append(opts, aliases)
	var resource DatabaseAccount
	err := ctx.RegisterResource("azure-nextgen:documentdb/v20150401:DatabaseAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabaseAccount gets an existing DatabaseAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabaseAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabaseAccountState, opts ...pulumi.ResourceOption) (*DatabaseAccount, error) {
	var resource DatabaseAccount
	err := ctx.ReadResource("azure-nextgen:documentdb/v20150401:DatabaseAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatabaseAccount resources.
type databaseAccountState struct {
	// List of Cosmos DB capabilities for the account
	Capabilities []CapabilityResponse `pulumi:"capabilities"`
	// The cassandra connector offer type for the Cosmos DB database C* account.
	ConnectorOffer *string `pulumi:"connectorOffer"`
	// The consistency policy for the Cosmos DB database account.
	ConsistencyPolicy *ConsistencyPolicyResponse `pulumi:"consistencyPolicy"`
	// The offer type for the Cosmos DB database account. Default value: Standard.
	DatabaseAccountOfferType *string `pulumi:"databaseAccountOfferType"`
	// The connection endpoint for the Cosmos DB database account.
	DocumentEndpoint *string `pulumi:"documentEndpoint"`
	// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
	EnableAutomaticFailover *bool `pulumi:"enableAutomaticFailover"`
	// Enables the cassandra connector on the Cosmos DB C* account
	EnableCassandraConnector *bool `pulumi:"enableCassandraConnector"`
	// Enables the account to write in multiple locations
	EnableMultipleWriteLocations *bool `pulumi:"enableMultipleWriteLocations"`
	// An array that contains the regions ordered by their failover priorities.
	FailoverPolicies []FailoverPolicyResponse `pulumi:"failoverPolicies"`
	// Cosmos DB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
	IpRangeFilter *string `pulumi:"ipRangeFilter"`
	// Flag to indicate whether to enable/disable Virtual Network ACL rules.
	IsVirtualNetworkFilterEnabled *bool `pulumi:"isVirtualNetworkFilterEnabled"`
	// Indicates the type of database account. This can only be set at database account creation.
	Kind *string `pulumi:"kind"`
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// The name of the database account.
	Name *string `pulumi:"name"`
	// The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'Offline' - the Cosmos DB account is not active. 'DeletionFailed' – the Cosmos DB account deletion failed.
	ProvisioningState *string `pulumi:"provisioningState"`
	// An array that contains of the read locations enabled for the Cosmos DB account.
	ReadLocations []LocationResponse `pulumi:"readLocations"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// The type of Azure resource.
	Type *string `pulumi:"type"`
	// List of Virtual Network ACL rules configured for the Cosmos DB account.
	VirtualNetworkRules []VirtualNetworkRuleResponse `pulumi:"virtualNetworkRules"`
	// An array that contains the write location for the Cosmos DB account.
	WriteLocations []LocationResponse `pulumi:"writeLocations"`
}

type DatabaseAccountState struct {
	// List of Cosmos DB capabilities for the account
	Capabilities CapabilityResponseArrayInput
	// The cassandra connector offer type for the Cosmos DB database C* account.
	ConnectorOffer pulumi.StringPtrInput
	// The consistency policy for the Cosmos DB database account.
	ConsistencyPolicy ConsistencyPolicyResponsePtrInput
	// The offer type for the Cosmos DB database account. Default value: Standard.
	DatabaseAccountOfferType pulumi.StringPtrInput
	// The connection endpoint for the Cosmos DB database account.
	DocumentEndpoint pulumi.StringPtrInput
	// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
	EnableAutomaticFailover pulumi.BoolPtrInput
	// Enables the cassandra connector on the Cosmos DB C* account
	EnableCassandraConnector pulumi.BoolPtrInput
	// Enables the account to write in multiple locations
	EnableMultipleWriteLocations pulumi.BoolPtrInput
	// An array that contains the regions ordered by their failover priorities.
	FailoverPolicies FailoverPolicyResponseArrayInput
	// Cosmos DB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
	IpRangeFilter pulumi.StringPtrInput
	// Flag to indicate whether to enable/disable Virtual Network ACL rules.
	IsVirtualNetworkFilterEnabled pulumi.BoolPtrInput
	// Indicates the type of database account. This can only be set at database account creation.
	Kind pulumi.StringPtrInput
	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrInput
	// The name of the database account.
	Name pulumi.StringPtrInput
	// The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'Offline' - the Cosmos DB account is not active. 'DeletionFailed' – the Cosmos DB account deletion failed.
	ProvisioningState pulumi.StringPtrInput
	// An array that contains of the read locations enabled for the Cosmos DB account.
	ReadLocations LocationResponseArrayInput
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapInput
	// The type of Azure resource.
	Type pulumi.StringPtrInput
	// List of Virtual Network ACL rules configured for the Cosmos DB account.
	VirtualNetworkRules VirtualNetworkRuleResponseArrayInput
	// An array that contains the write location for the Cosmos DB account.
	WriteLocations LocationResponseArrayInput
}

func (DatabaseAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseAccountState)(nil)).Elem()
}

type databaseAccountArgs struct {
	// Cosmos DB database account name.
	AccountName string `pulumi:"accountName"`
	// List of Cosmos DB capabilities for the account
	Capabilities []Capability `pulumi:"capabilities"`
	// The cassandra connector offer type for the Cosmos DB database C* account.
	ConnectorOffer *string `pulumi:"connectorOffer"`
	// The consistency policy for the Cosmos DB account.
	ConsistencyPolicy *ConsistencyPolicy `pulumi:"consistencyPolicy"`
	// The offer type for the database
	DatabaseAccountOfferType string `pulumi:"databaseAccountOfferType"`
	// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
	EnableAutomaticFailover *bool `pulumi:"enableAutomaticFailover"`
	// Enables the cassandra connector on the Cosmos DB C* account
	EnableCassandraConnector *bool `pulumi:"enableCassandraConnector"`
	// Enables the account to write in multiple locations
	EnableMultipleWriteLocations *bool `pulumi:"enableMultipleWriteLocations"`
	// Cosmos DB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
	IpRangeFilter *string `pulumi:"ipRangeFilter"`
	// Flag to indicate whether to enable/disable Virtual Network ACL rules.
	IsVirtualNetworkFilterEnabled *bool `pulumi:"isVirtualNetworkFilterEnabled"`
	// Indicates the type of database account. This can only be set at database account creation.
	Kind *string `pulumi:"kind"`
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// An array that contains the georeplication locations enabled for the Cosmos DB account.
	Locations []Location `pulumi:"locations"`
	// Name of an Azure resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// List of Virtual Network ACL rules configured for the Cosmos DB account.
	VirtualNetworkRules []VirtualNetworkRule `pulumi:"virtualNetworkRules"`
}

// The set of arguments for constructing a DatabaseAccount resource.
type DatabaseAccountArgs struct {
	// Cosmos DB database account name.
	AccountName pulumi.StringInput
	// List of Cosmos DB capabilities for the account
	Capabilities CapabilityArrayInput
	// The cassandra connector offer type for the Cosmos DB database C* account.
	ConnectorOffer pulumi.StringPtrInput
	// The consistency policy for the Cosmos DB account.
	ConsistencyPolicy ConsistencyPolicyPtrInput
	// The offer type for the database
	DatabaseAccountOfferType pulumi.StringInput
	// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
	EnableAutomaticFailover pulumi.BoolPtrInput
	// Enables the cassandra connector on the Cosmos DB C* account
	EnableCassandraConnector pulumi.BoolPtrInput
	// Enables the account to write in multiple locations
	EnableMultipleWriteLocations pulumi.BoolPtrInput
	// Cosmos DB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
	IpRangeFilter pulumi.StringPtrInput
	// Flag to indicate whether to enable/disable Virtual Network ACL rules.
	IsVirtualNetworkFilterEnabled pulumi.BoolPtrInput
	// Indicates the type of database account. This can only be set at database account creation.
	Kind pulumi.StringPtrInput
	// The location of the resource group to which the resource belongs.
	Location pulumi.StringPtrInput
	// An array that contains the georeplication locations enabled for the Cosmos DB account.
	Locations LocationArrayInput
	// Name of an Azure resource group.
	ResourceGroupName pulumi.StringInput
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags pulumi.StringMapInput
	// List of Virtual Network ACL rules configured for the Cosmos DB account.
	VirtualNetworkRules VirtualNetworkRuleArrayInput
}

func (DatabaseAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseAccountArgs)(nil)).Elem()
}
