// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20200801
{
    public static class GetDeploymentAtSubscriptionScope
    {
        public static Task<GetDeploymentAtSubscriptionScopeResult> InvokeAsync(GetDeploymentAtSubscriptionScopeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDeploymentAtSubscriptionScopeResult>("azure-nextgen:resources/v20200801:getDeploymentAtSubscriptionScope", args ?? new GetDeploymentAtSubscriptionScopeArgs(), options.WithVersion());
    }


    public sealed class GetDeploymentAtSubscriptionScopeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [Input("deploymentName", required: true)]
        public string DeploymentName { get; set; } = null!;

        public GetDeploymentAtSubscriptionScopeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDeploymentAtSubscriptionScopeResult
    {
        /// <summary>
        /// the location of the deployment.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Deployment properties.
        /// </summary>
        public readonly Outputs.DeploymentPropertiesExtendedResponse Properties;
        /// <summary>
        /// Deployment tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the deployment.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDeploymentAtSubscriptionScopeResult(
            string? location,

            string name,

            Outputs.DeploymentPropertiesExtendedResponse properties,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Location = location;
            Name = name;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
