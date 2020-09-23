// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest
{
    public static class GetFactoryDataPlaneAccess
    {
        public static Task<GetFactoryDataPlaneAccessResult> InvokeAsync(GetFactoryDataPlaneAccessArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFactoryDataPlaneAccessResult>("azure-nextgen:datafactory/latest:getFactoryDataPlaneAccess", args ?? new GetFactoryDataPlaneAccessArgs(), options.WithVersion());
    }


    public sealed class GetFactoryDataPlaneAccessArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The resource path to get access relative to factory. Currently only empty string is supported which corresponds to the factory resource.
        /// </summary>
        [Input("accessResourcePath")]
        public string? AccessResourcePath { get; set; }

        /// <summary>
        /// Expiration time for the token. Maximum duration for the token is eight hours and by default the token will expire in eight hours.
        /// </summary>
        [Input("expireTime")]
        public string? ExpireTime { get; set; }

        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName", required: true)]
        public string FactoryName { get; set; } = null!;

        /// <summary>
        /// The string with permissions for Data Plane access. Currently only 'r' is supported which grants read only access.
        /// </summary>
        [Input("permissions")]
        public string? Permissions { get; set; }

        /// <summary>
        /// The name of the profile. Currently only the default is supported. The default value is DefaultProfile.
        /// </summary>
        [Input("profileName")]
        public string? ProfileName { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Start time for the token. If not specified the current time will be used.
        /// </summary>
        [Input("startTime")]
        public string? StartTime { get; set; }

        public GetFactoryDataPlaneAccessArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFactoryDataPlaneAccessResult
    {
        /// <summary>
        /// Data Plane read only access token.
        /// </summary>
        public readonly string? AccessToken;
        /// <summary>
        /// Data Plane service base URL.
        /// </summary>
        public readonly string? DataPlaneUrl;
        /// <summary>
        /// The user access policy.
        /// </summary>
        public readonly Outputs.UserAccessPolicyResponseResult? Policy;

        [OutputConstructor]
        private GetFactoryDataPlaneAccessResult(
            string? accessToken,

            string? dataPlaneUrl,

            Outputs.UserAccessPolicyResponseResult? policy)
        {
            AccessToken = accessToken;
            DataPlaneUrl = dataPlaneUrl;
            Policy = policy;
        }
    }
}
