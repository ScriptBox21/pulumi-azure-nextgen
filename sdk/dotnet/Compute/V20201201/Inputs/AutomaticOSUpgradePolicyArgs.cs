// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201201.Inputs
{

    /// <summary>
    /// The configuration parameters used for performing automatic OS upgrade.
    /// </summary>
    public sealed class AutomaticOSUpgradePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether OS image rollback feature should be disabled. Default value is false.
        /// </summary>
        [Input("disableAutomaticRollback")]
        public Input<bool>? DisableAutomaticRollback { get; set; }

        /// <summary>
        /// Indicates whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the OS image becomes available. Default value is false. &lt;br&gt;&lt;br&gt; If this is set to true for Windows based scale sets, [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet) is automatically set to false and cannot be set to true.
        /// </summary>
        [Input("enableAutomaticOSUpgrade")]
        public Input<bool>? EnableAutomaticOSUpgrade { get; set; }

        public AutomaticOSUpgradePolicyArgs()
        {
        }
    }
}
