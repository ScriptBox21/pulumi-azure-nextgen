// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20191001.Outputs
{

    [OutputType]
    public sealed class ErrorAdditionalInfoResponse
    {
        /// <summary>
        /// The additional info.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Info;
        /// <summary>
        /// The additional info type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ErrorAdditionalInfoResponse(
            ImmutableDictionary<string, object> info,

            string type)
        {
            Info = info;
            Type = type;
        }
    }
}