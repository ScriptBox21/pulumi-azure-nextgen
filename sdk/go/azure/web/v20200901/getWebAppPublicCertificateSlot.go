// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWebAppPublicCertificateSlot(ctx *pulumi.Context, args *LookupWebAppPublicCertificateSlotArgs, opts ...pulumi.InvokeOption) (*LookupWebAppPublicCertificateSlotResult, error) {
	var rv LookupWebAppPublicCertificateSlotResult
	err := ctx.Invoke("azure-nextgen:web/v20200901:getWebAppPublicCertificateSlot", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWebAppPublicCertificateSlotArgs struct {
	// Name of the app.
	Name string `pulumi:"name"`
	// Public certificate name.
	PublicCertificateName string `pulumi:"publicCertificateName"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API the named binding for the production slot.
	Slot string `pulumi:"slot"`
}

// Public certificate object
type LookupWebAppPublicCertificateSlotResult struct {
	// Public Certificate byte array
	Blob *string `pulumi:"blob"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// Resource Name.
	Name string `pulumi:"name"`
	// Public Certificate Location
	PublicCertificateLocation *string `pulumi:"publicCertificateLocation"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Certificate Thumbprint
	Thumbprint string `pulumi:"thumbprint"`
	// Resource type.
	Type string `pulumi:"type"`
}
