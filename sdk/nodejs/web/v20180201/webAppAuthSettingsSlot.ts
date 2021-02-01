// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Configuration settings for the Azure App Service Authentication / Authorization feature.
 */
export class WebAppAuthSettingsSlot extends pulumi.CustomResource {
    /**
     * Get an existing WebAppAuthSettingsSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebAppAuthSettingsSlot {
        return new WebAppAuthSettingsSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:web/v20180201:WebAppAuthSettingsSlot';

    /**
     * Returns true if the given object is an instance of WebAppAuthSettingsSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebAppAuthSettingsSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppAuthSettingsSlot.__pulumiType;
    }

    /**
     * Login parameters to send to the OpenID Connect authorization endpoint when
     * a user logs in. Each parameter must be in the form "key=value".
     */
    public readonly additionalLoginParams!: pulumi.Output<string[] | undefined>;
    /**
     * Allowed audience values to consider when validating JWTs issued by 
     * Azure Active Directory. Note that the <code>ClientID</code> value is always considered an
     * allowed audience, regardless of this setting.
     */
    public readonly allowedAudiences!: pulumi.Output<string[] | undefined>;
    /**
     * External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
     * This is an advanced setting typically only needed by Windows Store application backends.
     * Note that URLs within the current domain are always implicitly allowed.
     */
    public readonly allowedExternalRedirectUrls!: pulumi.Output<string[] | undefined>;
    /**
     * The Client ID of this relying party application, known as the client_id.
     * This setting is required for enabling OpenID Connection authentication with Azure Active Directory or 
     * other 3rd party OpenID Connect providers.
     * More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
     */
    public readonly clientId!: pulumi.Output<string | undefined>;
    /**
     * The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
     * This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
     * Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
     * More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
     */
    public readonly clientSecret!: pulumi.Output<string | undefined>;
    /**
     * An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
     * a replacement for the Client Secret. It is also optional.
     */
    public readonly clientSecretCertificateThumbprint!: pulumi.Output<string | undefined>;
    /**
     * The default authentication provider to use when multiple providers are configured.
     * This setting is only needed if multiple providers are configured and the unauthenticated client
     * action is set to "RedirectToLoginPage".
     */
    public readonly defaultProvider!: pulumi.Output<string | undefined>;
    /**
     * <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * The App ID of the Facebook app used for login.
     * This setting is required for enabling Facebook Login.
     * Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
     */
    public readonly facebookAppId!: pulumi.Output<string | undefined>;
    /**
     * The App Secret of the Facebook app used for Facebook Login.
     * This setting is required for enabling Facebook Login.
     * Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
     */
    public readonly facebookAppSecret!: pulumi.Output<string | undefined>;
    /**
     * The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
     * This setting is optional.
     * Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
     */
    public readonly facebookOAuthScopes!: pulumi.Output<string[] | undefined>;
    /**
     * The OpenID Connect Client ID for the Google web application.
     * This setting is required for enabling Google Sign-In.
     * Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
     */
    public readonly googleClientId!: pulumi.Output<string | undefined>;
    /**
     * The client secret associated with the Google web application.
     * This setting is required for enabling Google Sign-In.
     * Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
     */
    public readonly googleClientSecret!: pulumi.Output<string | undefined>;
    /**
     * The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
     * This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
     * Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
     */
    public readonly googleOAuthScopes!: pulumi.Output<string[] | undefined>;
    /**
     * The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
     * When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
     * This URI is a case-sensitive identifier for the token issuer.
     * More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
     */
    public readonly issuer!: pulumi.Output<string | undefined>;
    /**
     * Kind of resource.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * The OAuth 2.0 client ID that was created for the app used for authentication.
     * This setting is required for enabling Microsoft Account authentication.
     * Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
     */
    public readonly microsoftAccountClientId!: pulumi.Output<string | undefined>;
    /**
     * The OAuth 2.0 client secret that was created for the app used for authentication.
     * This setting is required for enabling Microsoft Account authentication.
     * Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
     */
    public readonly microsoftAccountClientSecret!: pulumi.Output<string | undefined>;
    /**
     * The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
     * This setting is optional. If not specified, "wl.basic" is used as the default scope.
     * Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
     */
    public readonly microsoftAccountOAuthScopes!: pulumi.Output<string[] | undefined>;
    /**
     * Resource Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
     * The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
     */
    public readonly runtimeVersion!: pulumi.Output<string | undefined>;
    /**
     * The number of hours after session token expiration that a session token can be used to
     * call the token refresh API. The default is 72 hours.
     */
    public readonly tokenRefreshExtensionHours!: pulumi.Output<number | undefined>;
    /**
     * <code>true</code> to durably store platform-specific security tokens that are obtained during login flows; otherwise, <code>false</code>.
     *  The default is <code>false</code>.
     */
    public readonly tokenStoreEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * The OAuth 1.0a consumer key of the Twitter application used for sign-in.
     * This setting is required for enabling Twitter Sign-In.
     * Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
     */
    public readonly twitterConsumerKey!: pulumi.Output<string | undefined>;
    /**
     * The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
     * This setting is required for enabling Twitter Sign-In.
     * Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
     */
    public readonly twitterConsumerSecret!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The action to take when an unauthenticated client attempts to access the app.
     */
    public readonly unauthenticatedClientAction!: pulumi.Output<string | undefined>;
    /**
     * Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such.
     */
    public readonly validateIssuer!: pulumi.Output<boolean | undefined>;

    /**
     * Create a WebAppAuthSettingsSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebAppAuthSettingsSlotArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.slot === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'slot'");
            }
            inputs["additionalLoginParams"] = args ? args.additionalLoginParams : undefined;
            inputs["allowedAudiences"] = args ? args.allowedAudiences : undefined;
            inputs["allowedExternalRedirectUrls"] = args ? args.allowedExternalRedirectUrls : undefined;
            inputs["clientId"] = args ? args.clientId : undefined;
            inputs["clientSecret"] = args ? args.clientSecret : undefined;
            inputs["clientSecretCertificateThumbprint"] = args ? args.clientSecretCertificateThumbprint : undefined;
            inputs["defaultProvider"] = args ? args.defaultProvider : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["facebookAppId"] = args ? args.facebookAppId : undefined;
            inputs["facebookAppSecret"] = args ? args.facebookAppSecret : undefined;
            inputs["facebookOAuthScopes"] = args ? args.facebookOAuthScopes : undefined;
            inputs["googleClientId"] = args ? args.googleClientId : undefined;
            inputs["googleClientSecret"] = args ? args.googleClientSecret : undefined;
            inputs["googleOAuthScopes"] = args ? args.googleOAuthScopes : undefined;
            inputs["issuer"] = args ? args.issuer : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["microsoftAccountClientId"] = args ? args.microsoftAccountClientId : undefined;
            inputs["microsoftAccountClientSecret"] = args ? args.microsoftAccountClientSecret : undefined;
            inputs["microsoftAccountOAuthScopes"] = args ? args.microsoftAccountOAuthScopes : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["runtimeVersion"] = args ? args.runtimeVersion : undefined;
            inputs["slot"] = args ? args.slot : undefined;
            inputs["tokenRefreshExtensionHours"] = args ? args.tokenRefreshExtensionHours : undefined;
            inputs["tokenStoreEnabled"] = args ? args.tokenStoreEnabled : undefined;
            inputs["twitterConsumerKey"] = args ? args.twitterConsumerKey : undefined;
            inputs["twitterConsumerSecret"] = args ? args.twitterConsumerSecret : undefined;
            inputs["unauthenticatedClientAction"] = args ? args.unauthenticatedClientAction : undefined;
            inputs["validateIssuer"] = args ? args.validateIssuer : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["additionalLoginParams"] = undefined /*out*/;
            inputs["allowedAudiences"] = undefined /*out*/;
            inputs["allowedExternalRedirectUrls"] = undefined /*out*/;
            inputs["clientId"] = undefined /*out*/;
            inputs["clientSecret"] = undefined /*out*/;
            inputs["clientSecretCertificateThumbprint"] = undefined /*out*/;
            inputs["defaultProvider"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["facebookAppId"] = undefined /*out*/;
            inputs["facebookAppSecret"] = undefined /*out*/;
            inputs["facebookOAuthScopes"] = undefined /*out*/;
            inputs["googleClientId"] = undefined /*out*/;
            inputs["googleClientSecret"] = undefined /*out*/;
            inputs["googleOAuthScopes"] = undefined /*out*/;
            inputs["issuer"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["microsoftAccountClientId"] = undefined /*out*/;
            inputs["microsoftAccountClientSecret"] = undefined /*out*/;
            inputs["microsoftAccountOAuthScopes"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["runtimeVersion"] = undefined /*out*/;
            inputs["tokenRefreshExtensionHours"] = undefined /*out*/;
            inputs["tokenStoreEnabled"] = undefined /*out*/;
            inputs["twitterConsumerKey"] = undefined /*out*/;
            inputs["twitterConsumerSecret"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["unauthenticatedClientAction"] = undefined /*out*/;
            inputs["validateIssuer"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:web/latest:WebAppAuthSettingsSlot" }, { type: "azure-nextgen:web/v20150801:WebAppAuthSettingsSlot" }, { type: "azure-nextgen:web/v20160801:WebAppAuthSettingsSlot" }, { type: "azure-nextgen:web/v20181101:WebAppAuthSettingsSlot" }, { type: "azure-nextgen:web/v20190801:WebAppAuthSettingsSlot" }, { type: "azure-nextgen:web/v20200601:WebAppAuthSettingsSlot" }, { type: "azure-nextgen:web/v20200901:WebAppAuthSettingsSlot" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppAuthSettingsSlot.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebAppAuthSettingsSlot resource.
 */
export interface WebAppAuthSettingsSlotArgs {
    /**
     * Login parameters to send to the OpenID Connect authorization endpoint when
     * a user logs in. Each parameter must be in the form "key=value".
     */
    readonly additionalLoginParams?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Allowed audience values to consider when validating JWTs issued by 
     * Azure Active Directory. Note that the <code>ClientID</code> value is always considered an
     * allowed audience, regardless of this setting.
     */
    readonly allowedAudiences?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
     * This is an advanced setting typically only needed by Windows Store application backends.
     * Note that URLs within the current domain are always implicitly allowed.
     */
    readonly allowedExternalRedirectUrls?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The Client ID of this relying party application, known as the client_id.
     * This setting is required for enabling OpenID Connection authentication with Azure Active Directory or 
     * other 3rd party OpenID Connect providers.
     * More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
     */
    readonly clientId?: pulumi.Input<string>;
    /**
     * The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
     * This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
     * Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
     * More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
     */
    readonly clientSecret?: pulumi.Input<string>;
    /**
     * An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
     * a replacement for the Client Secret. It is also optional.
     */
    readonly clientSecretCertificateThumbprint?: pulumi.Input<string>;
    /**
     * The default authentication provider to use when multiple providers are configured.
     * This setting is only needed if multiple providers are configured and the unauthenticated client
     * action is set to "RedirectToLoginPage".
     */
    readonly defaultProvider?: pulumi.Input<enums.web.v20180201.BuiltInAuthenticationProvider>;
    /**
     * <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * The App ID of the Facebook app used for login.
     * This setting is required for enabling Facebook Login.
     * Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
     */
    readonly facebookAppId?: pulumi.Input<string>;
    /**
     * The App Secret of the Facebook app used for Facebook Login.
     * This setting is required for enabling Facebook Login.
     * Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
     */
    readonly facebookAppSecret?: pulumi.Input<string>;
    /**
     * The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
     * This setting is optional.
     * Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
     */
    readonly facebookOAuthScopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The OpenID Connect Client ID for the Google web application.
     * This setting is required for enabling Google Sign-In.
     * Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
     */
    readonly googleClientId?: pulumi.Input<string>;
    /**
     * The client secret associated with the Google web application.
     * This setting is required for enabling Google Sign-In.
     * Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
     */
    readonly googleClientSecret?: pulumi.Input<string>;
    /**
     * The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
     * This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
     * Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
     */
    readonly googleOAuthScopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
     * When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
     * This URI is a case-sensitive identifier for the token issuer.
     * More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
     */
    readonly issuer?: pulumi.Input<string>;
    /**
     * Kind of resource.
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * The OAuth 2.0 client ID that was created for the app used for authentication.
     * This setting is required for enabling Microsoft Account authentication.
     * Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
     */
    readonly microsoftAccountClientId?: pulumi.Input<string>;
    /**
     * The OAuth 2.0 client secret that was created for the app used for authentication.
     * This setting is required for enabling Microsoft Account authentication.
     * Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
     */
    readonly microsoftAccountClientSecret?: pulumi.Input<string>;
    /**
     * The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
     * This setting is optional. If not specified, "wl.basic" is used as the default scope.
     * Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
     */
    readonly microsoftAccountOAuthScopes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Name of web app.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
     * The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
     */
    readonly runtimeVersion?: pulumi.Input<string>;
    /**
     * Name of web app slot. If not specified then will default to production slot.
     */
    readonly slot: pulumi.Input<string>;
    /**
     * The number of hours after session token expiration that a session token can be used to
     * call the token refresh API. The default is 72 hours.
     */
    readonly tokenRefreshExtensionHours?: pulumi.Input<number>;
    /**
     * <code>true</code> to durably store platform-specific security tokens that are obtained during login flows; otherwise, <code>false</code>.
     *  The default is <code>false</code>.
     */
    readonly tokenStoreEnabled?: pulumi.Input<boolean>;
    /**
     * The OAuth 1.0a consumer key of the Twitter application used for sign-in.
     * This setting is required for enabling Twitter Sign-In.
     * Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
     */
    readonly twitterConsumerKey?: pulumi.Input<string>;
    /**
     * The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
     * This setting is required for enabling Twitter Sign-In.
     * Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
     */
    readonly twitterConsumerSecret?: pulumi.Input<string>;
    /**
     * The action to take when an unauthenticated client attempts to access the app.
     */
    readonly unauthenticatedClientAction?: pulumi.Input<enums.web.v20180201.UnauthenticatedClientAction>;
    /**
     * Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such.
     */
    readonly validateIssuer?: pulumi.Input<boolean>;
}
