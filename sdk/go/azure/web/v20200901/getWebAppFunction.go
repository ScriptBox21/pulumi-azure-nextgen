// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWebAppFunction(ctx *pulumi.Context, args *LookupWebAppFunctionArgs, opts ...pulumi.InvokeOption) (*LookupWebAppFunctionResult, error) {
	var rv LookupWebAppFunctionResult
	err := ctx.Invoke("azure-nextgen:web/v20200901:getWebAppFunction", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWebAppFunctionArgs struct {
	// Function name.
	FunctionName string `pulumi:"functionName"`
	// Site name.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Function information.
type LookupWebAppFunctionResult struct {
	// Config information.
	Config interface{} `pulumi:"config"`
	// Config URI.
	ConfigHref *string `pulumi:"configHref"`
	// File list.
	Files map[string]string `pulumi:"files"`
	// Function App ID.
	FunctionAppId *string `pulumi:"functionAppId"`
	// Function URI.
	Href *string `pulumi:"href"`
	// The invocation URL
	InvokeUrlTemplate *string `pulumi:"invokeUrlTemplate"`
	// Gets or sets a value indicating whether the function is disabled
	IsDisabled *bool `pulumi:"isDisabled"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// The function language
	Language *string `pulumi:"language"`
	// Resource Name.
	Name string `pulumi:"name"`
	// Script URI.
	ScriptHref *string `pulumi:"scriptHref"`
	// Script root path URI.
	ScriptRootPathHref *string `pulumi:"scriptRootPathHref"`
	// Secrets file URI.
	SecretsFileHref *string `pulumi:"secretsFileHref"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Test data used when testing via the Azure Portal.
	TestData *string `pulumi:"testData"`
	// Test data URI.
	TestDataHref *string `pulumi:"testDataHref"`
	// Resource type.
	Type string `pulumi:"type"`
}
