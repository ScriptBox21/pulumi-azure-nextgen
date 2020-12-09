// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901.Outputs
{

    [OutputType]
    public sealed class UrlRedirectActionParametersResponse
    {
        /// <summary>
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// </summary>
        public readonly string? CustomFragment;
        /// <summary>
        /// Host to redirect. Leave empty to use the incoming host as the destination host.
        /// </summary>
        public readonly string? CustomHostname;
        /// <summary>
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination path.
        /// </summary>
        public readonly string? CustomPath;
        /// <summary>
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string; leave empty to preserve the incoming query string. Query string must be in &lt;key&gt;=&lt;value&gt; format. ? and &amp; will be added automatically so do not include them.
        /// </summary>
        public readonly string? CustomQueryString;
        /// <summary>
        /// Protocol to use for the redirect. The default value is MatchRequest
        /// </summary>
        public readonly string? DestinationProtocol;
        public readonly string OdataType;
        /// <summary>
        /// The redirect type the rule will use when redirecting traffic.
        /// </summary>
        public readonly string RedirectType;

        [OutputConstructor]
        private UrlRedirectActionParametersResponse(
            string? customFragment,

            string? customHostname,

            string? customPath,

            string? customQueryString,

            string? destinationProtocol,

            string odataType,

            string redirectType)
        {
            CustomFragment = customFragment;
            CustomHostname = customHostname;
            CustomPath = customPath;
            CustomQueryString = customQueryString;
            DestinationProtocol = destinationProtocol;
            OdataType = odataType;
            RedirectType = redirectType;
        }
    }
}
