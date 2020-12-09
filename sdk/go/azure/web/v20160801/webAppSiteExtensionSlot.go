// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Site Extension Information.
type WebAppSiteExtensionSlot struct {
	pulumi.CustomResourceState

	// List of authors.
	Authors pulumi.StringArrayOutput `pulumi:"authors"`
	// Site Extension comment.
	Comment pulumi.StringPtrOutput `pulumi:"comment"`
	// Detailed description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Count of downloads.
	DownloadCount pulumi.IntPtrOutput `pulumi:"downloadCount"`
	// Extension URL.
	ExtensionUrl pulumi.StringPtrOutput `pulumi:"extensionUrl"`
	// Feed URL.
	FeedUrl pulumi.StringPtrOutput `pulumi:"feedUrl"`
	// Icon URL.
	IconUrl pulumi.StringPtrOutput `pulumi:"iconUrl"`
	// Installer command line parameters.
	InstallationArgs pulumi.StringPtrOutput `pulumi:"installationArgs"`
	// Installed timestamp.
	InstalledDateTime pulumi.StringPtrOutput `pulumi:"installedDateTime"`
	// Kind of resource.
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// License URL.
	LicenseUrl pulumi.StringPtrOutput `pulumi:"licenseUrl"`
	// <code>true</code> if the local version is the latest version; <code>false</code> otherwise.
	LocalIsLatestVersion pulumi.BoolPtrOutput `pulumi:"localIsLatestVersion"`
	// Local path.
	LocalPath pulumi.StringPtrOutput `pulumi:"localPath"`
	// Resource Name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Project URL.
	ProjectUrl pulumi.StringPtrOutput `pulumi:"projectUrl"`
	// Provisioning state.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Published timestamp.
	PublishedDateTime pulumi.StringPtrOutput `pulumi:"publishedDateTime"`
	// Summary description.
	Summary pulumi.StringPtrOutput `pulumi:"summary"`
	// Site extension title.
	Title pulumi.StringPtrOutput `pulumi:"title"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// Version information.
	Version pulumi.StringPtrOutput `pulumi:"version"`
}

// NewWebAppSiteExtensionSlot registers a new resource with the given unique name, arguments, and options.
func NewWebAppSiteExtensionSlot(ctx *pulumi.Context,
	name string, args *WebAppSiteExtensionSlotArgs, opts ...pulumi.ResourceOption) (*WebAppSiteExtensionSlot, error) {
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SiteExtensionId == nil {
		return nil, errors.New("missing required argument 'SiteExtensionId'")
	}
	if args == nil || args.Slot == nil {
		return nil, errors.New("missing required argument 'Slot'")
	}
	if args == nil {
		args = &WebAppSiteExtensionSlotArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:WebAppSiteExtensionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:WebAppSiteExtensionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:WebAppSiteExtensionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:WebAppSiteExtensionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:WebAppSiteExtensionSlot"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:WebAppSiteExtensionSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource WebAppSiteExtensionSlot
	err := ctx.RegisterResource("azure-nextgen:web/v20160801:WebAppSiteExtensionSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebAppSiteExtensionSlot gets an existing WebAppSiteExtensionSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebAppSiteExtensionSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebAppSiteExtensionSlotState, opts ...pulumi.ResourceOption) (*WebAppSiteExtensionSlot, error) {
	var resource WebAppSiteExtensionSlot
	err := ctx.ReadResource("azure-nextgen:web/v20160801:WebAppSiteExtensionSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WebAppSiteExtensionSlot resources.
type webAppSiteExtensionSlotState struct {
	// List of authors.
	Authors []string `pulumi:"authors"`
	// Site Extension comment.
	Comment *string `pulumi:"comment"`
	// Detailed description.
	Description *string `pulumi:"description"`
	// Count of downloads.
	DownloadCount *int `pulumi:"downloadCount"`
	// Extension URL.
	ExtensionUrl *string `pulumi:"extensionUrl"`
	// Feed URL.
	FeedUrl *string `pulumi:"feedUrl"`
	// Icon URL.
	IconUrl *string `pulumi:"iconUrl"`
	// Installer command line parameters.
	InstallationArgs *string `pulumi:"installationArgs"`
	// Installed timestamp.
	InstalledDateTime *string `pulumi:"installedDateTime"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// License URL.
	LicenseUrl *string `pulumi:"licenseUrl"`
	// <code>true</code> if the local version is the latest version; <code>false</code> otherwise.
	LocalIsLatestVersion *bool `pulumi:"localIsLatestVersion"`
	// Local path.
	LocalPath *string `pulumi:"localPath"`
	// Resource Name.
	Name *string `pulumi:"name"`
	// Project URL.
	ProjectUrl *string `pulumi:"projectUrl"`
	// Provisioning state.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Published timestamp.
	PublishedDateTime *string `pulumi:"publishedDateTime"`
	// Summary description.
	Summary *string `pulumi:"summary"`
	// Site extension title.
	Title *string `pulumi:"title"`
	// Resource type.
	Type *string `pulumi:"type"`
	// Version information.
	Version *string `pulumi:"version"`
}

type WebAppSiteExtensionSlotState struct {
	// List of authors.
	Authors pulumi.StringArrayInput
	// Site Extension comment.
	Comment pulumi.StringPtrInput
	// Detailed description.
	Description pulumi.StringPtrInput
	// Count of downloads.
	DownloadCount pulumi.IntPtrInput
	// Extension URL.
	ExtensionUrl pulumi.StringPtrInput
	// Feed URL.
	FeedUrl pulumi.StringPtrInput
	// Icon URL.
	IconUrl pulumi.StringPtrInput
	// Installer command line parameters.
	InstallationArgs pulumi.StringPtrInput
	// Installed timestamp.
	InstalledDateTime pulumi.StringPtrInput
	// Kind of resource.
	Kind pulumi.StringPtrInput
	// License URL.
	LicenseUrl pulumi.StringPtrInput
	// <code>true</code> if the local version is the latest version; <code>false</code> otherwise.
	LocalIsLatestVersion pulumi.BoolPtrInput
	// Local path.
	LocalPath pulumi.StringPtrInput
	// Resource Name.
	Name pulumi.StringPtrInput
	// Project URL.
	ProjectUrl pulumi.StringPtrInput
	// Provisioning state.
	ProvisioningState pulumi.StringPtrInput
	// Published timestamp.
	PublishedDateTime pulumi.StringPtrInput
	// Summary description.
	Summary pulumi.StringPtrInput
	// Site extension title.
	Title pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
	// Version information.
	Version pulumi.StringPtrInput
}

func (WebAppSiteExtensionSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSiteExtensionSlotState)(nil)).Elem()
}

type webAppSiteExtensionSlotArgs struct {
	// Site name.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Site extension name.
	SiteExtensionId string `pulumi:"siteExtensionId"`
	// Name of the deployment slot. If a slot is not specified, the API deletes a deployment for the production slot.
	Slot string `pulumi:"slot"`
}

// The set of arguments for constructing a WebAppSiteExtensionSlot resource.
type WebAppSiteExtensionSlotArgs struct {
	// Site name.
	Name pulumi.StringInput
	// Name of the resource group to which the resource belongs.
	ResourceGroupName pulumi.StringInput
	// Site extension name.
	SiteExtensionId pulumi.StringInput
	// Name of the deployment slot. If a slot is not specified, the API deletes a deployment for the production slot.
	Slot pulumi.StringInput
}

func (WebAppSiteExtensionSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webAppSiteExtensionSlotArgs)(nil)).Elem()
}

type WebAppSiteExtensionSlotInput interface {
	pulumi.Input

	ToWebAppSiteExtensionSlotOutput() WebAppSiteExtensionSlotOutput
	ToWebAppSiteExtensionSlotOutputWithContext(ctx context.Context) WebAppSiteExtensionSlotOutput
}

func (WebAppSiteExtensionSlot) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSiteExtensionSlot)(nil)).Elem()
}

func (i WebAppSiteExtensionSlot) ToWebAppSiteExtensionSlotOutput() WebAppSiteExtensionSlotOutput {
	return i.ToWebAppSiteExtensionSlotOutputWithContext(context.Background())
}

func (i WebAppSiteExtensionSlot) ToWebAppSiteExtensionSlotOutputWithContext(ctx context.Context) WebAppSiteExtensionSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebAppSiteExtensionSlotOutput)
}

type WebAppSiteExtensionSlotOutput struct {
	*pulumi.OutputState
}

func (WebAppSiteExtensionSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WebAppSiteExtensionSlotOutput)(nil)).Elem()
}

func (o WebAppSiteExtensionSlotOutput) ToWebAppSiteExtensionSlotOutput() WebAppSiteExtensionSlotOutput {
	return o
}

func (o WebAppSiteExtensionSlotOutput) ToWebAppSiteExtensionSlotOutputWithContext(ctx context.Context) WebAppSiteExtensionSlotOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebAppSiteExtensionSlotOutput{})
}
