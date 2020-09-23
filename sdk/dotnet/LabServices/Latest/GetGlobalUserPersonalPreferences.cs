// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.LabServices.Latest
{
    public static class GetGlobalUserPersonalPreferences
    {
        public static Task<GetGlobalUserPersonalPreferencesResult> InvokeAsync(GetGlobalUserPersonalPreferencesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetGlobalUserPersonalPreferencesResult>("azure-nextgen:labservices/latest:getGlobalUserPersonalPreferences", args ?? new GetGlobalUserPersonalPreferencesArgs(), options.WithVersion());
    }


    public sealed class GetGlobalUserPersonalPreferencesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Enum indicating if user is adding or removing a favorite lab
        /// </summary>
        [Input("addRemove")]
        public string? AddRemove { get; set; }

        /// <summary>
        /// Resource Id of the lab account
        /// </summary>
        [Input("labAccountResourceId")]
        public string? LabAccountResourceId { get; set; }

        /// <summary>
        /// Resource Id of the lab to add/remove from the favorites list
        /// </summary>
        [Input("labResourceId")]
        public string? LabResourceId { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Input("userName", required: true)]
        public string UserName { get; set; } = null!;

        public GetGlobalUserPersonalPreferencesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetGlobalUserPersonalPreferencesResult
    {
        /// <summary>
        /// Array of favorite lab resource ids
        /// </summary>
        public readonly ImmutableArray<string> FavoriteLabResourceIds;

        [OutputConstructor]
        private GetGlobalUserPersonalPreferencesResult(ImmutableArray<string> favoriteLabResourceIds)
        {
            FavoriteLabResourceIds = favoriteLabResourceIds;
        }
    }
}
