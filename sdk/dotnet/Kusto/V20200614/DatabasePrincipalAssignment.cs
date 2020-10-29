// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Kusto.V20200614
{
    /// <summary>
    /// Class representing a database principal assignment.
    /// </summary>
    public partial class DatabasePrincipalAssignment : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
        /// </summary>
        [Output("principalId")]
        public Output<string> PrincipalId { get; private set; } = null!;

        /// <summary>
        /// The principal name
        /// </summary>
        [Output("principalName")]
        public Output<string> PrincipalName { get; private set; } = null!;

        /// <summary>
        /// Principal type.
        /// </summary>
        [Output("principalType")]
        public Output<string> PrincipalType { get; private set; } = null!;

        /// <summary>
        /// The provisioned state of the resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Database principal role.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// The tenant id of the principal
        /// </summary>
        [Output("tenantId")]
        public Output<string?> TenantId { get; private set; } = null!;

        /// <summary>
        /// The tenant name of the principal
        /// </summary>
        [Output("tenantName")]
        public Output<string> TenantName { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DatabasePrincipalAssignment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DatabasePrincipalAssignment(string name, DatabasePrincipalAssignmentArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:kusto/v20200614:DatabasePrincipalAssignment", name, args ?? new DatabasePrincipalAssignmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DatabasePrincipalAssignment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:kusto/v20200614:DatabasePrincipalAssignment", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/latest:DatabasePrincipalAssignment"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20191109:DatabasePrincipalAssignment"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20200215:DatabasePrincipalAssignment"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20200918:DatabasePrincipalAssignment"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DatabasePrincipalAssignment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DatabasePrincipalAssignment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DatabasePrincipalAssignment(name, id, options);
        }
    }

    public sealed class DatabasePrincipalAssignmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Kusto cluster.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the database in the Kusto cluster.
        /// </summary>
        [Input("databaseName", required: true)]
        public Input<string> DatabaseName { get; set; } = null!;

        /// <summary>
        /// The name of the Kusto principalAssignment.
        /// </summary>
        [Input("principalAssignmentName", required: true)]
        public Input<string> PrincipalAssignmentName { get; set; } = null!;

        /// <summary>
        /// The principal ID assigned to the database principal. It can be a user email, application ID, or security group name.
        /// </summary>
        [Input("principalId", required: true)]
        public Input<string> PrincipalId { get; set; } = null!;

        /// <summary>
        /// Principal type.
        /// </summary>
        [Input("principalType", required: true)]
        public Input<string> PrincipalType { get; set; } = null!;

        /// <summary>
        /// The name of the resource group containing the Kusto cluster.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Database principal role.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The tenant id of the principal
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public DatabasePrincipalAssignmentArgs()
        {
        }
    }
}
