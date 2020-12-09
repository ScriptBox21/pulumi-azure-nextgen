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
    public sealed class HttpErrorRangeParametersResponse
    {
        /// <summary>
        /// The inclusive start of the http status code range.
        /// </summary>
        public readonly int? Begin;
        /// <summary>
        /// The inclusive end of the http status code range.
        /// </summary>
        public readonly int? End;

        [OutputConstructor]
        private HttpErrorRangeParametersResponse(
            int? begin,

            int? end)
        {
            Begin = begin;
            End = end;
        }
    }
}
