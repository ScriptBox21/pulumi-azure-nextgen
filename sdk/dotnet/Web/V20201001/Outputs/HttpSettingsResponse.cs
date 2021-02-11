// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001.Outputs
{

    [OutputType]
    public sealed class HttpSettingsResponse
    {
        public readonly Outputs.ForwardProxyResponse? ForwardProxy;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        public readonly bool? RequireHttps;
        public readonly Outputs.HttpSettingsRoutesResponse? Routes;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private HttpSettingsResponse(
            Outputs.ForwardProxyResponse? forwardProxy,

            string id,

            string? kind,

            string name,

            bool? requireHttps,

            Outputs.HttpSettingsRoutesResponse? routes,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            ForwardProxy = forwardProxy;
            Id = id;
            Kind = kind;
            Name = name;
            RequireHttps = requireHttps;
            Routes = routes;
            SystemData = systemData;
            Type = type;
        }
    }
}
