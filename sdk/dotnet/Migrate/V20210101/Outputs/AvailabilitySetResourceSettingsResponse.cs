// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.V20210101.Outputs
{

    [OutputType]
    public sealed class AvailabilitySetResourceSettingsResponse
    {
        /// <summary>
        /// Gets or sets the target fault domain.
        /// </summary>
        public readonly int? FaultDomain;
        /// <summary>
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// Expected value is 'Microsoft.Compute/availabilitySets'.
        /// </summary>
        public readonly string ResourceType;
        /// <summary>
        /// Gets or sets the target Resource name.
        /// </summary>
        public readonly string TargetResourceName;
        /// <summary>
        /// Gets or sets the target update domain.
        /// </summary>
        public readonly int? UpdateDomain;

        [OutputConstructor]
        private AvailabilitySetResourceSettingsResponse(
            int? faultDomain,

            string resourceType,

            string targetResourceName,

            int? updateDomain)
        {
            FaultDomain = faultDomain;
            ResourceType = resourceType;
            TargetResourceName = targetResourceName;
            UpdateDomain = updateDomain;
        }
    }
}
