// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func GetFactoryGitHubAccessToken(ctx *pulumi.Context, args *GetFactoryGitHubAccessTokenArgs, opts ...pulumi.InvokeOption) (*GetFactoryGitHubAccessTokenResult, error) {
	var rv GetFactoryGitHubAccessTokenResult
	err := ctx.Invoke("azure-nextgen:datafactory/latest:getFactoryGitHubAccessToken", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type GetFactoryGitHubAccessTokenArgs struct {
	// The factory name.
	FactoryName string `pulumi:"factoryName"`
	// GitHub access code.
	GitHubAccessCode string `pulumi:"gitHubAccessCode"`
	// GitHub access token base URL.
	GitHubAccessTokenBaseUrl string `pulumi:"gitHubAccessTokenBaseUrl"`
	// GitHub application client ID.
	GitHubClientId *string `pulumi:"gitHubClientId"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Get GitHub access token response definition.
type GetFactoryGitHubAccessTokenResult struct {
	// GitHub access token.
	GitHubAccessToken *string `pulumi:"gitHubAccessToken"`
}
