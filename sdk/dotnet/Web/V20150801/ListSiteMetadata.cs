// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801
{
    public static class ListSiteMetadata
    {
        public static Task<ListSiteMetadataResult> InvokeAsync(ListSiteMetadataArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListSiteMetadataResult>("azure-nextgen:web/v20150801:listSiteMetadata", args ?? new ListSiteMetadataArgs(), options.WithVersion());
    }


    public sealed class ListSiteMetadataArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of web app
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListSiteMetadataArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListSiteMetadataResult
    {
        /// <summary>
        /// Kind of resource
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource Name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ListSiteMetadataResult(
            string? kind,

            string location,

            string? name,

            ImmutableDictionary<string, string>? tags,

            string? type)
        {
            Kind = kind;
            Location = location;
            Name = name;
            Tags = tags;
            Type = type;
        }
    }
}