// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20190101
{
    public static class GetApiManagementServiceSsoToken
    {
        public static Task<GetApiManagementServiceSsoTokenResult> InvokeAsync(GetApiManagementServiceSsoTokenArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApiManagementServiceSsoTokenResult>("azure-nextgen:apimanagement/v20190101:getApiManagementServiceSsoToken", args ?? new GetApiManagementServiceSsoTokenArgs(), options.WithVersion());
    }


    public sealed class GetApiManagementServiceSsoTokenArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetApiManagementServiceSsoTokenArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApiManagementServiceSsoTokenResult
    {
        /// <summary>
        /// Redirect URL to the Publisher Portal containing the SSO token.
        /// </summary>
        public readonly string? RedirectUri;

        [OutputConstructor]
        private GetApiManagementServiceSsoTokenResult(string? redirectUri)
        {
            RedirectUri = redirectUri;
        }
    }
}
