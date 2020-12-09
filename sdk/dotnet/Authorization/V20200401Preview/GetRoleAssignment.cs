// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20200401Preview
{
    public static class GetRoleAssignment
    {
        public static Task<GetRoleAssignmentResult> InvokeAsync(GetRoleAssignmentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRoleAssignmentResult>("azure-nextgen:authorization/v20200401preview:getRoleAssignment", args ?? new GetRoleAssignmentArgs(), options.WithVersion());
    }


    public sealed class GetRoleAssignmentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the role assignment to get.
        /// </summary>
        [Input("roleAssignmentName", required: true)]
        public string RoleAssignmentName { get; set; } = null!;

        /// <summary>
        /// The scope of the role assignment.
        /// </summary>
        [Input("scope", required: true)]
        public string Scope { get; set; } = null!;

        public GetRoleAssignmentArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRoleAssignmentResult
    {
        /// <summary>
        /// The Delegation flag for the role assignment
        /// </summary>
        public readonly bool? CanDelegate;
        /// <summary>
        /// The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'
        /// </summary>
        public readonly string? Condition;
        /// <summary>
        /// Version of the condition. Currently accepted value is '2.0'
        /// </summary>
        public readonly string? ConditionVersion;
        /// <summary>
        /// Id of the user who created the assignment
        /// </summary>
        public readonly string? CreatedBy;
        /// <summary>
        /// Time it was created
        /// </summary>
        public readonly string? CreatedOn;
        /// <summary>
        /// Id of the delegated managed identity resource
        /// </summary>
        public readonly string? DelegatedManagedIdentityResourceId;
        /// <summary>
        /// Description of role assignment
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The role assignment name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The principal ID.
        /// </summary>
        public readonly string? PrincipalId;
        /// <summary>
        /// The principal type of the assigned principal ID.
        /// </summary>
        public readonly string? PrincipalType;
        /// <summary>
        /// The role definition ID.
        /// </summary>
        public readonly string? RoleDefinitionId;
        /// <summary>
        /// The role assignment scope.
        /// </summary>
        public readonly string? Scope;
        /// <summary>
        /// The role assignment type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Id of the user who updated the assignment
        /// </summary>
        public readonly string? UpdatedBy;
        /// <summary>
        /// Time it was updated
        /// </summary>
        public readonly string? UpdatedOn;

        [OutputConstructor]
        private GetRoleAssignmentResult(
            bool? canDelegate,

            string? condition,

            string? conditionVersion,

            string? createdBy,

            string? createdOn,

            string? delegatedManagedIdentityResourceId,

            string? description,

            string name,

            string? principalId,

            string? principalType,

            string? roleDefinitionId,

            string? scope,

            string type,

            string? updatedBy,

            string? updatedOn)
        {
            CanDelegate = canDelegate;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedBy = createdBy;
            CreatedOn = createdOn;
            DelegatedManagedIdentityResourceId = delegatedManagedIdentityResourceId;
            Description = description;
            Name = name;
            PrincipalId = principalId;
            PrincipalType = principalType;
            RoleDefinitionId = roleDefinitionId;
            Scope = scope;
            Type = type;
            UpdatedBy = updatedBy;
            UpdatedOn = updatedOn;
        }
    }
}
