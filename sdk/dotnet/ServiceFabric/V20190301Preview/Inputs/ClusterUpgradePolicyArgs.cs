// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.V20190301Preview.Inputs
{

    /// <summary>
    /// Describes the policy used when upgrading the cluster.
    /// </summary>
    public sealed class ClusterUpgradePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The cluster delta health policy used when upgrading the cluster.
        /// </summary>
        [Input("deltaHealthPolicy")]
        public Input<Inputs.ClusterUpgradeDeltaHealthPolicyArgs>? DeltaHealthPolicy { get; set; }

        /// <summary>
        /// If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data).
        /// </summary>
        [Input("forceRestart")]
        public Input<bool>? ForceRestart { get; set; }

        /// <summary>
        /// The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Input("healthCheckRetryTimeout", required: true)]
        public Input<string> HealthCheckRetryTimeout { get; set; } = null!;

        /// <summary>
        /// The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Input("healthCheckStableDuration", required: true)]
        public Input<string> HealthCheckStableDuration { get; set; } = null!;

        /// <summary>
        /// The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Input("healthCheckWaitDuration", required: true)]
        public Input<string> HealthCheckWaitDuration { get; set; } = null!;

        /// <summary>
        /// The cluster health policy used when upgrading the cluster.
        /// </summary>
        [Input("healthPolicy", required: true)]
        public Input<Inputs.ClusterHealthPolicyArgs> HealthPolicy { get; set; } = null!;

        /// <summary>
        /// The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Input("upgradeDomainTimeout", required: true)]
        public Input<string> UpgradeDomainTimeout { get; set; } = null!;

        /// <summary>
        /// The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Input("upgradeReplicaSetCheckTimeout", required: true)]
        public Input<string> UpgradeReplicaSetCheckTimeout { get; set; } = null!;

        /// <summary>
        /// The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format.
        /// </summary>
        [Input("upgradeTimeout", required: true)]
        public Input<string> UpgradeTimeout { get; set; } = null!;

        public ClusterUpgradePolicyArgs()
        {
        }
    }
}