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
    public sealed class UrlRedirectActionResponse
    {
        /// <summary>
        /// The name of the action for the delivery rule.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Defines the parameters for the action.
        /// </summary>
        public readonly Outputs.UrlRedirectActionParametersResponse Parameters;

        [OutputConstructor]
        private UrlRedirectActionResponse(
            string name,

            Outputs.UrlRedirectActionParametersResponse parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }
}
