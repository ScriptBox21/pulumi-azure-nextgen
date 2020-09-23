// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupNetworkExperimentProfile(ctx *pulumi.Context, args *LookupNetworkExperimentProfileArgs, opts ...pulumi.InvokeOption) (*LookupNetworkExperimentProfileResult, error) {
	var rv LookupNetworkExperimentProfileResult
	err := ctx.Invoke("azure-nextgen:network/latest:getNetworkExperimentProfile", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupNetworkExperimentProfileArgs struct {
	// The Profile identifier associated with the Tenant and Partner
	ProfileName string `pulumi:"profileName"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Defines an Network Experiment Profile and lists of Experiments
type LookupNetworkExperimentProfileResult struct {
	// The state of the Experiment
	EnabledState *string `pulumi:"enabledState"`
	// Gets a unique read-only string that changes whenever the resource is updated.
	Etag *string `pulumi:"etag"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Resource name.
	Name string `pulumi:"name"`
	// Resource status.
	ResourceState string `pulumi:"resourceState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type string `pulumi:"type"`
}
