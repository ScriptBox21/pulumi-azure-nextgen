// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest.Outputs
{

    [OutputType]
    public sealed class CookieExpirationResponse
    {
        public readonly string? Convention;
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
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        public readonly string? TimeToExpiration;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private CookieExpirationResponse(
            string? convention,

            string id,

            string? kind,

            string name,

            Outputs.SystemDataResponse systemData,

            string? timeToExpiration,

            string type)
        {
            Convention = convention;
            Id = id;
            Kind = kind;
            Name = name;
            SystemData = systemData;
            TimeToExpiration = timeToExpiration;
            Type = type;
        }
    }
}
