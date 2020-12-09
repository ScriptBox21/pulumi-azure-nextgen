// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.V20191001Preview.Outputs
{

    [OutputType]
    public sealed class MoveResourcePropertiesResponse
    {
        /// <summary>
        /// Gets or sets the move resource dependencies.
        /// </summary>
        public readonly ImmutableArray<Outputs.MoveResourceDependencyResponse> DependsOn;
        /// <summary>
        /// Gets or sets the move resource dependencies overrides.
        /// </summary>
        public readonly ImmutableArray<Outputs.MoveResourceDependencyOverrideResponse> DependsOnOverrides;
        /// <summary>
        /// Defines the move resource errors.
        /// </summary>
        public readonly Outputs.MoveResourcePropertiesResponseErrors Errors;
        /// <summary>
        /// Gets or sets the existing target ARM Id of the resource.
        /// </summary>
        public readonly string? ExistingTargetId;
        /// <summary>
        /// Gets a value indicating whether the resolve action is required over the move collection.
        /// </summary>
        public readonly bool IsResolveRequired;
        /// <summary>
        /// Defines the move resource status.
        /// </summary>
        public readonly Outputs.MoveResourcePropertiesResponseMoveStatus MoveStatus;
        /// <summary>
        /// Defines the provisioning states.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Gets or sets the resource settings.
        /// </summary>
        public readonly Union<Outputs.AvailabilitySetResourceSettingsResponse, Union<Outputs.LoadBalancerResourceSettingsResponse, Union<Outputs.NetworkInterfaceResourceSettingsResponse, Union<Outputs.NetworkSecurityGroupResourceSettingsResponse, Union<Outputs.PublicIPAddressResourceSettingsResponse, Union<Outputs.ResourceGroupResourceSettingsResponse, Union<Outputs.SqlDatabaseResourceSettingsResponse, Union<Outputs.SqlElasticPoolResourceSettingsResponse, Union<Outputs.SqlServerResourceSettingsResponse, Union<Outputs.VirtualMachineResourceSettingsResponse, Outputs.VirtualNetworkResourceSettingsResponse>>>>>>>>>>? ResourceSettings;
        /// <summary>
        /// Gets or sets the Source ARM Id of the resource.
        /// </summary>
        public readonly string SourceId;
        /// <summary>
        /// Gets or sets the source resource settings.
        /// </summary>
        public readonly Union<Outputs.AvailabilitySetResourceSettingsResponse, Union<Outputs.LoadBalancerResourceSettingsResponse, Union<Outputs.NetworkInterfaceResourceSettingsResponse, Union<Outputs.NetworkSecurityGroupResourceSettingsResponse, Union<Outputs.PublicIPAddressResourceSettingsResponse, Union<Outputs.ResourceGroupResourceSettingsResponse, Union<Outputs.SqlDatabaseResourceSettingsResponse, Union<Outputs.SqlElasticPoolResourceSettingsResponse, Union<Outputs.SqlServerResourceSettingsResponse, Union<Outputs.VirtualMachineResourceSettingsResponse, Outputs.VirtualNetworkResourceSettingsResponse>>>>>>>>>> SourceResourceSettings;
        /// <summary>
        /// Gets or sets the Target ARM Id of the resource.
        /// </summary>
        public readonly string TargetId;

        [OutputConstructor]
        private MoveResourcePropertiesResponse(
            ImmutableArray<Outputs.MoveResourceDependencyResponse> dependsOn,

            ImmutableArray<Outputs.MoveResourceDependencyOverrideResponse> dependsOnOverrides,

            Outputs.MoveResourcePropertiesResponseErrors errors,

            string? existingTargetId,

            bool isResolveRequired,

            Outputs.MoveResourcePropertiesResponseMoveStatus moveStatus,

            string provisioningState,

            Union<Outputs.AvailabilitySetResourceSettingsResponse, Union<Outputs.LoadBalancerResourceSettingsResponse, Union<Outputs.NetworkInterfaceResourceSettingsResponse, Union<Outputs.NetworkSecurityGroupResourceSettingsResponse, Union<Outputs.PublicIPAddressResourceSettingsResponse, Union<Outputs.ResourceGroupResourceSettingsResponse, Union<Outputs.SqlDatabaseResourceSettingsResponse, Union<Outputs.SqlElasticPoolResourceSettingsResponse, Union<Outputs.SqlServerResourceSettingsResponse, Union<Outputs.VirtualMachineResourceSettingsResponse, Outputs.VirtualNetworkResourceSettingsResponse>>>>>>>>>>? resourceSettings,

            string sourceId,

            Union<Outputs.AvailabilitySetResourceSettingsResponse, Union<Outputs.LoadBalancerResourceSettingsResponse, Union<Outputs.NetworkInterfaceResourceSettingsResponse, Union<Outputs.NetworkSecurityGroupResourceSettingsResponse, Union<Outputs.PublicIPAddressResourceSettingsResponse, Union<Outputs.ResourceGroupResourceSettingsResponse, Union<Outputs.SqlDatabaseResourceSettingsResponse, Union<Outputs.SqlElasticPoolResourceSettingsResponse, Union<Outputs.SqlServerResourceSettingsResponse, Union<Outputs.VirtualMachineResourceSettingsResponse, Outputs.VirtualNetworkResourceSettingsResponse>>>>>>>>>> sourceResourceSettings,

            string targetId)
        {
            DependsOn = dependsOn;
            DependsOnOverrides = dependsOnOverrides;
            Errors = errors;
            ExistingTargetId = existingTargetId;
            IsResolveRequired = isResolveRequired;
            MoveStatus = moveStatus;
            ProvisioningState = provisioningState;
            ResourceSettings = resourceSettings;
            SourceId = sourceId;
            SourceResourceSettings = sourceResourceSettings;
            TargetId = targetId;
        }
    }
}
