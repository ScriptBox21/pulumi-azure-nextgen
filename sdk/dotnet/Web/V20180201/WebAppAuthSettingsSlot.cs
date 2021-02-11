// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20180201
{
    /// <summary>
    /// Configuration settings for the Azure App Service Authentication / Authorization feature.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20180201:WebAppAuthSettingsSlot")]
    public partial class WebAppAuthSettingsSlot : Pulumi.CustomResource
    {
        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        [Output("additionalLoginParams")]
        public Output<ImmutableArray<string>> AdditionalLoginParams { get; private set; } = null!;

        /// <summary>
        /// Allowed audience values to consider when validating JWTs issued by 
        /// Azure Active Directory. Note that the &lt;code&gt;ClientID&lt;/code&gt; value is always considered an
        /// allowed audience, regardless of this setting.
        /// </summary>
        [Output("allowedAudiences")]
        public Output<ImmutableArray<string>> AllowedAudiences { get; private set; } = null!;

        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </summary>
        [Output("allowedExternalRedirectUrls")]
        public Output<ImmutableArray<string>> AllowedExternalRedirectUrls { get; private set; } = null!;

        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or 
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Output("clientId")]
        public Output<string?> ClientId { get; private set; } = null!;

        /// <summary>
        /// The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
        /// This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
        /// Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Output("clientSecret")]
        public Output<string?> ClientSecret { get; private set; } = null!;

        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [Output("clientSecretCertificateThumbprint")]
        public Output<string?> ClientSecretCertificateThumbprint { get; private set; } = null!;

        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </summary>
        [Output("defaultProvider")]
        public Output<string?> DefaultProvider { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The App ID of the Facebook app used for login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [Output("facebookAppId")]
        public Output<string?> FacebookAppId { get; private set; } = null!;

        /// <summary>
        /// The App Secret of the Facebook app used for Facebook Login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [Output("facebookAppSecret")]
        public Output<string?> FacebookAppSecret { get; private set; } = null!;

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
        /// This setting is optional.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [Output("facebookOAuthScopes")]
        public Output<ImmutableArray<string>> FacebookOAuthScopes { get; private set; } = null!;

        /// <summary>
        /// The OpenID Connect Client ID for the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [Output("googleClientId")]
        public Output<string?> GoogleClientId { get; private set; } = null!;

        /// <summary>
        /// The client secret associated with the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [Output("googleClientSecret")]
        public Output<string?> GoogleClientSecret { get; private set; } = null!;

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
        /// This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [Output("googleOAuthScopes")]
        public Output<ImmutableArray<string>> GoogleOAuthScopes { get; private set; } = null!;

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [Output("issuer")]
        public Output<string?> Issuer { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client ID that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [Output("microsoftAccountClientId")]
        public Output<string?> MicrosoftAccountClientId { get; private set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client secret that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [Output("microsoftAccountClientSecret")]
        public Output<string?> MicrosoftAccountClientSecret { get; private set; } = null!;

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
        /// This setting is optional. If not specified, "wl.basic" is used as the default scope.
        /// Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
        /// </summary>
        [Output("microsoftAccountOAuthScopes")]
        public Output<ImmutableArray<string>> MicrosoftAccountOAuthScopes { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </summary>
        [Output("runtimeVersion")]
        public Output<string?> RuntimeVersion { get; private set; } = null!;

        /// <summary>
        /// The number of hours after session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </summary>
        [Output("tokenRefreshExtensionHours")]
        public Output<double?> TokenRefreshExtensionHours { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  The default is &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Output("tokenStoreEnabled")]
        public Output<bool?> TokenStoreEnabled { get; private set; } = null!;

        /// <summary>
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        [Output("twitterConsumerKey")]
        public Output<string?> TwitterConsumerKey { get; private set; } = null!;

        /// <summary>
        /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        [Output("twitterConsumerSecret")]
        public Output<string?> TwitterConsumerSecret { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The action to take when an unauthenticated client attempts to access the app.
        /// </summary>
        [Output("unauthenticatedClientAction")]
        public Output<string?> UnauthenticatedClientAction { get; private set; } = null!;

        /// <summary>
        /// Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such.
        /// </summary>
        [Output("validateIssuer")]
        public Output<bool?> ValidateIssuer { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppAuthSettingsSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppAuthSettingsSlot(string name, WebAppAuthSettingsSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20180201:WebAppAuthSettingsSlot", name, args ?? new WebAppAuthSettingsSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppAuthSettingsSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20180201:WebAppAuthSettingsSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:WebAppAuthSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppAuthSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppAuthSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppAuthSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppAuthSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppAuthSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppAuthSettingsSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:WebAppAuthSettingsSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppAuthSettingsSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppAuthSettingsSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppAuthSettingsSlot(name, id, options);
        }
    }

    public sealed class WebAppAuthSettingsSlotArgs : Pulumi.ResourceArgs
    {
        [Input("additionalLoginParams")]
        private InputList<string>? _additionalLoginParams;

        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        public InputList<string> AdditionalLoginParams
        {
            get => _additionalLoginParams ?? (_additionalLoginParams = new InputList<string>());
            set => _additionalLoginParams = value;
        }

        [Input("allowedAudiences")]
        private InputList<string>? _allowedAudiences;

        /// <summary>
        /// Allowed audience values to consider when validating JWTs issued by 
        /// Azure Active Directory. Note that the &lt;code&gt;ClientID&lt;/code&gt; value is always considered an
        /// allowed audience, regardless of this setting.
        /// </summary>
        public InputList<string> AllowedAudiences
        {
            get => _allowedAudiences ?? (_allowedAudiences = new InputList<string>());
            set => _allowedAudiences = value;
        }

        [Input("allowedExternalRedirectUrls")]
        private InputList<string>? _allowedExternalRedirectUrls;

        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </summary>
        public InputList<string> AllowedExternalRedirectUrls
        {
            get => _allowedExternalRedirectUrls ?? (_allowedExternalRedirectUrls = new InputList<string>());
            set => _allowedExternalRedirectUrls = value;
        }

        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or 
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
        /// This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
        /// Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [Input("clientSecretCertificateThumbprint")]
        public Input<string>? ClientSecretCertificateThumbprint { get; set; }

        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </summary>
        [Input("defaultProvider")]
        public Input<Pulumi.AzureNextGen.Web.V20180201.BuiltInAuthenticationProvider>? DefaultProvider { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the Authentication / Authorization feature is enabled for the current app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The App ID of the Facebook app used for login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [Input("facebookAppId")]
        public Input<string>? FacebookAppId { get; set; }

        /// <summary>
        /// The App Secret of the Facebook app used for Facebook Login.
        /// This setting is required for enabling Facebook Login.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        [Input("facebookAppSecret")]
        public Input<string>? FacebookAppSecret { get; set; }

        [Input("facebookOAuthScopes")]
        private InputList<string>? _facebookOAuthScopes;

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
        /// This setting is optional.
        /// Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        /// </summary>
        public InputList<string> FacebookOAuthScopes
        {
            get => _facebookOAuthScopes ?? (_facebookOAuthScopes = new InputList<string>());
            set => _facebookOAuthScopes = value;
        }

        /// <summary>
        /// The OpenID Connect Client ID for the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [Input("googleClientId")]
        public Input<string>? GoogleClientId { get; set; }

        /// <summary>
        /// The client secret associated with the Google web application.
        /// This setting is required for enabling Google Sign-In.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        [Input("googleClientSecret")]
        public Input<string>? GoogleClientSecret { get; set; }

        [Input("googleOAuthScopes")]
        private InputList<string>? _googleOAuthScopes;

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
        /// This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
        /// Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        /// </summary>
        public InputList<string> GoogleOAuthScopes
        {
            get => _googleOAuthScopes ?? (_googleOAuthScopes = new InputList<string>());
            set => _googleOAuthScopes = value;
        }

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// The OAuth 2.0 client ID that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [Input("microsoftAccountClientId")]
        public Input<string>? MicrosoftAccountClientId { get; set; }

        /// <summary>
        /// The OAuth 2.0 client secret that was created for the app used for authentication.
        /// This setting is required for enabling Microsoft Account authentication.
        /// Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        /// </summary>
        [Input("microsoftAccountClientSecret")]
        public Input<string>? MicrosoftAccountClientSecret { get; set; }

        [Input("microsoftAccountOAuthScopes")]
        private InputList<string>? _microsoftAccountOAuthScopes;

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
        /// This setting is optional. If not specified, "wl.basic" is used as the default scope.
        /// Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
        /// </summary>
        public InputList<string> MicrosoftAccountOAuthScopes
        {
            get => _microsoftAccountOAuthScopes ?? (_microsoftAccountOAuthScopes = new InputList<string>());
            set => _microsoftAccountOAuthScopes = value;
        }

        /// <summary>
        /// Name of web app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </summary>
        [Input("runtimeVersion")]
        public Input<string>? RuntimeVersion { get; set; }

        /// <summary>
        /// Name of web app slot. If not specified then will default to production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        /// <summary>
        /// The number of hours after session token expiration that a session token can be used to
        /// call the token refresh API. The default is 72 hours.
        /// </summary>
        [Input("tokenRefreshExtensionHours")]
        public Input<double>? TokenRefreshExtensionHours { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to durably store platform-specific security tokens that are obtained during login flows; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  The default is &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("tokenStoreEnabled")]
        public Input<bool>? TokenStoreEnabled { get; set; }

        /// <summary>
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        [Input("twitterConsumerKey")]
        public Input<string>? TwitterConsumerKey { get; set; }

        /// <summary>
        /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
        /// This setting is required for enabling Twitter Sign-In.
        /// Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        /// </summary>
        [Input("twitterConsumerSecret")]
        public Input<string>? TwitterConsumerSecret { get; set; }

        /// <summary>
        /// The action to take when an unauthenticated client attempts to access the app.
        /// </summary>
        [Input("unauthenticatedClientAction")]
        public Input<Pulumi.AzureNextGen.Web.V20180201.UnauthenticatedClientAction>? UnauthenticatedClientAction { get; set; }

        /// <summary>
        /// Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such.
        /// </summary>
        [Input("validateIssuer")]
        public Input<bool>? ValidateIssuer { get; set; }

        public WebAppAuthSettingsSlotArgs()
        {
        }
    }
}
