// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201005preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWebTest(ctx *pulumi.Context, args *LookupWebTestArgs, opts ...pulumi.InvokeOption) (*LookupWebTestResult, error) {
	var rv LookupWebTestResult
	err := ctx.Invoke("azure-nextgen:insights/v20201005preview:getWebTest", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWebTestArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Application Insights WebTest resource.
	WebTestName string `pulumi:"webTestName"`
}

// An Application Insights WebTest definition.
type LookupWebTestResult struct {
	// An XML configuration specification for a WebTest.
	Configuration *WebTestPropertiesResponseConfiguration `pulumi:"configuration"`
	// The collection of content validation properties
	ContentValidation *WebTestPropertiesResponseContentValidation `pulumi:"contentValidation"`
	// User defined description for this WebTest.
	Description *string `pulumi:"description"`
	// Is the test actively being monitored.
	Enabled *bool `pulumi:"enabled"`
	// Validate that the WebTest returns the http status code provided.
	ExpectedHttpStatusCode *int `pulumi:"expectedHttpStatusCode"`
	// Interval in seconds between test runs for this WebTest. Default value is 300.
	Frequency *int `pulumi:"frequency"`
	// When set, validation will ignore the status code.
	IgnoreHttpsStatusCode *bool `pulumi:"ignoreHttpsStatusCode"`
	// The kind of WebTest that this web test watches. Choices are ping and multistep.
	Kind *string `pulumi:"kind"`
	// Resource location
	Location string `pulumi:"location"`
	// A list of where to physically run the tests from to give global coverage for accessibility of your application.
	Locations []WebTestGeolocationResponse `pulumi:"locations"`
	// Azure resource name
	Name string `pulumi:"name"`
	// Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed.
	ProvisioningState string `pulumi:"provisioningState"`
	// The collection of request properties
	Request *WebTestPropertiesResponseRequest `pulumi:"request"`
	// Allow for retries should this WebTest fail.
	RetryEnabled *bool `pulumi:"retryEnabled"`
	// A number of days to check still remain before the the existing SSL cert expires.
	SSLCertRemainingLifetimeCheck *int `pulumi:"sSLCertRemainingLifetimeCheck"`
	// Checks to see if the SSL cert is still valid.
	SSLCheck *bool `pulumi:"sSLCheck"`
	// Unique ID of this WebTest. This is typically the same value as the Name field.
	SyntheticMonitorId string `pulumi:"syntheticMonitorId"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Seconds until this WebTest will timeout and fail. Default value is 30.
	Timeout *int `pulumi:"timeout"`
	// Azure resource type
	Type string `pulumi:"type"`
	// The kind of web test this is, valid choices are ping, multistep, basic, and standard.
	WebTestKind string `pulumi:"webTestKind"`
	// User defined name if this WebTest.
	WebTestName string `pulumi:"webTestName"`
}
