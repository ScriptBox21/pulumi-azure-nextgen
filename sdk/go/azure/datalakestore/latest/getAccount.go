// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAccount(ctx *pulumi.Context, args *LookupAccountArgs, opts ...pulumi.InvokeOption) (*LookupAccountResult, error) {
	var rv LookupAccountResult
	err := ctx.Invoke("azure-nextgen:datalakestore/latest:getAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAccountArgs struct {
	// The name of the Data Lake Store account.
	AccountName string `pulumi:"accountName"`
	// The name of the Azure resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Data Lake Store account information.
type LookupAccountResult struct {
	// The unique identifier associated with this Data Lake Store account.
	AccountId string `pulumi:"accountId"`
	// The account creation time.
	CreationTime string `pulumi:"creationTime"`
	// The commitment tier in use for the current month.
	CurrentTier string `pulumi:"currentTier"`
	// The default owner group for all new folders and files created in the Data Lake Store account.
	DefaultGroup string `pulumi:"defaultGroup"`
	// The Key Vault encryption configuration.
	EncryptionConfig EncryptionConfigResponse `pulumi:"encryptionConfig"`
	// The current state of encryption provisioning for this Data Lake Store account.
	EncryptionProvisioningState string `pulumi:"encryptionProvisioningState"`
	// The current state of encryption for this Data Lake Store account.
	EncryptionState string `pulumi:"encryptionState"`
	// The full CName endpoint for this account.
	Endpoint string `pulumi:"endpoint"`
	// The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
	FirewallAllowAzureIps string `pulumi:"firewallAllowAzureIps"`
	// The list of firewall rules associated with this Data Lake Store account.
	FirewallRules []FirewallRuleResponse `pulumi:"firewallRules"`
	// The current state of the IP address firewall for this Data Lake Store account.
	FirewallState string `pulumi:"firewallState"`
	// The Key Vault encryption identity, if any.
	Identity EncryptionIdentityResponse `pulumi:"identity"`
	// The account last modified time.
	LastModifiedTime string `pulumi:"lastModifiedTime"`
	// The resource location.
	Location string `pulumi:"location"`
	// The resource name.
	Name string `pulumi:"name"`
	// The commitment tier to use for next month.
	NewTier string `pulumi:"newTier"`
	// The provisioning status of the Data Lake Store account.
	ProvisioningState string `pulumi:"provisioningState"`
	// The state of the Data Lake Store account.
	State string `pulumi:"state"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The current state of the trusted identity provider feature for this Data Lake Store account.
	TrustedIdProviderState string `pulumi:"trustedIdProviderState"`
	// The list of trusted identity providers associated with this Data Lake Store account.
	TrustedIdProviders []TrustedIdProviderResponse `pulumi:"trustedIdProviders"`
	// The resource type.
	Type string `pulumi:"type"`
	// The list of virtual network rules associated with this Data Lake Store account.
	VirtualNetworkRules []VirtualNetworkRuleResponse `pulumi:"virtualNetworkRules"`
}