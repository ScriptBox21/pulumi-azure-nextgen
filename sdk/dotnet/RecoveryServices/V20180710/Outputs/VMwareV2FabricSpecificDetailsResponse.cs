// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20180710.Outputs
{

    [OutputType]
    public sealed class VMwareV2FabricSpecificDetailsResponse
    {
        /// <summary>
        /// Gets the class type. Overridden in derived classes.
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// The Migration solution ARM Id.
        /// </summary>
        public readonly string MigrationSolutionId;
        /// <summary>
        /// The service endpoint.
        /// </summary>
        public readonly string ServiceEndpoint;
        /// <summary>
        /// The service resource Id.
        /// </summary>
        public readonly string ServiceResourceId;
        /// <summary>
        /// The ARM Id of the VMware site.
        /// </summary>
        public readonly string VmwareSiteId;

        [OutputConstructor]
        private VMwareV2FabricSpecificDetailsResponse(
            string instanceType,

            string migrationSolutionId,

            string serviceEndpoint,

            string serviceResourceId,

            string vmwareSiteId)
        {
            InstanceType = instanceType;
            MigrationSolutionId = migrationSolutionId;
            ServiceEndpoint = serviceEndpoint;
            ServiceResourceId = serviceResourceId;
            VmwareSiteId = vmwareSiteId;
        }
    }
}