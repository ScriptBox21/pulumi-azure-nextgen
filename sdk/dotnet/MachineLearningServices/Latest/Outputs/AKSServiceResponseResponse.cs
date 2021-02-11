// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.Latest.Outputs
{

    [OutputType]
    public sealed class AKSServiceResponseResponse
    {
        /// <summary>
        /// Whether or not AAD authentication is enabled.
        /// </summary>
        public readonly bool? AadAuthEnabled;
        /// <summary>
        /// Whether or not Application Insights is enabled.
        /// </summary>
        public readonly bool? AppInsightsEnabled;
        /// <summary>
        /// Whether or not authentication is enabled.
        /// </summary>
        public readonly bool? AuthEnabled;
        /// <summary>
        /// The auto scaler properties.
        /// </summary>
        public readonly Outputs.AKSServiceResponseResponseAutoScaler? AutoScaler;
        /// <summary>
        /// The name of the compute resource.
        /// </summary>
        public readonly string? ComputeName;
        /// <summary>
        /// The compute environment type for the service.
        /// Expected value is 'Custom'.
        /// </summary>
        public readonly string ComputeType;
        /// <summary>
        /// The container resource requirements.
        /// </summary>
        public readonly Outputs.ContainerResourceRequirementsResponse? ContainerResourceRequirements;
        /// <summary>
        /// Details of the data collection options specified.
        /// </summary>
        public readonly Outputs.AKSServiceResponseResponseDataCollection? DataCollection;
        /// <summary>
        /// The deployment status.
        /// </summary>
        public readonly Outputs.AKSServiceResponseResponseDeploymentStatus DeploymentStatus;
        /// <summary>
        /// The deployment type for the service.
        /// </summary>
        public readonly string? DeploymentType;
        /// <summary>
        /// The service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The Environment, models and assets used for inferencing.
        /// </summary>
        public readonly Outputs.AKSServiceResponseResponseEnvironmentImageRequest? EnvironmentImageRequest;
        /// <summary>
        /// The error details.
        /// </summary>
        public readonly Outputs.ServiceResponseBaseResponseError Error;
        /// <summary>
        /// Is this the default variant.
        /// </summary>
        public readonly bool? IsDefault;
        /// <summary>
        /// The service tag dictionary. Tags are mutable.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? KvTags;
        /// <summary>
        /// The liveness probe requirements.
        /// </summary>
        public readonly Outputs.AKSServiceResponseResponseLivenessProbeRequirements? LivenessProbeRequirements;
        /// <summary>
        /// The maximum number of concurrent requests per container.
        /// </summary>
        public readonly int? MaxConcurrentRequestsPerContainer;
        /// <summary>
        /// Maximum time a request will wait in the queue (in milliseconds). After this time, the service will return 503 (Service Unavailable)
        /// </summary>
        public readonly int? MaxQueueWaitMs;
        /// <summary>
        /// Details on the models and configurations.
        /// </summary>
        public readonly ImmutableDictionary<string, object> ModelConfigMap;
        /// <summary>
        /// The list of models.
        /// </summary>
        public readonly ImmutableArray<Outputs.ModelResponse> Models;
        /// <summary>
        /// The Kubernetes namespace of the deployment.
        /// </summary>
        public readonly string? Namespace;
        /// <summary>
        /// The number of replicas on the cluster.
        /// </summary>
        public readonly int? NumReplicas;
        /// <summary>
        /// The service property dictionary. Properties are immutable.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Properties;
        /// <summary>
        /// The scoring timeout in milliseconds.
        /// </summary>
        public readonly int? ScoringTimeoutMs;
        /// <summary>
        /// The Uri for sending scoring requests.
        /// </summary>
        public readonly string ScoringUri;
        /// <summary>
        /// The current state of the service.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The Uri for sending swagger requests.
        /// </summary>
        public readonly string SwaggerUri;
        /// <summary>
        /// The amount of traffic variant receives.
        /// </summary>
        public readonly double? TrafficPercentile;
        /// <summary>
        /// The type of the variant.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private AKSServiceResponseResponse(
            bool? aadAuthEnabled,

            bool? appInsightsEnabled,

            bool? authEnabled,

            Outputs.AKSServiceResponseResponseAutoScaler? autoScaler,

            string? computeName,

            string computeType,

            Outputs.ContainerResourceRequirementsResponse? containerResourceRequirements,

            Outputs.AKSServiceResponseResponseDataCollection? dataCollection,

            Outputs.AKSServiceResponseResponseDeploymentStatus deploymentStatus,

            string? deploymentType,

            string? description,

            Outputs.AKSServiceResponseResponseEnvironmentImageRequest? environmentImageRequest,

            Outputs.ServiceResponseBaseResponseError error,

            bool? isDefault,

            ImmutableDictionary<string, string>? kvTags,

            Outputs.AKSServiceResponseResponseLivenessProbeRequirements? livenessProbeRequirements,

            int? maxConcurrentRequestsPerContainer,

            int? maxQueueWaitMs,

            ImmutableDictionary<string, object> modelConfigMap,

            ImmutableArray<Outputs.ModelResponse> models,

            string? @namespace,

            int? numReplicas,

            ImmutableDictionary<string, string>? properties,

            int? scoringTimeoutMs,

            string scoringUri,

            string state,

            string swaggerUri,

            double? trafficPercentile,

            string? type)
        {
            AadAuthEnabled = aadAuthEnabled;
            AppInsightsEnabled = appInsightsEnabled;
            AuthEnabled = authEnabled;
            AutoScaler = autoScaler;
            ComputeName = computeName;
            ComputeType = computeType;
            ContainerResourceRequirements = containerResourceRequirements;
            DataCollection = dataCollection;
            DeploymentStatus = deploymentStatus;
            DeploymentType = deploymentType;
            Description = description;
            EnvironmentImageRequest = environmentImageRequest;
            Error = error;
            IsDefault = isDefault;
            KvTags = kvTags;
            LivenessProbeRequirements = livenessProbeRequirements;
            MaxConcurrentRequestsPerContainer = maxConcurrentRequestsPerContainer;
            MaxQueueWaitMs = maxQueueWaitMs;
            ModelConfigMap = modelConfigMap;
            Models = models;
            Namespace = @namespace;
            NumReplicas = numReplicas;
            Properties = properties;
            ScoringTimeoutMs = scoringTimeoutMs;
            ScoringUri = scoringUri;
            State = state;
            SwaggerUri = swaggerUri;
            TrafficPercentile = trafficPercentile;
            Type = type;
        }
    }
}
