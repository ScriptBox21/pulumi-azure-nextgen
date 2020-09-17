// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Virtual machine guest diagnostics settings resource.
type GuestDiagnosticsSetting struct {
	pulumi.CustomResourceState

	// the array of data source object which are configured to collect and send data
	DataSources DataSourceResponseArrayOutput `pulumi:"dataSources"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Azure resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Operating system type for the configuration
	OsType       pulumi.StringPtrOutput `pulumi:"osType"`
	ProxySetting pulumi.StringPtrOutput `pulumi:"proxySetting"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Azure resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewGuestDiagnosticsSetting registers a new resource with the given unique name, arguments, and options.
func NewGuestDiagnosticsSetting(ctx *pulumi.Context,
	name string, args *GuestDiagnosticsSettingArgs, opts ...pulumi.ResourceOption) (*GuestDiagnosticsSetting, error) {
	if args == nil || args.DiagnosticSettingsName == nil {
		return nil, errors.New("missing required argument 'DiagnosticSettingsName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &GuestDiagnosticsSettingArgs{}
	}
	var resource GuestDiagnosticsSetting
	err := ctx.RegisterResource("azure-nextgen:insights/v20180601preview:guestDiagnosticsSetting", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGuestDiagnosticsSetting gets an existing GuestDiagnosticsSetting resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGuestDiagnosticsSetting(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GuestDiagnosticsSettingState, opts ...pulumi.ResourceOption) (*GuestDiagnosticsSetting, error) {
	var resource GuestDiagnosticsSetting
	err := ctx.ReadResource("azure-nextgen:insights/v20180601preview:guestDiagnosticsSetting", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GuestDiagnosticsSetting resources.
type guestDiagnosticsSettingState struct {
	// the array of data source object which are configured to collect and send data
	DataSources []DataSourceResponse `pulumi:"dataSources"`
	// Resource location
	Location *string `pulumi:"location"`
	// Azure resource name
	Name *string `pulumi:"name"`
	// Operating system type for the configuration
	OsType       *string `pulumi:"osType"`
	ProxySetting *string `pulumi:"proxySetting"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Azure resource type
	Type *string `pulumi:"type"`
}

type GuestDiagnosticsSettingState struct {
	// the array of data source object which are configured to collect and send data
	DataSources DataSourceResponseArrayInput
	// Resource location
	Location pulumi.StringPtrInput
	// Azure resource name
	Name pulumi.StringPtrInput
	// Operating system type for the configuration
	OsType       pulumi.StringPtrInput
	ProxySetting pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Azure resource type
	Type pulumi.StringPtrInput
}

func (GuestDiagnosticsSettingState) ElementType() reflect.Type {
	return reflect.TypeOf((*guestDiagnosticsSettingState)(nil)).Elem()
}

type guestDiagnosticsSettingArgs struct {
	// the array of data source object which are configured to collect and send data
	DataSources []DataSource `pulumi:"dataSources"`
	// The name of the diagnostic setting.
	DiagnosticSettingsName string `pulumi:"diagnosticSettingsName"`
	// Resource location
	Location string `pulumi:"location"`
	// Operating system type for the configuration
	OsType       *string `pulumi:"osType"`
	ProxySetting *string `pulumi:"proxySetting"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a GuestDiagnosticsSetting resource.
type GuestDiagnosticsSettingArgs struct {
	// the array of data source object which are configured to collect and send data
	DataSources DataSourceArrayInput
	// The name of the diagnostic setting.
	DiagnosticSettingsName pulumi.StringInput
	// Resource location
	Location pulumi.StringInput
	// Operating system type for the configuration
	OsType       pulumi.StringPtrInput
	ProxySetting pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
}

func (GuestDiagnosticsSettingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*guestDiagnosticsSettingArgs)(nil)).Elem()
}