// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridNetwork.V20200101Preview.Outputs
{

    [OutputType]
    public sealed class VirtualNetworkFunctionTemplateResponse
    {
        /// <summary>
        /// An array of virtual network function role definitions.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualNetworkFunctionRoleConfigurationResponse> VirutalNetworkFunctionRoleConfigurations;

        [OutputConstructor]
        private VirtualNetworkFunctionTemplateResponse(ImmutableArray<Outputs.VirtualNetworkFunctionRoleConfigurationResponse> virutalNetworkFunctionRoleConfigurations)
        {
            VirutalNetworkFunctionRoleConfigurations = virutalNetworkFunctionRoleConfigurations;
        }
    }
}