// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class SelfHostedIntegrationRuntimeStatusResponseResult
    {
        /// <summary>
        /// Whether Self-hosted integration runtime auto update has been turned on.
        /// </summary>
        public readonly string AutoUpdate;
        /// <summary>
        /// Object with additional information about integration runtime capabilities.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Capabilities;
        /// <summary>
        /// The time at which the integration runtime was created, in ISO8601 format.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// The data factory name which the integration runtime belong to.
        /// </summary>
        public readonly string DataFactoryName;
        /// <summary>
        /// It is used to set the encryption mode for node-node communication channel (when more than 2 self-hosted integration runtime nodes exist).
        /// </summary>
        public readonly string InternalChannelEncryption;
        /// <summary>
        /// The list of linked integration runtimes that are created to share with this integration runtime.
        /// </summary>
        public readonly ImmutableArray<Outputs.LinkedIntegrationRuntimeResponseResult> Links;
        /// <summary>
        /// The local time zone offset in hours.
        /// </summary>
        public readonly string LocalTimeZoneOffset;
        /// <summary>
        /// The list of nodes for this integration runtime.
        /// </summary>
        public readonly ImmutableArray<Outputs.SelfHostedIntegrationRuntimeNodeResponseResult> Nodes;
        /// <summary>
        /// The date at which the integration runtime will be scheduled to update, in ISO8601 format.
        /// </summary>
        public readonly string ScheduledUpdateDate;
        /// <summary>
        /// The URLs for the services used in integration runtime backend service.
        /// </summary>
        public readonly ImmutableArray<string> ServiceUrls;
        /// <summary>
        /// The state of integration runtime.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The task queue id of the integration runtime.
        /// </summary>
        public readonly string TaskQueueId;
        /// <summary>
        /// Type of integration runtime.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// The time in the date scheduled by service to update the integration runtime, e.g., PT03H is 3 hours
        /// </summary>
        public readonly string UpdateDelayOffset;
        /// <summary>
        /// Version of the integration runtime.
        /// </summary>
        public readonly string Version;
        /// <summary>
        /// Status of the integration runtime version.
        /// </summary>
        public readonly string VersionStatus;

        [OutputConstructor]
        private SelfHostedIntegrationRuntimeStatusResponseResult(
            string autoUpdate,

            ImmutableDictionary<string, string> capabilities,

            string createTime,

            string dataFactoryName,

            string internalChannelEncryption,

            ImmutableArray<Outputs.LinkedIntegrationRuntimeResponseResult> links,

            string localTimeZoneOffset,

            ImmutableArray<Outputs.SelfHostedIntegrationRuntimeNodeResponseResult> nodes,

            string scheduledUpdateDate,

            ImmutableArray<string> serviceUrls,

            string state,

            string taskQueueId,

            string? type,

            string updateDelayOffset,

            string version,

            string versionStatus)
        {
            AutoUpdate = autoUpdate;
            Capabilities = capabilities;
            CreateTime = createTime;
            DataFactoryName = dataFactoryName;
            InternalChannelEncryption = internalChannelEncryption;
            Links = links;
            LocalTimeZoneOffset = localTimeZoneOffset;
            Nodes = nodes;
            ScheduledUpdateDate = scheduledUpdateDate;
            ServiceUrls = serviceUrls;
            State = state;
            TaskQueueId = taskQueueId;
            Type = type;
            UpdateDelayOffset = updateDelayOffset;
            Version = version;
            VersionStatus = versionStatus;
        }
    }
}
