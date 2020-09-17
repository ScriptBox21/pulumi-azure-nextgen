// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20151101Preview
{
    public static class GetContainerService
    {
        public static Task<GetContainerServiceResult> InvokeAsync(GetContainerServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetContainerServiceResult>("azure-nextgen:containerservice/v20151101preview:getContainerService", args ?? new GetContainerServiceArgs(), options.WithVersion());
    }


    public sealed class GetContainerServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the container service within the given subscription and resource group.
        /// </summary>
        [Input("containerServiceName", required: true)]
        public string ContainerServiceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetContainerServiceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetContainerServiceResult
    {
        /// <summary>
        /// Properties of agent pools
        /// </summary>
        public readonly ImmutableArray<Outputs.ContainerServiceAgentPoolProfileResponse> AgentPoolProfiles;
        /// <summary>
        /// Properties for Diagnostic Agent
        /// </summary>
        public readonly Outputs.ContainerServiceDiagnosticsProfileResponse? DiagnosticsProfile;
        /// <summary>
        /// Properties for Linux VMs
        /// </summary>
        public readonly Outputs.ContainerServiceLinuxProfileResponse LinuxProfile;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Properties of master agents
        /// </summary>
        public readonly Outputs.ContainerServiceMasterProfileResponse MasterProfile;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Properties of orchestrator
        /// </summary>
        public readonly Outputs.ContainerServiceOrchestratorProfileResponse? OrchestratorProfile;
        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Properties of Windows VMs
        /// </summary>
        public readonly Outputs.ContainerServiceWindowsProfileResponse? WindowsProfile;

        [OutputConstructor]
        private GetContainerServiceResult(
            ImmutableArray<Outputs.ContainerServiceAgentPoolProfileResponse> agentPoolProfiles,

            Outputs.ContainerServiceDiagnosticsProfileResponse? diagnosticsProfile,

            Outputs.ContainerServiceLinuxProfileResponse linuxProfile,

            string location,

            Outputs.ContainerServiceMasterProfileResponse masterProfile,

            string name,

            Outputs.ContainerServiceOrchestratorProfileResponse? orchestratorProfile,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.ContainerServiceWindowsProfileResponse? windowsProfile)
        {
            AgentPoolProfiles = agentPoolProfiles;
            DiagnosticsProfile = diagnosticsProfile;
            LinuxProfile = linuxProfile;
            Location = location;
            MasterProfile = masterProfile;
            Name = name;
            OrchestratorProfile = orchestratorProfile;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            WindowsProfile = windowsProfile;
        }
    }
}