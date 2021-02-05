// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20210301.Outputs
{

    [OutputType]
    public sealed class ResourceRequirementsResponse
    {
        /// <summary>
        /// The resource limits of this container instance.
        /// </summary>
        public readonly Outputs.ResourceLimitsResponse? Limits;
        /// <summary>
        /// The resource requests of this container instance.
        /// </summary>
        public readonly Outputs.ResourceRequestsResponse Requests;

        [OutputConstructor]
        private ResourceRequirementsResponse(
            Outputs.ResourceLimitsResponse? limits,

            Outputs.ResourceRequestsResponse requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
