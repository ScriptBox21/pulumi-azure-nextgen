// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Key Vault container ARM resource for a certificate that is purchased through Azure.
type AppServiceCertificateOrderCertificate struct {
	pulumi.CustomResourceState

	// Key Vault resource Id.
	KeyVaultId pulumi.StringPtrOutput `pulumi:"keyVaultId"`
	// Key Vault secret name.
	KeyVaultSecretName pulumi.StringPtrOutput `pulumi:"keyVaultSecretName"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Status of the Key Vault secret.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewAppServiceCertificateOrderCertificate registers a new resource with the given unique name, arguments, and options.
func NewAppServiceCertificateOrderCertificate(ctx *pulumi.Context,
	name string, args *AppServiceCertificateOrderCertificateArgs, opts ...pulumi.ResourceOption) (*AppServiceCertificateOrderCertificate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CertificateOrderName == nil {
		return nil, errors.New("invalid value for required argument 'CertificateOrderName'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/latest:AppServiceCertificateOrderCertificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20150801:AppServiceCertificateOrderCertificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20180201:AppServiceCertificateOrderCertificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20190801:AppServiceCertificateOrderCertificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20200601:AppServiceCertificateOrderCertificate"),
		},
		{
			Type: pulumi.String("azure-nextgen:certificateregistration/v20201001:AppServiceCertificateOrderCertificate"),
		},
	})
	opts = append(opts, aliases)
	var resource AppServiceCertificateOrderCertificate
	err := ctx.RegisterResource("azure-nextgen:certificateregistration/v20200901:AppServiceCertificateOrderCertificate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAppServiceCertificateOrderCertificate gets an existing AppServiceCertificateOrderCertificate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAppServiceCertificateOrderCertificate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AppServiceCertificateOrderCertificateState, opts ...pulumi.ResourceOption) (*AppServiceCertificateOrderCertificate, error) {
	var resource AppServiceCertificateOrderCertificate
	err := ctx.ReadResource("azure-nextgen:certificateregistration/v20200901:AppServiceCertificateOrderCertificate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AppServiceCertificateOrderCertificate resources.
type appServiceCertificateOrderCertificateState struct {
	// Key Vault resource Id.
	KeyVaultId *string `pulumi:"keyVaultId"`
	// Key Vault secret name.
	KeyVaultSecretName *string `pulumi:"keyVaultSecretName"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location *string `pulumi:"location"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Status of the Key Vault secret.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The system metadata relating to this resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type AppServiceCertificateOrderCertificateState struct {
	// Key Vault resource Id.
	KeyVaultId pulumi.StringPtrInput
	// Key Vault secret name.
	KeyVaultSecretName pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Status of the Key Vault secret.
	ProvisioningState pulumi.StringPtrInput
	// The system metadata relating to this resource.
	SystemData SystemDataResponsePtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (AppServiceCertificateOrderCertificateState) ElementType() reflect.Type {
	return reflect.TypeOf((*appServiceCertificateOrderCertificateState)(nil)).Elem()
}

type appServiceCertificateOrderCertificateArgs struct {
	// Name of the certificate order.
	CertificateOrderName string `pulumi:"certificateOrderName"`
	// Key Vault resource Id.
	KeyVaultId *string `pulumi:"keyVaultId"`
	// Key Vault secret name.
	KeyVaultSecretName *string `pulumi:"keyVaultSecretName"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location *string `pulumi:"location"`
	// Name of the certificate.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a AppServiceCertificateOrderCertificate resource.
type AppServiceCertificateOrderCertificateArgs struct {
	// Name of the certificate order.
	CertificateOrderName pulumi.StringInput
	// Key Vault resource Id.
	KeyVaultId pulumi.StringPtrInput
	// Key Vault secret name.
	KeyVaultSecretName pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringPtrInput
	// Name of the certificate.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (AppServiceCertificateOrderCertificateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*appServiceCertificateOrderCertificateArgs)(nil)).Elem()
}

type AppServiceCertificateOrderCertificateInput interface {
	pulumi.Input

	ToAppServiceCertificateOrderCertificateOutput() AppServiceCertificateOrderCertificateOutput
	ToAppServiceCertificateOrderCertificateOutputWithContext(ctx context.Context) AppServiceCertificateOrderCertificateOutput
}

func (*AppServiceCertificateOrderCertificate) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificateOrderCertificate)(nil))
}

func (i *AppServiceCertificateOrderCertificate) ToAppServiceCertificateOrderCertificateOutput() AppServiceCertificateOrderCertificateOutput {
	return i.ToAppServiceCertificateOrderCertificateOutputWithContext(context.Background())
}

func (i *AppServiceCertificateOrderCertificate) ToAppServiceCertificateOrderCertificateOutputWithContext(ctx context.Context) AppServiceCertificateOrderCertificateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AppServiceCertificateOrderCertificateOutput)
}

type AppServiceCertificateOrderCertificateOutput struct {
	*pulumi.OutputState
}

func (AppServiceCertificateOrderCertificateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AppServiceCertificateOrderCertificate)(nil))
}

func (o AppServiceCertificateOrderCertificateOutput) ToAppServiceCertificateOrderCertificateOutput() AppServiceCertificateOrderCertificateOutput {
	return o
}

func (o AppServiceCertificateOrderCertificateOutput) ToAppServiceCertificateOrderCertificateOutputWithContext(ctx context.Context) AppServiceCertificateOrderCertificateOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AppServiceCertificateOrderCertificateOutput{})
}
