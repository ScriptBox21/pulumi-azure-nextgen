// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20191101

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupViewByScope(ctx *pulumi.Context, args *LookupViewByScopeArgs, opts ...pulumi.InvokeOption) (*LookupViewByScopeResult, error) {
	var rv LookupViewByScopeResult
	err := ctx.Invoke("azure-nextgen:costmanagement/v20191101:getViewByScope", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupViewByScopeArgs struct {
	// The scope associated with view operations. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for External Billing Account scope and 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for External Subscription scope.
	Scope string `pulumi:"scope"`
	// View name
	ViewName string `pulumi:"viewName"`
}

// States and configurations of Cost Analysis.
type LookupViewByScopeResult struct {
	// Show costs accumulated over time.
	Accumulated *string `pulumi:"accumulated"`
	// Chart type of the main view in Cost Analysis. Required.
	Chart *string `pulumi:"chart"`
	// Date the user created this view.
	CreatedOn string `pulumi:"createdOn"`
	// Selected currency.
	Currency string `pulumi:"currency"`
	// Has definition for data in this report config.
	Dataset *ReportConfigDatasetResponse `pulumi:"dataset"`
	// Selected date range for viewing cost in.
	DateRange string `pulumi:"dateRange"`
	// User input name of the view. Required.
	DisplayName *string `pulumi:"displayName"`
	// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
	ETag *string `pulumi:"eTag"`
	// List of KPIs to show in Cost Analysis UI.
	Kpis []KpiPropertiesResponse `pulumi:"kpis"`
	// Metric to use when displaying costs.
	Metric *string `pulumi:"metric"`
	// Date when the user last modified this view.
	ModifiedOn string `pulumi:"modifiedOn"`
	// Resource name.
	Name string `pulumi:"name"`
	// Configuration of 3 sub-views in the Cost Analysis UI.
	Pivots []PivotPropertiesResponse `pulumi:"pivots"`
	// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
	Scope *string `pulumi:"scope"`
	// Has time period for pulling data for the report.
	TimePeriod *ReportConfigTimePeriodResponse `pulumi:"timePeriod"`
	// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
	Timeframe string `pulumi:"timeframe"`
	// Resource type.
	Type string `pulumi:"type"`
}
