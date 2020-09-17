// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataLakeAnalytics.V20161101.Outputs
{

    [OutputType]
    public sealed class ComputePolicyResponse
    {
        /// <summary>
        /// The resource identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The maximum degree of parallelism per job this user can use to submit jobs.
        /// </summary>
        public readonly int MaxDegreeOfParallelismPerJob;
        /// <summary>
        /// The minimum priority per job this user can use to submit jobs.
        /// </summary>
        public readonly int MinPriorityPerJob;
        /// <summary>
        /// The resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The AAD object identifier for the entity to create a policy for.
        /// </summary>
        public readonly string ObjectId;
        /// <summary>
        /// The type of AAD object the object identifier refers to.
        /// </summary>
        public readonly string ObjectType;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ComputePolicyResponse(
            string id,

            int maxDegreeOfParallelismPerJob,

            int minPriorityPerJob,

            string name,

            string objectId,

            string objectType,

            string type)
        {
            Id = id;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            Name = name;
            ObjectId = objectId;
            ObjectType = objectType;
            Type = type;
        }
    }
}