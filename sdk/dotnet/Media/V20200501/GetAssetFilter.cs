// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20200501
{
    public static class GetAssetFilter
    {
        public static Task<GetAssetFilterResult> InvokeAsync(GetAssetFilterArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAssetFilterResult>("azure-nextgen:media/v20200501:getAssetFilter", args ?? new GetAssetFilterArgs(), options.WithVersion());
    }


    public sealed class GetAssetFilterArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The Asset name.
        /// </summary>
        [Input("assetName", required: true)]
        public string AssetName { get; set; } = null!;

        /// <summary>
        /// The Asset Filter name
        /// </summary>
        [Input("filterName", required: true)]
        public string FilterName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAssetFilterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAssetFilterResult
    {
        /// <summary>
        /// The first quality.
        /// </summary>
        public readonly Outputs.FirstQualityResponse? FirstQuality;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The presentation time range.
        /// </summary>
        public readonly Outputs.PresentationTimeRangeResponse? PresentationTimeRange;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The tracks selection conditions.
        /// </summary>
        public readonly ImmutableArray<Outputs.FilterTrackSelectionResponse> Tracks;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetAssetFilterResult(
            Outputs.FirstQualityResponse? firstQuality,

            string id,

            string name,

            Outputs.PresentationTimeRangeResponse? presentationTimeRange,

            Outputs.SystemDataResponse systemData,

            ImmutableArray<Outputs.FilterTrackSelectionResponse> tracks,

            string type)
        {
            FirstQuality = firstQuality;
            Id = id;
            Name = name;
            PresentationTimeRange = presentationTimeRange;
            SystemData = systemData;
            Tracks = tracks;
            Type = type;
        }
    }
}
