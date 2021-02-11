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
    public sealed class GlobalValidationResponse
    {
        public readonly ImmutableArray<string> ExcludedPaths;
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
        public readonly string? RedirectToProvider;
        public readonly bool? RequireAuthentication;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        public readonly string? UnauthenticatedClientAction;

        [OutputConstructor]
        private GlobalValidationResponse(
            ImmutableArray<string> excludedPaths,

            string id,

            string? kind,

            string name,

            string? redirectToProvider,

            bool? requireAuthentication,

            Outputs.SystemDataResponse systemData,

            string type,

            string? unauthenticatedClientAction)
        {
            ExcludedPaths = excludedPaths;
            Id = id;
            Kind = kind;
            Name = name;
            RedirectToProvider = redirectToProvider;
            RequireAuthentication = requireAuthentication;
            SystemData = systemData;
            Type = type;
            UnauthenticatedClientAction = unauthenticatedClientAction;
        }
    }
}
