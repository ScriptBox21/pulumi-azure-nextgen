// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AlertsManagement.V20190505Preview.Outputs
{

    [OutputType]
    public sealed class DiagnosticsResponse
    {
        /// <summary>
        /// conditions on which alerts will be filtered
        /// </summary>
        public readonly Outputs.ConditionsResponse? Conditions;
        /// <summary>
        /// Creation time of action rule. Date-Time in ISO-8601 format.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Created by user name.
        /// </summary>
        public readonly string CreatedBy;
        /// <summary>
        /// Description of action rule
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Last updated time of action rule. Date-Time in ISO-8601 format.
        /// </summary>
        public readonly string LastModifiedAt;
        /// <summary>
        /// Last modified by user name.
        /// </summary>
        public readonly string LastModifiedBy;
        /// <summary>
        /// scope on which action rule will apply
        /// </summary>
        public readonly Outputs.ScopeResponse? Scope;
        /// <summary>
        /// Indicates if the given action rule is enabled or disabled
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// Indicates type of action rule
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DiagnosticsResponse(
            Outputs.ConditionsResponse? conditions,

            string createdAt,

            string createdBy,

            string? description,

            string lastModifiedAt,

            string lastModifiedBy,

            Outputs.ScopeResponse? scope,

            string? status,

            string type)
        {
            Conditions = conditions;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            Description = description;
            LastModifiedAt = lastModifiedAt;
            LastModifiedBy = lastModifiedBy;
            Scope = scope;
            Status = status;
            Type = type;
        }
    }
}