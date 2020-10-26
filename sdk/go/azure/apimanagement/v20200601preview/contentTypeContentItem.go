// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Content type contract details.
type ContentTypeContentItem struct {
	pulumi.CustomResourceState

	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Properties of the content item.
	Properties pulumi.AnyOutput `pulumi:"properties"`
	// Resource type for API Management resource.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewContentTypeContentItem registers a new resource with the given unique name, arguments, and options.
func NewContentTypeContentItem(ctx *pulumi.Context,
	name string, args *ContentTypeContentItemArgs, opts ...pulumi.ResourceOption) (*ContentTypeContentItem, error) {
	if args == nil || args.ContentItemId == nil {
		return nil, errors.New("missing required argument 'ContentItemId'")
	}
	if args == nil || args.ContentTypeId == nil {
		return nil, errors.New("missing required argument 'ContentTypeId'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServiceName == nil {
		return nil, errors.New("missing required argument 'ServiceName'")
	}
	if args == nil {
		args = &ContentTypeContentItemArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:apimanagement/latest:ContentTypeContentItem"),
		},
		{
			Type: pulumi.String("azure-nextgen:apimanagement/v20191201:ContentTypeContentItem"),
		},
	})
	opts = append(opts, aliases)
	var resource ContentTypeContentItem
	err := ctx.RegisterResource("azure-nextgen:apimanagement/v20200601preview:ContentTypeContentItem", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContentTypeContentItem gets an existing ContentTypeContentItem resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContentTypeContentItem(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContentTypeContentItemState, opts ...pulumi.ResourceOption) (*ContentTypeContentItem, error) {
	var resource ContentTypeContentItem
	err := ctx.ReadResource("azure-nextgen:apimanagement/v20200601preview:ContentTypeContentItem", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContentTypeContentItem resources.
type contentTypeContentItemState struct {
	// Resource name.
	Name *string `pulumi:"name"`
	// Properties of the content item.
	Properties interface{} `pulumi:"properties"`
	// Resource type for API Management resource.
	Type *string `pulumi:"type"`
}

type ContentTypeContentItemState struct {
	// Resource name.
	Name pulumi.StringPtrInput
	// Properties of the content item.
	Properties pulumi.Input
	// Resource type for API Management resource.
	Type pulumi.StringPtrInput
}

func (ContentTypeContentItemState) ElementType() reflect.Type {
	return reflect.TypeOf((*contentTypeContentItemState)(nil)).Elem()
}

type contentTypeContentItemArgs struct {
	// Content item identifier.
	ContentItemId string `pulumi:"contentItemId"`
	// Content type identifier.
	ContentTypeId string `pulumi:"contentTypeId"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the API Management service.
	ServiceName string `pulumi:"serviceName"`
}

// The set of arguments for constructing a ContentTypeContentItem resource.
type ContentTypeContentItemArgs struct {
	// Content item identifier.
	ContentItemId pulumi.StringInput
	// Content type identifier.
	ContentTypeId pulumi.StringInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// The name of the API Management service.
	ServiceName pulumi.StringInput
}

func (ContentTypeContentItemArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*contentTypeContentItemArgs)(nil)).Elem()
}