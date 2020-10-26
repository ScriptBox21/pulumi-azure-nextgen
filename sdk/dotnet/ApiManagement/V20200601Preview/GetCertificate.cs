// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20200601Preview
{
    public static class GetCertificate
    {
        public static Task<GetCertificateResult> InvokeAsync(GetCertificateArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCertificateResult>("azure-nextgen:apimanagement/v20200601preview:getCertificate", args ?? new GetCertificateArgs(), options.WithVersion());
    }


    public sealed class GetCertificateArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Identifier of the certificate entity. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("certificateId", required: true)]
        public string CertificateId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetCertificateArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCertificateResult
    {
        /// <summary>
        /// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        /// </summary>
        public readonly string ExpirationDate;
        /// <summary>
        /// KeyVault location details of the certificate.
        /// </summary>
        public readonly Outputs.KeyVaultContractPropertiesResponse? KeyVault;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Subject attribute of the certificate.
        /// </summary>
        public readonly string Subject;
        /// <summary>
        /// Thumbprint of the certificate.
        /// </summary>
        public readonly string Thumbprint;
        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetCertificateResult(
            string expirationDate,

            Outputs.KeyVaultContractPropertiesResponse? keyVault,

            string name,

            string subject,

            string thumbprint,

            string type)
        {
            ExpirationDate = expirationDate;
            KeyVault = keyVault;
            Name = name;
            Subject = subject;
            Thumbprint = thumbprint;
            Type = type;
        }
    }
}
