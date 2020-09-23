// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Security.V20190101Preview
{
    public static class GetAssessment
    {
        public static Task<GetAssessmentResult> InvokeAsync(GetAssessmentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAssessmentResult>("azure-nextgen:security/v20190101preview:getAssessment", args ?? new GetAssessmentArgs(), options.WithVersion());
    }


    public sealed class GetAssessmentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Assessment Key - Unique key for the assessment type
        /// </summary>
        [Input("assessmentName", required: true)]
        public string AssessmentName { get; set; } = null!;

        /// <summary>
        /// OData expand. Optional.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The identifier of the resource.
        /// </summary>
        [Input("resourceId", required: true)]
        public string ResourceId { get; set; } = null!;

        public GetAssessmentArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAssessmentResult
    {
        /// <summary>
        /// Additional data regarding the assessment
        /// </summary>
        public readonly ImmutableDictionary<string, string>? AdditionalData;
        /// <summary>
        /// User friendly display name of the assessment
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Links relevant to the assessment
        /// </summary>
        public readonly Outputs.AssessmentLinksResponse Links;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Details of the resource that was assessed
        /// </summary>
        public readonly Union<Outputs.AzureResourceDetailsResponse, Outputs.OnPremiseResourceDetailsResponse> ResourceDetails;
        /// <summary>
        /// The result of the assessment
        /// </summary>
        public readonly Outputs.AssessmentStatusResponse Status;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetAssessmentResult(
            ImmutableDictionary<string, string>? additionalData,

            string displayName,

            Outputs.AssessmentLinksResponse links,

            string name,

            Union<Outputs.AzureResourceDetailsResponse, Outputs.OnPremiseResourceDetailsResponse> resourceDetails,

            Outputs.AssessmentStatusResponse status,

            string type)
        {
            AdditionalData = additionalData;
            DisplayName = displayName;
            Links = links;
            Name = name;
            ResourceDetails = resourceDetails;
            Status = status;
            Type = type;
        }
    }
}
