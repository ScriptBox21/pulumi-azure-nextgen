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
    public sealed class NetworkSecurityGroupResourceSettingsResponse
    {
        /// <summary>
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// Expected value is 'Microsoft.Network/networkSecurityGroups'.
        /// </summary>
        public readonly string ResourceType;
        /// <summary>
        /// Gets or sets Security rules of network security group.
        /// </summary>
        public readonly ImmutableArray<Outputs.NsgSecurityRuleResponse> SecurityRules;
        /// <summary>
        /// Gets or sets the target Resource name.
        /// </summary>
        public readonly string TargetResourceName;

        [OutputConstructor]
        private NetworkSecurityGroupResourceSettingsResponse(
            string resourceType,

            ImmutableArray<Outputs.NsgSecurityRuleResponse> securityRules,

            string targetResourceName)
        {
            ResourceType = resourceType;
            SecurityRules = securityRules;
            TargetResourceName = targetResourceName;
        }
    }
}
