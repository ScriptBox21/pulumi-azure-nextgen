// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Datadog.V20200201Preview.Outputs
{

    [OutputType]
    public sealed class DatadogHostMetadataResponseResult
    {
        /// <summary>
        /// The agent version.
        /// </summary>
        public readonly string? AgentVersion;
        public readonly Outputs.DatadogInstallMethodResponseResult? InstallMethod;
        public readonly Outputs.DatadogLogsAgentResponseResult? LogsAgent;

        [OutputConstructor]
        private DatadogHostMetadataResponseResult(
            string? agentVersion,

            Outputs.DatadogInstallMethodResponseResult? installMethod,

            Outputs.DatadogLogsAgentResponseResult? logsAgent)
        {
            AgentVersion = agentVersion;
            InstallMethod = installMethod;
            LogsAgent = logsAgent;
        }
    }
}
