// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DomainRegistration.Latest
{
    /// <summary>
    /// Information about a domain.
    /// </summary>
    public partial class Domain : Pulumi.CustomResource
    {
        [Output("authCode")]
        public Output<string?> AuthCode { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Output("autoRenew")]
        public Output<bool?> AutoRenew { get; private set; } = null!;

        /// <summary>
        /// Legal agreement consent.
        /// </summary>
        [Output("consent")]
        public Output<Outputs.DomainPurchaseConsentResponse> Consent { get; private set; } = null!;

        /// <summary>
        /// Administrative contact.
        /// </summary>
        [Output("contactAdmin")]
        public Output<Outputs.ContactResponse> ContactAdmin { get; private set; } = null!;

        /// <summary>
        /// Billing contact.
        /// </summary>
        [Output("contactBilling")]
        public Output<Outputs.ContactResponse> ContactBilling { get; private set; } = null!;

        /// <summary>
        /// Registrant contact.
        /// </summary>
        [Output("contactRegistrant")]
        public Output<Outputs.ContactResponse> ContactRegistrant { get; private set; } = null!;

        /// <summary>
        /// Technical contact.
        /// </summary>
        [Output("contactTech")]
        public Output<Outputs.ContactResponse> ContactTech { get; private set; } = null!;

        /// <summary>
        /// Domain creation timestamp.
        /// </summary>
        [Output("createdTime")]
        public Output<string> CreatedTime { get; private set; } = null!;

        /// <summary>
        /// Current DNS type
        /// </summary>
        [Output("dnsType")]
        public Output<string?> DnsType { get; private set; } = null!;

        /// <summary>
        /// Azure DNS Zone to use
        /// </summary>
        [Output("dnsZoneId")]
        public Output<string?> DnsZoneId { get; private set; } = null!;

        /// <summary>
        /// Reasons why domain is not renewable.
        /// </summary>
        [Output("domainNotRenewableReasons")]
        public Output<ImmutableArray<string>> DomainNotRenewableReasons { get; private set; } = null!;

        /// <summary>
        /// Domain expiration timestamp.
        /// </summary>
        [Output("expirationTime")]
        public Output<string> ExpirationTime { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Timestamp when the domain was renewed last time.
        /// </summary>
        [Output("lastRenewedTime")]
        public Output<string> LastRenewedTime { get; private set; } = null!;

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// All hostnames derived from the domain and assigned to Azure resources.
        /// </summary>
        [Output("managedHostNames")]
        public Output<ImmutableArray<Outputs.HostNameResponse>> ManagedHostNames { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Name servers.
        /// </summary>
        [Output("nameServers")]
        public Output<ImmutableArray<string>> NameServers { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Output("privacy")]
        public Output<bool?> Privacy { get; private set; } = null!;

        /// <summary>
        /// Domain provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value will be &lt;code&gt;true&lt;/code&gt; if domain registration status is active and 
        ///  it is hosted on name servers Azure has programmatic access to.
        /// </summary>
        [Output("readyForDnsRecordManagement")]
        public Output<bool> ReadyForDnsRecordManagement { get; private set; } = null!;

        /// <summary>
        /// Domain registration status.
        /// </summary>
        [Output("registrationStatus")]
        public Output<string> RegistrationStatus { get; private set; } = null!;

        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Target DNS type (would be used for migration)
        /// </summary>
        [Output("targetDnsType")]
        public Output<string?> TargetDnsType { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Domain resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Domain(string name, DomainArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:domainregistration/latest:Domain", name, args ?? new DomainArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Domain(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:domainregistration/latest:Domain", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20150401:Domain"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20150801:Domain"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20180201:Domain"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20190801:Domain"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20200601:Domain"},
                    new Pulumi.Alias { Type = "azure-nextgen:domainregistration/v20200901:Domain"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Domain resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Domain Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Domain(name, id, options);
        }
    }

    public sealed class DomainArgs : Pulumi.ResourceArgs
    {
        [Input("authCode")]
        public Input<string>? AuthCode { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("autoRenew")]
        public Input<bool>? AutoRenew { get; set; }

        /// <summary>
        /// Legal agreement consent.
        /// </summary>
        [Input("consent", required: true)]
        public Input<Inputs.DomainPurchaseConsentArgs> Consent { get; set; } = null!;

        /// <summary>
        /// Administrative contact.
        /// </summary>
        [Input("contactAdmin", required: true)]
        public Input<Inputs.ContactArgs> ContactAdmin { get; set; } = null!;

        /// <summary>
        /// Billing contact.
        /// </summary>
        [Input("contactBilling", required: true)]
        public Input<Inputs.ContactArgs> ContactBilling { get; set; } = null!;

        /// <summary>
        /// Registrant contact.
        /// </summary>
        [Input("contactRegistrant", required: true)]
        public Input<Inputs.ContactArgs> ContactRegistrant { get; set; } = null!;

        /// <summary>
        /// Technical contact.
        /// </summary>
        [Input("contactTech", required: true)]
        public Input<Inputs.ContactArgs> ContactTech { get; set; } = null!;

        /// <summary>
        /// Current DNS type
        /// </summary>
        [Input("dnsType")]
        public Input<string>? DnsType { get; set; }

        /// <summary>
        /// Azure DNS Zone to use
        /// </summary>
        [Input("dnsZoneId")]
        public Input<string>? DnsZoneId { get; set; }

        /// <summary>
        /// Name of the domain.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("privacy")]
        public Input<bool>? Privacy { get; set; }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Target DNS type (would be used for migration)
        /// </summary>
        [Input("targetDnsType")]
        public Input<string>? TargetDnsType { get; set; }

        public DomainArgs()
        {
        }
    }
}
