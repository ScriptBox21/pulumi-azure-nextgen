// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20160330

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Container service.
type ContainerService struct {
	pulumi.CustomResourceState

	// Properties of the agent pool.
	AgentPoolProfiles ContainerServiceAgentPoolProfileResponseArrayOutput `pulumi:"agentPoolProfiles"`
	// Properties of the diagnostic agent.
	DiagnosticsProfile ContainerServiceDiagnosticsProfileResponsePtrOutput `pulumi:"diagnosticsProfile"`
	// Properties of Linux VMs.
	LinuxProfile ContainerServiceLinuxProfileResponseOutput `pulumi:"linuxProfile"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Properties of master agents.
	MasterProfile ContainerServiceMasterProfileResponseOutput `pulumi:"masterProfile"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Properties of the orchestrator.
	OrchestratorProfile ContainerServiceOrchestratorProfileResponsePtrOutput `pulumi:"orchestratorProfile"`
	// the current deployment or provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
	// Properties of Windows VMs.
	WindowsProfile ContainerServiceWindowsProfileResponsePtrOutput `pulumi:"windowsProfile"`
}

// NewContainerService registers a new resource with the given unique name, arguments, and options.
func NewContainerService(ctx *pulumi.Context,
	name string, args *ContainerServiceArgs, opts ...pulumi.ResourceOption) (*ContainerService, error) {
	if args == nil || args.AgentPoolProfiles == nil {
		return nil, errors.New("missing required argument 'AgentPoolProfiles'")
	}
	if args == nil || args.ContainerServiceName == nil {
		return nil, errors.New("missing required argument 'ContainerServiceName'")
	}
	if args == nil || args.LinuxProfile == nil {
		return nil, errors.New("missing required argument 'LinuxProfile'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.MasterProfile == nil {
		return nil, errors.New("missing required argument 'MasterProfile'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ContainerServiceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:containerservice/latest:ContainerService"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerservice/v20151101preview:ContainerService"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerservice/v20160930:ContainerService"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerservice/v20170131:ContainerService"),
		},
		{
			Type: pulumi.String("azure-nextgen:containerservice/v20170701:ContainerService"),
		},
	})
	opts = append(opts, aliases)
	var resource ContainerService
	err := ctx.RegisterResource("azure-nextgen:containerservice/v20160330:ContainerService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContainerService gets an existing ContainerService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainerService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContainerServiceState, opts ...pulumi.ResourceOption) (*ContainerService, error) {
	var resource ContainerService
	err := ctx.ReadResource("azure-nextgen:containerservice/v20160330:ContainerService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ContainerService resources.
type containerServiceState struct {
	// Properties of the agent pool.
	AgentPoolProfiles []ContainerServiceAgentPoolProfileResponse `pulumi:"agentPoolProfiles"`
	// Properties of the diagnostic agent.
	DiagnosticsProfile *ContainerServiceDiagnosticsProfileResponse `pulumi:"diagnosticsProfile"`
	// Properties of Linux VMs.
	LinuxProfile *ContainerServiceLinuxProfileResponse `pulumi:"linuxProfile"`
	// Resource location
	Location *string `pulumi:"location"`
	// Properties of master agents.
	MasterProfile *ContainerServiceMasterProfileResponse `pulumi:"masterProfile"`
	// Resource name
	Name *string `pulumi:"name"`
	// Properties of the orchestrator.
	OrchestratorProfile *ContainerServiceOrchestratorProfileResponse `pulumi:"orchestratorProfile"`
	// the current deployment or provisioning state, which only appears in the response.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type
	Type *string `pulumi:"type"`
	// Properties of Windows VMs.
	WindowsProfile *ContainerServiceWindowsProfileResponse `pulumi:"windowsProfile"`
}

type ContainerServiceState struct {
	// Properties of the agent pool.
	AgentPoolProfiles ContainerServiceAgentPoolProfileResponseArrayInput
	// Properties of the diagnostic agent.
	DiagnosticsProfile ContainerServiceDiagnosticsProfileResponsePtrInput
	// Properties of Linux VMs.
	LinuxProfile ContainerServiceLinuxProfileResponsePtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Properties of master agents.
	MasterProfile ContainerServiceMasterProfileResponsePtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Properties of the orchestrator.
	OrchestratorProfile ContainerServiceOrchestratorProfileResponsePtrInput
	// the current deployment or provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Resource type
	Type pulumi.StringPtrInput
	// Properties of Windows VMs.
	WindowsProfile ContainerServiceWindowsProfileResponsePtrInput
}

func (ContainerServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*containerServiceState)(nil)).Elem()
}

type containerServiceArgs struct {
	// Properties of the agent pool.
	AgentPoolProfiles []ContainerServiceAgentPoolProfile `pulumi:"agentPoolProfiles"`
	// The name of the container service in the specified subscription and resource group.
	ContainerServiceName string `pulumi:"containerServiceName"`
	// Properties of the diagnostic agent.
	DiagnosticsProfile *ContainerServiceDiagnosticsProfile `pulumi:"diagnosticsProfile"`
	// Properties of Linux VMs.
	LinuxProfile ContainerServiceLinuxProfile `pulumi:"linuxProfile"`
	// Resource location
	Location string `pulumi:"location"`
	// Properties of master agents.
	MasterProfile ContainerServiceMasterProfile `pulumi:"masterProfile"`
	// Properties of the orchestrator.
	OrchestratorProfile *ContainerServiceOrchestratorProfile `pulumi:"orchestratorProfile"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Properties of Windows VMs.
	WindowsProfile *ContainerServiceWindowsProfile `pulumi:"windowsProfile"`
}

// The set of arguments for constructing a ContainerService resource.
type ContainerServiceArgs struct {
	// Properties of the agent pool.
	AgentPoolProfiles ContainerServiceAgentPoolProfileArrayInput
	// The name of the container service in the specified subscription and resource group.
	ContainerServiceName pulumi.StringInput
	// Properties of the diagnostic agent.
	DiagnosticsProfile ContainerServiceDiagnosticsProfilePtrInput
	// Properties of Linux VMs.
	LinuxProfile ContainerServiceLinuxProfileInput
	// Resource location
	Location pulumi.StringInput
	// Properties of master agents.
	MasterProfile ContainerServiceMasterProfileInput
	// Properties of the orchestrator.
	OrchestratorProfile ContainerServiceOrchestratorProfilePtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Properties of Windows VMs.
	WindowsProfile ContainerServiceWindowsProfilePtrInput
}

func (ContainerServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*containerServiceArgs)(nil)).Elem()
}