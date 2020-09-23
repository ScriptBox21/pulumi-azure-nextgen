// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20200501
{
    public static class GetContentKeyPolicyPropertiesWithSecrets
    {
        public static Task<GetContentKeyPolicyPropertiesWithSecretsResult> InvokeAsync(GetContentKeyPolicyPropertiesWithSecretsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetContentKeyPolicyPropertiesWithSecretsResult>("azure-nextgen:media/v20200501:getContentKeyPolicyPropertiesWithSecrets", args ?? new GetContentKeyPolicyPropertiesWithSecretsArgs(), options.WithVersion());
    }


    public sealed class GetContentKeyPolicyPropertiesWithSecretsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The Content Key Policy name.
        /// </summary>
        [Input("contentKeyPolicyName", required: true)]
        public string ContentKeyPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetContentKeyPolicyPropertiesWithSecretsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetContentKeyPolicyPropertiesWithSecretsResult
    {
        /// <summary>
        /// The creation date of the Policy
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// A description for the Policy.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The last modified date of the Policy
        /// </summary>
        public readonly string LastModified;
        /// <summary>
        /// The Key Policy options.
        /// </summary>
        public readonly ImmutableArray<Outputs.ContentKeyPolicyOptionResponse> Options;
        /// <summary>
        /// The legacy Policy ID.
        /// </summary>
        public readonly string PolicyId;

        [OutputConstructor]
        private GetContentKeyPolicyPropertiesWithSecretsResult(
            string created,

            string? description,

            string lastModified,

            ImmutableArray<Outputs.ContentKeyPolicyOptionResponse> options,

            string policyId)
        {
            Created = created;
            Description = description;
            LastModified = lastModified;
            Options = options;
            PolicyId = policyId;
        }
    }
}
