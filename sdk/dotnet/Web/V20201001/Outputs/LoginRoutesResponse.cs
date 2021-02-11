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
    public sealed class LoginRoutesResponse
    {
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        public readonly string? LogoutEndpoint;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private LoginRoutesResponse(
            string id,

            string? kind,

            string? logoutEndpoint,

            string name,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Kind = kind;
            LogoutEndpoint = logoutEndpoint;
            Name = name;
            SystemData = systemData;
            Type = type;
        }
    }
}
