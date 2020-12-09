// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901
{
    public static class ListWebAppFunctionSecrets
    {
        public static Task<ListWebAppFunctionSecretsResult> InvokeAsync(ListWebAppFunctionSecretsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppFunctionSecretsResult>("azure-nextgen:web/v20200901:listWebAppFunctionSecrets", args ?? new ListWebAppFunctionSecretsArgs(), options.WithVersion());
    }


    public sealed class ListWebAppFunctionSecretsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Function name.
        /// </summary>
        [Input("functionName", required: true)]
        public string FunctionName { get; set; } = null!;

        /// <summary>
        /// Site name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListWebAppFunctionSecretsArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppFunctionSecretsResult
    {
        /// <summary>
        /// Secret key.
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// Trigger URL.
        /// </summary>
        public readonly string? TriggerUrl;

        [OutputConstructor]
        private ListWebAppFunctionSecretsResult(
            string? key,

            string? triggerUrl)
        {
            Key = key;
            TriggerUrl = triggerUrl;
        }
    }
}
