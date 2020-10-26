// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DBforMySQL.V20200701Preview.Inputs
{

    /// <summary>
    /// Delegated subnet arguments of a server
    /// </summary>
    public sealed class DelegatedSubnetArgumentsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// delegated subnet arm resource id.
        /// </summary>
        [Input("subnetArmResourceId")]
        public Input<string>? SubnetArmResourceId { get; set; }

        public DelegatedSubnetArgumentsArgs()
        {
        }
    }
}
