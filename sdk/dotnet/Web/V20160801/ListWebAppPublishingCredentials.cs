// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20160801
{
    public static class ListWebAppPublishingCredentials
    {
        public static Task<ListWebAppPublishingCredentialsResult> InvokeAsync(ListWebAppPublishingCredentialsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListWebAppPublishingCredentialsResult>("azure-nextgen:web/v20160801:listWebAppPublishingCredentials", args ?? new ListWebAppPublishingCredentialsArgs(), options.WithVersion());
    }


    public sealed class ListWebAppPublishingCredentialsArgs : Pulumi.InvokeArgs
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

        public ListWebAppPublishingCredentialsArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListWebAppPublishingCredentialsResult
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
        /// Password used for publishing.
        /// </summary>
        public readonly string? PublishingPassword;
        /// <summary>
        /// Password hash used for publishing.
        /// </summary>
        public readonly string? PublishingPasswordHash;
        /// <summary>
        /// Password hash salt used for publishing.
        /// </summary>
        public readonly string? PublishingPasswordHashSalt;
        /// <summary>
        /// Username used for publishing.
        /// </summary>
        public readonly string PublishingUserName;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Username
        /// </summary>
        public readonly string? UserName;

        [OutputConstructor]
        private ListWebAppPublishingCredentialsResult(
            string? kind,

            string name,

            string? publishingPassword,

            string? publishingPasswordHash,

            string? publishingPasswordHashSalt,

            string publishingUserName,

            string type,

            string? userName)
        {
            Kind = kind;
            Name = name;
            PublishingPassword = publishingPassword;
            PublishingPasswordHash = publishingPasswordHash;
            PublishingPasswordHashSalt = publishingPasswordHashSalt;
            PublishingUserName = publishingUserName;
            Type = type;
            UserName = userName;
        }
    }
}