// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.TimeSeriesInsights.V20171115.Outputs
{

    [OutputType]
    public sealed class IngressEnvironmentStatusResponse
    {
        /// <summary>
        /// This string represents the state of ingress operations on an environment. It can be "Disabled", "Ready", "Running", "Paused" or "Unknown"
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// An object that contains the details about an environment's state.
        /// </summary>
        public readonly Outputs.EnvironmentStateDetailsResponse StateDetails;

        [OutputConstructor]
        private IngressEnvironmentStatusResponse(
            string? state,

            Outputs.EnvironmentStateDetailsResponse stateDetails)
        {
            State = state;
            StateDetails = stateDetails;
        }
    }
}
