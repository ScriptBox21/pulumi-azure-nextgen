// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190318preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ErrorDetailResponse struct {
	// The error's code.
	Code string `pulumi:"code"`
	// Additional error details.
	Details []ErrorDetailResponse `pulumi:"details"`
	// A human readable error message.
	Message string `pulumi:"message"`
	// Indicates which property in the request is responsible for the error.
	Target *string `pulumi:"target"`
}

// ErrorDetailResponseInput is an input type that accepts ErrorDetailResponseArgs and ErrorDetailResponseOutput values.
// You can construct a concrete instance of `ErrorDetailResponseInput` via:
//
//          ErrorDetailResponseArgs{...}
type ErrorDetailResponseInput interface {
	pulumi.Input

	ToErrorDetailResponseOutput() ErrorDetailResponseOutput
	ToErrorDetailResponseOutputWithContext(context.Context) ErrorDetailResponseOutput
}

type ErrorDetailResponseArgs struct {
	// The error's code.
	Code pulumi.StringInput `pulumi:"code"`
	// Additional error details.
	Details ErrorDetailResponseArrayInput `pulumi:"details"`
	// A human readable error message.
	Message pulumi.StringInput `pulumi:"message"`
	// Indicates which property in the request is responsible for the error.
	Target pulumi.StringPtrInput `pulumi:"target"`
}

func (ErrorDetailResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ErrorDetailResponse)(nil)).Elem()
}

func (i ErrorDetailResponseArgs) ToErrorDetailResponseOutput() ErrorDetailResponseOutput {
	return i.ToErrorDetailResponseOutputWithContext(context.Background())
}

func (i ErrorDetailResponseArgs) ToErrorDetailResponseOutputWithContext(ctx context.Context) ErrorDetailResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ErrorDetailResponseOutput)
}

// ErrorDetailResponseArrayInput is an input type that accepts ErrorDetailResponseArray and ErrorDetailResponseArrayOutput values.
// You can construct a concrete instance of `ErrorDetailResponseArrayInput` via:
//
//          ErrorDetailResponseArray{ ErrorDetailResponseArgs{...} }
type ErrorDetailResponseArrayInput interface {
	pulumi.Input

	ToErrorDetailResponseArrayOutput() ErrorDetailResponseArrayOutput
	ToErrorDetailResponseArrayOutputWithContext(context.Context) ErrorDetailResponseArrayOutput
}

type ErrorDetailResponseArray []ErrorDetailResponseInput

func (ErrorDetailResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ErrorDetailResponse)(nil)).Elem()
}

func (i ErrorDetailResponseArray) ToErrorDetailResponseArrayOutput() ErrorDetailResponseArrayOutput {
	return i.ToErrorDetailResponseArrayOutputWithContext(context.Background())
}

func (i ErrorDetailResponseArray) ToErrorDetailResponseArrayOutputWithContext(ctx context.Context) ErrorDetailResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ErrorDetailResponseArrayOutput)
}

type ErrorDetailResponseOutput struct{ *pulumi.OutputState }

func (ErrorDetailResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ErrorDetailResponse)(nil)).Elem()
}

func (o ErrorDetailResponseOutput) ToErrorDetailResponseOutput() ErrorDetailResponseOutput {
	return o
}

func (o ErrorDetailResponseOutput) ToErrorDetailResponseOutputWithContext(ctx context.Context) ErrorDetailResponseOutput {
	return o
}

// The error's code.
func (o ErrorDetailResponseOutput) Code() pulumi.StringOutput {
	return o.ApplyT(func(v ErrorDetailResponse) string { return v.Code }).(pulumi.StringOutput)
}

// Additional error details.
func (o ErrorDetailResponseOutput) Details() ErrorDetailResponseArrayOutput {
	return o.ApplyT(func(v ErrorDetailResponse) []ErrorDetailResponse { return v.Details }).(ErrorDetailResponseArrayOutput)
}

// A human readable error message.
func (o ErrorDetailResponseOutput) Message() pulumi.StringOutput {
	return o.ApplyT(func(v ErrorDetailResponse) string { return v.Message }).(pulumi.StringOutput)
}

// Indicates which property in the request is responsible for the error.
func (o ErrorDetailResponseOutput) Target() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ErrorDetailResponse) *string { return v.Target }).(pulumi.StringPtrOutput)
}

type ErrorDetailResponseArrayOutput struct{ *pulumi.OutputState }

func (ErrorDetailResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ErrorDetailResponse)(nil)).Elem()
}

func (o ErrorDetailResponseArrayOutput) ToErrorDetailResponseArrayOutput() ErrorDetailResponseArrayOutput {
	return o
}

func (o ErrorDetailResponseArrayOutput) ToErrorDetailResponseArrayOutputWithContext(ctx context.Context) ErrorDetailResponseArrayOutput {
	return o
}

func (o ErrorDetailResponseArrayOutput) Index(i pulumi.IntInput) ErrorDetailResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ErrorDetailResponse {
		return vs[0].([]ErrorDetailResponse)[vs[1].(int)]
	}).(ErrorDetailResponseOutput)
}

// Specifies the operating system settings for the hybrid machine.
type OSProfileResponse struct {
	// Specifies the host OS name of the hybrid machine.
	ComputerName string `pulumi:"computerName"`
}

// OSProfileResponseInput is an input type that accepts OSProfileResponseArgs and OSProfileResponseOutput values.
// You can construct a concrete instance of `OSProfileResponseInput` via:
//
//          OSProfileResponseArgs{...}
type OSProfileResponseInput interface {
	pulumi.Input

	ToOSProfileResponseOutput() OSProfileResponseOutput
	ToOSProfileResponseOutputWithContext(context.Context) OSProfileResponseOutput
}

// Specifies the operating system settings for the hybrid machine.
type OSProfileResponseArgs struct {
	// Specifies the host OS name of the hybrid machine.
	ComputerName pulumi.StringInput `pulumi:"computerName"`
}

func (OSProfileResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*OSProfileResponse)(nil)).Elem()
}

func (i OSProfileResponseArgs) ToOSProfileResponseOutput() OSProfileResponseOutput {
	return i.ToOSProfileResponseOutputWithContext(context.Background())
}

func (i OSProfileResponseArgs) ToOSProfileResponseOutputWithContext(ctx context.Context) OSProfileResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OSProfileResponseOutput)
}

func (i OSProfileResponseArgs) ToOSProfileResponsePtrOutput() OSProfileResponsePtrOutput {
	return i.ToOSProfileResponsePtrOutputWithContext(context.Background())
}

func (i OSProfileResponseArgs) ToOSProfileResponsePtrOutputWithContext(ctx context.Context) OSProfileResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OSProfileResponseOutput).ToOSProfileResponsePtrOutputWithContext(ctx)
}

// OSProfileResponsePtrInput is an input type that accepts OSProfileResponseArgs, OSProfileResponsePtr and OSProfileResponsePtrOutput values.
// You can construct a concrete instance of `OSProfileResponsePtrInput` via:
//
//          OSProfileResponseArgs{...}
//
//  or:
//
//          nil
type OSProfileResponsePtrInput interface {
	pulumi.Input

	ToOSProfileResponsePtrOutput() OSProfileResponsePtrOutput
	ToOSProfileResponsePtrOutputWithContext(context.Context) OSProfileResponsePtrOutput
}

type osprofileResponsePtrType OSProfileResponseArgs

func OSProfileResponsePtr(v *OSProfileResponseArgs) OSProfileResponsePtrInput {
	return (*osprofileResponsePtrType)(v)
}

func (*osprofileResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**OSProfileResponse)(nil)).Elem()
}

func (i *osprofileResponsePtrType) ToOSProfileResponsePtrOutput() OSProfileResponsePtrOutput {
	return i.ToOSProfileResponsePtrOutputWithContext(context.Background())
}

func (i *osprofileResponsePtrType) ToOSProfileResponsePtrOutputWithContext(ctx context.Context) OSProfileResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OSProfileResponsePtrOutput)
}

// Specifies the operating system settings for the hybrid machine.
type OSProfileResponseOutput struct{ *pulumi.OutputState }

func (OSProfileResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OSProfileResponse)(nil)).Elem()
}

func (o OSProfileResponseOutput) ToOSProfileResponseOutput() OSProfileResponseOutput {
	return o
}

func (o OSProfileResponseOutput) ToOSProfileResponseOutputWithContext(ctx context.Context) OSProfileResponseOutput {
	return o
}

func (o OSProfileResponseOutput) ToOSProfileResponsePtrOutput() OSProfileResponsePtrOutput {
	return o.ToOSProfileResponsePtrOutputWithContext(context.Background())
}

func (o OSProfileResponseOutput) ToOSProfileResponsePtrOutputWithContext(ctx context.Context) OSProfileResponsePtrOutput {
	return o.ApplyT(func(v OSProfileResponse) *OSProfileResponse {
		return &v
	}).(OSProfileResponsePtrOutput)
}

// Specifies the host OS name of the hybrid machine.
func (o OSProfileResponseOutput) ComputerName() pulumi.StringOutput {
	return o.ApplyT(func(v OSProfileResponse) string { return v.ComputerName }).(pulumi.StringOutput)
}

type OSProfileResponsePtrOutput struct{ *pulumi.OutputState }

func (OSProfileResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OSProfileResponse)(nil)).Elem()
}

func (o OSProfileResponsePtrOutput) ToOSProfileResponsePtrOutput() OSProfileResponsePtrOutput {
	return o
}

func (o OSProfileResponsePtrOutput) ToOSProfileResponsePtrOutputWithContext(ctx context.Context) OSProfileResponsePtrOutput {
	return o
}

func (o OSProfileResponsePtrOutput) Elem() OSProfileResponseOutput {
	return o.ApplyT(func(v *OSProfileResponse) OSProfileResponse { return *v }).(OSProfileResponseOutput)
}

// Specifies the host OS name of the hybrid machine.
func (o OSProfileResponsePtrOutput) ComputerName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OSProfileResponse) *string {
		if v == nil {
			return nil
		}
		return &v.ComputerName
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(ErrorDetailResponseOutput{})
	pulumi.RegisterOutputType(ErrorDetailResponseArrayOutput{})
	pulumi.RegisterOutputType(OSProfileResponseOutput{})
	pulumi.RegisterOutputType(OSProfileResponsePtrOutput{})
}