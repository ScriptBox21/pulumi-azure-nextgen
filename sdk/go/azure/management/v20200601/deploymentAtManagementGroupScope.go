// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Deployment information.
type DeploymentAtManagementGroupScope struct {
	pulumi.CustomResourceState

	// the location of the deployment.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// The name of the deployment.
	Name pulumi.StringOutput `pulumi:"name"`
	// Deployment properties.
	Properties DeploymentPropertiesExtendedResponseOutput `pulumi:"properties"`
	// Deployment tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The type of the deployment.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewDeploymentAtManagementGroupScope registers a new resource with the given unique name, arguments, and options.
func NewDeploymentAtManagementGroupScope(ctx *pulumi.Context,
	name string, args *DeploymentAtManagementGroupScopeArgs, opts ...pulumi.ResourceOption) (*DeploymentAtManagementGroupScope, error) {
	if args == nil || args.DeploymentName == nil {
		return nil, errors.New("missing required argument 'DeploymentName'")
	}
	if args == nil || args.GroupId == nil {
		return nil, errors.New("missing required argument 'GroupId'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.Properties == nil {
		return nil, errors.New("missing required argument 'Properties'")
	}
	if args == nil {
		args = &DeploymentAtManagementGroupScopeArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:management/latest:DeploymentAtManagementGroupScope"),
		},
		{
			Type: pulumi.String("azure-nextgen:management/v20190501:DeploymentAtManagementGroupScope"),
		},
		{
			Type: pulumi.String("azure-nextgen:management/v20190510:DeploymentAtManagementGroupScope"),
		},
		{
			Type: pulumi.String("azure-nextgen:management/v20190701:DeploymentAtManagementGroupScope"),
		},
		{
			Type: pulumi.String("azure-nextgen:management/v20190801:DeploymentAtManagementGroupScope"),
		},
		{
			Type: pulumi.String("azure-nextgen:management/v20191001:DeploymentAtManagementGroupScope"),
		},
		{
			Type: pulumi.String("azure-nextgen:management/v20200801:DeploymentAtManagementGroupScope"),
		},
		{
			Type: pulumi.String("azure-nextgen:management/v20201001:DeploymentAtManagementGroupScope"),
		},
	})
	opts = append(opts, aliases)
	var resource DeploymentAtManagementGroupScope
	err := ctx.RegisterResource("azure-nextgen:management/v20200601:DeploymentAtManagementGroupScope", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeploymentAtManagementGroupScope gets an existing DeploymentAtManagementGroupScope resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeploymentAtManagementGroupScope(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeploymentAtManagementGroupScopeState, opts ...pulumi.ResourceOption) (*DeploymentAtManagementGroupScope, error) {
	var resource DeploymentAtManagementGroupScope
	err := ctx.ReadResource("azure-nextgen:management/v20200601:DeploymentAtManagementGroupScope", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DeploymentAtManagementGroupScope resources.
type deploymentAtManagementGroupScopeState struct {
	// the location of the deployment.
	Location *string `pulumi:"location"`
	// The name of the deployment.
	Name *string `pulumi:"name"`
	// Deployment properties.
	Properties *DeploymentPropertiesExtendedResponse `pulumi:"properties"`
	// Deployment tags
	Tags map[string]string `pulumi:"tags"`
	// The type of the deployment.
	Type *string `pulumi:"type"`
}

type DeploymentAtManagementGroupScopeState struct {
	// the location of the deployment.
	Location pulumi.StringPtrInput
	// The name of the deployment.
	Name pulumi.StringPtrInput
	// Deployment properties.
	Properties DeploymentPropertiesExtendedResponsePtrInput
	// Deployment tags
	Tags pulumi.StringMapInput
	// The type of the deployment.
	Type pulumi.StringPtrInput
}

func (DeploymentAtManagementGroupScopeState) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentAtManagementGroupScopeState)(nil)).Elem()
}

type deploymentAtManagementGroupScopeArgs struct {
	// The name of the deployment.
	DeploymentName string `pulumi:"deploymentName"`
	// The management group ID.
	GroupId string `pulumi:"groupId"`
	// The location to store the deployment data.
	Location string `pulumi:"location"`
	// The deployment properties.
	Properties DeploymentProperties `pulumi:"properties"`
	// Deployment tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a DeploymentAtManagementGroupScope resource.
type DeploymentAtManagementGroupScopeArgs struct {
	// The name of the deployment.
	DeploymentName pulumi.StringInput
	// The management group ID.
	GroupId pulumi.StringInput
	// The location to store the deployment data.
	Location pulumi.StringInput
	// The deployment properties.
	Properties DeploymentPropertiesInput
	// Deployment tags
	Tags pulumi.StringMapInput
}

func (DeploymentAtManagementGroupScopeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deploymentAtManagementGroupScopeArgs)(nil)).Elem()
}

type DeploymentAtManagementGroupScopeInput interface {
	pulumi.Input

	ToDeploymentAtManagementGroupScopeOutput() DeploymentAtManagementGroupScopeOutput
	ToDeploymentAtManagementGroupScopeOutputWithContext(ctx context.Context) DeploymentAtManagementGroupScopeOutput
}

func (DeploymentAtManagementGroupScope) ElementType() reflect.Type {
	return reflect.TypeOf((*DeploymentAtManagementGroupScope)(nil)).Elem()
}

func (i DeploymentAtManagementGroupScope) ToDeploymentAtManagementGroupScopeOutput() DeploymentAtManagementGroupScopeOutput {
	return i.ToDeploymentAtManagementGroupScopeOutputWithContext(context.Background())
}

func (i DeploymentAtManagementGroupScope) ToDeploymentAtManagementGroupScopeOutputWithContext(ctx context.Context) DeploymentAtManagementGroupScopeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeploymentAtManagementGroupScopeOutput)
}

type DeploymentAtManagementGroupScopeOutput struct {
	*pulumi.OutputState
}

func (DeploymentAtManagementGroupScopeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DeploymentAtManagementGroupScopeOutput)(nil)).Elem()
}

func (o DeploymentAtManagementGroupScopeOutput) ToDeploymentAtManagementGroupScopeOutput() DeploymentAtManagementGroupScopeOutput {
	return o
}

func (o DeploymentAtManagementGroupScopeOutput) ToDeploymentAtManagementGroupScopeOutputWithContext(ctx context.Context) DeploymentAtManagementGroupScopeOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DeploymentAtManagementGroupScopeOutput{})
}
