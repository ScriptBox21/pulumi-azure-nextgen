// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20210101

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A piece of evidence supporting the compliance state set in the attestation.
type AttestationEvidence struct {
	// The description for this piece of evidence.
	Description *string `pulumi:"description"`
	// The URI location of the evidence.
	SourceUri *string `pulumi:"sourceUri"`
}

// AttestationEvidenceInput is an input type that accepts AttestationEvidenceArgs and AttestationEvidenceOutput values.
// You can construct a concrete instance of `AttestationEvidenceInput` via:
//
//          AttestationEvidenceArgs{...}
type AttestationEvidenceInput interface {
	pulumi.Input

	ToAttestationEvidenceOutput() AttestationEvidenceOutput
	ToAttestationEvidenceOutputWithContext(context.Context) AttestationEvidenceOutput
}

// A piece of evidence supporting the compliance state set in the attestation.
type AttestationEvidenceArgs struct {
	// The description for this piece of evidence.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// The URI location of the evidence.
	SourceUri pulumi.StringPtrInput `pulumi:"sourceUri"`
}

func (AttestationEvidenceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AttestationEvidence)(nil)).Elem()
}

func (i AttestationEvidenceArgs) ToAttestationEvidenceOutput() AttestationEvidenceOutput {
	return i.ToAttestationEvidenceOutputWithContext(context.Background())
}

func (i AttestationEvidenceArgs) ToAttestationEvidenceOutputWithContext(ctx context.Context) AttestationEvidenceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttestationEvidenceOutput)
}

// AttestationEvidenceArrayInput is an input type that accepts AttestationEvidenceArray and AttestationEvidenceArrayOutput values.
// You can construct a concrete instance of `AttestationEvidenceArrayInput` via:
//
//          AttestationEvidenceArray{ AttestationEvidenceArgs{...} }
type AttestationEvidenceArrayInput interface {
	pulumi.Input

	ToAttestationEvidenceArrayOutput() AttestationEvidenceArrayOutput
	ToAttestationEvidenceArrayOutputWithContext(context.Context) AttestationEvidenceArrayOutput
}

type AttestationEvidenceArray []AttestationEvidenceInput

func (AttestationEvidenceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AttestationEvidence)(nil)).Elem()
}

func (i AttestationEvidenceArray) ToAttestationEvidenceArrayOutput() AttestationEvidenceArrayOutput {
	return i.ToAttestationEvidenceArrayOutputWithContext(context.Background())
}

func (i AttestationEvidenceArray) ToAttestationEvidenceArrayOutputWithContext(ctx context.Context) AttestationEvidenceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttestationEvidenceArrayOutput)
}

// A piece of evidence supporting the compliance state set in the attestation.
type AttestationEvidenceOutput struct{ *pulumi.OutputState }

func (AttestationEvidenceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AttestationEvidence)(nil)).Elem()
}

func (o AttestationEvidenceOutput) ToAttestationEvidenceOutput() AttestationEvidenceOutput {
	return o
}

func (o AttestationEvidenceOutput) ToAttestationEvidenceOutputWithContext(ctx context.Context) AttestationEvidenceOutput {
	return o
}

// The description for this piece of evidence.
func (o AttestationEvidenceOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AttestationEvidence) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// The URI location of the evidence.
func (o AttestationEvidenceOutput) SourceUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AttestationEvidence) *string { return v.SourceUri }).(pulumi.StringPtrOutput)
}

type AttestationEvidenceArrayOutput struct{ *pulumi.OutputState }

func (AttestationEvidenceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AttestationEvidence)(nil)).Elem()
}

func (o AttestationEvidenceArrayOutput) ToAttestationEvidenceArrayOutput() AttestationEvidenceArrayOutput {
	return o
}

func (o AttestationEvidenceArrayOutput) ToAttestationEvidenceArrayOutputWithContext(ctx context.Context) AttestationEvidenceArrayOutput {
	return o
}

func (o AttestationEvidenceArrayOutput) Index(i pulumi.IntInput) AttestationEvidenceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AttestationEvidence {
		return vs[0].([]AttestationEvidence)[vs[1].(int)]
	}).(AttestationEvidenceOutput)
}

// A piece of evidence supporting the compliance state set in the attestation.
type AttestationEvidenceResponse struct {
	// The description for this piece of evidence.
	Description *string `pulumi:"description"`
	// The URI location of the evidence.
	SourceUri *string `pulumi:"sourceUri"`
}

// AttestationEvidenceResponseInput is an input type that accepts AttestationEvidenceResponseArgs and AttestationEvidenceResponseOutput values.
// You can construct a concrete instance of `AttestationEvidenceResponseInput` via:
//
//          AttestationEvidenceResponseArgs{...}
type AttestationEvidenceResponseInput interface {
	pulumi.Input

	ToAttestationEvidenceResponseOutput() AttestationEvidenceResponseOutput
	ToAttestationEvidenceResponseOutputWithContext(context.Context) AttestationEvidenceResponseOutput
}

// A piece of evidence supporting the compliance state set in the attestation.
type AttestationEvidenceResponseArgs struct {
	// The description for this piece of evidence.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// The URI location of the evidence.
	SourceUri pulumi.StringPtrInput `pulumi:"sourceUri"`
}

func (AttestationEvidenceResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AttestationEvidenceResponse)(nil)).Elem()
}

func (i AttestationEvidenceResponseArgs) ToAttestationEvidenceResponseOutput() AttestationEvidenceResponseOutput {
	return i.ToAttestationEvidenceResponseOutputWithContext(context.Background())
}

func (i AttestationEvidenceResponseArgs) ToAttestationEvidenceResponseOutputWithContext(ctx context.Context) AttestationEvidenceResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttestationEvidenceResponseOutput)
}

// AttestationEvidenceResponseArrayInput is an input type that accepts AttestationEvidenceResponseArray and AttestationEvidenceResponseArrayOutput values.
// You can construct a concrete instance of `AttestationEvidenceResponseArrayInput` via:
//
//          AttestationEvidenceResponseArray{ AttestationEvidenceResponseArgs{...} }
type AttestationEvidenceResponseArrayInput interface {
	pulumi.Input

	ToAttestationEvidenceResponseArrayOutput() AttestationEvidenceResponseArrayOutput
	ToAttestationEvidenceResponseArrayOutputWithContext(context.Context) AttestationEvidenceResponseArrayOutput
}

type AttestationEvidenceResponseArray []AttestationEvidenceResponseInput

func (AttestationEvidenceResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AttestationEvidenceResponse)(nil)).Elem()
}

func (i AttestationEvidenceResponseArray) ToAttestationEvidenceResponseArrayOutput() AttestationEvidenceResponseArrayOutput {
	return i.ToAttestationEvidenceResponseArrayOutputWithContext(context.Background())
}

func (i AttestationEvidenceResponseArray) ToAttestationEvidenceResponseArrayOutputWithContext(ctx context.Context) AttestationEvidenceResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AttestationEvidenceResponseArrayOutput)
}

// A piece of evidence supporting the compliance state set in the attestation.
type AttestationEvidenceResponseOutput struct{ *pulumi.OutputState }

func (AttestationEvidenceResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AttestationEvidenceResponse)(nil)).Elem()
}

func (o AttestationEvidenceResponseOutput) ToAttestationEvidenceResponseOutput() AttestationEvidenceResponseOutput {
	return o
}

func (o AttestationEvidenceResponseOutput) ToAttestationEvidenceResponseOutputWithContext(ctx context.Context) AttestationEvidenceResponseOutput {
	return o
}

// The description for this piece of evidence.
func (o AttestationEvidenceResponseOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AttestationEvidenceResponse) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// The URI location of the evidence.
func (o AttestationEvidenceResponseOutput) SourceUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AttestationEvidenceResponse) *string { return v.SourceUri }).(pulumi.StringPtrOutput)
}

type AttestationEvidenceResponseArrayOutput struct{ *pulumi.OutputState }

func (AttestationEvidenceResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AttestationEvidenceResponse)(nil)).Elem()
}

func (o AttestationEvidenceResponseArrayOutput) ToAttestationEvidenceResponseArrayOutput() AttestationEvidenceResponseArrayOutput {
	return o
}

func (o AttestationEvidenceResponseArrayOutput) ToAttestationEvidenceResponseArrayOutputWithContext(ctx context.Context) AttestationEvidenceResponseArrayOutput {
	return o
}

func (o AttestationEvidenceResponseArrayOutput) Index(i pulumi.IntInput) AttestationEvidenceResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AttestationEvidenceResponse {
		return vs[0].([]AttestationEvidenceResponse)[vs[1].(int)]
	}).(AttestationEvidenceResponseOutput)
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponse struct {
	// The timestamp of resource creation (UTC).
	CreatedAt *string `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy *string `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType *string `pulumi:"createdByType"`
	// The timestamp of resource last modification (UTC)
	LastModifiedAt *string `pulumi:"lastModifiedAt"`
	// The identity that last modified the resource.
	LastModifiedBy *string `pulumi:"lastModifiedBy"`
	// The type of identity that last modified the resource.
	LastModifiedByType *string `pulumi:"lastModifiedByType"`
}

// SystemDataResponseInput is an input type that accepts SystemDataResponseArgs and SystemDataResponseOutput values.
// You can construct a concrete instance of `SystemDataResponseInput` via:
//
//          SystemDataResponseArgs{...}
type SystemDataResponseInput interface {
	pulumi.Input

	ToSystemDataResponseOutput() SystemDataResponseOutput
	ToSystemDataResponseOutputWithContext(context.Context) SystemDataResponseOutput
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponseArgs struct {
	// The timestamp of resource creation (UTC).
	CreatedAt pulumi.StringPtrInput `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy pulumi.StringPtrInput `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType pulumi.StringPtrInput `pulumi:"createdByType"`
	// The timestamp of resource last modification (UTC)
	LastModifiedAt pulumi.StringPtrInput `pulumi:"lastModifiedAt"`
	// The identity that last modified the resource.
	LastModifiedBy pulumi.StringPtrInput `pulumi:"lastModifiedBy"`
	// The type of identity that last modified the resource.
	LastModifiedByType pulumi.StringPtrInput `pulumi:"lastModifiedByType"`
}

func (SystemDataResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SystemDataResponse)(nil)).Elem()
}

func (i SystemDataResponseArgs) ToSystemDataResponseOutput() SystemDataResponseOutput {
	return i.ToSystemDataResponseOutputWithContext(context.Background())
}

func (i SystemDataResponseArgs) ToSystemDataResponseOutputWithContext(ctx context.Context) SystemDataResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SystemDataResponseOutput)
}

func (i SystemDataResponseArgs) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return i.ToSystemDataResponsePtrOutputWithContext(context.Background())
}

func (i SystemDataResponseArgs) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SystemDataResponseOutput).ToSystemDataResponsePtrOutputWithContext(ctx)
}

// SystemDataResponsePtrInput is an input type that accepts SystemDataResponseArgs, SystemDataResponsePtr and SystemDataResponsePtrOutput values.
// You can construct a concrete instance of `SystemDataResponsePtrInput` via:
//
//          SystemDataResponseArgs{...}
//
//  or:
//
//          nil
type SystemDataResponsePtrInput interface {
	pulumi.Input

	ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput
	ToSystemDataResponsePtrOutputWithContext(context.Context) SystemDataResponsePtrOutput
}

type systemDataResponsePtrType SystemDataResponseArgs

func SystemDataResponsePtr(v *SystemDataResponseArgs) SystemDataResponsePtrInput {
	return (*systemDataResponsePtrType)(v)
}

func (*systemDataResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SystemDataResponse)(nil)).Elem()
}

func (i *systemDataResponsePtrType) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return i.ToSystemDataResponsePtrOutputWithContext(context.Background())
}

func (i *systemDataResponsePtrType) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SystemDataResponsePtrOutput)
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponseOutput struct{ *pulumi.OutputState }

func (SystemDataResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SystemDataResponse)(nil)).Elem()
}

func (o SystemDataResponseOutput) ToSystemDataResponseOutput() SystemDataResponseOutput {
	return o
}

func (o SystemDataResponseOutput) ToSystemDataResponseOutputWithContext(ctx context.Context) SystemDataResponseOutput {
	return o
}

func (o SystemDataResponseOutput) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return o.ToSystemDataResponsePtrOutputWithContext(context.Background())
}

func (o SystemDataResponseOutput) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *SystemDataResponse {
		return &v
	}).(SystemDataResponsePtrOutput)
}

// The timestamp of resource creation (UTC).
func (o SystemDataResponseOutput) CreatedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedAt }).(pulumi.StringPtrOutput)
}

// The identity that created the resource.
func (o SystemDataResponseOutput) CreatedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that created the resource.
func (o SystemDataResponseOutput) CreatedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedByType }).(pulumi.StringPtrOutput)
}

// The timestamp of resource last modification (UTC)
func (o SystemDataResponseOutput) LastModifiedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedAt }).(pulumi.StringPtrOutput)
}

// The identity that last modified the resource.
func (o SystemDataResponseOutput) LastModifiedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o SystemDataResponseOutput) LastModifiedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedByType }).(pulumi.StringPtrOutput)
}

type SystemDataResponsePtrOutput struct{ *pulumi.OutputState }

func (SystemDataResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SystemDataResponse)(nil)).Elem()
}

func (o SystemDataResponsePtrOutput) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return o
}

func (o SystemDataResponsePtrOutput) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return o
}

func (o SystemDataResponsePtrOutput) Elem() SystemDataResponseOutput {
	return o.ApplyT(func(v *SystemDataResponse) SystemDataResponse { return *v }).(SystemDataResponseOutput)
}

// The timestamp of resource creation (UTC).
func (o SystemDataResponsePtrOutput) CreatedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.CreatedAt
	}).(pulumi.StringPtrOutput)
}

// The identity that created the resource.
func (o SystemDataResponsePtrOutput) CreatedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.CreatedBy
	}).(pulumi.StringPtrOutput)
}

// The type of identity that created the resource.
func (o SystemDataResponsePtrOutput) CreatedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.CreatedByType
	}).(pulumi.StringPtrOutput)
}

// The timestamp of resource last modification (UTC)
func (o SystemDataResponsePtrOutput) LastModifiedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.LastModifiedAt
	}).(pulumi.StringPtrOutput)
}

// The identity that last modified the resource.
func (o SystemDataResponsePtrOutput) LastModifiedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.LastModifiedBy
	}).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o SystemDataResponsePtrOutput) LastModifiedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.LastModifiedByType
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(AttestationEvidenceOutput{})
	pulumi.RegisterOutputType(AttestationEvidenceArrayOutput{})
	pulumi.RegisterOutputType(AttestationEvidenceResponseOutput{})
	pulumi.RegisterOutputType(AttestationEvidenceResponseArrayOutput{})
	pulumi.RegisterOutputType(SystemDataResponseOutput{})
	pulumi.RegisterOutputType(SystemDataResponsePtrOutput{})
}
