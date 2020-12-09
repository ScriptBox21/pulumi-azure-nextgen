// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest
{
    public static class GetWebAppPublicCertificate
    {
        public static Task<GetWebAppPublicCertificateResult> InvokeAsync(GetWebAppPublicCertificateArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWebAppPublicCertificateResult>("azure-nextgen:web/latest:getWebAppPublicCertificate", args ?? new GetWebAppPublicCertificateArgs(), options.WithVersion());
    }


    public sealed class GetWebAppPublicCertificateArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Public certificate name.
        /// </summary>
        [Input("publicCertificateName", required: true)]
        public string PublicCertificateName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetWebAppPublicCertificateArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWebAppPublicCertificateResult
    {
        /// <summary>
        /// Public Certificate byte array
        /// </summary>
        public readonly string? Blob;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Public Certificate Location
        /// </summary>
        public readonly string? PublicCertificateLocation;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Certificate Thumbprint
        /// </summary>
        public readonly string Thumbprint;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetWebAppPublicCertificateResult(
            string? blob,

            string? kind,

            string name,

            string? publicCertificateLocation,

            Outputs.SystemDataResponse systemData,

            string thumbprint,

            string type)
        {
            Blob = blob;
            Kind = kind;
            Name = name;
            PublicCertificateLocation = publicCertificateLocation;
            SystemData = systemData;
            Thumbprint = thumbprint;
            Type = type;
        }
    }
}
