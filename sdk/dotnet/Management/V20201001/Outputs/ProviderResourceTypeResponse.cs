// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Management.V20201001.Outputs
{

    [OutputType]
    public sealed class ProviderResourceTypeResponse
    {
        /// <summary>
        /// The aliases that are supported by this resource type.
        /// </summary>
        public readonly ImmutableArray<Outputs.AliasResponse> Aliases;
        /// <summary>
        /// The API profiles for the resource provider.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApiProfileResponse> ApiProfiles;
        /// <summary>
        /// The API version.
        /// </summary>
        public readonly ImmutableArray<string> ApiVersions;
        /// <summary>
        /// The additional capabilities offered by this resource type.
        /// </summary>
        public readonly string? Capabilities;
        /// <summary>
        /// The default API version.
        /// </summary>
        public readonly string DefaultApiVersion;
        /// <summary>
        /// The location mappings that are supported by this resource type.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProviderExtendedLocationResponse> LocationMappings;
        /// <summary>
        /// The collection of locations where this resource type can be created.
        /// </summary>
        public readonly ImmutableArray<string> Locations;
        /// <summary>
        /// The properties.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Properties;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string? ResourceType;

        [OutputConstructor]
        private ProviderResourceTypeResponse(
            ImmutableArray<Outputs.AliasResponse> aliases,

            ImmutableArray<Outputs.ApiProfileResponse> apiProfiles,

            ImmutableArray<string> apiVersions,

            string? capabilities,

            string defaultApiVersion,

            ImmutableArray<Outputs.ProviderExtendedLocationResponse> locationMappings,

            ImmutableArray<string> locations,

            ImmutableDictionary<string, string>? properties,

            string? resourceType)
        {
            Aliases = aliases;
            ApiProfiles = apiProfiles;
            ApiVersions = apiVersions;
            Capabilities = capabilities;
            DefaultApiVersion = defaultApiVersion;
            LocationMappings = locationMappings;
            Locations = locations;
            Properties = properties;
            ResourceType = resourceType;
        }
    }
}
