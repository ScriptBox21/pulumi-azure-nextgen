// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListWebAppAuthSettingsSlot(ctx *pulumi.Context, args *ListWebAppAuthSettingsSlotArgs, opts ...pulumi.InvokeOption) (*ListWebAppAuthSettingsSlotResult, error) {
	var rv ListWebAppAuthSettingsSlotResult
	err := ctx.Invoke("azure-nextgen:web/latest:listWebAppAuthSettingsSlot", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListWebAppAuthSettingsSlotArgs struct {
	// Name of the app.
	Name string `pulumi:"name"`
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the deployment slot. If a slot is not specified, the API will get the settings for the production slot.
	Slot string `pulumi:"slot"`
}

// Configuration settings for the Azure App Service Authentication / Authorization feature.
type ListWebAppAuthSettingsSlotResult struct {
	// Gets a JSON string containing the Azure AD Acl settings.
	AadClaimsAuthorization *string `pulumi:"aadClaimsAuthorization"`
	// Login parameters to send to the OpenID Connect authorization endpoint when
	// a user logs in. Each parameter must be in the form "key=value".
	AdditionalLoginParams []string `pulumi:"additionalLoginParams"`
	// Allowed audience values to consider when validating JWTs issued by
	// Azure Active Directory. Note that the <code>ClientID</code> value is always considered an
	// allowed audience, regardless of this setting.
	AllowedAudiences []string `pulumi:"allowedAudiences"`
	// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
	// This is an advanced setting typically only needed by Windows Store application backends.
	// Note that URLs within the current domain are always implicitly allowed.
	AllowedExternalRedirectUrls []string `pulumi:"allowedExternalRedirectUrls"`
	// The path of the config file containing auth settings.
	// If the path is relative, base will the site's root directory.
	AuthFilePath *string `pulumi:"authFilePath"`
	// The Client ID of this relying party application, known as the client_id.
	// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
	// other 3rd party OpenID Connect providers.
	// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
	ClientId *string `pulumi:"clientId"`
	// The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
	// This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
	// Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
	// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
	ClientSecret *string `pulumi:"clientSecret"`
	// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
	// a replacement for the Client Secret. It is also optional.
	ClientSecretCertificateThumbprint *string `pulumi:"clientSecretCertificateThumbprint"`
	// The app setting name that contains the client secret of the relying party application.
	ClientSecretSettingName *string `pulumi:"clientSecretSettingName"`
	// The default authentication provider to use when multiple providers are configured.
	// This setting is only needed if multiple providers are configured and the unauthenticated client
	// action is set to "RedirectToLoginPage".
	DefaultProvider *string `pulumi:"defaultProvider"`
	// <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
	Enabled *bool `pulumi:"enabled"`
	// The App ID of the Facebook app used for login.
	// This setting is required for enabling Facebook Login.
	// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
	FacebookAppId *string `pulumi:"facebookAppId"`
	// The App Secret of the Facebook app used for Facebook Login.
	// This setting is required for enabling Facebook Login.
	// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
	FacebookAppSecret *string `pulumi:"facebookAppSecret"`
	// The app setting name that contains the app secret used for Facebook Login.
	FacebookAppSecretSettingName *string `pulumi:"facebookAppSecretSettingName"`
	// The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
	// This setting is optional.
	// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
	FacebookOAuthScopes []string `pulumi:"facebookOAuthScopes"`
	// The Client Id of the GitHub app used for login.
	// This setting is required for enabling Github login
	GitHubClientId *string `pulumi:"gitHubClientId"`
	// The Client Secret of the GitHub app used for Github Login.
	// This setting is required for enabling Github login.
	GitHubClientSecret *string `pulumi:"gitHubClientSecret"`
	// The app setting name that contains the client secret of the Github
	// app used for GitHub Login.
	GitHubClientSecretSettingName *string `pulumi:"gitHubClientSecretSettingName"`
	// The OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
	// This setting is optional
	GitHubOAuthScopes []string `pulumi:"gitHubOAuthScopes"`
	// The OpenID Connect Client ID for the Google web application.
	// This setting is required for enabling Google Sign-In.
	// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
	GoogleClientId *string `pulumi:"googleClientId"`
	// The client secret associated with the Google web application.
	// This setting is required for enabling Google Sign-In.
	// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
	GoogleClientSecret *string `pulumi:"googleClientSecret"`
	// The app setting name that contains the client secret associated with
	// the Google web application.
	GoogleClientSecretSettingName *string `pulumi:"googleClientSecretSettingName"`
	// The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
	// This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
	// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
	GoogleOAuthScopes []string `pulumi:"googleOAuthScopes"`
	// "true" if the auth config settings should be read from a file,
	// "false" otherwise
	IsAuthFromFile *string `pulumi:"isAuthFromFile"`
	// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
	// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
	// This URI is a case-sensitive identifier for the token issuer.
	// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
	Issuer *string `pulumi:"issuer"`
	// Kind of resource.
	Kind *string `pulumi:"kind"`
	// The OAuth 2.0 client ID that was created for the app used for authentication.
	// This setting is required for enabling Microsoft Account authentication.
	// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
	MicrosoftAccountClientId *string `pulumi:"microsoftAccountClientId"`
	// The OAuth 2.0 client secret that was created for the app used for authentication.
	// This setting is required for enabling Microsoft Account authentication.
	// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
	MicrosoftAccountClientSecret *string `pulumi:"microsoftAccountClientSecret"`
	// The app setting name containing the OAuth 2.0 client secret that was created for the
	// app used for authentication.
	MicrosoftAccountClientSecretSettingName *string `pulumi:"microsoftAccountClientSecretSettingName"`
	// The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
	// This setting is optional. If not specified, "wl.basic" is used as the default scope.
	// Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
	MicrosoftAccountOAuthScopes []string `pulumi:"microsoftAccountOAuthScopes"`
	// Resource Name.
	Name string `pulumi:"name"`
	// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
	// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
	RuntimeVersion *string `pulumi:"runtimeVersion"`
	// The system metadata relating to this resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The number of hours after session token expiration that a session token can be used to
	// call the token refresh API. The default is 72 hours.
	TokenRefreshExtensionHours *float64 `pulumi:"tokenRefreshExtensionHours"`
	// <code>true</code> to durably store platform-specific security tokens that are obtained during login flows; otherwise, <code>false</code>.
	//  The default is <code>false</code>.
	TokenStoreEnabled *bool `pulumi:"tokenStoreEnabled"`
	// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
	// This setting is required for enabling Twitter Sign-In.
	// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
	TwitterConsumerKey *string `pulumi:"twitterConsumerKey"`
	// The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
	// This setting is required for enabling Twitter Sign-In.
	// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
	TwitterConsumerSecret *string `pulumi:"twitterConsumerSecret"`
	// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
	// application used for sign-in.
	TwitterConsumerSecretSettingName *string `pulumi:"twitterConsumerSecretSettingName"`
	// Resource type.
	Type string `pulumi:"type"`
	// The action to take when an unauthenticated client attempts to access the app.
	UnauthenticatedClientAction *string `pulumi:"unauthenticatedClientAction"`
	// Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such.
	ValidateIssuer *bool `pulumi:"validateIssuer"`
}
