// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20171101preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The response to an extension resource GET request.
type Extension struct {
	pulumi.CustomResourceState

	// Resource location.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The extension plan that was purchased.
	Plan ExtensionResourcePlanResponsePtrOutput `pulumi:"plan"`
	// Resource properties.
	Properties pulumi.StringMapOutput `pulumi:"properties"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewExtension registers a new resource with the given unique name, arguments, and options.
func NewExtension(ctx *pulumi.Context,
	name string, args *ExtensionArgs, opts ...pulumi.ResourceOption) (*Extension, error) {
	if args == nil || args.AccountResourceName == nil {
		return nil, errors.New("missing required argument 'AccountResourceName'")
	}
	if args == nil || args.ExtensionResourceName == nil {
		return nil, errors.New("missing required argument 'ExtensionResourceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ExtensionArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:visualstudio/v20140401preview:Extension"),
		},
	})
	opts = append(opts, aliases)
	var resource Extension
	err := ctx.RegisterResource("azure-nextgen:visualstudio/v20171101preview:Extension", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExtension gets an existing Extension resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExtension(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExtensionState, opts ...pulumi.ResourceOption) (*Extension, error) {
	var resource Extension
	err := ctx.ReadResource("azure-nextgen:visualstudio/v20171101preview:Extension", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Extension resources.
type extensionState struct {
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name *string `pulumi:"name"`
	// The extension plan that was purchased.
	Plan *ExtensionResourcePlanResponse `pulumi:"plan"`
	// Resource properties.
	Properties map[string]string `pulumi:"properties"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type *string `pulumi:"type"`
}

type ExtensionState struct {
	// Resource location.
	Location pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// The extension plan that was purchased.
	Plan ExtensionResourcePlanResponsePtrInput
	// Resource properties.
	Properties pulumi.StringMapInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Resource type.
	Type pulumi.StringPtrInput
}

func (ExtensionState) ElementType() reflect.Type {
	return reflect.TypeOf((*extensionState)(nil)).Elem()
}

type extensionArgs struct {
	// The name of the Visual Studio Team Services account resource.
	AccountResourceName string `pulumi:"accountResourceName"`
	// The name of the extension.
	ExtensionResourceName string `pulumi:"extensionResourceName"`
	// The Azure region of the Visual Studio account associated with this request (i.e 'southcentralus'.)
	Location *string `pulumi:"location"`
	// Extended information about the plan being purchased for this extension resource.
	Plan *ExtensionResourcePlan `pulumi:"plan"`
	// A dictionary of extended properties. This property is currently unused.
	Properties map[string]string `pulumi:"properties"`
	// Name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// A dictionary of user-defined tags to be stored with the extension resource.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Extension resource.
type ExtensionArgs struct {
	// The name of the Visual Studio Team Services account resource.
	AccountResourceName pulumi.StringInput
	// The name of the extension.
	ExtensionResourceName pulumi.StringInput
	// The Azure region of the Visual Studio account associated with this request (i.e 'southcentralus'.)
	Location pulumi.StringPtrInput
	// Extended information about the plan being purchased for this extension resource.
	Plan ExtensionResourcePlanPtrInput
	// A dictionary of extended properties. This property is currently unused.
	Properties pulumi.StringMapInput
	// Name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// A dictionary of user-defined tags to be stored with the extension resource.
	Tags pulumi.StringMapInput
}

func (ExtensionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*extensionArgs)(nil)).Elem()
}
