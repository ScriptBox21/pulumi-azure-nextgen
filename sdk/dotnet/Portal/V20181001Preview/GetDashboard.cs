// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Portal.V20181001Preview
{
    public static class GetDashboard
    {
        public static Task<GetDashboardResult> InvokeAsync(GetDashboardArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDashboardResult>("azure-nextgen:portal/v20181001preview:getDashboard", args ?? new GetDashboardArgs(), options.WithVersion());
    }


    public sealed class GetDashboardArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the dashboard.
        /// </summary>
        [Input("dashboardName", required: true)]
        public string DashboardName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDashboardArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDashboardResult
    {
        /// <summary>
        /// The dashboard lenses.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.DashboardLensResponse>? Lenses;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The dashboard metadata.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableDictionary<string, object>>? Metadata;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetDashboardResult(
            ImmutableDictionary<string, Outputs.DashboardLensResponse>? lenses,

            string location,

            ImmutableDictionary<string, ImmutableDictionary<string, object>>? metadata,

            string name,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Lenses = lenses;
            Location = location;
            Metadata = metadata;
            Name = name;
            Tags = tags;
            Type = type;
        }
    }
}