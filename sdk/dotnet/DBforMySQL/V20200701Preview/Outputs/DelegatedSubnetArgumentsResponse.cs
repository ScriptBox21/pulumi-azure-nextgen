// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DBforMySQL.V20200701Preview.Outputs
{

    [OutputType]
    public sealed class DelegatedSubnetArgumentsResponse
    {
        /// <summary>
        /// delegated subnet arm resource id.
        /// </summary>
        public readonly string? SubnetArmResourceId;

        [OutputConstructor]
        private DelegatedSubnetArgumentsResponse(string? subnetArmResourceId)
        {
            SubnetArmResourceId = subnetArmResourceId;
        }
    }
}
