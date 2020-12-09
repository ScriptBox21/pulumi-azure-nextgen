// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901
{
    public static class GetWebAppHostNameBindingSlot
    {
        public static Task<GetWebAppHostNameBindingSlotResult> InvokeAsync(GetWebAppHostNameBindingSlotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWebAppHostNameBindingSlotResult>("azure-nextgen:web/v20200901:getWebAppHostNameBindingSlot", args ?? new GetWebAppHostNameBindingSlotArgs(), options.WithVersion());
    }


    public sealed class GetWebAppHostNameBindingSlotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Hostname in the hostname binding.
        /// </summary>
        [Input("hostName", required: true)]
        public string HostName { get; set; } = null!;

        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the deployment slot. If a slot is not specified, the API the named binding for the production slot.
        /// </summary>
        [Input("slot", required: true)]
        public string Slot { get; set; } = null!;

        public GetWebAppHostNameBindingSlotArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWebAppHostNameBindingSlotResult
    {
        /// <summary>
        /// Azure resource name.
        /// </summary>
        public readonly string? AzureResourceName;
        /// <summary>
        /// Azure resource type.
        /// </summary>
        public readonly string? AzureResourceType;
        /// <summary>
        /// Custom DNS record type.
        /// </summary>
        public readonly string? CustomHostNameDnsRecordType;
        /// <summary>
        /// Fully qualified ARM domain resource URI.
        /// </summary>
        public readonly string? DomainId;
        /// <summary>
        /// Hostname type.
        /// </summary>
        public readonly string? HostNameType;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// App Service app name.
        /// </summary>
        public readonly string? SiteName;
        /// <summary>
        /// SSL type
        /// </summary>
        public readonly string? SslState;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// SSL certificate thumbprint
        /// </summary>
        public readonly string? Thumbprint;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Virtual IP address assigned to the hostname if IP based SSL is enabled.
        /// </summary>
        public readonly string VirtualIP;

        [OutputConstructor]
        private GetWebAppHostNameBindingSlotResult(
            string? azureResourceName,

            string? azureResourceType,

            string? customHostNameDnsRecordType,

            string? domainId,

            string? hostNameType,

            string? kind,

            string name,

            string? siteName,

            string? sslState,

            Outputs.SystemDataResponse systemData,

            string? thumbprint,

            string type,

            string virtualIP)
        {
            AzureResourceName = azureResourceName;
            AzureResourceType = azureResourceType;
            CustomHostNameDnsRecordType = customHostNameDnsRecordType;
            DomainId = domainId;
            HostNameType = hostNameType;
            Kind = kind;
            Name = name;
            SiteName = siteName;
            SslState = sslState;
            SystemData = systemData;
            Thumbprint = thumbprint;
            Type = type;
            VirtualIP = virtualIP;
        }
    }
}
