// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDomainOwnershipIdentifier(ctx *pulumi.Context, args *LookupDomainOwnershipIdentifierArgs, opts ...pulumi.InvokeOption) (*LookupDomainOwnershipIdentifierResult, error) {
	var rv LookupDomainOwnershipIdentifierResult
	err := ctx.Invoke("azure-nextgen:domainregistration/latest:getDomainOwnershipIdentifier", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDomainOwnershipIdentifierArgs struct {
	// Name of domain.
	DomainName string `pulumi:"domainName"`
	// Name of identifier.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Domain ownership Identifier.
type LookupDomainOwnershipIdentifierResult struct {
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name string `pulumi:"name"`
	// Ownership Id.
	OwnershipId *string `pulumi:"ownershipId"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type string `pulumi:"type"`
}
