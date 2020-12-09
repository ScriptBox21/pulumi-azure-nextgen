// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CertificateRegistration.V20200901
{
    public static class GetAppServiceCertificateOrder
    {
        public static Task<GetAppServiceCertificateOrderResult> InvokeAsync(GetAppServiceCertificateOrderArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAppServiceCertificateOrderResult>("azure-nextgen:certificateregistration/v20200901:getAppServiceCertificateOrder", args ?? new GetAppServiceCertificateOrderArgs(), options.WithVersion());
    }


    public sealed class GetAppServiceCertificateOrderArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the certificate order..
        /// </summary>
        [Input("certificateOrderName", required: true)]
        public string CertificateOrderName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAppServiceCertificateOrderArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAppServiceCertificateOrderResult
    {
        /// <summary>
        /// Reasons why App Service Certificate is not renewable at the current moment.
        /// </summary>
        public readonly ImmutableArray<string> AppServiceCertificateNotRenewableReasons;
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        public readonly bool? AutoRenew;
        /// <summary>
        /// State of the Key Vault secret.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.AppServiceCertificateResponse>? Certificates;
        /// <summary>
        /// Last CSR that was created for this order.
        /// </summary>
        public readonly string? Csr;
        /// <summary>
        /// Certificate distinguished name.
        /// </summary>
        public readonly string? DistinguishedName;
        /// <summary>
        /// Domain verification token.
        /// </summary>
        public readonly string DomainVerificationToken;
        /// <summary>
        /// Certificate expiration time.
        /// </summary>
        public readonly string ExpirationTime;
        /// <summary>
        /// Intermediate certificate.
        /// </summary>
        public readonly Outputs.CertificateDetailsResponse Intermediate;
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        public readonly bool IsPrivateKeyExternal;
        /// <summary>
        /// Certificate key size.
        /// </summary>
        public readonly int? KeySize;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Certificate last issuance time.
        /// </summary>
        public readonly string LastCertificateIssuanceTime;
        /// <summary>
        /// Resource Location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Time stamp when the certificate would be auto renewed next
        /// </summary>
        public readonly string NextAutoRenewalTimeStamp;
        /// <summary>
        /// Certificate product type.
        /// </summary>
        public readonly string ProductType;
        /// <summary>
        /// Status of certificate order.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Root certificate.
        /// </summary>
        public readonly Outputs.CertificateDetailsResponse Root;
        /// <summary>
        /// Current serial number of the certificate.
        /// </summary>
        public readonly string SerialNumber;
        /// <summary>
        /// Signed certificate.
        /// </summary>
        public readonly Outputs.CertificateDetailsResponse SignedCertificate;
        /// <summary>
        /// Current order status.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Duration in years (must be between 1 and 3).
        /// </summary>
        public readonly int? ValidityInYears;

        [OutputConstructor]
        private GetAppServiceCertificateOrderResult(
            ImmutableArray<string> appServiceCertificateNotRenewableReasons,

            bool? autoRenew,

            ImmutableDictionary<string, Outputs.AppServiceCertificateResponse>? certificates,

            string? csr,

            string? distinguishedName,

            string domainVerificationToken,

            string expirationTime,

            Outputs.CertificateDetailsResponse intermediate,

            bool isPrivateKeyExternal,

            int? keySize,

            string? kind,

            string lastCertificateIssuanceTime,

            string location,

            string name,

            string nextAutoRenewalTimeStamp,

            string productType,

            string provisioningState,

            Outputs.CertificateDetailsResponse root,

            string serialNumber,

            Outputs.CertificateDetailsResponse signedCertificate,

            string status,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type,

            int? validityInYears)
        {
            AppServiceCertificateNotRenewableReasons = appServiceCertificateNotRenewableReasons;
            AutoRenew = autoRenew;
            Certificates = certificates;
            Csr = csr;
            DistinguishedName = distinguishedName;
            DomainVerificationToken = domainVerificationToken;
            ExpirationTime = expirationTime;
            Intermediate = intermediate;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            KeySize = keySize;
            Kind = kind;
            LastCertificateIssuanceTime = lastCertificateIssuanceTime;
            Location = location;
            Name = name;
            NextAutoRenewalTimeStamp = nextAutoRenewalTimeStamp;
            ProductType = productType;
            ProvisioningState = provisioningState;
            Root = root;
            SerialNumber = serialNumber;
            SignedCertificate = signedCertificate;
            Status = status;
            SystemData = systemData;
            Tags = tags;
            Type = type;
            ValidityInYears = validityInYears;
        }
    }
}
