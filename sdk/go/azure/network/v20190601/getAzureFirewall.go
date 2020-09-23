// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAzureFirewall(ctx *pulumi.Context, args *LookupAzureFirewallArgs, opts ...pulumi.InvokeOption) (*LookupAzureFirewallResult, error) {
	var rv LookupAzureFirewallResult
	err := ctx.Invoke("azure-nextgen:network/v20190601:getAzureFirewall", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAzureFirewallArgs struct {
	// The name of the Azure Firewall.
	AzureFirewallName string `pulumi:"azureFirewallName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Azure Firewall resource.
type LookupAzureFirewallResult struct {
	// Collection of application rule collections used by Azure Firewall.
	ApplicationRuleCollections []AzureFirewallApplicationRuleCollectionResponse `pulumi:"applicationRuleCollections"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// The firewallPolicy associated with this azure firewall.
	FirewallPolicy *SubResourceResponse `pulumi:"firewallPolicy"`
	// IP addresses associated with AzureFirewall.
	HubIpAddresses HubIPAddressesResponse `pulumi:"hubIpAddresses"`
	// IP configuration of the Azure Firewall resource.
	IpConfigurations []AzureFirewallIPConfigurationResponse `pulumi:"ipConfigurations"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name string `pulumi:"name"`
	// Collection of NAT rule collections used by Azure Firewall.
	NatRuleCollections []AzureFirewallNatRuleCollectionResponse `pulumi:"natRuleCollections"`
	// Collection of network rule collections used by Azure Firewall.
	NetworkRuleCollections []AzureFirewallNetworkRuleCollectionResponse `pulumi:"networkRuleCollections"`
	// The provisioning state of the resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The operation mode for Threat Intelligence.
	ThreatIntelMode *string `pulumi:"threatIntelMode"`
	// Resource type.
	Type string `pulumi:"type"`
	// The virtualHub to which the firewall belongs.
	VirtualHub *SubResourceResponse `pulumi:"virtualHub"`
	// A list of availability zones denoting where the resource needs to come from.
	Zones []string `pulumi:"zones"`
}
