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
    public sealed class BackendCredentialsContractResponse
    {
        /// <summary>
        /// Authorization header authentication
        /// </summary>
        public readonly Outputs.BackendAuthorizationHeaderCredentialsResponse? Authorization;
        /// <summary>
        /// List of Client Certificate Thumbprint.
        /// </summary>
        public readonly ImmutableArray<string> Certificate;
        /// <summary>
        /// Header Parameter description.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<string>>? Header;
        /// <summary>
        /// Query Parameter description.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<string>>? Query;

        [OutputConstructor]
        private BackendCredentialsContractResponse(
            Outputs.BackendAuthorizationHeaderCredentialsResponse? authorization,

            ImmutableArray<string> certificate,

            ImmutableDictionary<string, ImmutableArray<string>>? header,

            ImmutableDictionary<string, ImmutableArray<string>>? query)
        {
            Authorization = authorization;
            Certificate = certificate;
            Header = header;
            Query = query;
        }
    }
}
