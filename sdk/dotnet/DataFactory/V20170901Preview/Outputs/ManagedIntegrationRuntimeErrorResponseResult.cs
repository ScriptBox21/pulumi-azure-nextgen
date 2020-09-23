// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class ManagedIntegrationRuntimeErrorResponseResult
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public readonly string Code;
        /// <summary>
        /// Error message.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Managed integration runtime error parameters.
        /// </summary>
        public readonly ImmutableArray<string> Parameters;
        /// <summary>
        /// The time when the error occurred.
        /// </summary>
        public readonly string Time;

        [OutputConstructor]
        private ManagedIntegrationRuntimeErrorResponseResult(
            string code,

            string message,

            ImmutableArray<string> parameters,

            string time)
        {
            Code = code;
            Message = message;
            Parameters = parameters;
            Time = time;
        }
    }
}
