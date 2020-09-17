// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Information about the SKU of the DigitalTwinsInstance.
type DigitalTwinsSkuInfo struct {
	// The name of the SKU.
	Name string `pulumi:"name"`
}

// DigitalTwinsSkuInfoInput is an input type that accepts DigitalTwinsSkuInfoArgs and DigitalTwinsSkuInfoOutput values.
// You can construct a concrete instance of `DigitalTwinsSkuInfoInput` via:
//
//          DigitalTwinsSkuInfoArgs{...}
type DigitalTwinsSkuInfoInput interface {
	pulumi.Input

	ToDigitalTwinsSkuInfoOutput() DigitalTwinsSkuInfoOutput
	ToDigitalTwinsSkuInfoOutputWithContext(context.Context) DigitalTwinsSkuInfoOutput
}

// Information about the SKU of the DigitalTwinsInstance.
type DigitalTwinsSkuInfoArgs struct {
	// The name of the SKU.
	Name pulumi.StringInput `pulumi:"name"`
}

func (DigitalTwinsSkuInfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DigitalTwinsSkuInfo)(nil)).Elem()
}

func (i DigitalTwinsSkuInfoArgs) ToDigitalTwinsSkuInfoOutput() DigitalTwinsSkuInfoOutput {
	return i.ToDigitalTwinsSkuInfoOutputWithContext(context.Background())
}

func (i DigitalTwinsSkuInfoArgs) ToDigitalTwinsSkuInfoOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DigitalTwinsSkuInfoOutput)
}

func (i DigitalTwinsSkuInfoArgs) ToDigitalTwinsSkuInfoPtrOutput() DigitalTwinsSkuInfoPtrOutput {
	return i.ToDigitalTwinsSkuInfoPtrOutputWithContext(context.Background())
}

func (i DigitalTwinsSkuInfoArgs) ToDigitalTwinsSkuInfoPtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DigitalTwinsSkuInfoOutput).ToDigitalTwinsSkuInfoPtrOutputWithContext(ctx)
}

// DigitalTwinsSkuInfoPtrInput is an input type that accepts DigitalTwinsSkuInfoArgs, DigitalTwinsSkuInfoPtr and DigitalTwinsSkuInfoPtrOutput values.
// You can construct a concrete instance of `DigitalTwinsSkuInfoPtrInput` via:
//
//          DigitalTwinsSkuInfoArgs{...}
//
//  or:
//
//          nil
type DigitalTwinsSkuInfoPtrInput interface {
	pulumi.Input

	ToDigitalTwinsSkuInfoPtrOutput() DigitalTwinsSkuInfoPtrOutput
	ToDigitalTwinsSkuInfoPtrOutputWithContext(context.Context) DigitalTwinsSkuInfoPtrOutput
}

type digitalTwinsSkuInfoPtrType DigitalTwinsSkuInfoArgs

func DigitalTwinsSkuInfoPtr(v *DigitalTwinsSkuInfoArgs) DigitalTwinsSkuInfoPtrInput {
	return (*digitalTwinsSkuInfoPtrType)(v)
}

func (*digitalTwinsSkuInfoPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**DigitalTwinsSkuInfo)(nil)).Elem()
}

func (i *digitalTwinsSkuInfoPtrType) ToDigitalTwinsSkuInfoPtrOutput() DigitalTwinsSkuInfoPtrOutput {
	return i.ToDigitalTwinsSkuInfoPtrOutputWithContext(context.Background())
}

func (i *digitalTwinsSkuInfoPtrType) ToDigitalTwinsSkuInfoPtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DigitalTwinsSkuInfoPtrOutput)
}

// Information about the SKU of the DigitalTwinsInstance.
type DigitalTwinsSkuInfoOutput struct{ *pulumi.OutputState }

func (DigitalTwinsSkuInfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DigitalTwinsSkuInfo)(nil)).Elem()
}

func (o DigitalTwinsSkuInfoOutput) ToDigitalTwinsSkuInfoOutput() DigitalTwinsSkuInfoOutput {
	return o
}

func (o DigitalTwinsSkuInfoOutput) ToDigitalTwinsSkuInfoOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoOutput {
	return o
}

func (o DigitalTwinsSkuInfoOutput) ToDigitalTwinsSkuInfoPtrOutput() DigitalTwinsSkuInfoPtrOutput {
	return o.ToDigitalTwinsSkuInfoPtrOutputWithContext(context.Background())
}

func (o DigitalTwinsSkuInfoOutput) ToDigitalTwinsSkuInfoPtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoPtrOutput {
	return o.ApplyT(func(v DigitalTwinsSkuInfo) *DigitalTwinsSkuInfo {
		return &v
	}).(DigitalTwinsSkuInfoPtrOutput)
}

// The name of the SKU.
func (o DigitalTwinsSkuInfoOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v DigitalTwinsSkuInfo) string { return v.Name }).(pulumi.StringOutput)
}

type DigitalTwinsSkuInfoPtrOutput struct{ *pulumi.OutputState }

func (DigitalTwinsSkuInfoPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DigitalTwinsSkuInfo)(nil)).Elem()
}

func (o DigitalTwinsSkuInfoPtrOutput) ToDigitalTwinsSkuInfoPtrOutput() DigitalTwinsSkuInfoPtrOutput {
	return o
}

func (o DigitalTwinsSkuInfoPtrOutput) ToDigitalTwinsSkuInfoPtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoPtrOutput {
	return o
}

func (o DigitalTwinsSkuInfoPtrOutput) Elem() DigitalTwinsSkuInfoOutput {
	return o.ApplyT(func(v *DigitalTwinsSkuInfo) DigitalTwinsSkuInfo { return *v }).(DigitalTwinsSkuInfoOutput)
}

// The name of the SKU.
func (o DigitalTwinsSkuInfoPtrOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DigitalTwinsSkuInfo) *string {
		if v == nil {
			return nil
		}
		return &v.Name
	}).(pulumi.StringPtrOutput)
}

// Information about the SKU of the DigitalTwinsInstance.
type DigitalTwinsSkuInfoResponse struct {
	// The name of the SKU.
	Name string `pulumi:"name"`
}

// DigitalTwinsSkuInfoResponseInput is an input type that accepts DigitalTwinsSkuInfoResponseArgs and DigitalTwinsSkuInfoResponseOutput values.
// You can construct a concrete instance of `DigitalTwinsSkuInfoResponseInput` via:
//
//          DigitalTwinsSkuInfoResponseArgs{...}
type DigitalTwinsSkuInfoResponseInput interface {
	pulumi.Input

	ToDigitalTwinsSkuInfoResponseOutput() DigitalTwinsSkuInfoResponseOutput
	ToDigitalTwinsSkuInfoResponseOutputWithContext(context.Context) DigitalTwinsSkuInfoResponseOutput
}

// Information about the SKU of the DigitalTwinsInstance.
type DigitalTwinsSkuInfoResponseArgs struct {
	// The name of the SKU.
	Name pulumi.StringInput `pulumi:"name"`
}

func (DigitalTwinsSkuInfoResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DigitalTwinsSkuInfoResponse)(nil)).Elem()
}

func (i DigitalTwinsSkuInfoResponseArgs) ToDigitalTwinsSkuInfoResponseOutput() DigitalTwinsSkuInfoResponseOutput {
	return i.ToDigitalTwinsSkuInfoResponseOutputWithContext(context.Background())
}

func (i DigitalTwinsSkuInfoResponseArgs) ToDigitalTwinsSkuInfoResponseOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DigitalTwinsSkuInfoResponseOutput)
}

func (i DigitalTwinsSkuInfoResponseArgs) ToDigitalTwinsSkuInfoResponsePtrOutput() DigitalTwinsSkuInfoResponsePtrOutput {
	return i.ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(context.Background())
}

func (i DigitalTwinsSkuInfoResponseArgs) ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DigitalTwinsSkuInfoResponseOutput).ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(ctx)
}

// DigitalTwinsSkuInfoResponsePtrInput is an input type that accepts DigitalTwinsSkuInfoResponseArgs, DigitalTwinsSkuInfoResponsePtr and DigitalTwinsSkuInfoResponsePtrOutput values.
// You can construct a concrete instance of `DigitalTwinsSkuInfoResponsePtrInput` via:
//
//          DigitalTwinsSkuInfoResponseArgs{...}
//
//  or:
//
//          nil
type DigitalTwinsSkuInfoResponsePtrInput interface {
	pulumi.Input

	ToDigitalTwinsSkuInfoResponsePtrOutput() DigitalTwinsSkuInfoResponsePtrOutput
	ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(context.Context) DigitalTwinsSkuInfoResponsePtrOutput
}

type digitalTwinsSkuInfoResponsePtrType DigitalTwinsSkuInfoResponseArgs

func DigitalTwinsSkuInfoResponsePtr(v *DigitalTwinsSkuInfoResponseArgs) DigitalTwinsSkuInfoResponsePtrInput {
	return (*digitalTwinsSkuInfoResponsePtrType)(v)
}

func (*digitalTwinsSkuInfoResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**DigitalTwinsSkuInfoResponse)(nil)).Elem()
}

func (i *digitalTwinsSkuInfoResponsePtrType) ToDigitalTwinsSkuInfoResponsePtrOutput() DigitalTwinsSkuInfoResponsePtrOutput {
	return i.ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(context.Background())
}

func (i *digitalTwinsSkuInfoResponsePtrType) ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DigitalTwinsSkuInfoResponsePtrOutput)
}

// Information about the SKU of the DigitalTwinsInstance.
type DigitalTwinsSkuInfoResponseOutput struct{ *pulumi.OutputState }

func (DigitalTwinsSkuInfoResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DigitalTwinsSkuInfoResponse)(nil)).Elem()
}

func (o DigitalTwinsSkuInfoResponseOutput) ToDigitalTwinsSkuInfoResponseOutput() DigitalTwinsSkuInfoResponseOutput {
	return o
}

func (o DigitalTwinsSkuInfoResponseOutput) ToDigitalTwinsSkuInfoResponseOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoResponseOutput {
	return o
}

func (o DigitalTwinsSkuInfoResponseOutput) ToDigitalTwinsSkuInfoResponsePtrOutput() DigitalTwinsSkuInfoResponsePtrOutput {
	return o.ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(context.Background())
}

func (o DigitalTwinsSkuInfoResponseOutput) ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoResponsePtrOutput {
	return o.ApplyT(func(v DigitalTwinsSkuInfoResponse) *DigitalTwinsSkuInfoResponse {
		return &v
	}).(DigitalTwinsSkuInfoResponsePtrOutput)
}

// The name of the SKU.
func (o DigitalTwinsSkuInfoResponseOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v DigitalTwinsSkuInfoResponse) string { return v.Name }).(pulumi.StringOutput)
}

type DigitalTwinsSkuInfoResponsePtrOutput struct{ *pulumi.OutputState }

func (DigitalTwinsSkuInfoResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DigitalTwinsSkuInfoResponse)(nil)).Elem()
}

func (o DigitalTwinsSkuInfoResponsePtrOutput) ToDigitalTwinsSkuInfoResponsePtrOutput() DigitalTwinsSkuInfoResponsePtrOutput {
	return o
}

func (o DigitalTwinsSkuInfoResponsePtrOutput) ToDigitalTwinsSkuInfoResponsePtrOutputWithContext(ctx context.Context) DigitalTwinsSkuInfoResponsePtrOutput {
	return o
}

func (o DigitalTwinsSkuInfoResponsePtrOutput) Elem() DigitalTwinsSkuInfoResponseOutput {
	return o.ApplyT(func(v *DigitalTwinsSkuInfoResponse) DigitalTwinsSkuInfoResponse { return *v }).(DigitalTwinsSkuInfoResponseOutput)
}

// The name of the SKU.
func (o DigitalTwinsSkuInfoResponsePtrOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DigitalTwinsSkuInfoResponse) *string {
		if v == nil {
			return nil
		}
		return &v.Name
	}).(pulumi.StringPtrOutput)
}

// properties related to eventgrid.
type EventGrid struct {
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey1 string `pulumi:"accessKey1"`
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey2 string `pulumi:"accessKey2"`
	// The type of Digital Twins endpoint
	EndpointType string `pulumi:"endpointType"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// EventGrid Topic Endpoint
	TopicEndpoint *string `pulumi:"topicEndpoint"`
}

// EventGridInput is an input type that accepts EventGridArgs and EventGridOutput values.
// You can construct a concrete instance of `EventGridInput` via:
//
//          EventGridArgs{...}
type EventGridInput interface {
	pulumi.Input

	ToEventGridOutput() EventGridOutput
	ToEventGridOutputWithContext(context.Context) EventGridOutput
}

// properties related to eventgrid.
type EventGridArgs struct {
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey1 pulumi.StringInput `pulumi:"accessKey1"`
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey2 pulumi.StringInput `pulumi:"accessKey2"`
	// The type of Digital Twins endpoint
	EndpointType pulumi.StringInput `pulumi:"endpointType"`
	// The resource tags.
	Tags pulumi.StringMapInput `pulumi:"tags"`
	// EventGrid Topic Endpoint
	TopicEndpoint pulumi.StringPtrInput `pulumi:"topicEndpoint"`
}

func (EventGridArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EventGrid)(nil)).Elem()
}

func (i EventGridArgs) ToEventGridOutput() EventGridOutput {
	return i.ToEventGridOutputWithContext(context.Background())
}

func (i EventGridArgs) ToEventGridOutputWithContext(ctx context.Context) EventGridOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventGridOutput)
}

// properties related to eventgrid.
type EventGridOutput struct{ *pulumi.OutputState }

func (EventGridOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventGrid)(nil)).Elem()
}

func (o EventGridOutput) ToEventGridOutput() EventGridOutput {
	return o
}

func (o EventGridOutput) ToEventGridOutputWithContext(ctx context.Context) EventGridOutput {
	return o
}

// EventGrid secondary accesskey. Will be obfuscated during read
func (o EventGridOutput) AccessKey1() pulumi.StringOutput {
	return o.ApplyT(func(v EventGrid) string { return v.AccessKey1 }).(pulumi.StringOutput)
}

// EventGrid secondary accesskey. Will be obfuscated during read
func (o EventGridOutput) AccessKey2() pulumi.StringOutput {
	return o.ApplyT(func(v EventGrid) string { return v.AccessKey2 }).(pulumi.StringOutput)
}

// The type of Digital Twins endpoint
func (o EventGridOutput) EndpointType() pulumi.StringOutput {
	return o.ApplyT(func(v EventGrid) string { return v.EndpointType }).(pulumi.StringOutput)
}

// The resource tags.
func (o EventGridOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v EventGrid) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// EventGrid Topic Endpoint
func (o EventGridOutput) TopicEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventGrid) *string { return v.TopicEndpoint }).(pulumi.StringPtrOutput)
}

// properties related to eventgrid.
type EventGridResponse struct {
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey1 string `pulumi:"accessKey1"`
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey2 string `pulumi:"accessKey2"`
	// Time when the Endpoint was added to DigitalTwinsInstance.
	CreatedTime string `pulumi:"createdTime"`
	// The type of Digital Twins endpoint
	EndpointType string `pulumi:"endpointType"`
	// The provisioning state.
	ProvisioningState string `pulumi:"provisioningState"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
	// EventGrid Topic Endpoint
	TopicEndpoint *string `pulumi:"topicEndpoint"`
}

// EventGridResponseInput is an input type that accepts EventGridResponseArgs and EventGridResponseOutput values.
// You can construct a concrete instance of `EventGridResponseInput` via:
//
//          EventGridResponseArgs{...}
type EventGridResponseInput interface {
	pulumi.Input

	ToEventGridResponseOutput() EventGridResponseOutput
	ToEventGridResponseOutputWithContext(context.Context) EventGridResponseOutput
}

// properties related to eventgrid.
type EventGridResponseArgs struct {
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey1 pulumi.StringInput `pulumi:"accessKey1"`
	// EventGrid secondary accesskey. Will be obfuscated during read
	AccessKey2 pulumi.StringInput `pulumi:"accessKey2"`
	// Time when the Endpoint was added to DigitalTwinsInstance.
	CreatedTime pulumi.StringInput `pulumi:"createdTime"`
	// The type of Digital Twins endpoint
	EndpointType pulumi.StringInput `pulumi:"endpointType"`
	// The provisioning state.
	ProvisioningState pulumi.StringInput `pulumi:"provisioningState"`
	// The resource tags.
	Tags pulumi.StringMapInput `pulumi:"tags"`
	// EventGrid Topic Endpoint
	TopicEndpoint pulumi.StringPtrInput `pulumi:"topicEndpoint"`
}

func (EventGridResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EventGridResponse)(nil)).Elem()
}

func (i EventGridResponseArgs) ToEventGridResponseOutput() EventGridResponseOutput {
	return i.ToEventGridResponseOutputWithContext(context.Background())
}

func (i EventGridResponseArgs) ToEventGridResponseOutputWithContext(ctx context.Context) EventGridResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventGridResponseOutput)
}

// properties related to eventgrid.
type EventGridResponseOutput struct{ *pulumi.OutputState }

func (EventGridResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventGridResponse)(nil)).Elem()
}

func (o EventGridResponseOutput) ToEventGridResponseOutput() EventGridResponseOutput {
	return o
}

func (o EventGridResponseOutput) ToEventGridResponseOutputWithContext(ctx context.Context) EventGridResponseOutput {
	return o
}

// EventGrid secondary accesskey. Will be obfuscated during read
func (o EventGridResponseOutput) AccessKey1() pulumi.StringOutput {
	return o.ApplyT(func(v EventGridResponse) string { return v.AccessKey1 }).(pulumi.StringOutput)
}

// EventGrid secondary accesskey. Will be obfuscated during read
func (o EventGridResponseOutput) AccessKey2() pulumi.StringOutput {
	return o.ApplyT(func(v EventGridResponse) string { return v.AccessKey2 }).(pulumi.StringOutput)
}

// Time when the Endpoint was added to DigitalTwinsInstance.
func (o EventGridResponseOutput) CreatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v EventGridResponse) string { return v.CreatedTime }).(pulumi.StringOutput)
}

// The type of Digital Twins endpoint
func (o EventGridResponseOutput) EndpointType() pulumi.StringOutput {
	return o.ApplyT(func(v EventGridResponse) string { return v.EndpointType }).(pulumi.StringOutput)
}

// The provisioning state.
func (o EventGridResponseOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v EventGridResponse) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// The resource tags.
func (o EventGridResponseOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v EventGridResponse) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// EventGrid Topic Endpoint
func (o EventGridResponseOutput) TopicEndpoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v EventGridResponse) *string { return v.TopicEndpoint }).(pulumi.StringPtrOutput)
}

// properties related to eventhub.
type EventHub struct {
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringPrimaryKey string `pulumi:"connectionStringPrimaryKey"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringSecondaryKey string `pulumi:"connectionStringSecondaryKey"`
	// The type of Digital Twins endpoint
	EndpointType string `pulumi:"endpointType"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// EventHubInput is an input type that accepts EventHubArgs and EventHubOutput values.
// You can construct a concrete instance of `EventHubInput` via:
//
//          EventHubArgs{...}
type EventHubInput interface {
	pulumi.Input

	ToEventHubOutput() EventHubOutput
	ToEventHubOutputWithContext(context.Context) EventHubOutput
}

// properties related to eventhub.
type EventHubArgs struct {
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringPrimaryKey pulumi.StringInput `pulumi:"connectionStringPrimaryKey"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringSecondaryKey pulumi.StringInput `pulumi:"connectionStringSecondaryKey"`
	// The type of Digital Twins endpoint
	EndpointType pulumi.StringInput `pulumi:"endpointType"`
	// The resource tags.
	Tags pulumi.StringMapInput `pulumi:"tags"`
}

func (EventHubArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EventHub)(nil)).Elem()
}

func (i EventHubArgs) ToEventHubOutput() EventHubOutput {
	return i.ToEventHubOutputWithContext(context.Background())
}

func (i EventHubArgs) ToEventHubOutputWithContext(ctx context.Context) EventHubOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventHubOutput)
}

// properties related to eventhub.
type EventHubOutput struct{ *pulumi.OutputState }

func (EventHubOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventHub)(nil)).Elem()
}

func (o EventHubOutput) ToEventHubOutput() EventHubOutput {
	return o
}

func (o EventHubOutput) ToEventHubOutputWithContext(ctx context.Context) EventHubOutput {
	return o
}

// PrimaryConnectionString of the endpoint. Will be obfuscated during read
func (o EventHubOutput) ConnectionStringPrimaryKey() pulumi.StringOutput {
	return o.ApplyT(func(v EventHub) string { return v.ConnectionStringPrimaryKey }).(pulumi.StringOutput)
}

// SecondaryConnectionString of the endpoint. Will be obfuscated during read
func (o EventHubOutput) ConnectionStringSecondaryKey() pulumi.StringOutput {
	return o.ApplyT(func(v EventHub) string { return v.ConnectionStringSecondaryKey }).(pulumi.StringOutput)
}

// The type of Digital Twins endpoint
func (o EventHubOutput) EndpointType() pulumi.StringOutput {
	return o.ApplyT(func(v EventHub) string { return v.EndpointType }).(pulumi.StringOutput)
}

// The resource tags.
func (o EventHubOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v EventHub) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// properties related to eventhub.
type EventHubResponse struct {
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringPrimaryKey string `pulumi:"connectionStringPrimaryKey"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringSecondaryKey string `pulumi:"connectionStringSecondaryKey"`
	// Time when the Endpoint was added to DigitalTwinsInstance.
	CreatedTime string `pulumi:"createdTime"`
	// The type of Digital Twins endpoint
	EndpointType string `pulumi:"endpointType"`
	// The provisioning state.
	ProvisioningState string `pulumi:"provisioningState"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// EventHubResponseInput is an input type that accepts EventHubResponseArgs and EventHubResponseOutput values.
// You can construct a concrete instance of `EventHubResponseInput` via:
//
//          EventHubResponseArgs{...}
type EventHubResponseInput interface {
	pulumi.Input

	ToEventHubResponseOutput() EventHubResponseOutput
	ToEventHubResponseOutputWithContext(context.Context) EventHubResponseOutput
}

// properties related to eventhub.
type EventHubResponseArgs struct {
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringPrimaryKey pulumi.StringInput `pulumi:"connectionStringPrimaryKey"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	ConnectionStringSecondaryKey pulumi.StringInput `pulumi:"connectionStringSecondaryKey"`
	// Time when the Endpoint was added to DigitalTwinsInstance.
	CreatedTime pulumi.StringInput `pulumi:"createdTime"`
	// The type of Digital Twins endpoint
	EndpointType pulumi.StringInput `pulumi:"endpointType"`
	// The provisioning state.
	ProvisioningState pulumi.StringInput `pulumi:"provisioningState"`
	// The resource tags.
	Tags pulumi.StringMapInput `pulumi:"tags"`
}

func (EventHubResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*EventHubResponse)(nil)).Elem()
}

func (i EventHubResponseArgs) ToEventHubResponseOutput() EventHubResponseOutput {
	return i.ToEventHubResponseOutputWithContext(context.Background())
}

func (i EventHubResponseArgs) ToEventHubResponseOutputWithContext(ctx context.Context) EventHubResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventHubResponseOutput)
}

// properties related to eventhub.
type EventHubResponseOutput struct{ *pulumi.OutputState }

func (EventHubResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventHubResponse)(nil)).Elem()
}

func (o EventHubResponseOutput) ToEventHubResponseOutput() EventHubResponseOutput {
	return o
}

func (o EventHubResponseOutput) ToEventHubResponseOutputWithContext(ctx context.Context) EventHubResponseOutput {
	return o
}

// PrimaryConnectionString of the endpoint. Will be obfuscated during read
func (o EventHubResponseOutput) ConnectionStringPrimaryKey() pulumi.StringOutput {
	return o.ApplyT(func(v EventHubResponse) string { return v.ConnectionStringPrimaryKey }).(pulumi.StringOutput)
}

// SecondaryConnectionString of the endpoint. Will be obfuscated during read
func (o EventHubResponseOutput) ConnectionStringSecondaryKey() pulumi.StringOutput {
	return o.ApplyT(func(v EventHubResponse) string { return v.ConnectionStringSecondaryKey }).(pulumi.StringOutput)
}

// Time when the Endpoint was added to DigitalTwinsInstance.
func (o EventHubResponseOutput) CreatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v EventHubResponse) string { return v.CreatedTime }).(pulumi.StringOutput)
}

// The type of Digital Twins endpoint
func (o EventHubResponseOutput) EndpointType() pulumi.StringOutput {
	return o.ApplyT(func(v EventHubResponse) string { return v.EndpointType }).(pulumi.StringOutput)
}

// The provisioning state.
func (o EventHubResponseOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v EventHubResponse) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// The resource tags.
func (o EventHubResponseOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v EventHubResponse) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// properties related to servicebus.
type ServiceBus struct {
	// The type of Digital Twins endpoint
	EndpointType string `pulumi:"endpointType"`
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	PrimaryConnectionString string `pulumi:"primaryConnectionString"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	SecondaryConnectionString string `pulumi:"secondaryConnectionString"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// ServiceBusInput is an input type that accepts ServiceBusArgs and ServiceBusOutput values.
// You can construct a concrete instance of `ServiceBusInput` via:
//
//          ServiceBusArgs{...}
type ServiceBusInput interface {
	pulumi.Input

	ToServiceBusOutput() ServiceBusOutput
	ToServiceBusOutputWithContext(context.Context) ServiceBusOutput
}

// properties related to servicebus.
type ServiceBusArgs struct {
	// The type of Digital Twins endpoint
	EndpointType pulumi.StringInput `pulumi:"endpointType"`
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	PrimaryConnectionString pulumi.StringInput `pulumi:"primaryConnectionString"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	SecondaryConnectionString pulumi.StringInput `pulumi:"secondaryConnectionString"`
	// The resource tags.
	Tags pulumi.StringMapInput `pulumi:"tags"`
}

func (ServiceBusArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceBus)(nil)).Elem()
}

func (i ServiceBusArgs) ToServiceBusOutput() ServiceBusOutput {
	return i.ToServiceBusOutputWithContext(context.Background())
}

func (i ServiceBusArgs) ToServiceBusOutputWithContext(ctx context.Context) ServiceBusOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceBusOutput)
}

// properties related to servicebus.
type ServiceBusOutput struct{ *pulumi.OutputState }

func (ServiceBusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceBus)(nil)).Elem()
}

func (o ServiceBusOutput) ToServiceBusOutput() ServiceBusOutput {
	return o
}

func (o ServiceBusOutput) ToServiceBusOutputWithContext(ctx context.Context) ServiceBusOutput {
	return o
}

// The type of Digital Twins endpoint
func (o ServiceBusOutput) EndpointType() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBus) string { return v.EndpointType }).(pulumi.StringOutput)
}

// PrimaryConnectionString of the endpoint. Will be obfuscated during read
func (o ServiceBusOutput) PrimaryConnectionString() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBus) string { return v.PrimaryConnectionString }).(pulumi.StringOutput)
}

// SecondaryConnectionString of the endpoint. Will be obfuscated during read
func (o ServiceBusOutput) SecondaryConnectionString() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBus) string { return v.SecondaryConnectionString }).(pulumi.StringOutput)
}

// The resource tags.
func (o ServiceBusOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v ServiceBus) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// properties related to servicebus.
type ServiceBusResponse struct {
	// Time when the Endpoint was added to DigitalTwinsInstance.
	CreatedTime string `pulumi:"createdTime"`
	// The type of Digital Twins endpoint
	EndpointType string `pulumi:"endpointType"`
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	PrimaryConnectionString string `pulumi:"primaryConnectionString"`
	// The provisioning state.
	ProvisioningState string `pulumi:"provisioningState"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	SecondaryConnectionString string `pulumi:"secondaryConnectionString"`
	// The resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// ServiceBusResponseInput is an input type that accepts ServiceBusResponseArgs and ServiceBusResponseOutput values.
// You can construct a concrete instance of `ServiceBusResponseInput` via:
//
//          ServiceBusResponseArgs{...}
type ServiceBusResponseInput interface {
	pulumi.Input

	ToServiceBusResponseOutput() ServiceBusResponseOutput
	ToServiceBusResponseOutputWithContext(context.Context) ServiceBusResponseOutput
}

// properties related to servicebus.
type ServiceBusResponseArgs struct {
	// Time when the Endpoint was added to DigitalTwinsInstance.
	CreatedTime pulumi.StringInput `pulumi:"createdTime"`
	// The type of Digital Twins endpoint
	EndpointType pulumi.StringInput `pulumi:"endpointType"`
	// PrimaryConnectionString of the endpoint. Will be obfuscated during read
	PrimaryConnectionString pulumi.StringInput `pulumi:"primaryConnectionString"`
	// The provisioning state.
	ProvisioningState pulumi.StringInput `pulumi:"provisioningState"`
	// SecondaryConnectionString of the endpoint. Will be obfuscated during read
	SecondaryConnectionString pulumi.StringInput `pulumi:"secondaryConnectionString"`
	// The resource tags.
	Tags pulumi.StringMapInput `pulumi:"tags"`
}

func (ServiceBusResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceBusResponse)(nil)).Elem()
}

func (i ServiceBusResponseArgs) ToServiceBusResponseOutput() ServiceBusResponseOutput {
	return i.ToServiceBusResponseOutputWithContext(context.Background())
}

func (i ServiceBusResponseArgs) ToServiceBusResponseOutputWithContext(ctx context.Context) ServiceBusResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceBusResponseOutput)
}

// properties related to servicebus.
type ServiceBusResponseOutput struct{ *pulumi.OutputState }

func (ServiceBusResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceBusResponse)(nil)).Elem()
}

func (o ServiceBusResponseOutput) ToServiceBusResponseOutput() ServiceBusResponseOutput {
	return o
}

func (o ServiceBusResponseOutput) ToServiceBusResponseOutputWithContext(ctx context.Context) ServiceBusResponseOutput {
	return o
}

// Time when the Endpoint was added to DigitalTwinsInstance.
func (o ServiceBusResponseOutput) CreatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBusResponse) string { return v.CreatedTime }).(pulumi.StringOutput)
}

// The type of Digital Twins endpoint
func (o ServiceBusResponseOutput) EndpointType() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBusResponse) string { return v.EndpointType }).(pulumi.StringOutput)
}

// PrimaryConnectionString of the endpoint. Will be obfuscated during read
func (o ServiceBusResponseOutput) PrimaryConnectionString() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBusResponse) string { return v.PrimaryConnectionString }).(pulumi.StringOutput)
}

// The provisioning state.
func (o ServiceBusResponseOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBusResponse) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// SecondaryConnectionString of the endpoint. Will be obfuscated during read
func (o ServiceBusResponseOutput) SecondaryConnectionString() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceBusResponse) string { return v.SecondaryConnectionString }).(pulumi.StringOutput)
}

// The resource tags.
func (o ServiceBusResponseOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v ServiceBusResponse) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

func init() {
	pulumi.RegisterOutputType(DigitalTwinsSkuInfoOutput{})
	pulumi.RegisterOutputType(DigitalTwinsSkuInfoPtrOutput{})
	pulumi.RegisterOutputType(DigitalTwinsSkuInfoResponseOutput{})
	pulumi.RegisterOutputType(DigitalTwinsSkuInfoResponsePtrOutput{})
	pulumi.RegisterOutputType(EventGridOutput{})
	pulumi.RegisterOutputType(EventGridResponseOutput{})
	pulumi.RegisterOutputType(EventHubOutput{})
	pulumi.RegisterOutputType(EventHubResponseOutput{})
	pulumi.RegisterOutputType(ServiceBusOutput{})
	pulumi.RegisterOutputType(ServiceBusResponseOutput{})
}