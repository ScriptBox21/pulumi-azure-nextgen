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
    /// The Azure mobile App push notification receiver.
    /// </summary>
    public sealed class AzureAppPushReceiverArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The email address registered for the Azure mobile app.
        /// </summary>
        [Input("emailAddress", required: true)]
        public Input<string> EmailAddress { get; set; } = null!;

        /// <summary>
        /// The name of the Azure mobile app push receiver. Names must be unique across all receivers within an action group.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public AzureAppPushReceiverArgs()
        {
        }
    }
}