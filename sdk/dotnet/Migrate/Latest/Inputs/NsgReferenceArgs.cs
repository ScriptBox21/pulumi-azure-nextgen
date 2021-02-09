// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.Latest.Inputs
{

    /// <summary>
    /// Defines reference to NSG.
    /// </summary>
    public sealed class NsgReferenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets the ARM resource ID of the tracked resource being referenced.
        /// </summary>
        [Input("sourceArmResourceId", required: true)]
        public Input<string> SourceArmResourceId { get; set; } = null!;

        public NsgReferenceArgs()
        {
        }
    }
}
