// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200501Preview.Outputs
{

    [OutputType]
    public sealed class LinkedInfoResponse
    {
        /// <summary>
        /// LinkedId id.
        /// </summary>
        public readonly string? LinkedId;
        /// <summary>
        /// Linked resource name.
        /// </summary>
        public readonly string? LinkedResourceName;
        /// <summary>
        /// Datastore origin
        /// </summary>
        public readonly string? Origin;

        [OutputConstructor]
        private LinkedInfoResponse(
            string? linkedId,

            string? linkedResourceName,

            string? origin)
        {
            LinkedId = linkedId;
            LinkedResourceName = linkedResourceName;
            Origin = origin;
        }
    }
}
