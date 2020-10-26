// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20200601Preview.Outputs
{

    [OutputType]
    public sealed class BackendProxyContractResponse
    {
        /// <summary>
        /// Password to connect to the WebProxy Server
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// WebProxy Server AbsoluteUri property which includes the entire URI stored in the Uri instance, including all fragments and query strings.
        /// </summary>
        public readonly string Url;
        /// <summary>
        /// Username to connect to the WebProxy server
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private BackendProxyContractResponse(
            string? password,

            string url,

            string? username)
        {
            Password = password;
            Url = url;
            Username = username;
        }
    }
}
