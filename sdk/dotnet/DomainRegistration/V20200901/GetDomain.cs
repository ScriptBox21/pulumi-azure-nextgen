// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DomainRegistration.V20200901
{
    public static class GetDomain
    {
        public static Task<GetDomainResult> InvokeAsync(GetDomainArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDomainResult>("azure-nextgen:domainregistration/v20200901:getDomain", args ?? new GetDomainArgs(), options.WithVersion());
    }


    public sealed class GetDomainArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the domain.
        /// </summary>
        [Input("domainName", required: true)]
        public string DomainName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDomainArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDomainResult
    {
        public readonly string? AuthCode;
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        public readonly bool? AutoRenew;
        /// <summary>
        /// Legal agreement consent.
        /// </summary>
        public readonly Outputs.DomainPurchaseConsentResponse Consent;
        /// <summary>
        /// Administrative contact.
        /// </summary>
        public readonly Outputs.ContactResponse ContactAdmin;
        /// <summary>
        /// Billing contact.
        /// </summary>
        public readonly Outputs.ContactResponse ContactBilling;
        /// <summary>
        /// Registrant contact.
        /// </summary>
        public readonly Outputs.ContactResponse ContactRegistrant;
        /// <summary>
        /// Technical contact.
        /// </summary>
        public readonly Outputs.ContactResponse ContactTech;
        /// <summary>
        /// Domain creation timestamp.
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// Current DNS type
        /// </summary>
        public readonly string? DnsType;
        /// <summary>
        /// Azure DNS Zone to use
        /// </summary>
        public readonly string? DnsZoneId;
        /// <summary>
        /// Reasons why domain is not renewable.
        /// </summary>
        public readonly ImmutableArray<string> DomainNotRenewableReasons;
        /// <summary>
        /// Domain expiration timestamp.
        /// </summary>
        public readonly string ExpirationTime;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Timestamp when the domain was renewed last time.
        /// </summary>
        public readonly string LastRenewedTime;
        /// <summary>
        /// Resource Location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// All hostnames derived from the domain and assigned to Azure resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.HostNameResponse> ManagedHostNames;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Name servers.
        /// </summary>
        public readonly ImmutableArray<string> NameServers;
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        public readonly bool? Privacy;
        /// <summary>
        /// Domain provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value will be &lt;code&gt;true&lt;/code&gt; if domain registration status is active and 
        ///  it is hosted on name servers Azure has programmatic access to.
        /// </summary>
        public readonly bool ReadyForDnsRecordManagement;
        /// <summary>
        /// Domain registration status.
        /// </summary>
        public readonly string RegistrationStatus;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Target DNS type (would be used for migration)
        /// </summary>
        public readonly string? TargetDnsType;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDomainResult(
            string? authCode,

            bool? autoRenew,

            Outputs.DomainPurchaseConsentResponse consent,

            Outputs.ContactResponse contactAdmin,

            Outputs.ContactResponse contactBilling,

            Outputs.ContactResponse contactRegistrant,

            Outputs.ContactResponse contactTech,

            string createdTime,

            string? dnsType,

            string? dnsZoneId,

            ImmutableArray<string> domainNotRenewableReasons,

            string expirationTime,

            string? kind,

            string lastRenewedTime,

            string location,

            ImmutableArray<Outputs.HostNameResponse> managedHostNames,

            string name,

            ImmutableArray<string> nameServers,

            bool? privacy,

            string provisioningState,

            bool readyForDnsRecordManagement,

            string registrationStatus,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string? targetDnsType,

            string type)
        {
            AuthCode = authCode;
            AutoRenew = autoRenew;
            Consent = consent;
            ContactAdmin = contactAdmin;
            ContactBilling = contactBilling;
            ContactRegistrant = contactRegistrant;
            ContactTech = contactTech;
            CreatedTime = createdTime;
            DnsType = dnsType;
            DnsZoneId = dnsZoneId;
            DomainNotRenewableReasons = domainNotRenewableReasons;
            ExpirationTime = expirationTime;
            Kind = kind;
            LastRenewedTime = lastRenewedTime;
            Location = location;
            ManagedHostNames = managedHostNames;
            Name = name;
            NameServers = nameServers;
            Privacy = privacy;
            ProvisioningState = provisioningState;
            ReadyForDnsRecordManagement = readyForDnsRecordManagement;
            RegistrationStatus = registrationStatus;
            SystemData = systemData;
            Tags = tags;
            TargetDnsType = targetDnsType;
            Type = type;
        }
    }
}
