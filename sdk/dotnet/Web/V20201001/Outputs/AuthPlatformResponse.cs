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
    public sealed class AuthPlatformResponse
    {
        public readonly string? ConfigFilePath;
        public readonly bool? Enabled;
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
        public readonly string? RuntimeVersion;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AuthPlatformResponse(
            string? configFilePath,

            bool? enabled,

            string id,

            string? kind,

            string name,

            string? runtimeVersion,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            ConfigFilePath = configFilePath;
            Enabled = enabled;
            Id = id;
            Kind = kind;
            Name = name;
            RuntimeVersion = runtimeVersion;
            SystemData = systemData;
            Type = type;
        }
    }
}
