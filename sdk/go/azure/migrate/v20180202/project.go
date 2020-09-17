// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180202

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Azure Migrate Project.
type Project struct {
	pulumi.CustomResourceState

	// Time when this project was created. Date-Time represented in ISO-8601 format.
	CreatedTimestamp pulumi.StringOutput `pulumi:"createdTimestamp"`
	// ARM ID of the Service Map workspace created by user.
	CustomerWorkspaceId pulumi.StringPtrOutput `pulumi:"customerWorkspaceId"`
	// Location of the Service Map workspace created by user.
	CustomerWorkspaceLocation pulumi.StringPtrOutput `pulumi:"customerWorkspaceLocation"`
	// Reports whether project is under discovery.
	DiscoveryStatus pulumi.StringOutput `pulumi:"discoveryStatus"`
	// For optimistic concurrency control.
	ETag pulumi.StringPtrOutput `pulumi:"eTag"`
	// Time when last assessment was created. Date-Time represented in ISO-8601 format. This value will be null until assessment is created.
	LastAssessmentTimestamp pulumi.StringOutput `pulumi:"lastAssessmentTimestamp"`
	// Session id of the last discovery.
	LastDiscoverySessionId pulumi.StringOutput `pulumi:"lastDiscoverySessionId"`
	// Time when this project was created. Date-Time represented in ISO-8601 format. This value will be null until discovery is complete.
	LastDiscoveryTimestamp pulumi.StringOutput `pulumi:"lastDiscoveryTimestamp"`
	// Azure location in which project is created.
	Location pulumi.StringPtrOutput `pulumi:"location"`
	// Name of the project.
	Name pulumi.StringOutput `pulumi:"name"`
	// Number of assessments created in the project.
	NumberOfAssessments pulumi.IntOutput `pulumi:"numberOfAssessments"`
	// Number of groups created in the project.
	NumberOfGroups pulumi.IntOutput `pulumi:"numberOfGroups"`
	// Number of machines in the project.
	NumberOfMachines pulumi.IntOutput `pulumi:"numberOfMachines"`
	// Provisioning state of the project.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Tags provided by Azure Tagging service.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// Type of the object = [Microsoft.Migrate/projects].
	Type pulumi.StringOutput `pulumi:"type"`
	// Time when this project was last updated. Date-Time represented in ISO-8601 format.
	UpdatedTimestamp pulumi.StringOutput `pulumi:"updatedTimestamp"`
}

// NewProject registers a new resource with the given unique name, arguments, and options.
func NewProject(ctx *pulumi.Context,
	name string, args *ProjectArgs, opts ...pulumi.ResourceOption) (*Project, error) {
	if args == nil || args.ProjectName == nil {
		return nil, errors.New("missing required argument 'ProjectName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ProjectArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:migrate/v20171111preview:Project"),
		},
	})
	opts = append(opts, aliases)
	var resource Project
	err := ctx.RegisterResource("azure-nextgen:migrate/v20180202:Project", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProject gets an existing Project resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProject(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProjectState, opts ...pulumi.ResourceOption) (*Project, error) {
	var resource Project
	err := ctx.ReadResource("azure-nextgen:migrate/v20180202:Project", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Project resources.
type projectState struct {
	// Time when this project was created. Date-Time represented in ISO-8601 format.
	CreatedTimestamp *string `pulumi:"createdTimestamp"`
	// ARM ID of the Service Map workspace created by user.
	CustomerWorkspaceId *string `pulumi:"customerWorkspaceId"`
	// Location of the Service Map workspace created by user.
	CustomerWorkspaceLocation *string `pulumi:"customerWorkspaceLocation"`
	// Reports whether project is under discovery.
	DiscoveryStatus *string `pulumi:"discoveryStatus"`
	// For optimistic concurrency control.
	ETag *string `pulumi:"eTag"`
	// Time when last assessment was created. Date-Time represented in ISO-8601 format. This value will be null until assessment is created.
	LastAssessmentTimestamp *string `pulumi:"lastAssessmentTimestamp"`
	// Session id of the last discovery.
	LastDiscoverySessionId *string `pulumi:"lastDiscoverySessionId"`
	// Time when this project was created. Date-Time represented in ISO-8601 format. This value will be null until discovery is complete.
	LastDiscoveryTimestamp *string `pulumi:"lastDiscoveryTimestamp"`
	// Azure location in which project is created.
	Location *string `pulumi:"location"`
	// Name of the project.
	Name *string `pulumi:"name"`
	// Number of assessments created in the project.
	NumberOfAssessments *int `pulumi:"numberOfAssessments"`
	// Number of groups created in the project.
	NumberOfGroups *int `pulumi:"numberOfGroups"`
	// Number of machines in the project.
	NumberOfMachines *int `pulumi:"numberOfMachines"`
	// Provisioning state of the project.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Tags provided by Azure Tagging service.
	Tags map[string]interface{} `pulumi:"tags"`
	// Type of the object = [Microsoft.Migrate/projects].
	Type *string `pulumi:"type"`
	// Time when this project was last updated. Date-Time represented in ISO-8601 format.
	UpdatedTimestamp *string `pulumi:"updatedTimestamp"`
}

type ProjectState struct {
	// Time when this project was created. Date-Time represented in ISO-8601 format.
	CreatedTimestamp pulumi.StringPtrInput
	// ARM ID of the Service Map workspace created by user.
	CustomerWorkspaceId pulumi.StringPtrInput
	// Location of the Service Map workspace created by user.
	CustomerWorkspaceLocation pulumi.StringPtrInput
	// Reports whether project is under discovery.
	DiscoveryStatus pulumi.StringPtrInput
	// For optimistic concurrency control.
	ETag pulumi.StringPtrInput
	// Time when last assessment was created. Date-Time represented in ISO-8601 format. This value will be null until assessment is created.
	LastAssessmentTimestamp pulumi.StringPtrInput
	// Session id of the last discovery.
	LastDiscoverySessionId pulumi.StringPtrInput
	// Time when this project was created. Date-Time represented in ISO-8601 format. This value will be null until discovery is complete.
	LastDiscoveryTimestamp pulumi.StringPtrInput
	// Azure location in which project is created.
	Location pulumi.StringPtrInput
	// Name of the project.
	Name pulumi.StringPtrInput
	// Number of assessments created in the project.
	NumberOfAssessments pulumi.IntPtrInput
	// Number of groups created in the project.
	NumberOfGroups pulumi.IntPtrInput
	// Number of machines in the project.
	NumberOfMachines pulumi.IntPtrInput
	// Provisioning state of the project.
	ProvisioningState pulumi.StringPtrInput
	// Tags provided by Azure Tagging service.
	Tags pulumi.MapInput
	// Type of the object = [Microsoft.Migrate/projects].
	Type pulumi.StringPtrInput
	// Time when this project was last updated. Date-Time represented in ISO-8601 format.
	UpdatedTimestamp pulumi.StringPtrInput
}

func (ProjectState) ElementType() reflect.Type {
	return reflect.TypeOf((*projectState)(nil)).Elem()
}

type projectArgs struct {
	// ARM ID of the Service Map workspace created by user.
	CustomerWorkspaceId *string `pulumi:"customerWorkspaceId"`
	// Location of the Service Map workspace created by user.
	CustomerWorkspaceLocation *string `pulumi:"customerWorkspaceLocation"`
	// For optimistic concurrency control.
	ETag *string `pulumi:"eTag"`
	// Azure location in which project is created.
	Location *string `pulumi:"location"`
	// Name of the Azure Migrate project.
	ProjectName string `pulumi:"projectName"`
	// Provisioning state of the project.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Name of the Azure Resource Group that project is part of.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Tags provided by Azure Tagging service.
	Tags map[string]interface{} `pulumi:"tags"`
}

// The set of arguments for constructing a Project resource.
type ProjectArgs struct {
	// ARM ID of the Service Map workspace created by user.
	CustomerWorkspaceId pulumi.StringPtrInput
	// Location of the Service Map workspace created by user.
	CustomerWorkspaceLocation pulumi.StringPtrInput
	// For optimistic concurrency control.
	ETag pulumi.StringPtrInput
	// Azure location in which project is created.
	Location pulumi.StringPtrInput
	// Name of the Azure Migrate project.
	ProjectName pulumi.StringInput
	// Provisioning state of the project.
	ProvisioningState pulumi.StringPtrInput
	// Name of the Azure Resource Group that project is part of.
	ResourceGroupName pulumi.StringInput
	// Tags provided by Azure Tagging service.
	Tags pulumi.MapInput
}

func (ProjectArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*projectArgs)(nil)).Elem()
}