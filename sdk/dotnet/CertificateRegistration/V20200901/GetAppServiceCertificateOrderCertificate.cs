// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CertificateRegistration.V20200901
{
    public static class GetAppServiceCertificateOrderCertificate
    {
        public static Task<GetAppServiceCertificateOrderCertificateResult> InvokeAsync(GetAppServiceCertificateOrderCertificateArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAppServiceCertificateOrderCertificateResult>("azure-nextgen:certificateregistration/v20200901:getAppServiceCertificateOrderCertificate", args ?? new GetAppServiceCertificateOrderCertificateArgs(), options.WithVersion());
    }


    public sealed class GetAppServiceCertificateOrderCertificateArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the certificate order.
        /// </summary>
        [Input("certificateOrderName", required: true)]
        public string CertificateOrderName { get; set; } = null!;

        /// <summary>
        /// Name of the certificate.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAppServiceCertificateOrderCertificateArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAppServiceCertificateOrderCertificateResult
    {
        /// <summary>
        /// Key Vault resource Id.
        /// </summary>
        public readonly string? KeyVaultId;
        /// <summary>
        /// Key Vault secret name.
        /// </summary>
        public readonly string? KeyVaultSecretName;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Status of the Key Vault secret.
        /// </summary>
        public readonly string ProvisioningState;
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

        [OutputConstructor]
        private GetAppServiceCertificateOrderCertificateResult(
            string? keyVaultId,

            string? keyVaultSecretName,

            string? kind,

            string location,

            string name,

            string provisioningState,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            KeyVaultId = keyVaultId;
            KeyVaultSecretName = keyVaultSecretName;
            Kind = kind;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}
