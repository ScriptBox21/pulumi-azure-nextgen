// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20181101

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Predefined action to be taken.
type AutoHealActionType pulumi.String

const (
	AutoHealActionTypeRecycle      = AutoHealActionType("Recycle")
	AutoHealActionTypeLogEvent     = AutoHealActionType("LogEvent")
	AutoHealActionTypeCustomAction = AutoHealActionType("CustomAction")
)

func (AutoHealActionType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e AutoHealActionType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e AutoHealActionType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e AutoHealActionType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e AutoHealActionType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Azure resource type.
type AzureResourceType pulumi.String

const (
	AzureResourceTypeWebsite        = AzureResourceType("Website")
	AzureResourceTypeTrafficManager = AzureResourceType("TrafficManager")
)

func (AzureResourceType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e AzureResourceType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e AzureResourceType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e AzureResourceType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e AzureResourceType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Type of storage.
type AzureStorageType pulumi.String

const (
	AzureStorageTypeAzureFiles = AzureStorageType("AzureFiles")
	AzureStorageTypeAzureBlob  = AzureStorageType("AzureBlob")
)

func (AzureStorageType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e AzureStorageType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e AzureStorageType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e AzureStorageType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e AzureStorageType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// The default authentication provider to use when multiple providers are configured.
// This setting is only needed if multiple providers are configured and the unauthenticated client
// action is set to "RedirectToLoginPage".
type BuiltInAuthenticationProvider pulumi.String

const (
	BuiltInAuthenticationProviderAzureActiveDirectory = BuiltInAuthenticationProvider("AzureActiveDirectory")
	BuiltInAuthenticationProviderFacebook             = BuiltInAuthenticationProvider("Facebook")
	BuiltInAuthenticationProviderGoogle               = BuiltInAuthenticationProvider("Google")
	BuiltInAuthenticationProviderMicrosoftAccount     = BuiltInAuthenticationProvider("MicrosoftAccount")
	BuiltInAuthenticationProviderTwitter              = BuiltInAuthenticationProvider("Twitter")
)

func (BuiltInAuthenticationProvider) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e BuiltInAuthenticationProvider) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e BuiltInAuthenticationProvider) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e BuiltInAuthenticationProvider) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e BuiltInAuthenticationProvider) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Type of database.
type ConnectionStringType pulumi.String

const (
	ConnectionStringTypeMySql           = ConnectionStringType("MySql")
	ConnectionStringTypeSQLServer       = ConnectionStringType("SQLServer")
	ConnectionStringTypeSQLAzure        = ConnectionStringType("SQLAzure")
	ConnectionStringTypeCustom          = ConnectionStringType("Custom")
	ConnectionStringTypeNotificationHub = ConnectionStringType("NotificationHub")
	ConnectionStringTypeServiceBus      = ConnectionStringType("ServiceBus")
	ConnectionStringTypeEventHub        = ConnectionStringType("EventHub")
	ConnectionStringTypeApiHub          = ConnectionStringType("ApiHub")
	ConnectionStringTypeDocDb           = ConnectionStringType("DocDb")
	ConnectionStringTypeRedisCache      = ConnectionStringType("RedisCache")
	ConnectionStringTypePostgreSQL      = ConnectionStringType("PostgreSQL")
)

func (ConnectionStringType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e ConnectionStringType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ConnectionStringType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ConnectionStringType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ConnectionStringType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Custom DNS record type.
type CustomHostNameDnsRecordType pulumi.String

const (
	CustomHostNameDnsRecordTypeCName = CustomHostNameDnsRecordType("CName")
	CustomHostNameDnsRecordTypeA     = CustomHostNameDnsRecordType("A")
)

func (CustomHostNameDnsRecordType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e CustomHostNameDnsRecordType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e CustomHostNameDnsRecordType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e CustomHostNameDnsRecordType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e CustomHostNameDnsRecordType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Database type (e.g. SqlAzure / MySql).
type DatabaseType pulumi.String

const (
	DatabaseTypeSqlAzure   = DatabaseType("SqlAzure")
	DatabaseTypeMySql      = DatabaseType("MySql")
	DatabaseTypeLocalMySql = DatabaseType("LocalMySql")
	DatabaseTypePostgreSql = DatabaseType("PostgreSql")
)

func (DatabaseType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e DatabaseType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e DatabaseType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e DatabaseType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e DatabaseType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// The unit of time for how often the backup should be executed (e.g. for weekly backup, this should be set to Day and FrequencyInterval should be set to 7)
type FrequencyUnit pulumi.String

const (
	FrequencyUnitDay  = FrequencyUnit("Day")
	FrequencyUnitHour = FrequencyUnit("Hour")
)

func (FrequencyUnit) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e FrequencyUnit) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e FrequencyUnit) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e FrequencyUnit) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e FrequencyUnit) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// State of FTP / FTPS service
type FtpsState pulumi.String

const (
	FtpsStateAllAllowed = FtpsState("AllAllowed")
	FtpsStateFtpsOnly   = FtpsState("FtpsOnly")
	FtpsStateDisabled   = FtpsState("Disabled")
)

func (FtpsState) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e FtpsState) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e FtpsState) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e FtpsState) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e FtpsState) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Hostname type.
type HostNameType pulumi.String

const (
	HostNameTypeVerified = HostNameType("Verified")
	HostNameTypeManaged  = HostNameType("Managed")
)

func (HostNameType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e HostNameType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e HostNameType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e HostNameType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e HostNameType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Indicates whether the hostname is a standard or repository hostname.
type HostType pulumi.String

const (
	HostTypeStandard   = HostType("Standard")
	HostTypeRepository = HostType("Repository")
)

func (HostType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e HostType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e HostType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e HostType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e HostType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Defines what this IP filter will be used for. This is to support IP filtering on proxies.
type IpFilterTag pulumi.String

const (
	IpFilterTagDefault  = IpFilterTag("Default")
	IpFilterTagXffProxy = IpFilterTag("XffProxy")
)

func (IpFilterTag) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e IpFilterTag) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e IpFilterTag) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e IpFilterTag) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e IpFilterTag) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Log level.
type LogLevel pulumi.String

const (
	LogLevelOff         = LogLevel("Off")
	LogLevelVerbose     = LogLevel("Verbose")
	LogLevelInformation = LogLevel("Information")
	LogLevelWarning     = LogLevel("Warning")
	LogLevelError       = LogLevel("Error")
)

func (LogLevel) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e LogLevel) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e LogLevel) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e LogLevel) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e LogLevel) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Managed pipeline mode.
type ManagedPipelineMode pulumi.String

const (
	ManagedPipelineModeIntegrated = ManagedPipelineMode("Integrated")
	ManagedPipelineModeClassic    = ManagedPipelineMode("Classic")
)

func (ManagedPipelineMode) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e ManagedPipelineMode) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ManagedPipelineMode) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ManagedPipelineMode) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ManagedPipelineMode) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Type of managed service identity.
type ManagedServiceIdentityType pulumi.String

const (
	ManagedServiceIdentityTypeSystemAssigned               = ManagedServiceIdentityType("SystemAssigned")
	ManagedServiceIdentityTypeUserAssigned                 = ManagedServiceIdentityType("UserAssigned")
	ManagedServiceIdentityType_SystemAssigned_UserAssigned = ManagedServiceIdentityType("SystemAssigned, UserAssigned")
	ManagedServiceIdentityTypeNone                         = ManagedServiceIdentityType("None")
)

func (ManagedServiceIdentityType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e ManagedServiceIdentityType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ManagedServiceIdentityType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ManagedServiceIdentityType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ManagedServiceIdentityType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Public Certificate Location
type PublicCertificateLocation pulumi.String

const (
	PublicCertificateLocationCurrentUserMy  = PublicCertificateLocation("CurrentUserMy")
	PublicCertificateLocationLocalMachineMy = PublicCertificateLocation("LocalMachineMy")
	PublicCertificateLocationUnknown        = PublicCertificateLocation("Unknown")
)

func (PublicCertificateLocation) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e PublicCertificateLocation) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e PublicCertificateLocation) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e PublicCertificateLocation) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e PublicCertificateLocation) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Site redundancy mode
type RedundancyMode pulumi.String

const (
	RedundancyModeNone         = RedundancyMode("None")
	RedundancyModeManual       = RedundancyMode("Manual")
	RedundancyModeFailover     = RedundancyMode("Failover")
	RedundancyModeActiveActive = RedundancyMode("ActiveActive")
	RedundancyModeGeoRedundant = RedundancyMode("GeoRedundant")
)

func (RedundancyMode) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e RedundancyMode) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e RedundancyMode) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e RedundancyMode) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e RedundancyMode) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// SCM type.
type ScmType pulumi.String

const (
	ScmTypeNone         = ScmType("None")
	ScmTypeDropbox      = ScmType("Dropbox")
	ScmTypeTfs          = ScmType("Tfs")
	ScmTypeLocalGit     = ScmType("LocalGit")
	ScmTypeGitHub       = ScmType("GitHub")
	ScmTypeCodePlexGit  = ScmType("CodePlexGit")
	ScmTypeCodePlexHg   = ScmType("CodePlexHg")
	ScmTypeBitbucketGit = ScmType("BitbucketGit")
	ScmTypeBitbucketHg  = ScmType("BitbucketHg")
	ScmTypeExternalGit  = ScmType("ExternalGit")
	ScmTypeExternalHg   = ScmType("ExternalHg")
	ScmTypeOneDrive     = ScmType("OneDrive")
	ScmTypeVSO          = ScmType("VSO")
)

func (ScmType) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e ScmType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ScmType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ScmType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ScmType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// Site load balancing.
type SiteLoadBalancing pulumi.String

const (
	SiteLoadBalancingWeightedRoundRobin   = SiteLoadBalancing("WeightedRoundRobin")
	SiteLoadBalancingLeastRequests        = SiteLoadBalancing("LeastRequests")
	SiteLoadBalancingLeastResponseTime    = SiteLoadBalancing("LeastResponseTime")
	SiteLoadBalancingWeightedTotalTraffic = SiteLoadBalancing("WeightedTotalTraffic")
	SiteLoadBalancingRequestHash          = SiteLoadBalancing("RequestHash")
)

func (SiteLoadBalancing) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e SiteLoadBalancing) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e SiteLoadBalancing) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e SiteLoadBalancing) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e SiteLoadBalancing) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// SSL type.
type SslState pulumi.String

const (
	SslStateDisabled       = SslState("Disabled")
	SslStateSniEnabled     = SslState("SniEnabled")
	SslStateIpBasedEnabled = SslState("IpBasedEnabled")
)

func (SslState) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e SslState) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e SslState) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e SslState) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e SslState) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// MinTlsVersion: configures the minimum version of TLS required for SSL requests
type SupportedTlsVersions pulumi.String

const (
	SupportedTlsVersions_1_0 = SupportedTlsVersions("1.0")
	SupportedTlsVersions_1_1 = SupportedTlsVersions("1.1")
	SupportedTlsVersions_1_2 = SupportedTlsVersions("1.2")
)

func (SupportedTlsVersions) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e SupportedTlsVersions) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e SupportedTlsVersions) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e SupportedTlsVersions) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e SupportedTlsVersions) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

// The action to take when an unauthenticated client attempts to access the app.
type UnauthenticatedClientAction pulumi.String

const (
	UnauthenticatedClientActionRedirectToLoginPage = UnauthenticatedClientAction("RedirectToLoginPage")
	UnauthenticatedClientActionAllowAnonymous      = UnauthenticatedClientAction("AllowAnonymous")
)

func (UnauthenticatedClientAction) ElementType() reflect.Type {
	return reflect.TypeOf((*pulumi.String)(nil)).Elem()
}

func (e UnauthenticatedClientAction) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e UnauthenticatedClientAction) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e UnauthenticatedClientAction) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e UnauthenticatedClientAction) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}
