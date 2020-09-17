// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20190301.Inputs
{

    /// <summary>
    /// An azure function receiver.
    /// </summary>
    public sealed class AzureFunctionReceiverArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The azure resource id of the function app.
        /// </summary>
        [Input("functionAppResourceId", required: true)]
        public Input<string> FunctionAppResourceId { get; set; } = null!;

        /// <summary>
        /// The function name in the function app.
        /// </summary>
        [Input("functionName", required: true)]
        public Input<string> FunctionName { get; set; } = null!;

        /// <summary>
        /// The http trigger url where http request sent to.
        /// </summary>
        [Input("httpTriggerUrl", required: true)]
        public Input<string> HttpTriggerUrl { get; set; } = null!;

        /// <summary>
        /// The name of the azure function receiver. Names must be unique across all receivers within an action group.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Indicates whether to use common alert schema.
        /// </summary>
        [Input("useCommonAlertSchema", required: true)]
        public Input<bool> UseCommonAlertSchema { get; set; } = null!;

        public AzureFunctionReceiverArgs()
        {
        }
    }
}