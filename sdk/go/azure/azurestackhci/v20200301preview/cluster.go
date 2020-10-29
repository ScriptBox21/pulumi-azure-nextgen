// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Cluster details.
type Cluster struct {
	pulumi.CustomResourceState

	// App id of cluster AAD identity.
	AadClientId pulumi.StringOutput `pulumi:"aadClientId"`
	// Tenant id of cluster AAD identity.
	AadTenantId pulumi.StringOutput `pulumi:"aadTenantId"`
	// Type of billing applied to the resource.
	BillingModel pulumi.StringOutput `pulumi:"billingModel"`
	// Unique, immutable resource id.
	CloudId pulumi.StringOutput `pulumi:"cloudId"`
	// Most recent billing meter timestamp.
	LastBillingTimestamp pulumi.StringOutput `pulumi:"lastBillingTimestamp"`
	// Most recent cluster sync timestamp.
	LastSyncTimestamp pulumi.StringOutput `pulumi:"lastSyncTimestamp"`
	// The geo-location where the resource lives
	Location pulumi.StringOutput `pulumi:"location"`
	// The name of the resource
	Name pulumi.StringOutput `pulumi:"name"`
	// Provisioning state.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// First cluster sync timestamp.
	RegistrationTimestamp pulumi.StringOutput `pulumi:"registrationTimestamp"`
	// Properties reported by cluster agent.
	ReportedProperties ClusterReportedPropertiesResponsePtrOutput `pulumi:"reportedProperties"`
	// Status of the cluster agent.
	Status pulumi.StringOutput `pulumi:"status"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Number of days remaining in the trial period.
	TrialDaysRemaining pulumi.Float64Output `pulumi:"trialDaysRemaining"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOption) (*Cluster, error) {
	if args == nil || args.AadClientId == nil {
		return nil, errors.New("missing required argument 'AadClientId'")
	}
	if args == nil || args.AadTenantId == nil {
		return nil, errors.New("missing required argument 'AadTenantId'")
	}
	if args == nil || args.ClusterName == nil {
		return nil, errors.New("missing required argument 'ClusterName'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ClusterArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:azurestackhci/latest:Cluster"),
		},
		{
			Type: pulumi.String("azure-nextgen:azurestackhci/v20201001:Cluster"),
		},
	})
	opts = append(opts, aliases)
	var resource Cluster
	err := ctx.RegisterResource("azure-nextgen:azurestackhci/v20200301preview:Cluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterState, opts ...pulumi.ResourceOption) (*Cluster, error) {
	var resource Cluster
	err := ctx.ReadResource("azure-nextgen:azurestackhci/v20200301preview:Cluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Cluster resources.
type clusterState struct {
	// App id of cluster AAD identity.
	AadClientId *string `pulumi:"aadClientId"`
	// Tenant id of cluster AAD identity.
	AadTenantId *string `pulumi:"aadTenantId"`
	// Type of billing applied to the resource.
	BillingModel *string `pulumi:"billingModel"`
	// Unique, immutable resource id.
	CloudId *string `pulumi:"cloudId"`
	// Most recent billing meter timestamp.
	LastBillingTimestamp *string `pulumi:"lastBillingTimestamp"`
	// Most recent cluster sync timestamp.
	LastSyncTimestamp *string `pulumi:"lastSyncTimestamp"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name *string `pulumi:"name"`
	// Provisioning state.
	ProvisioningState *string `pulumi:"provisioningState"`
	// First cluster sync timestamp.
	RegistrationTimestamp *string `pulumi:"registrationTimestamp"`
	// Properties reported by cluster agent.
	ReportedProperties *ClusterReportedPropertiesResponse `pulumi:"reportedProperties"`
	// Status of the cluster agent.
	Status *string `pulumi:"status"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Number of days remaining in the trial period.
	TrialDaysRemaining *float64 `pulumi:"trialDaysRemaining"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type *string `pulumi:"type"`
}

type ClusterState struct {
	// App id of cluster AAD identity.
	AadClientId pulumi.StringPtrInput
	// Tenant id of cluster AAD identity.
	AadTenantId pulumi.StringPtrInput
	// Type of billing applied to the resource.
	BillingModel pulumi.StringPtrInput
	// Unique, immutable resource id.
	CloudId pulumi.StringPtrInput
	// Most recent billing meter timestamp.
	LastBillingTimestamp pulumi.StringPtrInput
	// Most recent cluster sync timestamp.
	LastSyncTimestamp pulumi.StringPtrInput
	// The geo-location where the resource lives
	Location pulumi.StringPtrInput
	// The name of the resource
	Name pulumi.StringPtrInput
	// Provisioning state.
	ProvisioningState pulumi.StringPtrInput
	// First cluster sync timestamp.
	RegistrationTimestamp pulumi.StringPtrInput
	// Properties reported by cluster agent.
	ReportedProperties ClusterReportedPropertiesResponsePtrInput
	// Status of the cluster agent.
	Status pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Number of days remaining in the trial period.
	TrialDaysRemaining pulumi.Float64PtrInput
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type pulumi.StringPtrInput
}

func (ClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterState)(nil)).Elem()
}

type clusterArgs struct {
	// App id of cluster AAD identity.
	AadClientId string `pulumi:"aadClientId"`
	// Tenant id of cluster AAD identity.
	AadTenantId string `pulumi:"aadTenantId"`
	// The name of the cluster.
	ClusterName string `pulumi:"clusterName"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	// App id of cluster AAD identity.
	AadClientId pulumi.StringInput
	// Tenant id of cluster AAD identity.
	AadTenantId pulumi.StringInput
	// The name of the cluster.
	ClusterName pulumi.StringInput
	// The geo-location where the resource lives
	Location pulumi.StringInput
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput
	// Resource tags.
	Tags pulumi.StringMapInput
}

func (ClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterArgs)(nil)).Elem()
}
