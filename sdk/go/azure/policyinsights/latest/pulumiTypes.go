// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Error definition.
type ErrorDefinitionResponse struct {
	// Additional scenario specific error details.
	AdditionalInfo []TypedErrorInfoResponse `pulumi:"additionalInfo"`
	// Service specific error code which serves as the substatus for the HTTP error code.
	Code string `pulumi:"code"`
	// Internal error details.
	Details []ErrorDefinitionResponse `pulumi:"details"`
	// Description of the error.
	Message string `pulumi:"message"`
	// The target of the error.
	Target string `pulumi:"target"`
}

// ErrorDefinitionResponseInput is an input type that accepts ErrorDefinitionResponseArgs and ErrorDefinitionResponseOutput values.
// You can construct a concrete instance of `ErrorDefinitionResponseInput` via:
//
//          ErrorDefinitionResponseArgs{...}
type ErrorDefinitionResponseInput interface {
	pulumi.Input

	ToErrorDefinitionResponseOutput() ErrorDefinitionResponseOutput
	ToErrorDefinitionResponseOutputWithContext(context.Context) ErrorDefinitionResponseOutput
}

// Error definition.
type ErrorDefinitionResponseArgs struct {
	// Additional scenario specific error details.
	AdditionalInfo TypedErrorInfoResponseArrayInput `pulumi:"additionalInfo"`
	// Service specific error code which serves as the substatus for the HTTP error code.
	Code pulumi.StringInput `pulumi:"code"`
	// Internal error details.
	Details ErrorDefinitionResponseArrayInput `pulumi:"details"`
	// Description of the error.
	Message pulumi.StringInput `pulumi:"message"`
	// The target of the error.
	Target pulumi.StringInput `pulumi:"target"`
}

func (ErrorDefinitionResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ErrorDefinitionResponse)(nil)).Elem()
}

func (i ErrorDefinitionResponseArgs) ToErrorDefinitionResponseOutput() ErrorDefinitionResponseOutput {
	return i.ToErrorDefinitionResponseOutputWithContext(context.Background())
}

func (i ErrorDefinitionResponseArgs) ToErrorDefinitionResponseOutputWithContext(ctx context.Context) ErrorDefinitionResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ErrorDefinitionResponseOutput)
}

// ErrorDefinitionResponseArrayInput is an input type that accepts ErrorDefinitionResponseArray and ErrorDefinitionResponseArrayOutput values.
// You can construct a concrete instance of `ErrorDefinitionResponseArrayInput` via:
//
//          ErrorDefinitionResponseArray{ ErrorDefinitionResponseArgs{...} }
type ErrorDefinitionResponseArrayInput interface {
	pulumi.Input

	ToErrorDefinitionResponseArrayOutput() ErrorDefinitionResponseArrayOutput
	ToErrorDefinitionResponseArrayOutputWithContext(context.Context) ErrorDefinitionResponseArrayOutput
}

type ErrorDefinitionResponseArray []ErrorDefinitionResponseInput

func (ErrorDefinitionResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ErrorDefinitionResponse)(nil)).Elem()
}

func (i ErrorDefinitionResponseArray) ToErrorDefinitionResponseArrayOutput() ErrorDefinitionResponseArrayOutput {
	return i.ToErrorDefinitionResponseArrayOutputWithContext(context.Background())
}

func (i ErrorDefinitionResponseArray) ToErrorDefinitionResponseArrayOutputWithContext(ctx context.Context) ErrorDefinitionResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ErrorDefinitionResponseArrayOutput)
}

// Error definition.
type ErrorDefinitionResponseOutput struct{ *pulumi.OutputState }

func (ErrorDefinitionResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ErrorDefinitionResponse)(nil)).Elem()
}

func (o ErrorDefinitionResponseOutput) ToErrorDefinitionResponseOutput() ErrorDefinitionResponseOutput {
	return o
}

func (o ErrorDefinitionResponseOutput) ToErrorDefinitionResponseOutputWithContext(ctx context.Context) ErrorDefinitionResponseOutput {
	return o
}

// Additional scenario specific error details.
func (o ErrorDefinitionResponseOutput) AdditionalInfo() TypedErrorInfoResponseArrayOutput {
	return o.ApplyT(func(v ErrorDefinitionResponse) []TypedErrorInfoResponse { return v.AdditionalInfo }).(TypedErrorInfoResponseArrayOutput)
}

// Service specific error code which serves as the substatus for the HTTP error code.
func (o ErrorDefinitionResponseOutput) Code() pulumi.StringOutput {
	return o.ApplyT(func(v ErrorDefinitionResponse) string { return v.Code }).(pulumi.StringOutput)
}

// Internal error details.
func (o ErrorDefinitionResponseOutput) Details() ErrorDefinitionResponseArrayOutput {
	return o.ApplyT(func(v ErrorDefinitionResponse) []ErrorDefinitionResponse { return v.Details }).(ErrorDefinitionResponseArrayOutput)
}

// Description of the error.
func (o ErrorDefinitionResponseOutput) Message() pulumi.StringOutput {
	return o.ApplyT(func(v ErrorDefinitionResponse) string { return v.Message }).(pulumi.StringOutput)
}

// The target of the error.
func (o ErrorDefinitionResponseOutput) Target() pulumi.StringOutput {
	return o.ApplyT(func(v ErrorDefinitionResponse) string { return v.Target }).(pulumi.StringOutput)
}

type ErrorDefinitionResponseArrayOutput struct{ *pulumi.OutputState }

func (ErrorDefinitionResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ErrorDefinitionResponse)(nil)).Elem()
}

func (o ErrorDefinitionResponseArrayOutput) ToErrorDefinitionResponseArrayOutput() ErrorDefinitionResponseArrayOutput {
	return o
}

func (o ErrorDefinitionResponseArrayOutput) ToErrorDefinitionResponseArrayOutputWithContext(ctx context.Context) ErrorDefinitionResponseArrayOutput {
	return o
}

func (o ErrorDefinitionResponseArrayOutput) Index(i pulumi.IntInput) ErrorDefinitionResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ErrorDefinitionResponse {
		return vs[0].([]ErrorDefinitionResponse)[vs[1].(int)]
	}).(ErrorDefinitionResponseOutput)
}

// Details of a single deployment created by the remediation.
type RemediationDeploymentResponse struct {
	// The time at which the remediation was created.
	CreatedOn string `pulumi:"createdOn"`
	// Resource ID of the template deployment that will remediate the resource.
	DeploymentId string `pulumi:"deploymentId"`
	// Error encountered while remediated the resource.
	Error ErrorDefinitionResponse `pulumi:"error"`
	// The time at which the remediation deployment was last updated.
	LastUpdatedOn string `pulumi:"lastUpdatedOn"`
	// Resource ID of the resource that is being remediated by the deployment.
	RemediatedResourceId string `pulumi:"remediatedResourceId"`
	// Location of the resource that is being remediated.
	ResourceLocation string `pulumi:"resourceLocation"`
	// Status of the remediation deployment.
	Status string `pulumi:"status"`
}

// RemediationDeploymentResponseInput is an input type that accepts RemediationDeploymentResponseArgs and RemediationDeploymentResponseOutput values.
// You can construct a concrete instance of `RemediationDeploymentResponseInput` via:
//
//          RemediationDeploymentResponseArgs{...}
type RemediationDeploymentResponseInput interface {
	pulumi.Input

	ToRemediationDeploymentResponseOutput() RemediationDeploymentResponseOutput
	ToRemediationDeploymentResponseOutputWithContext(context.Context) RemediationDeploymentResponseOutput
}

// Details of a single deployment created by the remediation.
type RemediationDeploymentResponseArgs struct {
	// The time at which the remediation was created.
	CreatedOn pulumi.StringInput `pulumi:"createdOn"`
	// Resource ID of the template deployment that will remediate the resource.
	DeploymentId pulumi.StringInput `pulumi:"deploymentId"`
	// Error encountered while remediated the resource.
	Error ErrorDefinitionResponseInput `pulumi:"error"`
	// The time at which the remediation deployment was last updated.
	LastUpdatedOn pulumi.StringInput `pulumi:"lastUpdatedOn"`
	// Resource ID of the resource that is being remediated by the deployment.
	RemediatedResourceId pulumi.StringInput `pulumi:"remediatedResourceId"`
	// Location of the resource that is being remediated.
	ResourceLocation pulumi.StringInput `pulumi:"resourceLocation"`
	// Status of the remediation deployment.
	Status pulumi.StringInput `pulumi:"status"`
}

func (RemediationDeploymentResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationDeploymentResponse)(nil)).Elem()
}

func (i RemediationDeploymentResponseArgs) ToRemediationDeploymentResponseOutput() RemediationDeploymentResponseOutput {
	return i.ToRemediationDeploymentResponseOutputWithContext(context.Background())
}

func (i RemediationDeploymentResponseArgs) ToRemediationDeploymentResponseOutputWithContext(ctx context.Context) RemediationDeploymentResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationDeploymentResponseOutput)
}

// RemediationDeploymentResponseArrayInput is an input type that accepts RemediationDeploymentResponseArray and RemediationDeploymentResponseArrayOutput values.
// You can construct a concrete instance of `RemediationDeploymentResponseArrayInput` via:
//
//          RemediationDeploymentResponseArray{ RemediationDeploymentResponseArgs{...} }
type RemediationDeploymentResponseArrayInput interface {
	pulumi.Input

	ToRemediationDeploymentResponseArrayOutput() RemediationDeploymentResponseArrayOutput
	ToRemediationDeploymentResponseArrayOutputWithContext(context.Context) RemediationDeploymentResponseArrayOutput
}

type RemediationDeploymentResponseArray []RemediationDeploymentResponseInput

func (RemediationDeploymentResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RemediationDeploymentResponse)(nil)).Elem()
}

func (i RemediationDeploymentResponseArray) ToRemediationDeploymentResponseArrayOutput() RemediationDeploymentResponseArrayOutput {
	return i.ToRemediationDeploymentResponseArrayOutputWithContext(context.Background())
}

func (i RemediationDeploymentResponseArray) ToRemediationDeploymentResponseArrayOutputWithContext(ctx context.Context) RemediationDeploymentResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationDeploymentResponseArrayOutput)
}

// Details of a single deployment created by the remediation.
type RemediationDeploymentResponseOutput struct{ *pulumi.OutputState }

func (RemediationDeploymentResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationDeploymentResponse)(nil)).Elem()
}

func (o RemediationDeploymentResponseOutput) ToRemediationDeploymentResponseOutput() RemediationDeploymentResponseOutput {
	return o
}

func (o RemediationDeploymentResponseOutput) ToRemediationDeploymentResponseOutputWithContext(ctx context.Context) RemediationDeploymentResponseOutput {
	return o
}

// The time at which the remediation was created.
func (o RemediationDeploymentResponseOutput) CreatedOn() pulumi.StringOutput {
	return o.ApplyT(func(v RemediationDeploymentResponse) string { return v.CreatedOn }).(pulumi.StringOutput)
}

// Resource ID of the template deployment that will remediate the resource.
func (o RemediationDeploymentResponseOutput) DeploymentId() pulumi.StringOutput {
	return o.ApplyT(func(v RemediationDeploymentResponse) string { return v.DeploymentId }).(pulumi.StringOutput)
}

// Error encountered while remediated the resource.
func (o RemediationDeploymentResponseOutput) Error() ErrorDefinitionResponseOutput {
	return o.ApplyT(func(v RemediationDeploymentResponse) ErrorDefinitionResponse { return v.Error }).(ErrorDefinitionResponseOutput)
}

// The time at which the remediation deployment was last updated.
func (o RemediationDeploymentResponseOutput) LastUpdatedOn() pulumi.StringOutput {
	return o.ApplyT(func(v RemediationDeploymentResponse) string { return v.LastUpdatedOn }).(pulumi.StringOutput)
}

// Resource ID of the resource that is being remediated by the deployment.
func (o RemediationDeploymentResponseOutput) RemediatedResourceId() pulumi.StringOutput {
	return o.ApplyT(func(v RemediationDeploymentResponse) string { return v.RemediatedResourceId }).(pulumi.StringOutput)
}

// Location of the resource that is being remediated.
func (o RemediationDeploymentResponseOutput) ResourceLocation() pulumi.StringOutput {
	return o.ApplyT(func(v RemediationDeploymentResponse) string { return v.ResourceLocation }).(pulumi.StringOutput)
}

// Status of the remediation deployment.
func (o RemediationDeploymentResponseOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v RemediationDeploymentResponse) string { return v.Status }).(pulumi.StringOutput)
}

type RemediationDeploymentResponseArrayOutput struct{ *pulumi.OutputState }

func (RemediationDeploymentResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RemediationDeploymentResponse)(nil)).Elem()
}

func (o RemediationDeploymentResponseArrayOutput) ToRemediationDeploymentResponseArrayOutput() RemediationDeploymentResponseArrayOutput {
	return o
}

func (o RemediationDeploymentResponseArrayOutput) ToRemediationDeploymentResponseArrayOutputWithContext(ctx context.Context) RemediationDeploymentResponseArrayOutput {
	return o
}

func (o RemediationDeploymentResponseArrayOutput) Index(i pulumi.IntInput) RemediationDeploymentResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) RemediationDeploymentResponse {
		return vs[0].([]RemediationDeploymentResponse)[vs[1].(int)]
	}).(RemediationDeploymentResponseOutput)
}

// The deployment status summary for all deployments created by the remediation.
type RemediationDeploymentSummaryResponse struct {
	// The number of deployments required by the remediation that have failed.
	FailedDeployments int `pulumi:"failedDeployments"`
	// The number of deployments required by the remediation that have succeeded.
	SuccessfulDeployments int `pulumi:"successfulDeployments"`
	// The number of deployments required by the remediation.
	TotalDeployments int `pulumi:"totalDeployments"`
}

// RemediationDeploymentSummaryResponseInput is an input type that accepts RemediationDeploymentSummaryResponseArgs and RemediationDeploymentSummaryResponseOutput values.
// You can construct a concrete instance of `RemediationDeploymentSummaryResponseInput` via:
//
//          RemediationDeploymentSummaryResponseArgs{...}
type RemediationDeploymentSummaryResponseInput interface {
	pulumi.Input

	ToRemediationDeploymentSummaryResponseOutput() RemediationDeploymentSummaryResponseOutput
	ToRemediationDeploymentSummaryResponseOutputWithContext(context.Context) RemediationDeploymentSummaryResponseOutput
}

// The deployment status summary for all deployments created by the remediation.
type RemediationDeploymentSummaryResponseArgs struct {
	// The number of deployments required by the remediation that have failed.
	FailedDeployments pulumi.IntInput `pulumi:"failedDeployments"`
	// The number of deployments required by the remediation that have succeeded.
	SuccessfulDeployments pulumi.IntInput `pulumi:"successfulDeployments"`
	// The number of deployments required by the remediation.
	TotalDeployments pulumi.IntInput `pulumi:"totalDeployments"`
}

func (RemediationDeploymentSummaryResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationDeploymentSummaryResponse)(nil)).Elem()
}

func (i RemediationDeploymentSummaryResponseArgs) ToRemediationDeploymentSummaryResponseOutput() RemediationDeploymentSummaryResponseOutput {
	return i.ToRemediationDeploymentSummaryResponseOutputWithContext(context.Background())
}

func (i RemediationDeploymentSummaryResponseArgs) ToRemediationDeploymentSummaryResponseOutputWithContext(ctx context.Context) RemediationDeploymentSummaryResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationDeploymentSummaryResponseOutput)
}

func (i RemediationDeploymentSummaryResponseArgs) ToRemediationDeploymentSummaryResponsePtrOutput() RemediationDeploymentSummaryResponsePtrOutput {
	return i.ToRemediationDeploymentSummaryResponsePtrOutputWithContext(context.Background())
}

func (i RemediationDeploymentSummaryResponseArgs) ToRemediationDeploymentSummaryResponsePtrOutputWithContext(ctx context.Context) RemediationDeploymentSummaryResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationDeploymentSummaryResponseOutput).ToRemediationDeploymentSummaryResponsePtrOutputWithContext(ctx)
}

// RemediationDeploymentSummaryResponsePtrInput is an input type that accepts RemediationDeploymentSummaryResponseArgs, RemediationDeploymentSummaryResponsePtr and RemediationDeploymentSummaryResponsePtrOutput values.
// You can construct a concrete instance of `RemediationDeploymentSummaryResponsePtrInput` via:
//
//          RemediationDeploymentSummaryResponseArgs{...}
//
//  or:
//
//          nil
type RemediationDeploymentSummaryResponsePtrInput interface {
	pulumi.Input

	ToRemediationDeploymentSummaryResponsePtrOutput() RemediationDeploymentSummaryResponsePtrOutput
	ToRemediationDeploymentSummaryResponsePtrOutputWithContext(context.Context) RemediationDeploymentSummaryResponsePtrOutput
}

type remediationDeploymentSummaryResponsePtrType RemediationDeploymentSummaryResponseArgs

func RemediationDeploymentSummaryResponsePtr(v *RemediationDeploymentSummaryResponseArgs) RemediationDeploymentSummaryResponsePtrInput {
	return (*remediationDeploymentSummaryResponsePtrType)(v)
}

func (*remediationDeploymentSummaryResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**RemediationDeploymentSummaryResponse)(nil)).Elem()
}

func (i *remediationDeploymentSummaryResponsePtrType) ToRemediationDeploymentSummaryResponsePtrOutput() RemediationDeploymentSummaryResponsePtrOutput {
	return i.ToRemediationDeploymentSummaryResponsePtrOutputWithContext(context.Background())
}

func (i *remediationDeploymentSummaryResponsePtrType) ToRemediationDeploymentSummaryResponsePtrOutputWithContext(ctx context.Context) RemediationDeploymentSummaryResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationDeploymentSummaryResponsePtrOutput)
}

// The deployment status summary for all deployments created by the remediation.
type RemediationDeploymentSummaryResponseOutput struct{ *pulumi.OutputState }

func (RemediationDeploymentSummaryResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationDeploymentSummaryResponse)(nil)).Elem()
}

func (o RemediationDeploymentSummaryResponseOutput) ToRemediationDeploymentSummaryResponseOutput() RemediationDeploymentSummaryResponseOutput {
	return o
}

func (o RemediationDeploymentSummaryResponseOutput) ToRemediationDeploymentSummaryResponseOutputWithContext(ctx context.Context) RemediationDeploymentSummaryResponseOutput {
	return o
}

func (o RemediationDeploymentSummaryResponseOutput) ToRemediationDeploymentSummaryResponsePtrOutput() RemediationDeploymentSummaryResponsePtrOutput {
	return o.ToRemediationDeploymentSummaryResponsePtrOutputWithContext(context.Background())
}

func (o RemediationDeploymentSummaryResponseOutput) ToRemediationDeploymentSummaryResponsePtrOutputWithContext(ctx context.Context) RemediationDeploymentSummaryResponsePtrOutput {
	return o.ApplyT(func(v RemediationDeploymentSummaryResponse) *RemediationDeploymentSummaryResponse {
		return &v
	}).(RemediationDeploymentSummaryResponsePtrOutput)
}

// The number of deployments required by the remediation that have failed.
func (o RemediationDeploymentSummaryResponseOutput) FailedDeployments() pulumi.IntOutput {
	return o.ApplyT(func(v RemediationDeploymentSummaryResponse) int { return v.FailedDeployments }).(pulumi.IntOutput)
}

// The number of deployments required by the remediation that have succeeded.
func (o RemediationDeploymentSummaryResponseOutput) SuccessfulDeployments() pulumi.IntOutput {
	return o.ApplyT(func(v RemediationDeploymentSummaryResponse) int { return v.SuccessfulDeployments }).(pulumi.IntOutput)
}

// The number of deployments required by the remediation.
func (o RemediationDeploymentSummaryResponseOutput) TotalDeployments() pulumi.IntOutput {
	return o.ApplyT(func(v RemediationDeploymentSummaryResponse) int { return v.TotalDeployments }).(pulumi.IntOutput)
}

type RemediationDeploymentSummaryResponsePtrOutput struct{ *pulumi.OutputState }

func (RemediationDeploymentSummaryResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RemediationDeploymentSummaryResponse)(nil)).Elem()
}

func (o RemediationDeploymentSummaryResponsePtrOutput) ToRemediationDeploymentSummaryResponsePtrOutput() RemediationDeploymentSummaryResponsePtrOutput {
	return o
}

func (o RemediationDeploymentSummaryResponsePtrOutput) ToRemediationDeploymentSummaryResponsePtrOutputWithContext(ctx context.Context) RemediationDeploymentSummaryResponsePtrOutput {
	return o
}

func (o RemediationDeploymentSummaryResponsePtrOutput) Elem() RemediationDeploymentSummaryResponseOutput {
	return o.ApplyT(func(v *RemediationDeploymentSummaryResponse) RemediationDeploymentSummaryResponse { return *v }).(RemediationDeploymentSummaryResponseOutput)
}

// The number of deployments required by the remediation that have failed.
func (o RemediationDeploymentSummaryResponsePtrOutput) FailedDeployments() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *RemediationDeploymentSummaryResponse) *int {
		if v == nil {
			return nil
		}
		return &v.FailedDeployments
	}).(pulumi.IntPtrOutput)
}

// The number of deployments required by the remediation that have succeeded.
func (o RemediationDeploymentSummaryResponsePtrOutput) SuccessfulDeployments() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *RemediationDeploymentSummaryResponse) *int {
		if v == nil {
			return nil
		}
		return &v.SuccessfulDeployments
	}).(pulumi.IntPtrOutput)
}

// The number of deployments required by the remediation.
func (o RemediationDeploymentSummaryResponsePtrOutput) TotalDeployments() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *RemediationDeploymentSummaryResponse) *int {
		if v == nil {
			return nil
		}
		return &v.TotalDeployments
	}).(pulumi.IntPtrOutput)
}

// The filters that will be applied to determine which resources to remediate.
type RemediationFilters struct {
	// The resource locations that will be remediated.
	Locations []string `pulumi:"locations"`
}

// RemediationFiltersInput is an input type that accepts RemediationFiltersArgs and RemediationFiltersOutput values.
// You can construct a concrete instance of `RemediationFiltersInput` via:
//
//          RemediationFiltersArgs{...}
type RemediationFiltersInput interface {
	pulumi.Input

	ToRemediationFiltersOutput() RemediationFiltersOutput
	ToRemediationFiltersOutputWithContext(context.Context) RemediationFiltersOutput
}

// The filters that will be applied to determine which resources to remediate.
type RemediationFiltersArgs struct {
	// The resource locations that will be remediated.
	Locations pulumi.StringArrayInput `pulumi:"locations"`
}

func (RemediationFiltersArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationFilters)(nil)).Elem()
}

func (i RemediationFiltersArgs) ToRemediationFiltersOutput() RemediationFiltersOutput {
	return i.ToRemediationFiltersOutputWithContext(context.Background())
}

func (i RemediationFiltersArgs) ToRemediationFiltersOutputWithContext(ctx context.Context) RemediationFiltersOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationFiltersOutput)
}

func (i RemediationFiltersArgs) ToRemediationFiltersPtrOutput() RemediationFiltersPtrOutput {
	return i.ToRemediationFiltersPtrOutputWithContext(context.Background())
}

func (i RemediationFiltersArgs) ToRemediationFiltersPtrOutputWithContext(ctx context.Context) RemediationFiltersPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationFiltersOutput).ToRemediationFiltersPtrOutputWithContext(ctx)
}

// RemediationFiltersPtrInput is an input type that accepts RemediationFiltersArgs, RemediationFiltersPtr and RemediationFiltersPtrOutput values.
// You can construct a concrete instance of `RemediationFiltersPtrInput` via:
//
//          RemediationFiltersArgs{...}
//
//  or:
//
//          nil
type RemediationFiltersPtrInput interface {
	pulumi.Input

	ToRemediationFiltersPtrOutput() RemediationFiltersPtrOutput
	ToRemediationFiltersPtrOutputWithContext(context.Context) RemediationFiltersPtrOutput
}

type remediationFiltersPtrType RemediationFiltersArgs

func RemediationFiltersPtr(v *RemediationFiltersArgs) RemediationFiltersPtrInput {
	return (*remediationFiltersPtrType)(v)
}

func (*remediationFiltersPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**RemediationFilters)(nil)).Elem()
}

func (i *remediationFiltersPtrType) ToRemediationFiltersPtrOutput() RemediationFiltersPtrOutput {
	return i.ToRemediationFiltersPtrOutputWithContext(context.Background())
}

func (i *remediationFiltersPtrType) ToRemediationFiltersPtrOutputWithContext(ctx context.Context) RemediationFiltersPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationFiltersPtrOutput)
}

// The filters that will be applied to determine which resources to remediate.
type RemediationFiltersOutput struct{ *pulumi.OutputState }

func (RemediationFiltersOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationFilters)(nil)).Elem()
}

func (o RemediationFiltersOutput) ToRemediationFiltersOutput() RemediationFiltersOutput {
	return o
}

func (o RemediationFiltersOutput) ToRemediationFiltersOutputWithContext(ctx context.Context) RemediationFiltersOutput {
	return o
}

func (o RemediationFiltersOutput) ToRemediationFiltersPtrOutput() RemediationFiltersPtrOutput {
	return o.ToRemediationFiltersPtrOutputWithContext(context.Background())
}

func (o RemediationFiltersOutput) ToRemediationFiltersPtrOutputWithContext(ctx context.Context) RemediationFiltersPtrOutput {
	return o.ApplyT(func(v RemediationFilters) *RemediationFilters {
		return &v
	}).(RemediationFiltersPtrOutput)
}

// The resource locations that will be remediated.
func (o RemediationFiltersOutput) Locations() pulumi.StringArrayOutput {
	return o.ApplyT(func(v RemediationFilters) []string { return v.Locations }).(pulumi.StringArrayOutput)
}

type RemediationFiltersPtrOutput struct{ *pulumi.OutputState }

func (RemediationFiltersPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RemediationFilters)(nil)).Elem()
}

func (o RemediationFiltersPtrOutput) ToRemediationFiltersPtrOutput() RemediationFiltersPtrOutput {
	return o
}

func (o RemediationFiltersPtrOutput) ToRemediationFiltersPtrOutputWithContext(ctx context.Context) RemediationFiltersPtrOutput {
	return o
}

func (o RemediationFiltersPtrOutput) Elem() RemediationFiltersOutput {
	return o.ApplyT(func(v *RemediationFilters) RemediationFilters { return *v }).(RemediationFiltersOutput)
}

// The resource locations that will be remediated.
func (o RemediationFiltersPtrOutput) Locations() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *RemediationFilters) []string {
		if v == nil {
			return nil
		}
		return v.Locations
	}).(pulumi.StringArrayOutput)
}

// The filters that will be applied to determine which resources to remediate.
type RemediationFiltersResponse struct {
	// The resource locations that will be remediated.
	Locations []string `pulumi:"locations"`
}

// RemediationFiltersResponseInput is an input type that accepts RemediationFiltersResponseArgs and RemediationFiltersResponseOutput values.
// You can construct a concrete instance of `RemediationFiltersResponseInput` via:
//
//          RemediationFiltersResponseArgs{...}
type RemediationFiltersResponseInput interface {
	pulumi.Input

	ToRemediationFiltersResponseOutput() RemediationFiltersResponseOutput
	ToRemediationFiltersResponseOutputWithContext(context.Context) RemediationFiltersResponseOutput
}

// The filters that will be applied to determine which resources to remediate.
type RemediationFiltersResponseArgs struct {
	// The resource locations that will be remediated.
	Locations pulumi.StringArrayInput `pulumi:"locations"`
}

func (RemediationFiltersResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationFiltersResponse)(nil)).Elem()
}

func (i RemediationFiltersResponseArgs) ToRemediationFiltersResponseOutput() RemediationFiltersResponseOutput {
	return i.ToRemediationFiltersResponseOutputWithContext(context.Background())
}

func (i RemediationFiltersResponseArgs) ToRemediationFiltersResponseOutputWithContext(ctx context.Context) RemediationFiltersResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationFiltersResponseOutput)
}

func (i RemediationFiltersResponseArgs) ToRemediationFiltersResponsePtrOutput() RemediationFiltersResponsePtrOutput {
	return i.ToRemediationFiltersResponsePtrOutputWithContext(context.Background())
}

func (i RemediationFiltersResponseArgs) ToRemediationFiltersResponsePtrOutputWithContext(ctx context.Context) RemediationFiltersResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationFiltersResponseOutput).ToRemediationFiltersResponsePtrOutputWithContext(ctx)
}

// RemediationFiltersResponsePtrInput is an input type that accepts RemediationFiltersResponseArgs, RemediationFiltersResponsePtr and RemediationFiltersResponsePtrOutput values.
// You can construct a concrete instance of `RemediationFiltersResponsePtrInput` via:
//
//          RemediationFiltersResponseArgs{...}
//
//  or:
//
//          nil
type RemediationFiltersResponsePtrInput interface {
	pulumi.Input

	ToRemediationFiltersResponsePtrOutput() RemediationFiltersResponsePtrOutput
	ToRemediationFiltersResponsePtrOutputWithContext(context.Context) RemediationFiltersResponsePtrOutput
}

type remediationFiltersResponsePtrType RemediationFiltersResponseArgs

func RemediationFiltersResponsePtr(v *RemediationFiltersResponseArgs) RemediationFiltersResponsePtrInput {
	return (*remediationFiltersResponsePtrType)(v)
}

func (*remediationFiltersResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**RemediationFiltersResponse)(nil)).Elem()
}

func (i *remediationFiltersResponsePtrType) ToRemediationFiltersResponsePtrOutput() RemediationFiltersResponsePtrOutput {
	return i.ToRemediationFiltersResponsePtrOutputWithContext(context.Background())
}

func (i *remediationFiltersResponsePtrType) ToRemediationFiltersResponsePtrOutputWithContext(ctx context.Context) RemediationFiltersResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemediationFiltersResponsePtrOutput)
}

// The filters that will be applied to determine which resources to remediate.
type RemediationFiltersResponseOutput struct{ *pulumi.OutputState }

func (RemediationFiltersResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RemediationFiltersResponse)(nil)).Elem()
}

func (o RemediationFiltersResponseOutput) ToRemediationFiltersResponseOutput() RemediationFiltersResponseOutput {
	return o
}

func (o RemediationFiltersResponseOutput) ToRemediationFiltersResponseOutputWithContext(ctx context.Context) RemediationFiltersResponseOutput {
	return o
}

func (o RemediationFiltersResponseOutput) ToRemediationFiltersResponsePtrOutput() RemediationFiltersResponsePtrOutput {
	return o.ToRemediationFiltersResponsePtrOutputWithContext(context.Background())
}

func (o RemediationFiltersResponseOutput) ToRemediationFiltersResponsePtrOutputWithContext(ctx context.Context) RemediationFiltersResponsePtrOutput {
	return o.ApplyT(func(v RemediationFiltersResponse) *RemediationFiltersResponse {
		return &v
	}).(RemediationFiltersResponsePtrOutput)
}

// The resource locations that will be remediated.
func (o RemediationFiltersResponseOutput) Locations() pulumi.StringArrayOutput {
	return o.ApplyT(func(v RemediationFiltersResponse) []string { return v.Locations }).(pulumi.StringArrayOutput)
}

type RemediationFiltersResponsePtrOutput struct{ *pulumi.OutputState }

func (RemediationFiltersResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RemediationFiltersResponse)(nil)).Elem()
}

func (o RemediationFiltersResponsePtrOutput) ToRemediationFiltersResponsePtrOutput() RemediationFiltersResponsePtrOutput {
	return o
}

func (o RemediationFiltersResponsePtrOutput) ToRemediationFiltersResponsePtrOutputWithContext(ctx context.Context) RemediationFiltersResponsePtrOutput {
	return o
}

func (o RemediationFiltersResponsePtrOutput) Elem() RemediationFiltersResponseOutput {
	return o.ApplyT(func(v *RemediationFiltersResponse) RemediationFiltersResponse { return *v }).(RemediationFiltersResponseOutput)
}

// The resource locations that will be remediated.
func (o RemediationFiltersResponsePtrOutput) Locations() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *RemediationFiltersResponse) []string {
		if v == nil {
			return nil
		}
		return v.Locations
	}).(pulumi.StringArrayOutput)
}

// Scenario specific error details.
type TypedErrorInfoResponse struct {
	// The type of included error details.
	Type string `pulumi:"type"`
}

// TypedErrorInfoResponseInput is an input type that accepts TypedErrorInfoResponseArgs and TypedErrorInfoResponseOutput values.
// You can construct a concrete instance of `TypedErrorInfoResponseInput` via:
//
//          TypedErrorInfoResponseArgs{...}
type TypedErrorInfoResponseInput interface {
	pulumi.Input

	ToTypedErrorInfoResponseOutput() TypedErrorInfoResponseOutput
	ToTypedErrorInfoResponseOutputWithContext(context.Context) TypedErrorInfoResponseOutput
}

// Scenario specific error details.
type TypedErrorInfoResponseArgs struct {
	// The type of included error details.
	Type pulumi.StringInput `pulumi:"type"`
}

func (TypedErrorInfoResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TypedErrorInfoResponse)(nil)).Elem()
}

func (i TypedErrorInfoResponseArgs) ToTypedErrorInfoResponseOutput() TypedErrorInfoResponseOutput {
	return i.ToTypedErrorInfoResponseOutputWithContext(context.Background())
}

func (i TypedErrorInfoResponseArgs) ToTypedErrorInfoResponseOutputWithContext(ctx context.Context) TypedErrorInfoResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TypedErrorInfoResponseOutput)
}

// TypedErrorInfoResponseArrayInput is an input type that accepts TypedErrorInfoResponseArray and TypedErrorInfoResponseArrayOutput values.
// You can construct a concrete instance of `TypedErrorInfoResponseArrayInput` via:
//
//          TypedErrorInfoResponseArray{ TypedErrorInfoResponseArgs{...} }
type TypedErrorInfoResponseArrayInput interface {
	pulumi.Input

	ToTypedErrorInfoResponseArrayOutput() TypedErrorInfoResponseArrayOutput
	ToTypedErrorInfoResponseArrayOutputWithContext(context.Context) TypedErrorInfoResponseArrayOutput
}

type TypedErrorInfoResponseArray []TypedErrorInfoResponseInput

func (TypedErrorInfoResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TypedErrorInfoResponse)(nil)).Elem()
}

func (i TypedErrorInfoResponseArray) ToTypedErrorInfoResponseArrayOutput() TypedErrorInfoResponseArrayOutput {
	return i.ToTypedErrorInfoResponseArrayOutputWithContext(context.Background())
}

func (i TypedErrorInfoResponseArray) ToTypedErrorInfoResponseArrayOutputWithContext(ctx context.Context) TypedErrorInfoResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TypedErrorInfoResponseArrayOutput)
}

// Scenario specific error details.
type TypedErrorInfoResponseOutput struct{ *pulumi.OutputState }

func (TypedErrorInfoResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TypedErrorInfoResponse)(nil)).Elem()
}

func (o TypedErrorInfoResponseOutput) ToTypedErrorInfoResponseOutput() TypedErrorInfoResponseOutput {
	return o
}

func (o TypedErrorInfoResponseOutput) ToTypedErrorInfoResponseOutputWithContext(ctx context.Context) TypedErrorInfoResponseOutput {
	return o
}

// The type of included error details.
func (o TypedErrorInfoResponseOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v TypedErrorInfoResponse) string { return v.Type }).(pulumi.StringOutput)
}

type TypedErrorInfoResponseArrayOutput struct{ *pulumi.OutputState }

func (TypedErrorInfoResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TypedErrorInfoResponse)(nil)).Elem()
}

func (o TypedErrorInfoResponseArrayOutput) ToTypedErrorInfoResponseArrayOutput() TypedErrorInfoResponseArrayOutput {
	return o
}

func (o TypedErrorInfoResponseArrayOutput) ToTypedErrorInfoResponseArrayOutputWithContext(ctx context.Context) TypedErrorInfoResponseArrayOutput {
	return o
}

func (o TypedErrorInfoResponseArrayOutput) Index(i pulumi.IntInput) TypedErrorInfoResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) TypedErrorInfoResponse {
		return vs[0].([]TypedErrorInfoResponse)[vs[1].(int)]
	}).(TypedErrorInfoResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(ErrorDefinitionResponseOutput{})
	pulumi.RegisterOutputType(ErrorDefinitionResponseArrayOutput{})
	pulumi.RegisterOutputType(RemediationDeploymentResponseOutput{})
	pulumi.RegisterOutputType(RemediationDeploymentResponseArrayOutput{})
	pulumi.RegisterOutputType(RemediationDeploymentSummaryResponseOutput{})
	pulumi.RegisterOutputType(RemediationDeploymentSummaryResponsePtrOutput{})
	pulumi.RegisterOutputType(RemediationFiltersOutput{})
	pulumi.RegisterOutputType(RemediationFiltersPtrOutput{})
	pulumi.RegisterOutputType(RemediationFiltersResponseOutput{})
	pulumi.RegisterOutputType(RemediationFiltersResponsePtrOutput{})
	pulumi.RegisterOutputType(TypedErrorInfoResponseOutput{})
	pulumi.RegisterOutputType(TypedErrorInfoResponseArrayOutput{})
}
