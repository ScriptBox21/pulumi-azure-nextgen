// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200801.Inputs
{

    public sealed class SharedPrivateLinkResourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The private link resource group id.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// Unique name of the private link.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The resource id that private link links to.
        /// </summary>
        [Input("privateLinkResourceId")]
        public Input<string>? PrivateLinkResourceId { get; set; }

        /// <summary>
        /// Request message.
        /// </summary>
        [Input("requestMessage")]
        public Input<string>? RequestMessage { get; set; }

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public SharedPrivateLinkResourceArgs()
        {
        }
    }
}
