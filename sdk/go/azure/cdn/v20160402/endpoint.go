// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160402

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// CDN endpoint is the entity within a CDN profile containing configuration information regarding caching behaviors and origins. The CDN endpoint is exposed using the URL format <endpointname>.azureedge.net by default, but custom domains can also be created.
type Endpoint struct {
	pulumi.CustomResourceState

	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress pulumi.StringArrayOutput `pulumi:"contentTypesToCompress"`
	// The host name of the endpoint {endpointName}.{DNSZone}
	HostName pulumi.StringOutput `pulumi:"hostName"`
	// Indicates whether the compression is enabled. Default value is false. If compression is enabled, the content transferred from cdn endpoint to end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled pulumi.BoolPtrOutput `pulumi:"isCompressionEnabled"`
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed pulumi.BoolPtrOutput `pulumi:"isHttpAllowed"`
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed pulumi.BoolPtrOutput `pulumi:"isHttpsAllowed"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The host header the CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader pulumi.StringPtrOutput `pulumi:"originHostHeader"`
	// The path used for origin requests.
	OriginPath pulumi.StringPtrOutput `pulumi:"originPath"`
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins DeepCreatedOriginResponseArrayOutput `pulumi:"origins"`
	// Provisioning status of the endpoint.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Defines the query string caching behavior.
	QueryStringCachingBehavior pulumi.StringPtrOutput `pulumi:"queryStringCachingBehavior"`
	// Resource status of the endpoint.
	ResourceState pulumi.StringOutput `pulumi:"resourceState"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewEndpoint registers a new resource with the given unique name, arguments, and options.
func NewEndpoint(ctx *pulumi.Context,
	name string, args *EndpointArgs, opts ...pulumi.ResourceOption) (*Endpoint, error) {
	if args == nil || args.EndpointName == nil {
		return nil, errors.New("missing required argument 'EndpointName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Origins == nil {
		return nil, errors.New("missing required argument 'Origins'")
	}
	if args == nil || args.ProfileName == nil {
		return nil, errors.New("missing required argument 'ProfileName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &EndpointArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:cdn/latest:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20150601:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20161002:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20170402:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20171012:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20190415:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20190615:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20190615preview:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20191231:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20200331:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20200415:Endpoint"),
		},
		{
			Type: pulumi.String("azure-nextgen:cdn/v20200901:Endpoint"),
		},
	})
	opts = append(opts, aliases)
	var resource Endpoint
	err := ctx.RegisterResource("azure-nextgen:cdn/v20160402:Endpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEndpoint gets an existing Endpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEndpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EndpointState, opts ...pulumi.ResourceOption) (*Endpoint, error) {
	var resource Endpoint
	err := ctx.ReadResource("azure-nextgen:cdn/v20160402:Endpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Endpoint resources.
type endpointState struct {
	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress []string `pulumi:"contentTypesToCompress"`
	// The host name of the endpoint {endpointName}.{DNSZone}
	HostName *string `pulumi:"hostName"`
	// Indicates whether the compression is enabled. Default value is false. If compression is enabled, the content transferred from cdn endpoint to end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled *bool `pulumi:"isCompressionEnabled"`
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed *bool `pulumi:"isHttpAllowed"`
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed *bool `pulumi:"isHttpsAllowed"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name *string `pulumi:"name"`
	// The host header the CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader *string `pulumi:"originHostHeader"`
	// The path used for origin requests.
	OriginPath *string `pulumi:"originPath"`
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins []DeepCreatedOriginResponse `pulumi:"origins"`
	// Provisioning status of the endpoint.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Defines the query string caching behavior.
	QueryStringCachingBehavior *string `pulumi:"queryStringCachingBehavior"`
	// Resource status of the endpoint.
	ResourceState *string `pulumi:"resourceState"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type EndpointState struct {
	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress pulumi.StringArrayInput
	// The host name of the endpoint {endpointName}.{DNSZone}
	HostName pulumi.StringPtrInput
	// Indicates whether the compression is enabled. Default value is false. If compression is enabled, the content transferred from cdn endpoint to end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled pulumi.BoolPtrInput
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed pulumi.BoolPtrInput
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed pulumi.BoolPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// The host header the CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader pulumi.StringPtrInput
	// The path used for origin requests.
	OriginPath pulumi.StringPtrInput
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins DeepCreatedOriginResponseArrayInput
	// Provisioning status of the endpoint.
	ProvisioningState pulumi.StringPtrInput
	// Defines the query string caching behavior.
	QueryStringCachingBehavior pulumi.StringPtrInput
	// Resource status of the endpoint.
	ResourceState pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (EndpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*endpointState)(nil)).Elem()
}

type endpointArgs struct {
	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress []string `pulumi:"contentTypesToCompress"`
	// Name of the endpoint within the CDN profile.
	EndpointName string `pulumi:"endpointName"`
	// Indicates whether content compression is enabled. Default value is false. If compression is enabled, the content transferred from the CDN endpoint to the end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled *bool `pulumi:"isCompressionEnabled"`
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed *bool `pulumi:"isHttpAllowed"`
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed *bool `pulumi:"isHttpsAllowed"`
	// Endpoint location
	Location string `pulumi:"location"`
	// The host header CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader *string `pulumi:"originHostHeader"`
	// The path used for origin requests.
	OriginPath *string `pulumi:"originPath"`
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins []DeepCreatedOrigin `pulumi:"origins"`
	// Name of the CDN profile within the resource group.
	ProfileName string `pulumi:"profileName"`
	// Defines the query string caching behavior.
	QueryStringCachingBehavior *string `pulumi:"queryStringCachingBehavior"`
	// Name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Endpoint tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Endpoint resource.
type EndpointArgs struct {
	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress pulumi.StringArrayInput
	// Name of the endpoint within the CDN profile.
	EndpointName pulumi.StringInput
	// Indicates whether content compression is enabled. Default value is false. If compression is enabled, the content transferred from the CDN endpoint to the end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled pulumi.BoolPtrInput
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed pulumi.BoolPtrInput
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed pulumi.BoolPtrInput
	// Endpoint location
	Location pulumi.StringInput
	// The host header CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader pulumi.StringPtrInput
	// The path used for origin requests.
	OriginPath pulumi.StringPtrInput
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins DeepCreatedOriginArrayInput
	// Name of the CDN profile within the resource group.
	ProfileName pulumi.StringInput
	// Defines the query string caching behavior.
	QueryStringCachingBehavior pulumi.StringPtrInput
	// Name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// Endpoint tags
	Tags pulumi.StringMapInput
}

func (EndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*endpointArgs)(nil)).Elem()
}

type EndpointInput interface {
	pulumi.Input

	ToEndpointOutput() EndpointOutput
	ToEndpointOutputWithContext(ctx context.Context) EndpointOutput
}

func (Endpoint) ElementType() reflect.Type {
	return reflect.TypeOf((*Endpoint)(nil)).Elem()
}

func (i Endpoint) ToEndpointOutput() EndpointOutput {
	return i.ToEndpointOutputWithContext(context.Background())
}

func (i Endpoint) ToEndpointOutputWithContext(ctx context.Context) EndpointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EndpointOutput)
}

type EndpointOutput struct {
	*pulumi.OutputState
}

func (EndpointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EndpointOutput)(nil)).Elem()
}

func (o EndpointOutput) ToEndpointOutput() EndpointOutput {
	return o
}

func (o EndpointOutput) ToEndpointOutputWithContext(ctx context.Context) EndpointOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(EndpointOutput{})
}
