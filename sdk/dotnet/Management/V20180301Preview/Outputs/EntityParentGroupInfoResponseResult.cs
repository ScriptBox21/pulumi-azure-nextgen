// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Management.V20180301Preview.Outputs
{

    [OutputType]
    public sealed class EntityParentGroupInfoResponseResult
    {
        /// <summary>
        /// The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000
        /// </summary>
        public readonly string? Id;

        [OutputConstructor]
        private EntityParentGroupInfoResponseResult(string? id)
        {
            Id = id;
        }
    }
}
