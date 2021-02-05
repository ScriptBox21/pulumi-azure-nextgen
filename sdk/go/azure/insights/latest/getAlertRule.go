// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAlertRule(ctx *pulumi.Context, args *LookupAlertRuleArgs, opts ...pulumi.InvokeOption) (*LookupAlertRuleResult, error) {
	var rv LookupAlertRuleResult
	err := ctx.Invoke("azure-nextgen:insights/latest:getAlertRule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAlertRuleArgs struct {
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the rule.
	RuleName string `pulumi:"ruleName"`
}

// The alert rule resource.
type LookupAlertRuleResult struct {
	// action that is performed when the alert rule becomes active, and when an alert condition is resolved.
	Action interface{} `pulumi:"action"`
	// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
	Actions []interface{} `pulumi:"actions"`
	// the condition that results in the alert rule being activated.
	Condition interface{} `pulumi:"condition"`
	// the description of the alert rule that will be included in the alert email.
	Description *string `pulumi:"description"`
	// Azure resource Id
	Id string `pulumi:"id"`
	// the flag that indicates whether the alert rule is enabled.
	IsEnabled bool `pulumi:"isEnabled"`
	// Last time the rule was updated in ISO8601 format.
	LastUpdatedTime string `pulumi:"lastUpdatedTime"`
	// Resource location
	Location string `pulumi:"location"`
	// Azure resource name
	Name string `pulumi:"name"`
	// the provisioning state.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Azure resource type
	Type string `pulumi:"type"`
}
