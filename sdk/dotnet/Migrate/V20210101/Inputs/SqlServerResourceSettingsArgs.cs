// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.V20210101.Inputs
{

    /// <summary>
    /// Defines the SQL Server resource settings.
    /// </summary>
    public sealed class SqlServerResourceSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource type. For example, the value can be Microsoft.Compute/virtualMachines.
        /// Expected value is 'Microsoft.Sql/servers'.
        /// </summary>
        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        /// <summary>
        /// Gets or sets the target Resource name.
        /// </summary>
        [Input("targetResourceName", required: true)]
        public Input<string> TargetResourceName { get; set; } = null!;

        public SqlServerResourceSettingsArgs()
        {
        }
    }
}
