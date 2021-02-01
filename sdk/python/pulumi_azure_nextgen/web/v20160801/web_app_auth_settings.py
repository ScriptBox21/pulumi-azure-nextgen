# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ._enums import *

__all__ = ['WebAppAuthSettings']


class WebAppAuthSettings(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 additional_login_params: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 allowed_audiences: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 allowed_external_redirect_urls: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 client_id: Optional[pulumi.Input[str]] = None,
                 client_secret: Optional[pulumi.Input[str]] = None,
                 default_provider: Optional[pulumi.Input['BuiltInAuthenticationProvider']] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 facebook_app_id: Optional[pulumi.Input[str]] = None,
                 facebook_app_secret: Optional[pulumi.Input[str]] = None,
                 facebook_o_auth_scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 google_client_id: Optional[pulumi.Input[str]] = None,
                 google_client_secret: Optional[pulumi.Input[str]] = None,
                 google_o_auth_scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 issuer: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 microsoft_account_client_id: Optional[pulumi.Input[str]] = None,
                 microsoft_account_client_secret: Optional[pulumi.Input[str]] = None,
                 microsoft_account_o_auth_scopes: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 runtime_version: Optional[pulumi.Input[str]] = None,
                 token_refresh_extension_hours: Optional[pulumi.Input[float]] = None,
                 token_store_enabled: Optional[pulumi.Input[bool]] = None,
                 twitter_consumer_key: Optional[pulumi.Input[str]] = None,
                 twitter_consumer_secret: Optional[pulumi.Input[str]] = None,
                 unauthenticated_client_action: Optional[pulumi.Input['UnauthenticatedClientAction']] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Configuration settings for the Azure App Service Authentication / Authorization feature.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] additional_login_params: Login parameters to send to the OpenID Connect authorization endpoint when
               a user logs in. Each parameter must be in the form "key=value".
        :param pulumi.Input[Sequence[pulumi.Input[str]]] allowed_audiences: Allowed audience values to consider when validating JWTs issued by 
               Azure Active Directory. Note that the <code>ClientID</code> value is always considered an
               allowed audience, regardless of this setting.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] allowed_external_redirect_urls: External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
               This is an advanced setting typically only needed by Windows Store application backends.
               Note that URLs within the current domain are always implicitly allowed.
        :param pulumi.Input[str] client_id: The Client ID of this relying party application, known as the client_id.
               This setting is required for enabling OpenID Connection authentication with Azure Active Directory or 
               other 3rd party OpenID Connect providers.
               More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        :param pulumi.Input[str] client_secret: The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
               This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
               Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
               More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        :param pulumi.Input['BuiltInAuthenticationProvider'] default_provider: The default authentication provider to use when multiple providers are configured.
               This setting is only needed if multiple providers are configured and the unauthenticated client
               action is set to "RedirectToLoginPage".
        :param pulumi.Input[bool] enabled: <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
        :param pulumi.Input[str] facebook_app_id: The App ID of the Facebook app used for login.
               This setting is required for enabling Facebook Login.
               Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        :param pulumi.Input[str] facebook_app_secret: The App Secret of the Facebook app used for Facebook Login.
               This setting is required for enabling Facebook Login.
               Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        :param pulumi.Input[Sequence[pulumi.Input[str]]] facebook_o_auth_scopes: The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
               This setting is optional.
               Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        :param pulumi.Input[str] google_client_id: The OpenID Connect Client ID for the Google web application.
               This setting is required for enabling Google Sign-In.
               Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        :param pulumi.Input[str] google_client_secret: The client secret associated with the Google web application.
               This setting is required for enabling Google Sign-In.
               Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        :param pulumi.Input[Sequence[pulumi.Input[str]]] google_o_auth_scopes: The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
               This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
               Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        :param pulumi.Input[str] issuer: The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
               When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
               This URI is a case-sensitive identifier for the token issuer.
               More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        :param pulumi.Input[str] kind: Kind of resource.
        :param pulumi.Input[str] microsoft_account_client_id: The OAuth 2.0 client ID that was created for the app used for authentication.
               This setting is required for enabling Microsoft Account authentication.
               Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        :param pulumi.Input[str] microsoft_account_client_secret: The OAuth 2.0 client secret that was created for the app used for authentication.
               This setting is required for enabling Microsoft Account authentication.
               Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        :param pulumi.Input[Sequence[pulumi.Input[str]]] microsoft_account_o_auth_scopes: The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
               This setting is optional. If not specified, "wl.basic" is used as the default scope.
               Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
        :param pulumi.Input[str] name: Name of web app.
        :param pulumi.Input[str] resource_group_name: Name of the resource group to which the resource belongs.
        :param pulumi.Input[str] runtime_version: The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
               The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        :param pulumi.Input[float] token_refresh_extension_hours: The number of hours after session token expiration that a session token can be used to
               call the token refresh API. The default is 72 hours.
        :param pulumi.Input[bool] token_store_enabled: <code>true</code> to durably store platform-specific security tokens that are obtained during login flows; otherwise, <code>false</code>.
                The default is <code>false</code>.
        :param pulumi.Input[str] twitter_consumer_key: The OAuth 1.0a consumer key of the Twitter application used for sign-in.
               This setting is required for enabling Twitter Sign-In.
               Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        :param pulumi.Input[str] twitter_consumer_secret: The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
               This setting is required for enabling Twitter Sign-In.
               Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        :param pulumi.Input['UnauthenticatedClientAction'] unauthenticated_client_action: The action to take when an unauthenticated client attempts to access the app.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['additional_login_params'] = additional_login_params
            __props__['allowed_audiences'] = allowed_audiences
            __props__['allowed_external_redirect_urls'] = allowed_external_redirect_urls
            __props__['client_id'] = client_id
            __props__['client_secret'] = client_secret
            __props__['default_provider'] = default_provider
            __props__['enabled'] = enabled
            __props__['facebook_app_id'] = facebook_app_id
            __props__['facebook_app_secret'] = facebook_app_secret
            __props__['facebook_o_auth_scopes'] = facebook_o_auth_scopes
            __props__['google_client_id'] = google_client_id
            __props__['google_client_secret'] = google_client_secret
            __props__['google_o_auth_scopes'] = google_o_auth_scopes
            __props__['issuer'] = issuer
            __props__['kind'] = kind
            __props__['microsoft_account_client_id'] = microsoft_account_client_id
            __props__['microsoft_account_client_secret'] = microsoft_account_client_secret
            __props__['microsoft_account_o_auth_scopes'] = microsoft_account_o_auth_scopes
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['runtime_version'] = runtime_version
            __props__['token_refresh_extension_hours'] = token_refresh_extension_hours
            __props__['token_store_enabled'] = token_store_enabled
            __props__['twitter_consumer_key'] = twitter_consumer_key
            __props__['twitter_consumer_secret'] = twitter_consumer_secret
            __props__['unauthenticated_client_action'] = unauthenticated_client_action
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:web/latest:WebAppAuthSettings"), pulumi.Alias(type_="azure-nextgen:web/v20150801:WebAppAuthSettings"), pulumi.Alias(type_="azure-nextgen:web/v20180201:WebAppAuthSettings"), pulumi.Alias(type_="azure-nextgen:web/v20181101:WebAppAuthSettings"), pulumi.Alias(type_="azure-nextgen:web/v20190801:WebAppAuthSettings"), pulumi.Alias(type_="azure-nextgen:web/v20200601:WebAppAuthSettings"), pulumi.Alias(type_="azure-nextgen:web/v20200901:WebAppAuthSettings")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(WebAppAuthSettings, __self__).__init__(
            'azure-nextgen:web/v20160801:WebAppAuthSettings',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'WebAppAuthSettings':
        """
        Get an existing WebAppAuthSettings resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return WebAppAuthSettings(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="additionalLoginParams")
    def additional_login_params(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Login parameters to send to the OpenID Connect authorization endpoint when
        a user logs in. Each parameter must be in the form "key=value".
        """
        return pulumi.get(self, "additional_login_params")

    @property
    @pulumi.getter(name="allowedAudiences")
    def allowed_audiences(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Allowed audience values to consider when validating JWTs issued by 
        Azure Active Directory. Note that the <code>ClientID</code> value is always considered an
        allowed audience, regardless of this setting.
        """
        return pulumi.get(self, "allowed_audiences")

    @property
    @pulumi.getter(name="allowedExternalRedirectUrls")
    def allowed_external_redirect_urls(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        This is an advanced setting typically only needed by Windows Store application backends.
        Note that URLs within the current domain are always implicitly allowed.
        """
        return pulumi.get(self, "allowed_external_redirect_urls")

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> pulumi.Output[Optional[str]]:
        """
        The Client ID of this relying party application, known as the client_id.
        This setting is required for enabling OpenID Connection authentication with Azure Active Directory or 
        other 3rd party OpenID Connect providers.
        More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> pulumi.Output[Optional[str]]:
        """
        The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
        This setting is optional. If no client secret is configured, the OpenID Connect implicit auth flow is used to authenticate end users.
        Otherwise, the OpenID Connect Authorization Code Flow is used to authenticate end users.
        More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        """
        return pulumi.get(self, "client_secret")

    @property
    @pulumi.getter(name="defaultProvider")
    def default_provider(self) -> pulumi.Output[Optional[str]]:
        """
        The default authentication provider to use when multiple providers are configured.
        This setting is only needed if multiple providers are configured and the unauthenticated client
        action is set to "RedirectToLoginPage".
        """
        return pulumi.get(self, "default_provider")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="facebookAppId")
    def facebook_app_id(self) -> pulumi.Output[Optional[str]]:
        """
        The App ID of the Facebook app used for login.
        This setting is required for enabling Facebook Login.
        Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        """
        return pulumi.get(self, "facebook_app_id")

    @property
    @pulumi.getter(name="facebookAppSecret")
    def facebook_app_secret(self) -> pulumi.Output[Optional[str]]:
        """
        The App Secret of the Facebook app used for Facebook Login.
        This setting is required for enabling Facebook Login.
        Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        """
        return pulumi.get(self, "facebook_app_secret")

    @property
    @pulumi.getter(name="facebookOAuthScopes")
    def facebook_o_auth_scopes(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
        This setting is optional.
        Facebook Login documentation: https://developers.facebook.com/docs/facebook-login
        """
        return pulumi.get(self, "facebook_o_auth_scopes")

    @property
    @pulumi.getter(name="googleClientId")
    def google_client_id(self) -> pulumi.Output[Optional[str]]:
        """
        The OpenID Connect Client ID for the Google web application.
        This setting is required for enabling Google Sign-In.
        Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        """
        return pulumi.get(self, "google_client_id")

    @property
    @pulumi.getter(name="googleClientSecret")
    def google_client_secret(self) -> pulumi.Output[Optional[str]]:
        """
        The client secret associated with the Google web application.
        This setting is required for enabling Google Sign-In.
        Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        """
        return pulumi.get(self, "google_client_secret")

    @property
    @pulumi.getter(name="googleOAuthScopes")
    def google_o_auth_scopes(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
        This setting is optional. If not specified, "openid", "profile", and "email" are used as default scopes.
        Google Sign-In documentation: https://developers.google.com/identity/sign-in/web/
        """
        return pulumi.get(self, "google_o_auth_scopes")

    @property
    @pulumi.getter
    def issuer(self) -> pulumi.Output[Optional[str]]:
        """
        The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        This URI is a case-sensitive identifier for the token issuer.
        More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        """
        return pulumi.get(self, "issuer")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[Optional[str]]:
        """
        Kind of resource.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter(name="microsoftAccountClientId")
    def microsoft_account_client_id(self) -> pulumi.Output[Optional[str]]:
        """
        The OAuth 2.0 client ID that was created for the app used for authentication.
        This setting is required for enabling Microsoft Account authentication.
        Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        """
        return pulumi.get(self, "microsoft_account_client_id")

    @property
    @pulumi.getter(name="microsoftAccountClientSecret")
    def microsoft_account_client_secret(self) -> pulumi.Output[Optional[str]]:
        """
        The OAuth 2.0 client secret that was created for the app used for authentication.
        This setting is required for enabling Microsoft Account authentication.
        Microsoft Account OAuth documentation: https://dev.onedrive.com/auth/msa_oauth.htm
        """
        return pulumi.get(self, "microsoft_account_client_secret")

    @property
    @pulumi.getter(name="microsoftAccountOAuthScopes")
    def microsoft_account_o_auth_scopes(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
        This setting is optional. If not specified, "wl.basic" is used as the default scope.
        Microsoft Account Scopes and permissions documentation: https://msdn.microsoft.com/en-us/library/dn631845.aspx
        """
        return pulumi.get(self, "microsoft_account_o_auth_scopes")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource Name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="runtimeVersion")
    def runtime_version(self) -> pulumi.Output[Optional[str]]:
        """
        The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        """
        return pulumi.get(self, "runtime_version")

    @property
    @pulumi.getter(name="tokenRefreshExtensionHours")
    def token_refresh_extension_hours(self) -> pulumi.Output[Optional[float]]:
        """
        The number of hours after session token expiration that a session token can be used to
        call the token refresh API. The default is 72 hours.
        """
        return pulumi.get(self, "token_refresh_extension_hours")

    @property
    @pulumi.getter(name="tokenStoreEnabled")
    def token_store_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        <code>true</code> to durably store platform-specific security tokens that are obtained during login flows; otherwise, <code>false</code>.
         The default is <code>false</code>.
        """
        return pulumi.get(self, "token_store_enabled")

    @property
    @pulumi.getter(name="twitterConsumerKey")
    def twitter_consumer_key(self) -> pulumi.Output[Optional[str]]:
        """
        The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        This setting is required for enabling Twitter Sign-In.
        Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        """
        return pulumi.get(self, "twitter_consumer_key")

    @property
    @pulumi.getter(name="twitterConsumerSecret")
    def twitter_consumer_secret(self) -> pulumi.Output[Optional[str]]:
        """
        The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
        This setting is required for enabling Twitter Sign-In.
        Twitter Sign-In documentation: https://dev.twitter.com/web/sign-in
        """
        return pulumi.get(self, "twitter_consumer_secret")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="unauthenticatedClientAction")
    def unauthenticated_client_action(self) -> pulumi.Output[Optional[str]]:
        """
        The action to take when an unauthenticated client attempts to access the app.
        """
        return pulumi.get(self, "unauthenticated_client_action")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

