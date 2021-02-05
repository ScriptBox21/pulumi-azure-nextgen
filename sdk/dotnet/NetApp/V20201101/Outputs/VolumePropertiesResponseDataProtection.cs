// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20201101.Outputs
{

    [OutputType]
    public sealed class VolumePropertiesResponseDataProtection
    {
        /// <summary>
        /// Backup Properties
        /// </summary>
        public readonly Outputs.VolumeBackupPropertiesResponse? Backup;
        /// <summary>
        /// Replication properties
        /// </summary>
        public readonly Outputs.ReplicationObjectResponse? Replication;
        /// <summary>
        /// Snapshot properties.
        /// </summary>
        public readonly Outputs.VolumeSnapshotPropertiesResponse? Snapshot;

        [OutputConstructor]
        private VolumePropertiesResponseDataProtection(
            Outputs.VolumeBackupPropertiesResponse? backup,

            Outputs.ReplicationObjectResponse? replication,

            Outputs.VolumeSnapshotPropertiesResponse? snapshot)
        {
            Backup = backup;
            Replication = replication;
            Snapshot = snapshot;
        }
    }
}
