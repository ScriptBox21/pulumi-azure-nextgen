// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Describes the source control configuration for web app
type SiteSourceControl struct {
	pulumi.CustomResourceState

	// Name of branch to use for deployment
	Branch pulumi.StringPtrOutput `pulumi:"branch"`
	// Whether to manual or continuous integration
	DeploymentRollbackEnabled pulumi.BoolPtrOutput `pulumi:"deploymentRollbackEnabled"`
	// Whether to manual or continuous integration
	IsManualIntegration pulumi.BoolPtrOutput `pulumi:"isManualIntegration"`
	// Mercurial or Git repository type
	IsMercurial pulumi.BoolPtrOutput `pulumi:"isMercurial"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Repository or source control url
	RepoUrl pulumi.StringPtrOutput `pulumi:"repoUrl"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewSiteSourceControl registers a new resource with the given unique name, arguments, and options.
func NewSiteSourceControl(ctx *pulumi.Context,
	name string, args *SiteSourceControlArgs, opts ...pulumi.ResourceOption) (*SiteSourceControl, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &SiteSourceControlArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:web/latest:SiteSourceControl"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20160801:SiteSourceControl"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20180201:SiteSourceControl"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20181101:SiteSourceControl"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20190801:SiteSourceControl"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200601:SiteSourceControl"),
		},
		{
			Type: pulumi.String("azure-nextgen:web/v20200901:SiteSourceControl"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteSourceControl
	err := ctx.RegisterResource("azure-nextgen:web/v20150801:SiteSourceControl", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteSourceControl gets an existing SiteSourceControl resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteSourceControl(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteSourceControlState, opts ...pulumi.ResourceOption) (*SiteSourceControl, error) {
	var resource SiteSourceControl
	err := ctx.ReadResource("azure-nextgen:web/v20150801:SiteSourceControl", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteSourceControl resources.
type siteSourceControlState struct {
	// Name of branch to use for deployment
	Branch *string `pulumi:"branch"`
	// Whether to manual or continuous integration
	DeploymentRollbackEnabled *bool `pulumi:"deploymentRollbackEnabled"`
	// Whether to manual or continuous integration
	IsManualIntegration *bool `pulumi:"isManualIntegration"`
	// Mercurial or Git repository type
	IsMercurial *bool `pulumi:"isMercurial"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Resource Name
	Name *string `pulumi:"name"`
	// Repository or source control url
	RepoUrl *string `pulumi:"repoUrl"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

type SiteSourceControlState struct {
	// Name of branch to use for deployment
	Branch pulumi.StringPtrInput
	// Whether to manual or continuous integration
	DeploymentRollbackEnabled pulumi.BoolPtrInput
	// Whether to manual or continuous integration
	IsManualIntegration pulumi.BoolPtrInput
	// Mercurial or Git repository type
	IsMercurial pulumi.BoolPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringPtrInput
	// Repository or source control url
	RepoUrl pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteSourceControlState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteSourceControlState)(nil)).Elem()
}

type siteSourceControlArgs struct {
	// Name of branch to use for deployment
	Branch *string `pulumi:"branch"`
	// Whether to manual or continuous integration
	DeploymentRollbackEnabled *bool `pulumi:"deploymentRollbackEnabled"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Whether to manual or continuous integration
	IsManualIntegration *bool `pulumi:"isManualIntegration"`
	// Mercurial or Git repository type
	IsMercurial *bool `pulumi:"isMercurial"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location string `pulumi:"location"`
	// Resource Name
	Name string `pulumi:"name"`
	// Repository or source control url
	RepoUrl *string `pulumi:"repoUrl"`
	// Name of resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a SiteSourceControl resource.
type SiteSourceControlArgs struct {
	// Name of branch to use for deployment
	Branch pulumi.StringPtrInput
	// Whether to manual or continuous integration
	DeploymentRollbackEnabled pulumi.BoolPtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Whether to manual or continuous integration
	IsManualIntegration pulumi.BoolPtrInput
	// Mercurial or Git repository type
	IsMercurial pulumi.BoolPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringInput
	// Resource Name
	Name pulumi.StringInput
	// Repository or source control url
	RepoUrl pulumi.StringPtrInput
	// Name of resource group
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteSourceControlArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteSourceControlArgs)(nil)).Elem()
}

type SiteSourceControlInput interface {
	pulumi.Input

	ToSiteSourceControlOutput() SiteSourceControlOutput
	ToSiteSourceControlOutputWithContext(ctx context.Context) SiteSourceControlOutput
}

func (SiteSourceControl) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteSourceControl)(nil)).Elem()
}

func (i SiteSourceControl) ToSiteSourceControlOutput() SiteSourceControlOutput {
	return i.ToSiteSourceControlOutputWithContext(context.Background())
}

func (i SiteSourceControl) ToSiteSourceControlOutputWithContext(ctx context.Context) SiteSourceControlOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteSourceControlOutput)
}

type SiteSourceControlOutput struct {
	*pulumi.OutputState
}

func (SiteSourceControlOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SiteSourceControlOutput)(nil)).Elem()
}

func (o SiteSourceControlOutput) ToSiteSourceControlOutput() SiteSourceControlOutput {
	return o
}

func (o SiteSourceControlOutput) ToSiteSourceControlOutputWithContext(ctx context.Context) SiteSourceControlOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SiteSourceControlOutput{})
}
