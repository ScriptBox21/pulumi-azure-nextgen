// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabricMesh.V20180701Preview.Outputs
{

    [OutputType]
    public sealed class AzureInternalMonitoringPipelineSinkDescriptionResponse
    {
        /// <summary>
        /// Azure Internal monitoring pipeline account.
        /// </summary>
        public readonly string? AccountName;
        /// <summary>
        /// Azure Internal monitoring pipeline autokey associated with the certificate.
        /// </summary>
        public readonly string? AutoKeyConfigUrl;
        /// <summary>
        /// A description of the sink.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The kind of DiagnosticsSink.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Azure Internal monitoring agent configuration.
        /// </summary>
        public readonly string? MaConfigUrl;
        /// <summary>
        /// Name of the sink. This value is referenced by DiagnosticsReferenceDescription
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Azure Internal monitoring pipeline account namespace.
        /// </summary>
        public readonly string? Namespace;

        [OutputConstructor]
        private AzureInternalMonitoringPipelineSinkDescriptionResponse(
            string? accountName,

            string? autoKeyConfigUrl,

            string? description,

            string kind,

            string? maConfigUrl,

            string? name,

            string? @namespace)
        {
            AccountName = accountName;
            AutoKeyConfigUrl = autoKeyConfigUrl;
            Description = description;
            Kind = kind;
            MaConfigUrl = maConfigUrl;
            Name = name;
            Namespace = @namespace;
        }
    }
}
