// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupService(ctx *pulumi.Context, args *LookupServiceArgs, opts ...pulumi.InvokeOption) (*LookupServiceResult, error) {
	var rv LookupServiceResult
	err := ctx.Invoke("azure-nextgen:search/v20200801preview:getService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupServiceArgs struct {
	// The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Azure Cognitive Search service associated with the specified resource group.
	SearchServiceName string `pulumi:"searchServiceName"`
}

// Describes an Azure Cognitive Search service and its current state.
type LookupServiceResult struct {
	// Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'.
	HostingMode *string `pulumi:"hostingMode"`
	// The identity of the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Network specific rules that determine how the Azure Cognitive Search service may be reached.
	NetworkRuleSet *NetworkRuleSetResponse `pulumi:"networkRuleSet"`
	// The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3.
	PartitionCount *int `pulumi:"partitionCount"`
	// The list of private endpoint connections to the Azure Cognitive Search service.
	PrivateEndpointConnections []PrivateEndpointConnectionResponse `pulumi:"privateEndpointConnections"`
	// The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either 'succeeded' or 'failed'. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as 'succeeded' directly in the call to Create search service. This is because the free service uses capacity that is already set up.
	ProvisioningState string `pulumi:"provisioningState"`
	// This value can be set to 'enabled' to avoid breaking changes on existing customer resources and templates. If set to 'disabled', traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method.
	PublicNetworkAccess *string `pulumi:"publicNetworkAccess"`
	// The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU.
	ReplicaCount *int `pulumi:"replicaCount"`
	// The list of shared private link resources managed by the Azure Cognitive Search service.
	SharedPrivateLinkResources []SharedPrivateLinkResourceResponse `pulumi:"sharedPrivateLinkResources"`
	// The SKU of the Search Service, which determines price tier and capacity limits. This property is required when creating a new Search Service.
	Sku *SkuResponse `pulumi:"sku"`
	// The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. If your service is in the degraded, disabled, or error states, it means the Azure Cognitive Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned.
	Status string `pulumi:"status"`
	// The details of the search service status.
	StatusDetails string `pulumi:"statusDetails"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
