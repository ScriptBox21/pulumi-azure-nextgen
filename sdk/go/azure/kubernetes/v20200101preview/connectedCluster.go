// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200101preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents a connected cluster.
type ConnectedCluster struct {
	pulumi.CustomResourceState

	// AAD profile of the connected cluster.
	AadProfile ConnectedClusterAADProfileResponseOutput `pulumi:"aadProfile"`
	// Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure.
	AgentPublicKeyCertificate pulumi.StringOutput `pulumi:"agentPublicKeyCertificate"`
	// Version of the agent running on the connected cluster resource
	AgentVersion pulumi.StringOutput `pulumi:"agentVersion"`
	// The identity of the connected cluster.
	Identity ConnectedClusterIdentityResponseOutput `pulumi:"identity"`
	// The Kubernetes version of the connected cluster resource
	KubernetesVersion pulumi.StringOutput `pulumi:"kubernetesVersion"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Provisioning state of the connected cluster resource.
	ProvisioningState pulumi.StringPtrOutput `pulumi:"provisioningState"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Number of nodes present in the connected cluster resource
	TotalNodeCount pulumi.IntOutput `pulumi:"totalNodeCount"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewConnectedCluster registers a new resource with the given unique name, arguments, and options.
func NewConnectedCluster(ctx *pulumi.Context,
	name string, args *ConnectedClusterArgs, opts ...pulumi.ResourceOption) (*ConnectedCluster, error) {
	if args == nil || args.AadProfile == nil {
		return nil, errors.New("missing required argument 'AadProfile'")
	}
	if args == nil || args.AgentPublicKeyCertificate == nil {
		return nil, errors.New("missing required argument 'AgentPublicKeyCertificate'")
	}
	if args == nil || args.ClusterName == nil {
		return nil, errors.New("missing required argument 'ClusterName'")
	}
	if args == nil || args.Identity == nil {
		return nil, errors.New("missing required argument 'Identity'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ConnectedClusterArgs{}
	}
	var resource ConnectedCluster
	err := ctx.RegisterResource("azure-nextgen:kubernetes/v20200101preview:ConnectedCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnectedCluster gets an existing ConnectedCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnectedCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectedClusterState, opts ...pulumi.ResourceOption) (*ConnectedCluster, error) {
	var resource ConnectedCluster
	err := ctx.ReadResource("azure-nextgen:kubernetes/v20200101preview:ConnectedCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConnectedCluster resources.
type connectedClusterState struct {
	// AAD profile of the connected cluster.
	AadProfile *ConnectedClusterAADProfileResponse `pulumi:"aadProfile"`
	// Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure.
	AgentPublicKeyCertificate *string `pulumi:"agentPublicKeyCertificate"`
	// Version of the agent running on the connected cluster resource
	AgentVersion *string `pulumi:"agentVersion"`
	// The identity of the connected cluster.
	Identity *ConnectedClusterIdentityResponse `pulumi:"identity"`
	// The Kubernetes version of the connected cluster resource
	KubernetesVersion *string `pulumi:"kubernetesVersion"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Provisioning state of the connected cluster resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Number of nodes present in the connected cluster resource
	TotalNodeCount *int `pulumi:"totalNodeCount"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type ConnectedClusterState struct {
	// AAD profile of the connected cluster.
	AadProfile ConnectedClusterAADProfileResponsePtrInput
	// Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure.
	AgentPublicKeyCertificate pulumi.StringPtrInput
	// Version of the agent running on the connected cluster resource
	AgentVersion pulumi.StringPtrInput
	// The identity of the connected cluster.
	Identity ConnectedClusterIdentityResponsePtrInput
	// The Kubernetes version of the connected cluster resource
	KubernetesVersion pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Provisioning state of the connected cluster resource.
	ProvisioningState pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Number of nodes present in the connected cluster resource
	TotalNodeCount pulumi.IntPtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (ConnectedClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectedClusterState)(nil)).Elem()
}

type connectedClusterArgs struct {
	// AAD profile of the connected cluster.
	AadProfile ConnectedClusterAADProfile `pulumi:"aadProfile"`
	// Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure.
	AgentPublicKeyCertificate string `pulumi:"agentPublicKeyCertificate"`
	// The name of the Kubernetes cluster on which get is called.
	ClusterName string `pulumi:"clusterName"`
	// The identity of the connected cluster.
	Identity ConnectedClusterIdentity `pulumi:"identity"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// Provisioning state of the connected cluster resource.
	ProvisioningState *string `pulumi:"provisioningState"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a ConnectedCluster resource.
type ConnectedClusterArgs struct {
	// AAD profile of the connected cluster.
	AadProfile ConnectedClusterAADProfileInput
	// Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure.
	AgentPublicKeyCertificate pulumi.StringInput
	// The name of the Kubernetes cluster on which get is called.
	ClusterName pulumi.StringInput
	// The identity of the connected cluster.
	Identity ConnectedClusterIdentityInput
	// The geo-location where the resource lives
	Location pulumi.StringInput
	// Provisioning state of the connected cluster resource.
	ProvisioningState pulumi.StringPtrInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ConnectedClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectedClusterArgs)(nil)).Elem()
}
