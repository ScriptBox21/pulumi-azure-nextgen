// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DBforPostgreSQL.V20200214Preview.Outputs
{

    [OutputType]
    public sealed class ServerPropertiesResponseDelegatedSubnetArguments
    {
        /// <summary>
        /// delegated subnet arm resource id.
        /// </summary>
        public readonly string? SubnetArmResourceId;

        [OutputConstructor]
        private ServerPropertiesResponseDelegatedSubnetArguments(string? subnetArmResourceId)
        {
            SubnetArmResourceId = subnetArmResourceId;
        }
    }
}
