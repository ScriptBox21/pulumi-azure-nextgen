// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DomainRegistration.V20200901
{
    public static class ListDomainRecommendations
    {
        public static Task<ListDomainRecommendationsResult> InvokeAsync(ListDomainRecommendationsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListDomainRecommendationsResult>("azure-nextgen:domainregistration/v20200901:listDomainRecommendations", args ?? new ListDomainRecommendationsArgs(), options.WithVersion());
    }


    public sealed class ListDomainRecommendationsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Keywords to be used for generating domain recommendations.
        /// </summary>
        [Input("keywords")]
        public string? Keywords { get; set; }

        /// <summary>
        /// Maximum number of recommendations.
        /// </summary>
        [Input("maxDomainRecommendations")]
        public int? MaxDomainRecommendations { get; set; }

        public ListDomainRecommendationsArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListDomainRecommendationsResult
    {
        /// <summary>
        /// Link to next page of resources.
        /// </summary>
        public readonly string NextLink;
        /// <summary>
        /// Collection of resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.NameIdentifierResponseResult> Value;

        [OutputConstructor]
        private ListDomainRecommendationsResult(
            string nextLink,

            ImmutableArray<Outputs.NameIdentifierResponseResult> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
