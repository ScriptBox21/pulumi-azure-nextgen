// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20170515Preview.Outputs
{

    [OutputType]
    public sealed class ErrorResponseResponse
    {
        /// <summary>
        /// Error code
        /// </summary>
        public readonly string? Code;
        /// <summary>
        /// Error message indicating why the operation failed.
        /// </summary>
        public readonly string? Message;

        [OutputConstructor]
        private ErrorResponseResponse(
            string? code,

            string? message)
        {
            Code = code;
            Message = message;
        }
    }
}