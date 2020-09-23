// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest
{
    public static class GetExposureControlFeatureValueByFactory
    {
        public static Task<GetExposureControlFeatureValueByFactoryResult> InvokeAsync(GetExposureControlFeatureValueByFactoryArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetExposureControlFeatureValueByFactoryResult>("azure-nextgen:datafactory/latest:getExposureControlFeatureValueByFactory", args ?? new GetExposureControlFeatureValueByFactoryArgs(), options.WithVersion());
    }


    public sealed class GetExposureControlFeatureValueByFactoryArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName", required: true)]
        public string FactoryName { get; set; } = null!;

        /// <summary>
        /// The feature name.
        /// </summary>
        [Input("featureName")]
        public string? FeatureName { get; set; }

        /// <summary>
        /// The feature type.
        /// </summary>
        [Input("featureType")]
        public string? FeatureType { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetExposureControlFeatureValueByFactoryArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetExposureControlFeatureValueByFactoryResult
    {
        /// <summary>
        /// The feature name.
        /// </summary>
        public readonly string FeatureName;
        /// <summary>
        /// The feature value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetExposureControlFeatureValueByFactoryResult(
            string featureName,

            string value)
        {
            FeatureName = featureName;
            Value = value;
        }
    }
}
