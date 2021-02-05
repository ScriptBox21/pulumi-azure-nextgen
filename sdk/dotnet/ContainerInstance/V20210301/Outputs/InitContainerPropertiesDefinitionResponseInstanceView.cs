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
    public sealed class InitContainerPropertiesDefinitionResponseInstanceView
    {
        /// <summary>
        /// The current state of the init container.
        /// </summary>
        public readonly Outputs.ContainerStateResponse CurrentState;
        /// <summary>
        /// The events of the init container.
        /// </summary>
        public readonly ImmutableArray<Outputs.EventResponse> Events;
        /// <summary>
        /// The previous state of the init container.
        /// </summary>
        public readonly Outputs.ContainerStateResponse PreviousState;
        /// <summary>
        /// The number of times that the init container has been restarted.
        /// </summary>
        public readonly int RestartCount;

        [OutputConstructor]
        private InitContainerPropertiesDefinitionResponseInstanceView(
            Outputs.ContainerStateResponse currentState,

            ImmutableArray<Outputs.EventResponse> events,

            Outputs.ContainerStateResponse previousState,

            int restartCount)
        {
            CurrentState = currentState;
            Events = events;
            PreviousState = previousState;
            RestartCount = restartCount;
        }
    }
}
