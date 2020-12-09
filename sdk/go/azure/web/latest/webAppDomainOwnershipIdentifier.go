// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A domain specific resource identifier.
type WebAppDomainOwnershipIdentifier struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponseOutput `pulumi:"systemData"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// String representation of the identity.
	Value pulumi.StringPtrOutput `pulumi:"value"`
}

// NewWebAppDomainOwnershipIdentifier registers a new resource with the given unique name, arguments, and options.
func NewWebAppDomainOwnershipIdentifier(ctx *pulumi.Context,
	name string, args *WebAppDomainOwnershipIdentifierArgs, opts ...pulumi.ResourceOption) (*WebAppDomainOwnershipIdentifier, error) {
	if args == nil || args.DomainOwnershipIdentifierName == nil {
		return nil, errors.New("missing required argument 'DomainOwnershipIdentifierName'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &WebAppDomainOwnershipIdentifierArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:WebAppDomainOwnershipIdentifier"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppDomainOwnershipIdentifier"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppDomainOwnershipIdentifier"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppDomainOwnershipIdentifier"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppDomainOwnershipIdentifier"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppDomainOwnershipIdentifier"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppDomainOwnershipIdentifier
	err := ctx.RegisterResource("azure-nextgen:web/latest:WebAppDomainOwnershipIdentifier", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppDomainOwnershipIdentifier gets an existing WebAppDomainOwnershipIdentifier resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppDomainOwnershipIdentifier(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppDomainOwnershipIdentifierState, opts ...pulumi.ResourceOption) (*WebAppDomainOwnershipIdentifier, error) {
	var resource WebAppDomainOwnershipIdentifier
	err := ctx.ReadResource("azure-nextgen:web/latest:WebAppDomainOwnershipIdentifier", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppDomainOwnershipIdentifier resources.
type webAppDomainOwnershipIdentifierState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// The system metadata relating to this resource.
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type *string `pulumi:"type"`
	// String representation of the identity.
	Value *string `pulumi:"value"`
}

type WebAppDomainOwnershipIdentifierState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// The system metadata relating to this resource.
	SystemData SystemDataResponsePtrInput
	// Resource type.
	Type pulumi.StringPtrInput
	// String representation of the identity.
	Value pulumi.StringPtrInput
}

func (WebAppDomainOwnershipIdentifierState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppDomainOwnershipIdentifierState)(nil)).Elem()
}

type webAppDomainOwnershipIdentifierArgs struct {
	// Name of domain ownership identifier.
	DomainOwnershipIdentifierName string `pulumi:"domainOwnershipIdentifierName"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// String representation of the identity.
	Value *string `pulumi:"value"`
}

// The set of arguments for constructing a WebAppDomainOwnershipIdentifier resource.
type WebAppDomainOwnershipIdentifierArgs struct {
	// Name of domain ownership identifier.
	DomainOwnershipIdentifierName pulumi.StringInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// String representation of the identity.
	Value pulumi.StringPtrInput
}

func (WebAppDomainOwnershipIdentifierArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppDomainOwnershipIdentifierArgs)(nil)).Elem()
}

type WebAppDomainOwnershipIdentifierInput interface {
	pulumi.Input

	ToWebAppDomainOwnershipIdentifierOutput() WebAppDomainOwnershipIdentifierOutput
	ToWebAppDomainOwnershipIdentifierOutputWithContext(ctx context.Context) WebAppDomainOwnershipIdentifierOutput
}

func (WebAppDomainOwnershipIdentifier) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppDomainOwnershipIdentifier)(nil)).Elem()
}

func (i WebAppDomainOwnershipIdentifier) ToWebAppDomainOwnershipIdentifierOutput() WebAppDomainOwnershipIdentifierOutput {
	return i.ToWebAppDomainOwnershipIdentifierOutputWithContext(context.Background())
}

func (i WebAppDomainOwnershipIdentifier) ToWebAppDomainOwnershipIdentifierOutputWithContext(ctx context.Context) WebAppDomainOwnershipIdentifierOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppDomainOwnershipIdentifierOutput)
}

type WebAppDomainOwnershipIdentifierOutput struct {
	*pulumi.OutputState
}

func (WebAppDomainOwnershipIdentifierOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppDomainOwnershipIdentifierOutput)(nil)).Elem()
}

func (o WebAppDomainOwnershipIdentifierOutput) ToWebAppDomainOwnershipIdentifierOutput() WebAppDomainOwnershipIdentifierOutput {
	return o
}

func (o WebAppDomainOwnershipIdentifierOutput) ToWebAppDomainOwnershipIdentifierOutputWithContext(ctx context.Context) WebAppDomainOwnershipIdentifierOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppDomainOwnershipIdentifierOutput{})
}
