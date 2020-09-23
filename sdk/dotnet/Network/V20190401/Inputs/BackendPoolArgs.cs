// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190401.Inputs
{

    /// <summary>
    /// A backend pool is a collection of backends that can be routed to.
    /// </summary>
    public sealed class BackendPoolArgs : Pulumi.ResourceArgs
    {
        [Input("backends")]
        private InputList<Inputs.BackendArgs>? _backends;

        /// <summary>
        /// The set of backends for this pool
        /// </summary>
        public InputList<Inputs.BackendArgs> Backends
        {
            get => _backends ?? (_backends = new InputList<Inputs.BackendArgs>());
            set => _backends = value;
        }

        /// <summary>
        /// L7 health probe settings for a backend pool
        /// </summary>
        [Input("healthProbeSettings")]
        public Input<Inputs.SubResourceArgs>? HealthProbeSettings { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Load balancing settings for a backend pool
        /// </summary>
        [Input("loadBalancingSettings")]
        public Input<Inputs.SubResourceArgs>? LoadBalancingSettings { get; set; }

        /// <summary>
        /// Resource name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public BackendPoolArgs()
        {
        }
    }
}
