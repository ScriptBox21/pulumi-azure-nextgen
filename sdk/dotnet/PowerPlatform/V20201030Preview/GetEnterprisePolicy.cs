// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.PowerPlatform.V20201030Preview
{
    public static class GetEnterprisePolicy
    {
        public static Task<GetEnterprisePolicyResult> InvokeAsync(GetEnterprisePolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetEnterprisePolicyResult>("azure-nextgen:powerplatform/v20201030preview:getEnterprisePolicy", args ?? new GetEnterprisePolicyArgs(), options.WithVersion());
    }


    public sealed class GetEnterprisePolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The EnterprisePolicy name.
        /// </summary>
        [Input("enterprisePolicyName", required: true)]
        public string EnterprisePolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetEnterprisePolicyArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetEnterprisePolicyResult
    {
        /// <summary>
        /// The encryption settings for a configuration store.
        /// </summary>
        public readonly Outputs.PropertiesResponseEncryption? Encryption;
        /// <summary>
        /// The identity of the EnterprisePolicy.
        /// </summary>
        public readonly Outputs.EnterprisePolicyIdentityResponse? Identity;
        /// <summary>
        /// Region where the EnterprisePolicy is located.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Settings concerning lockbox.
        /// </summary>
        public readonly Outputs.PropertiesResponseLockbox? Lockbox;
        /// <summary>
        /// Name of the EnterprisePolicy.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetEnterprisePolicyResult(
            Outputs.PropertiesResponseEncryption? encryption,

            Outputs.EnterprisePolicyIdentityResponse? identity,

            string location,

            Outputs.PropertiesResponseLockbox? lockbox,

            string name,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Encryption = encryption;
            Identity = identity;
            Location = location;
            Lockbox = lockbox;
            Name = name;
            SystemData = systemData;
            Tags = tags;
            Type = type;
        }
    }
}