// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Management.V20200801.Outputs
{

    [OutputType]
    public sealed class ApiProfileResponse
    {
        /// <summary>
        /// The API version.
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// The profile version.
        /// </summary>
        public readonly string ProfileVersion;

        [OutputConstructor]
        private ApiProfileResponse(
            string apiVersion,

            string profileVersion)
        {
            ApiVersion = apiVersion;
            ProfileVersion = profileVersion;
        }
    }
}
