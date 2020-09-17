// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.V20180901Preview.Outputs
{

    [OutputType]
    public sealed class SolutionPropertiesResponse
    {
        /// <summary>
        /// Gets or sets the cleanup state of the solution.
        /// </summary>
        public readonly string? CleanupState;
        /// <summary>
        /// Gets or sets the details of the solution.
        /// </summary>
        public readonly Outputs.SolutionDetailsResponse? Details;
        /// <summary>
        /// Gets or sets the goal of the solution.
        /// </summary>
        public readonly string? Goal;
        /// <summary>
        /// Gets or sets the purpose of the solution.
        /// </summary>
        public readonly string? Purpose;
        /// <summary>
        /// Gets or sets the current status of the solution.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// Gets or sets the summary of the solution.
        /// </summary>
        public readonly Union<Outputs.DatabasesSolutionSummaryResponse, Outputs.ServersSolutionSummaryResponse>? Summary;
        /// <summary>
        /// Gets or sets the tool being used in the solution.
        /// </summary>
        public readonly string? Tool;

        [OutputConstructor]
        private SolutionPropertiesResponse(
            string? cleanupState,

            Outputs.SolutionDetailsResponse? details,

            string? goal,

            string? purpose,

            string? status,

            Union<Outputs.DatabasesSolutionSummaryResponse, Outputs.ServersSolutionSummaryResponse>? summary,

            string? tool)
        {
            CleanupState = cleanupState;
            Details = details;
            Goal = goal;
            Purpose = purpose;
            Status = status;
            Summary = summary;
            Tool = tool;
        }
    }
}