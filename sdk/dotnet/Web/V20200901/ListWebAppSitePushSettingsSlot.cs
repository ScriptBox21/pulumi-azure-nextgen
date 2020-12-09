// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901
{
    public static class ListWebAppSitePushSettingsSlot
    {
        public static Task<ListWebAppSitePushSettingsSlotResult> InvokeAsync(ListWebAppSitePushSettingsSlotArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppSitePushSettingsSlotResult>("azure-nextgen:web/v20200901:listWebAppSitePushSettingsSlot", args ?? new ListWebAppSitePushSettingsSlotArgs(), options.WithVersion());
    }


    public sealed class ListWebAppSitePushSettingsSlotArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of web app.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of web app slot. If not specified then will default to production slot.
        /// </summary>
        [Input("slot", required: true)]
        public string Slot { get; set; } = null!;

        public ListWebAppSitePushSettingsSlotArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppSitePushSettingsSlotResult
    {
        /// <summary>
        /// Gets or sets a JSON string containing a list of dynamic tags that will be evaluated from user claims in the push registration endpoint.
        /// </summary>
        public readonly string? DynamicTagsJson;
        /// <summary>
        /// Gets or sets a flag indicating whether the Push endpoint is enabled.
        /// </summary>
        public readonly bool IsPushEnabled;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that are whitelisted for use by the push registration endpoint.
        /// </summary>
        public readonly string? TagWhitelistJson;
        /// <summary>
        /// Gets or sets a JSON string containing a list of tags that require user authentication to be used in the push registration endpoint.
        /// Tags can consist of alphanumeric characters and the following:
        /// '_', '@', '#', '.', ':', '-'. 
        /// Validation should be performed at the PushRequestHandler.
        /// </summary>
        public readonly string? TagsRequiringAuth;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListWebAppSitePushSettingsSlotResult(
            string? dynamicTagsJson,

            bool isPushEnabled,

            string? kind,

            string name,

            Outputs.SystemDataResponse systemData,

            string? tagWhitelistJson,

            string? tagsRequiringAuth,

            string type)
        {
            DynamicTagsJson = dynamicTagsJson;
            IsPushEnabled = isPushEnabled;
            Kind = kind;
            Name = name;
            SystemData = systemData;
            TagWhitelistJson = tagWhitelistJson;
            TagsRequiringAuth = tagsRequiringAuth;
            Type = type;
        }
    }
}
