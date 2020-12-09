// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901
{
    public static class ListSiteIdentifiersAssignedToHostName
    {
        public static Task<ListSiteIdentifiersAssignedToHostNameResult> InvokeAsync(ListSiteIdentifiersAssignedToHostNameArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListSiteIdentifiersAssignedToHostNameResult>("azure-nextgen:web/v20200901:listSiteIdentifiersAssignedToHostName", args ?? new ListSiteIdentifiersAssignedToHostNameArgs(), options.WithVersion());
    }


    public sealed class ListSiteIdentifiersAssignedToHostNameArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the object.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public ListSiteIdentifiersAssignedToHostNameArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListSiteIdentifiersAssignedToHostNameResult
    {
        /// <summary>
        /// Link to next page of resources.
        /// </summary>
        public readonly string NextLink;
        /// <summary>
        /// Collection of resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.IdentifierResponseResult> Value;

        [OutputConstructor]
        private ListSiteIdentifiersAssignedToHostNameResult(
            string nextLink,

            ImmutableArray<Outputs.IdentifierResponseResult> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
