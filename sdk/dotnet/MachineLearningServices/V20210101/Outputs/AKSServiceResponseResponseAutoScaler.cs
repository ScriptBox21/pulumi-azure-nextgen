// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20210101.Outputs
{

    [OutputType]
    public sealed class AKSServiceResponseResponseAutoScaler
    {
        /// <summary>
        /// Option to enable/disable auto scaling.
        /// </summary>
        public readonly bool? AutoscaleEnabled;
        /// <summary>
        /// The maximum number of replicas in the cluster.
        /// </summary>
        public readonly int? MaxReplicas;
        /// <summary>
        /// The minimum number of replicas to scale down to.
        /// </summary>
        public readonly int? MinReplicas;
        /// <summary>
        /// The amount of seconds to wait between auto scale updates.
        /// </summary>
        public readonly int? RefreshPeriodInSeconds;
        /// <summary>
        /// The target utilization percentage to use for determining whether to scale the cluster.
        /// </summary>
        public readonly int? TargetUtilization;

        [OutputConstructor]
        private AKSServiceResponseResponseAutoScaler(
            bool? autoscaleEnabled,

            int? maxReplicas,

            int? minReplicas,

            int? refreshPeriodInSeconds,

            int? targetUtilization)
        {
            AutoscaleEnabled = autoscaleEnabled;
            MaxReplicas = maxReplicas;
            MinReplicas = minReplicas;
            RefreshPeriodInSeconds = refreshPeriodInSeconds;
            TargetUtilization = targetUtilization;
        }
    }
}
