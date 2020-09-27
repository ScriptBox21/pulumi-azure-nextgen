// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200601Preview.Outputs
{

    [OutputType]
    public sealed class SqlTriggerGetPropertiesResponseResource
    {
        /// <summary>
        /// Body of the Trigger
        /// </summary>
        public readonly string? Body;
        /// <summary>
        /// A system generated property representing the resource etag required for optimistic concurrency control.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Name of the Cosmos DB SQL trigger
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A system generated property. A unique identifier.
        /// </summary>
        public readonly string Rid;
        /// <summary>
        /// The operation the trigger is associated with
        /// </summary>
        public readonly string? TriggerOperation;
        /// <summary>
        /// Type of the Trigger
        /// </summary>
        public readonly string? TriggerType;

        [OutputConstructor]
        private SqlTriggerGetPropertiesResponseResource(
            string? body,

            string etag,

            string id,

            string rid,

            string? triggerOperation,

            string? triggerType)
        {
            Body = body;
            Etag = etag;
            Id = id;
            Rid = rid;
            TriggerOperation = triggerOperation;
            TriggerType = triggerType;
        }
    }
}
