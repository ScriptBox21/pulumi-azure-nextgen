// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupBlobInventoryPolicy(ctx *pulumi.Context, args *LookupBlobInventoryPolicyArgs, opts ...pulumi.InvokeOption) (*LookupBlobInventoryPolicyResult, error) {
	var rv LookupBlobInventoryPolicyResult
	err := ctx.Invoke("azure-nextgen:storage/v20200801preview:getBlobInventoryPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupBlobInventoryPolicyArgs struct {
	// The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
	AccountName string `pulumi:"accountName"`
	// The name of the storage account blob inventory policy. It should always be 'default'
	BlobInventoryPolicyName string `pulumi:"blobInventoryPolicyName"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The storage account blob inventory policy.
type LookupBlobInventoryPolicyResult struct {
	// Returns the last modified date and time of the blob inventory policy.
	LastModifiedTime string `pulumi:"lastModifiedTime"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The storage account blob inventory policy object. It is composed of policy rules.
	Policy BlobInventoryPolicySchemaResponse `pulumi:"policy"`
	// Metadata pertaining to creation and last modification of the resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}