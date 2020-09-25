// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.LabServices.Latest
{
    public static class GetGlobalUserOperationStatus
    {
        public static Task<GetGlobalUserOperationStatusResult> InvokeAsync(GetGlobalUserOperationStatusArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetGlobalUserOperationStatusResult>("azure-nextgen:labservices/latest:getGlobalUserOperationStatus", args ?? new GetGlobalUserOperationStatusArgs(), options.WithVersion());
    }


    public sealed class GetGlobalUserOperationStatusArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The operation url of long running operation
        /// </summary>
        [Input("operationUrl", required: true)]
        public string OperationUrl { get; set; } = null!;

        /// <summary>
        /// The name of the user.
        /// </summary>
        [Input("userName", required: true)]
        public string UserName { get; set; } = null!;

        public GetGlobalUserOperationStatusArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetGlobalUserOperationStatusResult
    {
        /// <summary>
        /// status of the long running operation for an environment
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetGlobalUserOperationStatusResult(string status)
        {
            Status = status;
        }
    }
}