// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190501.Outputs
{

    [OutputType]
    public sealed class BackendPoolResponse
    {
        /// <summary>
        /// The set of backends for this pool
        /// </summary>
        public readonly ImmutableArray<Outputs.BackendResponse> Backends;
        /// <summary>
        /// L7 health probe settings for a backend pool
        /// </summary>
        public readonly Outputs.SubResourceResponse? HealthProbeSettings;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Load balancing settings for a backend pool
        /// </summary>
        public readonly Outputs.SubResourceResponse? LoadBalancingSettings;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Resource status.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private BackendPoolResponse(
            ImmutableArray<Outputs.BackendResponse> backends,

            Outputs.SubResourceResponse? healthProbeSettings,

            string? id,

            Outputs.SubResourceResponse? loadBalancingSettings,

            string? name,

            string resourceState,

            string type)
        {
            Backends = backends;
            HealthProbeSettings = healthProbeSettings;
            Id = id;
            LoadBalancingSettings = loadBalancingSettings;
            Name = name;
            ResourceState = resourceState;
            Type = type;
        }
    }
}
