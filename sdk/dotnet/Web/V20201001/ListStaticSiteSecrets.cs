// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20201001
{
    public static class ListStaticSiteSecrets
    {
        public static Task<ListStaticSiteSecretsResult> InvokeAsync(ListStaticSiteSecretsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListStaticSiteSecretsResult>("azure-nextgen:web/v20201001:listStaticSiteSecrets", args ?? new ListStaticSiteSecretsArgs(), options.WithVersion());
    }


    public sealed class ListStaticSiteSecretsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the static site.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListStaticSiteSecretsArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListStaticSiteSecretsResult
    {
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Settings.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Properties;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListStaticSiteSecretsResult(
            string id,

            string? kind,

            string name,

            ImmutableDictionary<string, string> properties,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Id = id;
            Kind = kind;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Type = type;
        }
    }
}
