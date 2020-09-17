// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20190801.Outputs
{

    [OutputType]
    public sealed class VirtualDirectoryResponse
    {
        /// <summary>
        /// Physical path.
        /// </summary>
        public readonly string? PhysicalPath;
        /// <summary>
        /// Path to virtual application.
        /// </summary>
        public readonly string? VirtualPath;

        [OutputConstructor]
        private VirtualDirectoryResponse(
            string? physicalPath,

            string? virtualPath)
        {
            PhysicalPath = physicalPath;
            VirtualPath = virtualPath;
        }
    }
}