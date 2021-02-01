// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20181101
{
    public static class ListWebAppConnectionStringsSlot
    {
        public static Task<ListWebAppConnectionStringsSlotResult> InvokeAsync(ListWebAppConnectionStringsSlotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppConnectionStringsSlotResult>("azure-nextgen:web/v20181101:listWebAppConnectionStringsSlot", args ?? new ListWebAppConnectionStringsSlotArgs(), options.WithVersion());
    }


    public sealed class ListWebAppConnectionStringsSlotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the deployment slot. If a slot is not specified, the API will get the connection settings for the production slot.
        /// </summary>
        [Input("slot", required: true)]
        public string Slot { get; set; } = null!;

        public ListWebAppConnectionStringsSlotArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppConnectionStringsSlotResult
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
        /// Connection strings.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ConnStringValueTypePairResponse> Properties;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListWebAppConnectionStringsSlotResult(
            string id,

            string? kind,

            string name,

            ImmutableDictionary<string, Outputs.ConnStringValueTypePairResponse> properties,

            string type)
        {
            Id = id;
            Kind = kind;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}
