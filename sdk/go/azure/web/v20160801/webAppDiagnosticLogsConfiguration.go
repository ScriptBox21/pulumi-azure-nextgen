// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Configuration of App Service site logs.
type WebAppDiagnosticLogsConfiguration struct {
	pulumi.CustomResourceState

	// Application logs configuration.
	ApplicationLogs ApplicationLogsConfigResponsePtrOutput `pulumi:"applicationLogs"`
	// Detailed error messages configuration.
	DetailedErrorMessages EnabledConfigResponsePtrOutput `pulumi:"detailedErrorMessages"`
	// Failed requests tracing configuration.
	FailedRequestsTracing EnabledConfigResponsePtrOutput `pulumi:"failedRequestsTracing"`
	// HTTP logs configuration.
	HttpLogs HttpLogsConfigResponsePtrOutput `pulumi:"httpLogs"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWebAppDiagnosticLogsConfiguration registers a new resource with the given unique name, arguments, and options.
func NewWebAppDiagnosticLogsConfiguration(ctx *pulumi.Context,
	name string, args *WebAppDiagnosticLogsConfigurationArgs, opts ...pulumi.ResourceOption) (*WebAppDiagnosticLogsConfiguration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppDiagnosticLogsConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppDiagnosticLogsConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppDiagnosticLogsConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppDiagnosticLogsConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppDiagnosticLogsConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppDiagnosticLogsConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppDiagnosticLogsConfiguration"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppDiagnosticLogsConfiguration"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppDiagnosticLogsConfiguration
	err := ctx.RegisterResource("azure-nextgen:web/v20160801:WebAppDiagnosticLogsConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppDiagnosticLogsConfiguration gets an existing WebAppDiagnosticLogsConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppDiagnosticLogsConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppDiagnosticLogsConfigurationState, opts ...pulumi.ResourceOption) (*WebAppDiagnosticLogsConfiguration, error) {
	var resource WebAppDiagnosticLogsConfiguration
	err := ctx.ReadResource("azure-nextgen:web/v20160801:WebAppDiagnosticLogsConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppDiagnosticLogsConfiguration resources.
type webAppDiagnosticLogsConfigurationState struct {
	// Application logs configuration.
	ApplicationLogs *ApplicationLogsConfigResponse `pulumi:"applicationLogs"`
	// Detailed error messages configuration.
	DetailedErrorMessages *EnabledConfigResponse `pulumi:"detailedErrorMessages"`
	// Failed requests tracing configuration.
	FailedRequestsTracing *EnabledConfigResponse `pulumi:"failedRequestsTracing"`
	// HTTP logs configuration.
	HttpLogs *HttpLogsConfigResponse `pulumi:"httpLogs"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type WebAppDiagnosticLogsConfigurationState struct {
	// Application logs configuration.
	ApplicationLogs ApplicationLogsConfigResponsePtrInput
	// Detailed error messages configuration.
	DetailedErrorMessages EnabledConfigResponsePtrInput
	// Failed requests tracing configuration.
	FailedRequestsTracing EnabledConfigResponsePtrInput
	// HTTP logs configuration.
	HttpLogs HttpLogsConfigResponsePtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (WebAppDiagnosticLogsConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppDiagnosticLogsConfigurationState)(nil)).Elem()
}

type webAppDiagnosticLogsConfigurationArgs struct {
	// Application logs configuration.
	ApplicationLogs *ApplicationLogsConfig `pulumi:"applicationLogs"`
	// Detailed error messages configuration.
	DetailedErrorMessages *EnabledConfig `pulumi:"detailedErrorMessages"`
	// Failed requests tracing configuration.
	FailedRequestsTracing *EnabledConfig `pulumi:"failedRequestsTracing"`
	// HTTP logs configuration.
	HttpLogs *HttpLogsConfig `pulumi:"httpLogs"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a WebAppDiagnosticLogsConfiguration resource.
type WebAppDiagnosticLogsConfigurationArgs struct {
	// Application logs configuration.
	ApplicationLogs ApplicationLogsConfigPtrInput
	// Detailed error messages configuration.
	DetailedErrorMessages EnabledConfigPtrInput
	// Failed requests tracing configuration.
	FailedRequestsTracing EnabledConfigPtrInput
	// HTTP logs configuration.
	HttpLogs HttpLogsConfigPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
}

func (WebAppDiagnosticLogsConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppDiagnosticLogsConfigurationArgs)(nil)).Elem()
}

type WebAppDiagnosticLogsConfigurationInput interface {
	pulumi.Input

	ToWebAppDiagnosticLogsConfigurationOutput() WebAppDiagnosticLogsConfigurationOutput
	ToWebAppDiagnosticLogsConfigurationOutputWithContext(ctx context.Context) WebAppDiagnosticLogsConfigurationOutput
}

func (*WebAppDiagnosticLogsConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppDiagnosticLogsConfiguration)(nil))
}

func (i *WebAppDiagnosticLogsConfiguration) ToWebAppDiagnosticLogsConfigurationOutput() WebAppDiagnosticLogsConfigurationOutput {
	return i.ToWebAppDiagnosticLogsConfigurationOutputWithContext(context.Background())
}

func (i *WebAppDiagnosticLogsConfiguration) ToWebAppDiagnosticLogsConfigurationOutputWithContext(ctx context.Context) WebAppDiagnosticLogsConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppDiagnosticLogsConfigurationOutput)
}

type WebAppDiagnosticLogsConfigurationOutput struct {
	*pulumi.OutputState
}

func (WebAppDiagnosticLogsConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppDiagnosticLogsConfiguration)(nil))
}

func (o WebAppDiagnosticLogsConfigurationOutput) ToWebAppDiagnosticLogsConfigurationOutput() WebAppDiagnosticLogsConfigurationOutput {
	return o
}

func (o WebAppDiagnosticLogsConfigurationOutput) ToWebAppDiagnosticLogsConfigurationOutputWithContext(ctx context.Context) WebAppDiagnosticLogsConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppDiagnosticLogsConfigurationOutput{})
}
