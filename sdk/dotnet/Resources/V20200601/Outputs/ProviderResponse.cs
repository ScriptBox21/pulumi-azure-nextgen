// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20200601.Outputs
{

    [OutputType]
    public sealed class ProviderResponse
    {
        /// <summary>
        /// The provider ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The namespace of the resource provider.
        /// </summary>
        public readonly string? Namespace;
        /// <summary>
        /// The registration policy of the resource provider.
        /// </summary>
        public readonly string RegistrationPolicy;
        /// <summary>
        /// The registration state of the resource provider.
        /// </summary>
        public readonly string RegistrationState;
        /// <summary>
        /// The collection of provider resource types.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProviderResourceTypeResponse> ResourceTypes;

        [OutputConstructor]
        private ProviderResponse(
            string id,

            string? @namespace,

            string registrationPolicy,

            string registrationState,

            ImmutableArray<Outputs.ProviderResourceTypeResponse> resourceTypes)
        {
            Id = id;
            Namespace = @namespace;
            RegistrationPolicy = registrationPolicy;
            RegistrationState = registrationState;
            ResourceTypes = resourceTypes;
        }
    }
}