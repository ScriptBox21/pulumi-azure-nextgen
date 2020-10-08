// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200301.Inputs
{

    /// <summary>
    /// Replication properties
    /// </summary>
    public sealed class ReplicationObjectArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether the local volume is the source or destination for the Volume Replication
        /// </summary>
        [Input("endpointType")]
        public Input<string>? EndpointType { get; set; }

        /// <summary>
        /// The remote region for the other end of the Volume Replication.
        /// </summary>
        [Input("remoteVolumeRegion")]
        public Input<string>? RemoteVolumeRegion { get; set; }

        /// <summary>
        /// The resource ID of the remote volume.
        /// </summary>
        [Input("remoteVolumeResourceId", required: true)]
        public Input<string> RemoteVolumeResourceId { get; set; } = null!;

        /// <summary>
        /// Id
        /// </summary>
        [Input("replicationId")]
        public Input<string>? ReplicationId { get; set; }

        /// <summary>
        /// Schedule
        /// </summary>
        [Input("replicationSchedule", required: true)]
        public Input<string> ReplicationSchedule { get; set; } = null!;

        public ReplicationObjectArgs()
        {
        }
    }
}
