// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190401

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The storage account.
type StorageAccount struct {
	pulumi.CustomResourceState

	// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
	AccessTier pulumi.StringOutput `pulumi:"accessTier"`
	// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
	AllowBlobPublicAccess pulumi.BoolPtrOutput `pulumi:"allowBlobPublicAccess"`
	// Provides the identity based authentication settings for Azure Files.
	AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthenticationResponsePtrOutput `pulumi:"azureFilesIdentityBasedAuthentication"`
	// Gets the creation date and time of the storage account in UTC.
	CreationTime pulumi.StringOutput `pulumi:"creationTime"`
	// Gets the custom domain the user assigned to this storage account.
	CustomDomain CustomDomainResponseOutput `pulumi:"customDomain"`
	// Allows https traffic only to storage service if sets to true.
	EnableHttpsTrafficOnly pulumi.BoolPtrOutput `pulumi:"enableHttpsTrafficOnly"`
	// Gets the encryption settings on the account. If unspecified, the account is unencrypted.
	Encryption EncryptionResponseOutput `pulumi:"encryption"`
	// If the failover is in progress, the value will be true, otherwise, it will be null.
	FailoverInProgress pulumi.BoolOutput `pulumi:"failoverInProgress"`
	// Geo Replication Stats
	GeoReplicationStats GeoReplicationStatsResponseOutput `pulumi:"geoReplicationStats"`
	// The identity of the resource.
	Identity IdentityResponsePtrOutput `pulumi:"identity"`
	// Account HierarchicalNamespace enabled if sets to true.
	IsHnsEnabled pulumi.BoolPtrOutput `pulumi:"isHnsEnabled"`
	// Gets the Kind.
	Kind pulumi.StringOutput `pulumi:"kind"`
	// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
	LargeFileSharesState pulumi.StringPtrOutput `pulumi:"largeFileSharesState"`
	// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
	LastGeoFailoverTime pulumi.StringOutput `pulumi:"lastGeoFailoverTime"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
	MinimumTlsVersion pulumi.StringPtrOutput `pulumi:"minimumTlsVersion"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Network rule set
	NetworkRuleSet NetworkRuleSetResponseOutput `pulumi:"networkRuleSet"`
	// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
	PrimaryEndpoints EndpointsResponseOutput `pulumi:"primaryEndpoints"`
	// Gets the location of the primary data center for the storage account.
	PrimaryLocation pulumi.StringOutput `pulumi:"primaryLocation"`
	// Gets the status of the storage account at the time the operation was called.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
	SecondaryEndpoints EndpointsResponseOutput `pulumi:"secondaryEndpoints"`
	// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
	SecondaryLocation pulumi.StringOutput `pulumi:"secondaryLocation"`
	// Gets the SKU.
	Sku SkuResponseOutput `pulumi:"sku"`
	// Gets the status indicating whether the primary location of the storage account is available or unavailable.
	StatusOfPrimary pulumi.StringOutput `pulumi:"statusOfPrimary"`
	// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
	StatusOfSecondary pulumi.StringOutput `pulumi:"statusOfSecondary"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewStorageAccount registers a new resource with the given unique name, arguments, and options.
func NewStorageAccount(ctx *pulumi.Context,
	name string, args *StorageAccountArgs, opts ...pulumi.ResourceOption) (*StorageAccount, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.Kind == nil {
		return nil, errors.New("missing required argument 'Kind'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	if args == nil {
		args = &StorageAccountArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storage/latest:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20150501preview:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20150615:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20160101:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20160501:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20161201:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20170601:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20171001:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20180201:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20180301preview:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20180701:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20181101:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190601:StorageAccount"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20200801preview:StorageAccount"),
		},
	})
	opts = append(opts, aliases)
	var resource StorageAccount
	err := ctx.RegisterResource("azure-nextgen:storage/v20190401:StorageAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStorageAccount gets an existing StorageAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStorageAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StorageAccountState, opts ...pulumi.ResourceOption) (*StorageAccount, error) {
	var resource StorageAccount
	err := ctx.ReadResource("azure-nextgen:storage/v20190401:StorageAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StorageAccount resources.
type storageAccountState struct {
	// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
	AccessTier *string `pulumi:"accessTier"`
	// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
	AllowBlobPublicAccess *bool `pulumi:"allowBlobPublicAccess"`
	// Provides the identity based authentication settings for Azure Files.
	AzureFilesIdentityBasedAuthentication *AzureFilesIdentityBasedAuthenticationResponse `pulumi:"azureFilesIdentityBasedAuthentication"`
	// Gets the creation date and time of the storage account in UTC.
	CreationTime *string `pulumi:"creationTime"`
	// Gets the custom domain the user assigned to this storage account.
	CustomDomain *CustomDomainResponse `pulumi:"customDomain"`
	// Allows https traffic only to storage service if sets to true.
	EnableHttpsTrafficOnly *bool `pulumi:"enableHttpsTrafficOnly"`
	// Gets the encryption settings on the account. If unspecified, the account is unencrypted.
	Encryption *EncryptionResponse `pulumi:"encryption"`
	// If the failover is in progress, the value will be true, otherwise, it will be null.
	FailoverInProgress *bool `pulumi:"failoverInProgress"`
	// Geo Replication Stats
	GeoReplicationStats *GeoReplicationStatsResponse `pulumi:"geoReplicationStats"`
	// The identity of the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// Account HierarchicalNamespace enabled if sets to true.
	IsHnsEnabled *bool `pulumi:"isHnsEnabled"`
	// Gets the Kind.
	Kind *string `pulumi:"kind"`
	// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
	LargeFileSharesState *string `pulumi:"largeFileSharesState"`
	// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
	LastGeoFailoverTime *string `pulumi:"lastGeoFailoverTime"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
	MinimumTlsVersion *string `pulumi:"minimumTlsVersion"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Network rule set
	NetworkRuleSet *NetworkRuleSetResponse `pulumi:"networkRuleSet"`
	// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
	PrimaryEndpoints *EndpointsResponse `pulumi:"primaryEndpoints"`
	// Gets the location of the primary data center for the storage account.
	PrimaryLocation *string `pulumi:"primaryLocation"`
	// Gets the status of the storage account at the time the operation was called.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
	SecondaryEndpoints *EndpointsResponse `pulumi:"secondaryEndpoints"`
	// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
	SecondaryLocation *string `pulumi:"secondaryLocation"`
	// Gets the SKU.
	Sku *SkuResponse `pulumi:"sku"`
	// Gets the status indicating whether the primary location of the storage account is available or unavailable.
	StatusOfPrimary *string `pulumi:"statusOfPrimary"`
	// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
	StatusOfSecondary *string `pulumi:"statusOfSecondary"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type StorageAccountState struct {
	// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
	AccessTier pulumi.StringPtrInput
	// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
	AllowBlobPublicAccess pulumi.BoolPtrInput
	// Provides the identity based authentication settings for Azure Files.
	AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthenticationResponsePtrInput
	// Gets the creation date and time of the storage account in UTC.
	CreationTime pulumi.StringPtrInput
	// Gets the custom domain the user assigned to this storage account.
	CustomDomain CustomDomainResponsePtrInput
	// Allows https traffic only to storage service if sets to true.
	EnableHttpsTrafficOnly pulumi.BoolPtrInput
	// Gets the encryption settings on the account. If unspecified, the account is unencrypted.
	Encryption EncryptionResponsePtrInput
	// If the failover is in progress, the value will be true, otherwise, it will be null.
	FailoverInProgress pulumi.BoolPtrInput
	// Geo Replication Stats
	GeoReplicationStats GeoReplicationStatsResponsePtrInput
	// The identity of the resource.
	Identity IdentityResponsePtrInput
	// Account HierarchicalNamespace enabled if sets to true.
	IsHnsEnabled pulumi.BoolPtrInput
	// Gets the Kind.
	Kind pulumi.StringPtrInput
	// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
	LargeFileSharesState pulumi.StringPtrInput
	// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
	LastGeoFailoverTime pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
	MinimumTlsVersion pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Network rule set
	NetworkRuleSet NetworkRuleSetResponsePtrInput
	// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
	PrimaryEndpoints EndpointsResponsePtrInput
	// Gets the location of the primary data center for the storage account.
	PrimaryLocation pulumi.StringPtrInput
	// Gets the status of the storage account at the time the operation was called.
	ProvisioningState pulumi.StringPtrInput
	// Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
	SecondaryEndpoints EndpointsResponsePtrInput
	// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
	SecondaryLocation pulumi.StringPtrInput
	// Gets the SKU.
	Sku SkuResponsePtrInput
	// Gets the status indicating whether the primary location of the storage account is available or unavailable.
	StatusOfPrimary pulumi.StringPtrInput
	// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
	StatusOfSecondary pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (StorageAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*storageAccountState)(nil)).Elem()
}

type storageAccountArgs struct {
	// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
	AccessTier *string `pulumi:"accessTier"`
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
	AllowBlobPublicAccess *bool `pulumi:"allowBlobPublicAccess"`
	// Provides the identity based authentication settings for Azure Files.
	AzureFilesIdentityBasedAuthentication *AzureFilesIdentityBasedAuthentication `pulumi:"azureFilesIdentityBasedAuthentication"`
	// User domain assigned to the storage account. Name is the CNAME source. Only one custom domain is supported per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name property.
	CustomDomain *CustomDomain `pulumi:"customDomain"`
	// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
	EnableHttpsTrafficOnly *bool `pulumi:"enableHttpsTrafficOnly"`
	// Not applicable. Azure Storage encryption is enabled for all storage accounts and cannot be disabled.
	Encryption *Encryption `pulumi:"encryption"`
	// The identity of the resource.
	Identity *Identity `pulumi:"identity"`
	// Account HierarchicalNamespace enabled if sets to true.
	IsHnsEnabled *bool `pulumi:"isHnsEnabled"`
	// Required. Indicates the type of storage account.
	Kind string `pulumi:"kind"`
	// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
	LargeFileSharesState *string `pulumi:"largeFileSharesState"`
	// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
	Location string `pulumi:"location"`
	// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
	MinimumTlsVersion *string `pulumi:"minimumTlsVersion"`
	// Network rule set
	NetworkRuleSet *NetworkRuleSet `pulumi:"networkRuleSet"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Required. Gets or sets the SKU name.
	Sku Sku `pulumi:"sku"`
	// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a StorageAccount resource.
type StorageAccountArgs struct {
	// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
	AccessTier pulumi.StringPtrInput
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName pulumi.StringInput
	// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
	AllowBlobPublicAccess pulumi.BoolPtrInput
	// Provides the identity based authentication settings for Azure Files.
	AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthenticationPtrInput
	// User domain assigned to the storage account. Name is the CNAME source. Only one custom domain is supported per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name property.
	CustomDomain CustomDomainPtrInput
	// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
	EnableHttpsTrafficOnly pulumi.BoolPtrInput
	// Not applicable. Azure Storage encryption is enabled for all storage accounts and cannot be disabled.
	Encryption EncryptionPtrInput
	// The identity of the resource.
	Identity IdentityPtrInput
	// Account HierarchicalNamespace enabled if sets to true.
	IsHnsEnabled pulumi.BoolPtrInput
	// Required. Indicates the type of storage account.
	Kind pulumi.StringInput
	// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
	LargeFileSharesState pulumi.StringPtrInput
	// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
	Location pulumi.StringInput
	// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
	MinimumTlsVersion pulumi.StringPtrInput
	// Network rule set
	NetworkRuleSet NetworkRuleSetPtrInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Required. Gets or sets the SKU name.
	Sku SkuInput
	// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
	Tags pulumi.StringMapInput
}

func (StorageAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*storageAccountArgs)(nil)).Elem()
}
