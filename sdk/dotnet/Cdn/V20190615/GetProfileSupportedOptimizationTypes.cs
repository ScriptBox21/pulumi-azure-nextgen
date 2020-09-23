// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20190615
{
    public static class GetProfileSupportedOptimizationTypes
    {
        public static Task<GetProfileSupportedOptimizationTypesResult> InvokeAsync(GetProfileSupportedOptimizationTypesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProfileSupportedOptimizationTypesResult>("azure-nextgen:cdn/v20190615:getProfileSupportedOptimizationTypes", args ?? new GetProfileSupportedOptimizationTypesArgs(), options.WithVersion());
    }


    public sealed class GetProfileSupportedOptimizationTypesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public string ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetProfileSupportedOptimizationTypesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProfileSupportedOptimizationTypesResult
    {
        /// <summary>
        /// Supported optimization types for a profile.
        /// </summary>
        public readonly ImmutableArray<string> SupportedOptimizationTypes;

        [OutputConstructor]
        private GetProfileSupportedOptimizationTypesResult(ImmutableArray<string> supportedOptimizationTypes)
        {
            SupportedOptimizationTypes = supportedOptimizationTypes;
        }
    }
}
