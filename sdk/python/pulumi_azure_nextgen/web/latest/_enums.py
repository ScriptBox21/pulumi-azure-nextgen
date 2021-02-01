# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'AccessControlEntryAction',
    'ApiType',
    'AutoHealActionType',
    'AzureResourceType',
    'AzureStorageType',
    'BuiltInAuthenticationProvider',
    'ClientCertMode',
    'ClientCredentialMethod',
    'ComputeModeOptions',
    'ConnectionParameterType',
    'ConnectionStringType',
    'CookieExpirationConvention',
    'CustomHostNameDnsRecordType',
    'DatabaseType',
    'ForwardProxyConvention',
    'FrequencyUnit',
    'FtpsState',
    'HostNameType',
    'HostType',
    'HostingEnvironmentStatus',
    'InternalLoadBalancingMode',
    'IpFilterTag',
    'LoadBalancingMode',
    'LogLevel',
    'ManagedPipelineMode',
    'ManagedServiceIdentityType',
    'ProvisioningState',
    'PublicCertificateLocation',
    'RedundancyMode',
    'RouteType',
    'ScmType',
    'SiteLoadBalancing',
    'SslState',
    'SupportedTlsVersions',
    'UnauthenticatedClientAction',
    'UnauthenticatedClientActionV2',
    'WorkerSizeOptions',
    'WsdlImportMethod',
]


class AccessControlEntryAction(str, Enum):
    PERMIT = "Permit"
    DENY = "Deny"


class ApiType(str, Enum):
    """
    The API type
    """
    NOT_SPECIFIED = "NotSpecified"
    REST = "Rest"
    SOAP = "Soap"


class AutoHealActionType(str, Enum):
    """
    Predefined action to be taken.
    """
    RECYCLE = "Recycle"
    LOG_EVENT = "LogEvent"
    CUSTOM_ACTION = "CustomAction"


class AzureResourceType(str, Enum):
    """
    Azure resource type.
    """
    WEBSITE = "Website"
    TRAFFIC_MANAGER = "TrafficManager"


class AzureStorageType(str, Enum):
    """
    Type of storage.
    """
    AZURE_FILES = "AzureFiles"
    AZURE_BLOB = "AzureBlob"


class BuiltInAuthenticationProvider(str, Enum):
    """
    The default authentication provider to use when multiple providers are configured.
    This setting is only needed if multiple providers are configured and the unauthenticated client
    action is set to "RedirectToLoginPage".
    """
    AZURE_ACTIVE_DIRECTORY = "AzureActiveDirectory"
    FACEBOOK = "Facebook"
    GOOGLE = "Google"
    MICROSOFT_ACCOUNT = "MicrosoftAccount"
    TWITTER = "Twitter"
    GITHUB = "Github"


class ClientCertMode(str, Enum):
    """
    This composes with ClientCertEnabled setting.
    - ClientCertEnabled: false means ClientCert is ignored.
    - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
    - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
    """
    REQUIRED = "Required"
    OPTIONAL = "Optional"


class ClientCredentialMethod(str, Enum):
    CLIENT_SECRET_POST = "ClientSecretPost"


class ComputeModeOptions(str, Enum):
    """
    Shared or dedicated web app hosting
    """
    SHARED = "Shared"
    DEDICATED = "Dedicated"
    DYNAMIC = "Dynamic"


class ConnectionParameterType(str, Enum):
    """
    Type of the parameter
    """
    STRING = "string"
    SECURESTRING = "securestring"
    SECUREOBJECT = "secureobject"
    INT = "int"
    BOOL = "bool"
    OBJECT = "object"
    ARRAY = "array"
    OAUTH_SETTING = "oauthSetting"
    CONNECTION = "connection"


class ConnectionStringType(str, Enum):
    """
    Type of database.
    """
    MY_SQL = "MySql"
    SQL_SERVER = "SQLServer"
    SQL_AZURE = "SQLAzure"
    CUSTOM = "Custom"
    NOTIFICATION_HUB = "NotificationHub"
    SERVICE_BUS = "ServiceBus"
    EVENT_HUB = "EventHub"
    API_HUB = "ApiHub"
    DOC_DB = "DocDb"
    REDIS_CACHE = "RedisCache"
    POSTGRE_SQL = "PostgreSQL"


class CookieExpirationConvention(str, Enum):
    FIXED_TIME = "FixedTime"
    IDENTITY_PROVIDER_DERIVED = "IdentityProviderDerived"


class CustomHostNameDnsRecordType(str, Enum):
    """
    Custom DNS record type.
    """
    C_NAME = "CName"
    A = "A"


class DatabaseType(str, Enum):
    """
    Database type (e.g. SqlAzure / MySql).
    """
    SQL_AZURE = "SqlAzure"
    MY_SQL = "MySql"
    LOCAL_MY_SQL = "LocalMySql"
    POSTGRE_SQL = "PostgreSql"


class ForwardProxyConvention(str, Enum):
    NO_PROXY = "NoProxy"
    STANDARD = "Standard"
    CUSTOM = "Custom"


class FrequencyUnit(str, Enum):
    """
    The unit of time for how often the backup should be executed (e.g. for weekly backup, this should be set to Day and FrequencyInterval should be set to 7)
    """
    DAY = "Day"
    HOUR = "Hour"


class FtpsState(str, Enum):
    """
    State of FTP / FTPS service
    """
    ALL_ALLOWED = "AllAllowed"
    FTPS_ONLY = "FtpsOnly"
    DISABLED = "Disabled"


class HostNameType(str, Enum):
    """
    Hostname type.
    """
    VERIFIED = "Verified"
    MANAGED = "Managed"


class HostType(str, Enum):
    """
    Indicates whether the hostname is a standard or repository hostname.
    """
    STANDARD = "Standard"
    REPOSITORY = "Repository"


class HostingEnvironmentStatus(str, Enum):
    """
    Current status of the hostingEnvironment (App Service Environment)
    """
    PREPARING = "Preparing"
    READY = "Ready"
    SCALING = "Scaling"
    DELETING = "Deleting"


class InternalLoadBalancingMode(str, Enum):
    """
    Specifies which endpoints to serve internally in the hostingEnvironment's (App Service Environment) VNET
    """
    NONE = "None"
    WEB = "Web"
    PUBLISHING = "Publishing"


class IpFilterTag(str, Enum):
    """
    Defines what this IP filter will be used for. This is to support IP filtering on proxies.
    """
    DEFAULT = "Default"
    XFF_PROXY = "XffProxy"
    SERVICE_TAG = "ServiceTag"


class LoadBalancingMode(str, Enum):
    """
    Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment.
    """
    NONE = "None"
    WEB = "Web"
    PUBLISHING = "Publishing"
    WEB_PUBLISHING = "Web,Publishing"


class LogLevel(str, Enum):
    """
    Log level.
    """
    OFF = "Off"
    VERBOSE = "Verbose"
    INFORMATION = "Information"
    WARNING = "Warning"
    ERROR = "Error"


class ManagedPipelineMode(str, Enum):
    """
    Managed pipeline mode.
    """
    INTEGRATED = "Integrated"
    CLASSIC = "Classic"


class ManagedServiceIdentityType(str, Enum):
    """
    Type of managed service identity.
    """
    SYSTEM_ASSIGNED = "SystemAssigned"
    USER_ASSIGNED = "UserAssigned"
    SYSTEM_ASSIGNED_USER_ASSIGNED = "SystemAssigned, UserAssigned"
    NONE = "None"


class ProvisioningState(str, Enum):
    """
    Provisioning state of the hostingEnvironment (App Service Environment)
    """
    SUCCEEDED = "Succeeded"
    FAILED = "Failed"
    CANCELED = "Canceled"
    IN_PROGRESS = "InProgress"
    DELETING = "Deleting"


class PublicCertificateLocation(str, Enum):
    """
    Public Certificate Location
    """
    CURRENT_USER_MY = "CurrentUserMy"
    LOCAL_MACHINE_MY = "LocalMachineMy"
    UNKNOWN = "Unknown"


class RedundancyMode(str, Enum):
    """
    Site redundancy mode
    """
    NONE = "None"
    MANUAL = "Manual"
    FAILOVER = "Failover"
    ACTIVE_ACTIVE = "ActiveActive"
    GEO_REDUNDANT = "GeoRedundant"


class RouteType(str, Enum):
    """
    The type of route this is:
    DEFAULT - By default, every app has routes to the local address ranges specified by RFC1918
    INHERITED - Routes inherited from the real Virtual Network routes
    STATIC - Static route set on the app only

    These values will be used for syncing an app's routes with those from a Virtual Network.
    """
    DEFAULT = "DEFAULT"
    INHERITED = "INHERITED"
    STATIC = "STATIC"


class ScmType(str, Enum):
    """
    SCM type.
    """
    NONE = "None"
    DROPBOX = "Dropbox"
    TFS = "Tfs"
    LOCAL_GIT = "LocalGit"
    GIT_HUB = "GitHub"
    CODE_PLEX_GIT = "CodePlexGit"
    CODE_PLEX_HG = "CodePlexHg"
    BITBUCKET_GIT = "BitbucketGit"
    BITBUCKET_HG = "BitbucketHg"
    EXTERNAL_GIT = "ExternalGit"
    EXTERNAL_HG = "ExternalHg"
    ONE_DRIVE = "OneDrive"
    VSO = "VSO"
    VSTSRM = "VSTSRM"


class SiteLoadBalancing(str, Enum):
    """
    Site load balancing.
    """
    WEIGHTED_ROUND_ROBIN = "WeightedRoundRobin"
    LEAST_REQUESTS = "LeastRequests"
    LEAST_RESPONSE_TIME = "LeastResponseTime"
    WEIGHTED_TOTAL_TRAFFIC = "WeightedTotalTraffic"
    REQUEST_HASH = "RequestHash"


class SslState(str, Enum):
    """
    SSL type.
    """
    DISABLED = "Disabled"
    SNI_ENABLED = "SniEnabled"
    IP_BASED_ENABLED = "IpBasedEnabled"


class SupportedTlsVersions(str, Enum):
    """
    ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site
    """
    SUPPORTED_TLS_VERSIONS_1_0 = "1.0"
    SUPPORTED_TLS_VERSIONS_1_1 = "1.1"
    SUPPORTED_TLS_VERSIONS_1_2 = "1.2"


class UnauthenticatedClientAction(str, Enum):
    """
    The action to take when an unauthenticated client attempts to access the app.
    """
    REDIRECT_TO_LOGIN_PAGE = "RedirectToLoginPage"
    ALLOW_ANONYMOUS = "AllowAnonymous"


class UnauthenticatedClientActionV2(str, Enum):
    REDIRECT_TO_LOGIN_PAGE = "RedirectToLoginPage"
    ALLOW_ANONYMOUS = "AllowAnonymous"
    RETURN401 = "Return401"
    RETURN403 = "Return403"


class WorkerSizeOptions(str, Enum):
    """
    Size of the machines
    """
    DEFAULT = "Default"
    SMALL = "Small"
    MEDIUM = "Medium"
    LARGE = "Large"


class WsdlImportMethod(str, Enum):
    """
    The WSDL import method
    """
    NOT_SPECIFIED = "NotSpecified"
    SOAP_TO_REST = "SoapToRest"
    SOAP_PASS_THROUGH = "SoapPassThrough"
