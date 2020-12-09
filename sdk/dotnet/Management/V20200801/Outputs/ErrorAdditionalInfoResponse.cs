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
    public sealed class ErrorAdditionalInfoResponse
    {
        /// <summary>
        /// The additional info.
        /// </summary>
        public readonly object Info;
        /// <summary>
        /// The additional info type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ErrorAdditionalInfoResponse(
            object info,

            string type)
        {
            Info = info;
            Type = type;
        }
    }
}
