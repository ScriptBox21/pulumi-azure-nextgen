// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupMediaService(ctx *pulumi.Context, args *LookupMediaServiceArgs, opts ...pulumi.InvokeOption) (*LookupMediaServiceResult, error) {
	var rv LookupMediaServiceResult
	err := ctx.Invoke("azure-nextgen:media/v20200501:getMediaService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupMediaServiceArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// A Media Services account.
type LookupMediaServiceResult struct {
	// The account encryption properties.
	Encryption *AccountEncryptionResponse `pulumi:"encryption"`
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The Managed Identity for the Media Services account.
	Identity *MediaServiceIdentityResponse `pulumi:"identity"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The Media Services account ID.
	MediaServiceId string `pulumi:"mediaServiceId"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The storage accounts for this resource.
	StorageAccounts       []StorageAccountResponse `pulumi:"storageAccounts"`
	StorageAuthentication *string                  `pulumi:"storageAuthentication"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
