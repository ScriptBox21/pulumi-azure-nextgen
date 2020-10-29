// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupIpFirewallRule(ctx *pulumi.Context, args *LookupIpFirewallRuleArgs, opts ...pulumi.InvokeOption) (*LookupIpFirewallRuleResult, error) {
	var rv LookupIpFirewallRuleResult
	err := ctx.Invoke("azure-nextgen:synapse/v20190601preview:getIpFirewallRule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupIpFirewallRuleArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The IP firewall rule name
	RuleName string `pulumi:"ruleName"`
	// The name of the workspace
	WorkspaceName string `pulumi:"workspaceName"`
}

// IP firewall rule
type LookupIpFirewallRuleResult struct {
	// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress
	EndIpAddress *string `pulumi:"endIpAddress"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Resource provisioning state
	ProvisioningState string `pulumi:"provisioningState"`
	// The start IP address of the firewall rule. Must be IPv4 format
	StartIpAddress *string `pulumi:"startIpAddress"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}
