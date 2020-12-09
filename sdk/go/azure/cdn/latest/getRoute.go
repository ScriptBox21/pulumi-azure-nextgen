// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupRoute(ctx *pulumi.Context, args *LookupRouteArgs, opts ...pulumi.InvokeOption) (*LookupRouteResult, error) {
	var rv LookupRouteResult
	err := ctx.Invoke("azure-nextgen:cdn/latest:getRoute", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupRouteArgs struct {
	// Name of the endpoint under the profile which is unique globally.
	EndpointName string `pulumi:"endpointName"`
	// Name of the CDN profile which is unique within the resource group.
	ProfileName string `pulumi:"profileName"`
	// Name of the Resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the routing rule.
	RouteName string `pulumi:"routeName"`
}

// Friendly Routes name mapping to the any Routes or secret related information.
type LookupRouteResult struct {
	// compression settings.
	CompressionSettings []CompressionSettingsResponse `pulumi:"compressionSettings"`
	// Domains referenced by this endpoint.
	CustomDomains    []ResourceReferenceResponse `pulumi:"customDomains"`
	DeploymentStatus string                      `pulumi:"deploymentStatus"`
	// Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'
	EnabledState *string `pulumi:"enabledState"`
	// Protocol this rule will use when forwarding traffic to backends.
	ForwardingProtocol *string `pulumi:"forwardingProtocol"`
	// Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed.
	HttpsRedirect *string `pulumi:"httpsRedirect"`
	// whether this route will be linked to the default endpoint domain.
	LinkToDefaultDomain *string `pulumi:"linkToDefaultDomain"`
	// Resource name.
	Name string `pulumi:"name"`
	// Specifies what scenario the customer wants this AzureFrontDoor endpoint to optimize for, e.g. Download, Media services. With this information, AzureFrontDoor can apply scenario driven optimization.
	OptimizationType *string `pulumi:"optimizationType"`
	// A reference to the origin group.
	OriginGroup ResourceReferenceResponse `pulumi:"originGroup"`
	// A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
	OriginPath *string `pulumi:"originPath"`
	// The route patterns of the rule.
	PatternsToMatch []string `pulumi:"patternsToMatch"`
	// Provisioning status
	ProvisioningState string `pulumi:"provisioningState"`
	// Defines how AzureFrontDoor caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
	QueryStringCachingBehavior *string `pulumi:"queryStringCachingBehavior"`
	// rule sets referenced by this endpoint.
	RuleSets []ResourceReferenceResponse `pulumi:"ruleSets"`
	// List of supported protocols for this route.
	SupportedProtocols []string `pulumi:"supportedProtocols"`
	// Read only system data
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource type.
	Type string `pulumi:"type"`
}
