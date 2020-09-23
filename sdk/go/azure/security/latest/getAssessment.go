// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupAssessment(ctx *pulumi.Context, args *LookupAssessmentArgs, opts ...pulumi.InvokeOption) (*LookupAssessmentResult, error) {
	var rv LookupAssessmentResult
	err := ctx.Invoke("azure-nextgen:security/latest:getAssessment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupAssessmentArgs struct {
	// The Assessment Key - Unique key for the assessment type
	AssessmentName string `pulumi:"assessmentName"`
	// OData expand. Optional.
	Expand *string `pulumi:"expand"`
	// The identifier of the resource.
	ResourceId string `pulumi:"resourceId"`
}

// Security assessment on a resource
type LookupAssessmentResult struct {
	// Additional data regarding the assessment
	AdditionalData map[string]string `pulumi:"additionalData"`
	// User friendly display name of the assessment
	DisplayName string `pulumi:"displayName"`
	// Links relevant to the assessment
	Links AssessmentLinksResponse `pulumi:"links"`
	// Describes properties of an assessment metadata.
	Metadata *SecurityAssessmentMetadataPropertiesResponse `pulumi:"metadata"`
	// Resource name
	Name string `pulumi:"name"`
	// Data regarding 3rd party partner integration
	PartnersData *SecurityAssessmentPartnerDataResponse `pulumi:"partnersData"`
	// Details of the resource that was assessed
	ResourceDetails interface{} `pulumi:"resourceDetails"`
	// The result of the assessment
	Status AssessmentStatusResponse `pulumi:"status"`
	// Resource type
	Type string `pulumi:"type"`
}
