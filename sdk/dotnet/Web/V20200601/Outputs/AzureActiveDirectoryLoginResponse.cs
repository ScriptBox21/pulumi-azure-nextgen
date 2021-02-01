// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200601.Outputs
{

    [OutputType]
    public sealed class AzureActiveDirectoryLoginResponse
    {
        public readonly bool? DisableWWWAuthenticate;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        public readonly ImmutableArray<string> LoginParameters;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AzureActiveDirectoryLoginResponse(
            bool? disableWWWAuthenticate,

            string id,

            string? kind,

            ImmutableArray<string> loginParameters,

            string name,

            string type)
        {
            DisableWWWAuthenticate = disableWWWAuthenticate;
            Id = id;
            Kind = kind;
            LoginParameters = loginParameters;
            Name = name;
            Type = type;
        }
    }
}
