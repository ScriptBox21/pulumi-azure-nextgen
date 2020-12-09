// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Key Vault container for a certificate that is purchased through Azure.
type AppServiceCertificate struct {
	// Key Vault resource Id.
	KeyVaultId *string `pulumi:"keyVaultId"`
	// Key Vault secret name.
	KeyVaultSecretName *string `pulumi:"keyVaultSecretName"`
}

// AppServiceCertificateInput is an input type that accepts AppServiceCertificateArgs and AppServiceCertificateOutput values.
// You can construct a concrete instance of `AppServiceCertificateInput` via:
//
//          AppServiceCertificateArgs{...}
type AppServiceCertificateInput interface {
	pulumi.Input

	ToAppServiceCertificateOutput() AppServiceCertificateOutput
	ToAppServiceCertificateOutputWithContext(context.Context) AppServiceCertificateOutput
}

// Key Vault container for a certificate that is purchased through Azure.
type AppServiceCertificateArgs struct {
	// Key Vault resource Id.
	KeyVaultId pulumi.StringPtrInput `pulumi:"keyVaultId"`
	// Key Vault secret name.
	KeyVaultSecretName pulumi.StringPtrInput `pulumi:"keyVaultSecretName"`
}

func (AppServiceCertificateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificate)(nil)).Elem()
}

func (i AppServiceCertificateArgs) ToAppServiceCertificateOutput() AppServiceCertificateOutput {
	return i.ToAppServiceCertificateOutputWithContext(context.Background())
}

func (i AppServiceCertificateArgs) ToAppServiceCertificateOutputWithContext(ctx context.Context) AppServiceCertificateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AppServiceCertificateOutput)
}

// AppServiceCertificateMapInput is an input type that accepts AppServiceCertificateMap and AppServiceCertificateMapOutput values.
// You can construct a concrete instance of `AppServiceCertificateMapInput` via:
//
//          AppServiceCertificateMap{ "key": AppServiceCertificateArgs{...} }
type AppServiceCertificateMapInput interface {
	pulumi.Input

	ToAppServiceCertificateMapOutput() AppServiceCertificateMapOutput
	ToAppServiceCertificateMapOutputWithContext(context.Context) AppServiceCertificateMapOutput
}

type AppServiceCertificateMap map[string]AppServiceCertificateInput

func (AppServiceCertificateMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]AppServiceCertificate)(nil)).Elem()
}

func (i AppServiceCertificateMap) ToAppServiceCertificateMapOutput() AppServiceCertificateMapOutput {
	return i.ToAppServiceCertificateMapOutputWithContext(context.Background())
}

func (i AppServiceCertificateMap) ToAppServiceCertificateMapOutputWithContext(ctx context.Context) AppServiceCertificateMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AppServiceCertificateMapOutput)
}

// Key Vault container for a certificate that is purchased through Azure.
type AppServiceCertificateOutput struct{ *pulumi.OutputState }

func (AppServiceCertificateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificate)(nil)).Elem()
}

func (o AppServiceCertificateOutput) ToAppServiceCertificateOutput() AppServiceCertificateOutput {
	return o
}

func (o AppServiceCertificateOutput) ToAppServiceCertificateOutputWithContext(ctx context.Context) AppServiceCertificateOutput {
	return o
}

// Key Vault resource Id.
func (o AppServiceCertificateOutput) KeyVaultId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AppServiceCertificate) *string { return v.KeyVaultId }).(pulumi.StringPtrOutput)
}

// Key Vault secret name.
func (o AppServiceCertificateOutput) KeyVaultSecretName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AppServiceCertificate) *string { return v.KeyVaultSecretName }).(pulumi.StringPtrOutput)
}

type AppServiceCertificateMapOutput struct{ *pulumi.OutputState }

func (AppServiceCertificateMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]AppServiceCertificate)(nil)).Elem()
}

func (o AppServiceCertificateMapOutput) ToAppServiceCertificateMapOutput() AppServiceCertificateMapOutput {
	return o
}

func (o AppServiceCertificateMapOutput) ToAppServiceCertificateMapOutputWithContext(ctx context.Context) AppServiceCertificateMapOutput {
	return o
}

func (o AppServiceCertificateMapOutput) MapIndex(k pulumi.StringInput) AppServiceCertificateOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) AppServiceCertificate {
		return vs[0].(map[string]AppServiceCertificate)[vs[1].(string)]
	}).(AppServiceCertificateOutput)
}

// Key Vault container for a certificate that is purchased through Azure.
type AppServiceCertificateResponse struct {
	// Key Vault resource Id.
	KeyVaultId *string `pulumi:"keyVaultId"`
	// Key Vault secret name.
	KeyVaultSecretName *string `pulumi:"keyVaultSecretName"`
	// Status of the Key Vault secret.
	ProvisioningState string `pulumi:"provisioningState"`
}

// AppServiceCertificateResponseInput is an input type that accepts AppServiceCertificateResponseArgs and AppServiceCertificateResponseOutput values.
// You can construct a concrete instance of `AppServiceCertificateResponseInput` via:
//
//          AppServiceCertificateResponseArgs{...}
type AppServiceCertificateResponseInput interface {
	pulumi.Input

	ToAppServiceCertificateResponseOutput() AppServiceCertificateResponseOutput
	ToAppServiceCertificateResponseOutputWithContext(context.Context) AppServiceCertificateResponseOutput
}

// Key Vault container for a certificate that is purchased through Azure.
type AppServiceCertificateResponseArgs struct {
	// Key Vault resource Id.
	KeyVaultId pulumi.StringPtrInput `pulumi:"keyVaultId"`
	// Key Vault secret name.
	KeyVaultSecretName pulumi.StringPtrInput `pulumi:"keyVaultSecretName"`
	// Status of the Key Vault secret.
	ProvisioningState pulumi.StringInput `pulumi:"provisioningState"`
}

func (AppServiceCertificateResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificateResponse)(nil)).Elem()
}

func (i AppServiceCertificateResponseArgs) ToAppServiceCertificateResponseOutput() AppServiceCertificateResponseOutput {
	return i.ToAppServiceCertificateResponseOutputWithContext(context.Background())
}

func (i AppServiceCertificateResponseArgs) ToAppServiceCertificateResponseOutputWithContext(ctx context.Context) AppServiceCertificateResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AppServiceCertificateResponseOutput)
}

// AppServiceCertificateResponseMapInput is an input type that accepts AppServiceCertificateResponseMap and AppServiceCertificateResponseMapOutput values.
// You can construct a concrete instance of `AppServiceCertificateResponseMapInput` via:
//
//          AppServiceCertificateResponseMap{ "key": AppServiceCertificateResponseArgs{...} }
type AppServiceCertificateResponseMapInput interface {
	pulumi.Input

	ToAppServiceCertificateResponseMapOutput() AppServiceCertificateResponseMapOutput
	ToAppServiceCertificateResponseMapOutputWithContext(context.Context) AppServiceCertificateResponseMapOutput
}

type AppServiceCertificateResponseMap map[string]AppServiceCertificateResponseInput

func (AppServiceCertificateResponseMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]AppServiceCertificateResponse)(nil)).Elem()
}

func (i AppServiceCertificateResponseMap) ToAppServiceCertificateResponseMapOutput() AppServiceCertificateResponseMapOutput {
	return i.ToAppServiceCertificateResponseMapOutputWithContext(context.Background())
}

func (i AppServiceCertificateResponseMap) ToAppServiceCertificateResponseMapOutputWithContext(ctx context.Context) AppServiceCertificateResponseMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AppServiceCertificateResponseMapOutput)
}

// Key Vault container for a certificate that is purchased through Azure.
type AppServiceCertificateResponseOutput struct{ *pulumi.OutputState }

func (AppServiceCertificateResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificateResponse)(nil)).Elem()
}

func (o AppServiceCertificateResponseOutput) ToAppServiceCertificateResponseOutput() AppServiceCertificateResponseOutput {
	return o
}

func (o AppServiceCertificateResponseOutput) ToAppServiceCertificateResponseOutputWithContext(ctx context.Context) AppServiceCertificateResponseOutput {
	return o
}

// Key Vault resource Id.
func (o AppServiceCertificateResponseOutput) KeyVaultId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AppServiceCertificateResponse) *string { return v.KeyVaultId }).(pulumi.StringPtrOutput)
}

// Key Vault secret name.
func (o AppServiceCertificateResponseOutput) KeyVaultSecretName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AppServiceCertificateResponse) *string { return v.KeyVaultSecretName }).(pulumi.StringPtrOutput)
}

// Status of the Key Vault secret.
func (o AppServiceCertificateResponseOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v AppServiceCertificateResponse) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

type AppServiceCertificateResponseMapOutput struct{ *pulumi.OutputState }

func (AppServiceCertificateResponseMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]AppServiceCertificateResponse)(nil)).Elem()
}

func (o AppServiceCertificateResponseMapOutput) ToAppServiceCertificateResponseMapOutput() AppServiceCertificateResponseMapOutput {
	return o
}

func (o AppServiceCertificateResponseMapOutput) ToAppServiceCertificateResponseMapOutputWithContext(ctx context.Context) AppServiceCertificateResponseMapOutput {
	return o
}

func (o AppServiceCertificateResponseMapOutput) MapIndex(k pulumi.StringInput) AppServiceCertificateResponseOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) AppServiceCertificateResponse {
		return vs[0].(map[string]AppServiceCertificateResponse)[vs[1].(string)]
	}).(AppServiceCertificateResponseOutput)
}

// SSL certificate details.
type CertificateDetailsResponse struct {
	// Certificate Issuer.
	Issuer string `pulumi:"issuer"`
	// Date Certificate is valid to.
	NotAfter string `pulumi:"notAfter"`
	// Date Certificate is valid from.
	NotBefore string `pulumi:"notBefore"`
	// Raw certificate data.
	RawData string `pulumi:"rawData"`
	// Certificate Serial Number.
	SerialNumber string `pulumi:"serialNumber"`
	// Certificate Signature algorithm.
	SignatureAlgorithm string `pulumi:"signatureAlgorithm"`
	// Certificate Subject.
	Subject string `pulumi:"subject"`
	// Certificate Thumbprint.
	Thumbprint string `pulumi:"thumbprint"`
	// Certificate Version.
	Version int `pulumi:"version"`
}

// CertificateDetailsResponseInput is an input type that accepts CertificateDetailsResponseArgs and CertificateDetailsResponseOutput values.
// You can construct a concrete instance of `CertificateDetailsResponseInput` via:
//
//          CertificateDetailsResponseArgs{...}
type CertificateDetailsResponseInput interface {
	pulumi.Input

	ToCertificateDetailsResponseOutput() CertificateDetailsResponseOutput
	ToCertificateDetailsResponseOutputWithContext(context.Context) CertificateDetailsResponseOutput
}

// SSL certificate details.
type CertificateDetailsResponseArgs struct {
	// Certificate Issuer.
	Issuer pulumi.StringInput `pulumi:"issuer"`
	// Date Certificate is valid to.
	NotAfter pulumi.StringInput `pulumi:"notAfter"`
	// Date Certificate is valid from.
	NotBefore pulumi.StringInput `pulumi:"notBefore"`
	// Raw certificate data.
	RawData pulumi.StringInput `pulumi:"rawData"`
	// Certificate Serial Number.
	SerialNumber pulumi.StringInput `pulumi:"serialNumber"`
	// Certificate Signature algorithm.
	SignatureAlgorithm pulumi.StringInput `pulumi:"signatureAlgorithm"`
	// Certificate Subject.
	Subject pulumi.StringInput `pulumi:"subject"`
	// Certificate Thumbprint.
	Thumbprint pulumi.StringInput `pulumi:"thumbprint"`
	// Certificate Version.
	Version pulumi.IntInput `pulumi:"version"`
}

func (CertificateDetailsResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*CertificateDetailsResponse)(nil)).Elem()
}

func (i CertificateDetailsResponseArgs) ToCertificateDetailsResponseOutput() CertificateDetailsResponseOutput {
	return i.ToCertificateDetailsResponseOutputWithContext(context.Background())
}

func (i CertificateDetailsResponseArgs) ToCertificateDetailsResponseOutputWithContext(ctx context.Context) CertificateDetailsResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CertificateDetailsResponseOutput)
}

func (i CertificateDetailsResponseArgs) ToCertificateDetailsResponsePtrOutput() CertificateDetailsResponsePtrOutput {
	return i.ToCertificateDetailsResponsePtrOutputWithContext(context.Background())
}

func (i CertificateDetailsResponseArgs) ToCertificateDetailsResponsePtrOutputWithContext(ctx context.Context) CertificateDetailsResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CertificateDetailsResponseOutput).ToCertificateDetailsResponsePtrOutputWithContext(ctx)
}

// CertificateDetailsResponsePtrInput is an input type that accepts CertificateDetailsResponseArgs, CertificateDetailsResponsePtr and CertificateDetailsResponsePtrOutput values.
// You can construct a concrete instance of `CertificateDetailsResponsePtrInput` via:
//
//          CertificateDetailsResponseArgs{...}
//
//  or:
//
//          nil
type CertificateDetailsResponsePtrInput interface {
	pulumi.Input

	ToCertificateDetailsResponsePtrOutput() CertificateDetailsResponsePtrOutput
	ToCertificateDetailsResponsePtrOutputWithContext(context.Context) CertificateDetailsResponsePtrOutput
}

type certificateDetailsResponsePtrType CertificateDetailsResponseArgs

func CertificateDetailsResponsePtr(v *CertificateDetailsResponseArgs) CertificateDetailsResponsePtrInput {
	return (*certificateDetailsResponsePtrType)(v)
}

func (*certificateDetailsResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**CertificateDetailsResponse)(nil)).Elem()
}

func (i *certificateDetailsResponsePtrType) ToCertificateDetailsResponsePtrOutput() CertificateDetailsResponsePtrOutput {
	return i.ToCertificateDetailsResponsePtrOutputWithContext(context.Background())
}

func (i *certificateDetailsResponsePtrType) ToCertificateDetailsResponsePtrOutputWithContext(ctx context.Context) CertificateDetailsResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CertificateDetailsResponsePtrOutput)
}

// SSL certificate details.
type CertificateDetailsResponseOutput struct{ *pulumi.OutputState }

func (CertificateDetailsResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CertificateDetailsResponse)(nil)).Elem()
}

func (o CertificateDetailsResponseOutput) ToCertificateDetailsResponseOutput() CertificateDetailsResponseOutput {
	return o
}

func (o CertificateDetailsResponseOutput) ToCertificateDetailsResponseOutputWithContext(ctx context.Context) CertificateDetailsResponseOutput {
	return o
}

func (o CertificateDetailsResponseOutput) ToCertificateDetailsResponsePtrOutput() CertificateDetailsResponsePtrOutput {
	return o.ToCertificateDetailsResponsePtrOutputWithContext(context.Background())
}

func (o CertificateDetailsResponseOutput) ToCertificateDetailsResponsePtrOutputWithContext(ctx context.Context) CertificateDetailsResponsePtrOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) *CertificateDetailsResponse {
		return &v
	}).(CertificateDetailsResponsePtrOutput)
}

// Certificate Issuer.
func (o CertificateDetailsResponseOutput) Issuer() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.Issuer }).(pulumi.StringOutput)
}

// Date Certificate is valid to.
func (o CertificateDetailsResponseOutput) NotAfter() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.NotAfter }).(pulumi.StringOutput)
}

// Date Certificate is valid from.
func (o CertificateDetailsResponseOutput) NotBefore() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.NotBefore }).(pulumi.StringOutput)
}

// Raw certificate data.
func (o CertificateDetailsResponseOutput) RawData() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.RawData }).(pulumi.StringOutput)
}

// Certificate Serial Number.
func (o CertificateDetailsResponseOutput) SerialNumber() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.SerialNumber }).(pulumi.StringOutput)
}

// Certificate Signature algorithm.
func (o CertificateDetailsResponseOutput) SignatureAlgorithm() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.SignatureAlgorithm }).(pulumi.StringOutput)
}

// Certificate Subject.
func (o CertificateDetailsResponseOutput) Subject() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.Subject }).(pulumi.StringOutput)
}

// Certificate Thumbprint.
func (o CertificateDetailsResponseOutput) Thumbprint() pulumi.StringOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) string { return v.Thumbprint }).(pulumi.StringOutput)
}

// Certificate Version.
func (o CertificateDetailsResponseOutput) Version() pulumi.IntOutput {
	return o.ApplyT(func(v CertificateDetailsResponse) int { return v.Version }).(pulumi.IntOutput)
}

type CertificateDetailsResponsePtrOutput struct{ *pulumi.OutputState }

func (CertificateDetailsResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CertificateDetailsResponse)(nil)).Elem()
}

func (o CertificateDetailsResponsePtrOutput) ToCertificateDetailsResponsePtrOutput() CertificateDetailsResponsePtrOutput {
	return o
}

func (o CertificateDetailsResponsePtrOutput) ToCertificateDetailsResponsePtrOutputWithContext(ctx context.Context) CertificateDetailsResponsePtrOutput {
	return o
}

func (o CertificateDetailsResponsePtrOutput) Elem() CertificateDetailsResponseOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) CertificateDetailsResponse { return *v }).(CertificateDetailsResponseOutput)
}

// Certificate Issuer.
func (o CertificateDetailsResponsePtrOutput) Issuer() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.Issuer
	}).(pulumi.StringPtrOutput)
}

// Date Certificate is valid to.
func (o CertificateDetailsResponsePtrOutput) NotAfter() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.NotAfter
	}).(pulumi.StringPtrOutput)
}

// Date Certificate is valid from.
func (o CertificateDetailsResponsePtrOutput) NotBefore() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.NotBefore
	}).(pulumi.StringPtrOutput)
}

// Raw certificate data.
func (o CertificateDetailsResponsePtrOutput) RawData() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.RawData
	}).(pulumi.StringPtrOutput)
}

// Certificate Serial Number.
func (o CertificateDetailsResponsePtrOutput) SerialNumber() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.SerialNumber
	}).(pulumi.StringPtrOutput)
}

// Certificate Signature algorithm.
func (o CertificateDetailsResponsePtrOutput) SignatureAlgorithm() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.SignatureAlgorithm
	}).(pulumi.StringPtrOutput)
}

// Certificate Subject.
func (o CertificateDetailsResponsePtrOutput) Subject() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.Subject
	}).(pulumi.StringPtrOutput)
}

// Certificate Thumbprint.
func (o CertificateDetailsResponsePtrOutput) Thumbprint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *string {
		if v == nil {
			return nil
		}
		return &v.Thumbprint
	}).(pulumi.StringPtrOutput)
}

// Certificate Version.
func (o CertificateDetailsResponsePtrOutput) Version() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *CertificateDetailsResponse) *int {
		if v == nil {
			return nil
		}
		return &v.Version
	}).(pulumi.IntPtrOutput)
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponse struct {
	// The timestamp of resource creation (UTC).
	CreatedAt *string `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy *string `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType *string `pulumi:"createdByType"`
	// The type of identity that last modified the resource.
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
	// The type of identity that last modified the resource.
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

// The type of identity that last modified the resource.
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

// The type of identity that last modified the resource.
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
	pulumi.RegisterOutputType(AppServiceCertificateOutput{})
	pulumi.RegisterOutputType(AppServiceCertificateMapOutput{})
	pulumi.RegisterOutputType(AppServiceCertificateResponseOutput{})
	pulumi.RegisterOutputType(AppServiceCertificateResponseMapOutput{})
	pulumi.RegisterOutputType(CertificateDetailsResponseOutput{})
	pulumi.RegisterOutputType(CertificateDetailsResponsePtrOutput{})
	pulumi.RegisterOutputType(SystemDataResponseOutput{})
	pulumi.RegisterOutputType(SystemDataResponsePtrOutput{})
}
