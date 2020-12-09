// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest
{
    public static class ListStaticSiteFunctionAppSettings
    {
        public static Task<ListStaticSiteFunctionAppSettingsResult> InvokeAsync(ListStaticSiteFunctionAppSettingsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListStaticSiteFunctionAppSettingsResult>("azure-nextgen:web/latest:listStaticSiteFunctionAppSettings", args ?? new ListStaticSiteFunctionAppSettingsArgs(), options.WithVersion());
    }


    public sealed class ListStaticSiteFunctionAppSettingsArgs : Pulumi.InvokeArgs
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

        public ListStaticSiteFunctionAppSettingsArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListStaticSiteFunctionAppSettingsResult
    {
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
        private ListStaticSiteFunctionAppSettingsResult(
            string? kind,

            string name,

            ImmutableDictionary<string, string> properties,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Kind = kind;
            Name = name;
            Properties = properties;
            SystemData = systemData;
            Type = type;
        }
    }
}
