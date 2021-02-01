// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class AzureActiveDirectoryResponse
    {
        public readonly bool? Enabled;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        public readonly bool? IsAutoProvisioned;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        public readonly Outputs.AzureActiveDirectoryLoginResponse? Login;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        public readonly Outputs.AzureActiveDirectoryRegistrationResponse? Registration;
        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        public readonly Outputs.AzureActiveDirectoryValidationResponse? Validation;

        [OutputConstructor]
        private AzureActiveDirectoryResponse(
            bool? enabled,

            string id,

            bool? isAutoProvisioned,

            string? kind,

            Outputs.AzureActiveDirectoryLoginResponse? login,

            string name,

            Outputs.AzureActiveDirectoryRegistrationResponse? registration,

            Outputs.SystemDataResponse systemData,

            string type,

            Outputs.AzureActiveDirectoryValidationResponse? validation)
        {
            Enabled = enabled;
            Id = id;
            IsAutoProvisioned = isAutoProvisioned;
            Kind = kind;
            Login = login;
            Name = name;
            Registration = registration;
            SystemData = systemData;
            Type = type;
            Validation = validation;
        }
    }
}
