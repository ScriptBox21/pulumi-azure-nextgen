// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180201

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Properties of the blob container, including Id, resource name, resource type, Etag.
type BlobContainer struct {
	pulumi.CustomResourceState

	// Resource Etag.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
	HasImmutabilityPolicy pulumi.BoolOutput `pulumi:"hasImmutabilityPolicy"`
	// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
	HasLegalHold pulumi.BoolOutput `pulumi:"hasLegalHold"`
	// The ImmutabilityPolicy property of the container.
	ImmutabilityPolicy ImmutabilityPolicyPropertiesResponseOutput `pulumi:"immutabilityPolicy"`
	// Returns the date and time the container was last modified.
	LastModifiedTime pulumi.StringOutput `pulumi:"lastModifiedTime"`
	// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
	LeaseDuration pulumi.StringOutput `pulumi:"leaseDuration"`
	// Lease state of the container.
	LeaseState pulumi.StringOutput `pulumi:"leaseState"`
	// The lease status of the container.
	LeaseStatus pulumi.StringOutput `pulumi:"leaseStatus"`
	// The LegalHold property of the container.
	LegalHold LegalHoldPropertiesResponseOutput `pulumi:"legalHold"`
	// A name-value pair to associate with the container as metadata.
	Metadata pulumi.StringMapOutput `pulumi:"metadata"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Specifies whether data in the container may be accessed publicly and the level of access.
	PublicAccess pulumi.StringPtrOutput `pulumi:"publicAccess"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewBlobContainer registers a new resource with the given unique name, arguments, and options.
func NewBlobContainer(ctx *pulumi.Context,
	name string, args *BlobContainerArgs, opts ...pulumi.ResourceOption) (*BlobContainer, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.ContainerName == nil {
		return nil, errors.New("missing required argument 'ContainerName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &BlobContainerArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:storage/latest:BlobContainer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20180301preview:BlobContainer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20180701:BlobContainer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20181101:BlobContainer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190401:BlobContainer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20190601:BlobContainer"),
		},
		{
			Type: pulumi.String("azure-nextgen:storage/v20200801preview:BlobContainer"),
		},
	})
	opts = append(opts, aliases)
	var resource BlobContainer
	err := ctx.RegisterResource("azure-nextgen:storage/v20180201:BlobContainer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBlobContainer gets an existing BlobContainer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBlobContainer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BlobContainerState, opts ...pulumi.ResourceOption) (*BlobContainer, error) {
	var resource BlobContainer
	err := ctx.ReadResource("azure-nextgen:storage/v20180201:BlobContainer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BlobContainer resources.
type blobContainerState struct {
	// Resource Etag.
	Etag *string `pulumi:"etag"`
	// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
	HasImmutabilityPolicy *bool `pulumi:"hasImmutabilityPolicy"`
	// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
	HasLegalHold *bool `pulumi:"hasLegalHold"`
	// The ImmutabilityPolicy property of the container.
	ImmutabilityPolicy *ImmutabilityPolicyPropertiesResponse `pulumi:"immutabilityPolicy"`
	// Returns the date and time the container was last modified.
	LastModifiedTime *string `pulumi:"lastModifiedTime"`
	// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
	LeaseDuration *string `pulumi:"leaseDuration"`
	// Lease state of the container.
	LeaseState *string `pulumi:"leaseState"`
	// The lease status of the container.
	LeaseStatus *string `pulumi:"leaseStatus"`
	// The LegalHold property of the container.
	LegalHold *LegalHoldPropertiesResponse `pulumi:"legalHold"`
	// A name-value pair to associate with the container as metadata.
	Metadata map[string]string `pulumi:"metadata"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Specifies whether data in the container may be accessed publicly and the level of access.
	PublicAccess *string `pulumi:"publicAccess"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type BlobContainerState struct {
	// Resource Etag.
	Etag pulumi.StringPtrInput
	// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
	HasImmutabilityPolicy pulumi.BoolPtrInput
	// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
	HasLegalHold pulumi.BoolPtrInput
	// The ImmutabilityPolicy property of the container.
	ImmutabilityPolicy ImmutabilityPolicyPropertiesResponsePtrInput
	// Returns the date and time the container was last modified.
	LastModifiedTime pulumi.StringPtrInput
	// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
	LeaseDuration pulumi.StringPtrInput
	// Lease state of the container.
	LeaseState pulumi.StringPtrInput
	// The lease status of the container.
	LeaseStatus pulumi.StringPtrInput
	// The LegalHold property of the container.
	LegalHold LegalHoldPropertiesResponsePtrInput
	// A name-value pair to associate with the container as metadata.
	Metadata pulumi.StringMapInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Specifies whether data in the container may be accessed publicly and the level of access.
	PublicAccess pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (BlobContainerState) ElementType() reflect.Type {
	return reflect.TypeOf((*blobContainerState)(nil)).Elem()
}

type blobContainerArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
	ContainerName string `pulumi:"containerName"`
	// A name-value pair to associate with the container as metadata.
	Metadata map[string]string `pulumi:"metadata"`
	// Specifies whether data in the container may be accessed publicly and the level of access.
	PublicAccess *string `pulumi:"publicAccess"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a BlobContainer resource.
type BlobContainerArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName pulumi.StringInput
	// The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
	ContainerName pulumi.StringInput
	// A name-value pair to associate with the container as metadata.
	Metadata pulumi.StringMapInput
	// Specifies whether data in the container may be accessed publicly and the level of access.
	PublicAccess pulumi.StringPtrInput
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
}

func (BlobContainerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*blobContainerArgs)(nil)).Elem()
}
