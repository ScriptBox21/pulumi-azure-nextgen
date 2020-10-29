// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A Streaming Locator resource
type StreamingLocator struct {
	pulumi.CustomResourceState

	// Alternative Media ID of this Streaming Locator
	AlternativeMediaId pulumi.StringPtrOutput `pulumi:"alternativeMediaId"`
	// Asset Name
	AssetName pulumi.StringOutput `pulumi:"assetName"`
	// The ContentKeys used by this Streaming Locator.
	ContentKeys StreamingLocatorContentKeyResponseArrayOutput `pulumi:"contentKeys"`
	// The creation time of the Streaming Locator.
	Created pulumi.StringOutput `pulumi:"created"`
	// Name of the default ContentKeyPolicy used by this Streaming Locator.
	DefaultContentKeyPolicyName pulumi.StringPtrOutput `pulumi:"defaultContentKeyPolicyName"`
	// The end time of the Streaming Locator.
	EndTime pulumi.StringPtrOutput `pulumi:"endTime"`
	// A list of asset or account filters which apply to this streaming locator
	Filters pulumi.StringArrayOutput `pulumi:"filters"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// The start time of the Streaming Locator.
	StartTime pulumi.StringPtrOutput `pulumi:"startTime"`
	// The StreamingLocatorId of the Streaming Locator.
	StreamingLocatorId pulumi.StringPtrOutput `pulumi:"streamingLocatorId"`
	// Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
	StreamingPolicyName pulumi.StringOutput `pulumi:"streamingPolicyName"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewStreamingLocator registers a new resource with the given unique name, arguments, and options.
func NewStreamingLocator(ctx *pulumi.Context,
	name string, args *StreamingLocatorArgs, opts ...pulumi.ResourceOption) (*StreamingLocator, error) {
	if args == nil || args.AccountName == nil {
		return nil, errors.New("missing required argument 'AccountName'")
	}
	if args == nil || args.AssetName == nil {
		return nil, errors.New("missing required argument 'AssetName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.StreamingLocatorName == nil {
		return nil, errors.New("missing required argument 'StreamingLocatorName'")
	}
	if args == nil || args.StreamingPolicyName == nil {
		return nil, errors.New("missing required argument 'StreamingPolicyName'")
	}
	if args == nil {
		args = &StreamingLocatorArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:media/v20180330preview:StreamingLocator"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180601preview:StreamingLocator"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20180701:StreamingLocator"),
		},
		{
			Type: pulumi.String("azure-nextgen:media/v20200501:StreamingLocator"),
		},
	})
	opts = append(opts, aliases)
	var resource StreamingLocator
	err := ctx.RegisterResource("azure-nextgen:media/latest:StreamingLocator", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStreamingLocator gets an existing StreamingLocator resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStreamingLocator(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StreamingLocatorState, opts ...pulumi.ResourceOption) (*StreamingLocator, error) {
	var resource StreamingLocator
	err := ctx.ReadResource("azure-nextgen:media/latest:StreamingLocator", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StreamingLocator resources.
type streamingLocatorState struct {
	// Alternative Media ID of this Streaming Locator
	AlternativeMediaId *string `pulumi:"alternativeMediaId"`
	// Asset Name
	AssetName *string `pulumi:"assetName"`
	// The ContentKeys used by this Streaming Locator.
	ContentKeys []StreamingLocatorContentKeyResponse `pulumi:"contentKeys"`
	// The creation time of the Streaming Locator.
	Created *string `pulumi:"created"`
	// Name of the default ContentKeyPolicy used by this Streaming Locator.
	DefaultContentKeyPolicyName *string `pulumi:"defaultContentKeyPolicyName"`
	// The end time of the Streaming Locator.
	EndTime *string `pulumi:"endTime"`
	// A list of asset or account filters which apply to this streaming locator
	Filters []string `pulumi:"filters"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// The start time of the Streaming Locator.
	StartTime *string `pulumi:"startTime"`
	// The StreamingLocatorId of the Streaming Locator.
	StreamingLocatorId *string `pulumi:"streamingLocatorId"`
	// Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
	StreamingPolicyName *string `pulumi:"streamingPolicyName"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type StreamingLocatorState struct {
	// Alternative Media ID of this Streaming Locator
	AlternativeMediaId pulumi.StringPtrInput
	// Asset Name
	AssetName pulumi.StringPtrInput
	// The ContentKeys used by this Streaming Locator.
	ContentKeys StreamingLocatorContentKeyResponseArrayInput
	// The creation time of the Streaming Locator.
	Created pulumi.StringPtrInput
	// Name of the default ContentKeyPolicy used by this Streaming Locator.
	DefaultContentKeyPolicyName pulumi.StringPtrInput
	// The end time of the Streaming Locator.
	EndTime pulumi.StringPtrInput
	// A list of asset or account filters which apply to this streaming locator
	Filters pulumi.StringArrayInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// The start time of the Streaming Locator.
	StartTime pulumi.StringPtrInput
	// The StreamingLocatorId of the Streaming Locator.
	StreamingLocatorId pulumi.StringPtrInput
	// Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
	StreamingPolicyName pulumi.StringPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (StreamingLocatorState) ElementType() reflect.Type {
	return reflect.TypeOf((*streamingLocatorState)(nil)).Elem()
}

type streamingLocatorArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// Alternative Media ID of this Streaming Locator
	AlternativeMediaId *string `pulumi:"alternativeMediaId"`
	// Asset Name
	AssetName string `pulumi:"assetName"`
	// The ContentKeys used by this Streaming Locator.
	ContentKeys []StreamingLocatorContentKey `pulumi:"contentKeys"`
	// Name of the default ContentKeyPolicy used by this Streaming Locator.
	DefaultContentKeyPolicyName *string `pulumi:"defaultContentKeyPolicyName"`
	// The end time of the Streaming Locator.
	EndTime *string `pulumi:"endTime"`
	// A list of asset or account filters which apply to this streaming locator
	Filters []string `pulumi:"filters"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The start time of the Streaming Locator.
	StartTime *string `pulumi:"startTime"`
	// The StreamingLocatorId of the Streaming Locator.
	StreamingLocatorId *string `pulumi:"streamingLocatorId"`
	// The Streaming Locator name.
	StreamingLocatorName string `pulumi:"streamingLocatorName"`
	// Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
	StreamingPolicyName string `pulumi:"streamingPolicyName"`
}

// The set of arguments for constructing a StreamingLocator resource.
type StreamingLocatorArgs struct {
	// The Media Services account name.
	AccountName pulumi.StringInput
	// Alternative Media ID of this Streaming Locator
	AlternativeMediaId pulumi.StringPtrInput
	// Asset Name
	AssetName pulumi.StringInput
	// The ContentKeys used by this Streaming Locator.
	ContentKeys StreamingLocatorContentKeyArrayInput
	// Name of the default ContentKeyPolicy used by this Streaming Locator.
	DefaultContentKeyPolicyName pulumi.StringPtrInput
	// The end time of the Streaming Locator.
	EndTime pulumi.StringPtrInput
	// A list of asset or account filters which apply to this streaming locator
	Filters pulumi.StringArrayInput
	// The name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// The start time of the Streaming Locator.
	StartTime pulumi.StringPtrInput
	// The StreamingLocatorId of the Streaming Locator.
	StreamingLocatorId pulumi.StringPtrInput
	// The Streaming Locator name.
	StreamingLocatorName pulumi.StringInput
	// Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
	StreamingPolicyName pulumi.StringInput
}

func (StreamingLocatorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*streamingLocatorArgs)(nil)).Elem()
}
