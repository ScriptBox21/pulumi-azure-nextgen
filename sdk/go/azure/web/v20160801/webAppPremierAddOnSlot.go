// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Premier add-on.
type WebAppPremierAddOnSlot struct {
	pulumi.CustomResourceState

	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Premier add on Marketplace offer.
	MarketplaceOffer pulumi.StringPtrOutput `pulumi:"marketplaceOffer"`
	// Premier add on Marketplace publisher.
	MarketplacePublisher pulumi.StringPtrOutput `pulumi:"marketplacePublisher"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Premier add on Name.
	PremierAddOnName pulumi.StringPtrOutput `pulumi:"premierAddOnName"`
	// Premier add on Product.
	Product pulumi.StringPtrOutput `pulumi:"product"`
	// Premier add on SKU.
	Sku pulumi.StringPtrOutput `pulumi:"sku"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// Premier add on Vendor.
	Vendor pulumi.StringPtrOutput `pulumi:"vendor"`
}

// NewWebAppPremierAddOnSlot registers a new resource with the given unique name, arguments, and options.
func NewWebAppPremierAddOnSlot(ctx *pulumi.Context,
	name string, args *WebAppPremierAddOnSlotArgs, opts ...pulumi.ResourceOption) (*WebAppPremierAddOnSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.PremierAddOnName == nil {
		return nil, errors.New("invalid value for required argument 'PremierAddOnName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.Slot == nil {
		return nil, errors.New("invalid value for required argument 'Slot'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppPremierAddOnSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20150801:WebAppPremierAddOnSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppPremierAddOnSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppPremierAddOnSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppPremierAddOnSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppPremierAddOnSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppPremierAddOnSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20201001:WebAppPremierAddOnSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppPremierAddOnSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20160801:WebAppPremierAddOnSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppPremierAddOnSlot gets an existing WebAppPremierAddOnSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppPremierAddOnSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppPremierAddOnSlotState, opts ...pulumi.ResourceOption) (*WebAppPremierAddOnSlot, error) {
	var resource WebAppPremierAddOnSlot
	err := ctx.ReadResource("azure-nextgen:web/v20160801:WebAppPremierAddOnSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppPremierAddOnSlot resources.
type webAppPremierAddOnSlotState struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location *string `pulumi:"location"`
	// Premier add on Marketplace offer.
	MarketplaceOffer *string `pulumi:"marketplaceOffer"`
	// Premier add on Marketplace publisher.
	MarketplacePublisher *string `pulumi:"marketplacePublisher"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Premier add on Name.
	PremierAddOnName *string `pulumi:"premierAddOnName"`
	// Premier add on Product.
	Product *string `pulumi:"product"`
	// Premier add on SKU.
	Sku *string `pulumi:"sku"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
	// Premier add on Vendor.
	Vendor *string `pulumi:"vendor"`
}

type WebAppPremierAddOnSlotState struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringPtrInput
	// Premier add on Marketplace offer.
	MarketplaceOffer pulumi.StringPtrInput
	// Premier add on Marketplace publisher.
	MarketplacePublisher pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Premier add on Name.
	PremierAddOnName pulumi.StringPtrInput
	// Premier add on Product.
	Product pulumi.StringPtrInput
	// Premier add on SKU.
	Sku pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
	// Premier add on Vendor.
	Vendor pulumi.StringPtrInput
}

func (WebAppPremierAddOnSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppPremierAddOnSlotState)(nil)).Elem()
}

type webAppPremierAddOnSlotArgs struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Location.
	Location *string `pulumi:"location"`
	// Premier add on Marketplace offer.
	MarketplaceOffer *string `pulumi:"marketplaceOffer"`
	// Premier add on Marketplace publisher.
	MarketplacePublisher *string `pulumi:"marketplacePublisher"`
	// Name of the app.
	Name string `pulumi:"name"`
	// Premier add on Name.
	PremierAddOnName string `pulumi:"premierAddOnName"`
	// Premier add on Product.
	Product *string `pulumi:"product"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Premier add on SKU.
	Sku *string `pulumi:"sku"`
	// Name of the deployment slot. If a slot is not specified, the API will update the named add-on for the production slot.
	Slot string `pulumi:"slot"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Premier add on Vendor.
	Vendor *string `pulumi:"vendor"`
}

// The set of arguments for constructing a WebAppPremierAddOnSlot resource.
type WebAppPremierAddOnSlotArgs struct {
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// Resource Location.
	Location pulumi.StringPtrInput
	// Premier add on Marketplace offer.
	MarketplaceOffer pulumi.StringPtrInput
	// Premier add on Marketplace publisher.
	MarketplacePublisher pulumi.StringPtrInput
	// Name of the app.
	Name pulumi.StringInput
	// Premier add on Name.
	PremierAddOnName pulumi.StringInput
	// Premier add on Product.
	Product pulumi.StringPtrInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Premier add on SKU.
	Sku pulumi.StringPtrInput
	// Name of the deployment slot. If a slot is not specified, the API will update the named add-on for the production slot.
	Slot pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Premier add on Vendor.
	Vendor pulumi.StringPtrInput
}

func (WebAppPremierAddOnSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppPremierAddOnSlotArgs)(nil)).Elem()
}

type WebAppPremierAddOnSlotInput interface {
	pulumi.Input

	ToWebAppPremierAddOnSlotOutput() WebAppPremierAddOnSlotOutput
	ToWebAppPremierAddOnSlotOutputWithContext(ctx context.Context) WebAppPremierAddOnSlotOutput
}

func (*WebAppPremierAddOnSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppPremierAddOnSlot)(nil))
}

func (i *WebAppPremierAddOnSlot) ToWebAppPremierAddOnSlotOutput() WebAppPremierAddOnSlotOutput {
	return i.ToWebAppPremierAddOnSlotOutputWithContext(context.Background())
}

func (i *WebAppPremierAddOnSlot) ToWebAppPremierAddOnSlotOutputWithContext(ctx context.Context) WebAppPremierAddOnSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppPremierAddOnSlotOutput)
}

type WebAppPremierAddOnSlotOutput struct {
	*pulumi.OutputState
}

func (WebAppPremierAddOnSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppPremierAddOnSlot)(nil))
}

func (o WebAppPremierAddOnSlotOutput) ToWebAppPremierAddOnSlotOutput() WebAppPremierAddOnSlotOutput {
	return o
}

func (o WebAppPremierAddOnSlotOutput) ToWebAppPremierAddOnSlotOutputWithContext(ctx context.Context) WebAppPremierAddOnSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppPremierAddOnSlotOutput{})
}
