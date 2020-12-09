// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Management.V20180301
{
    /// <summary>
    /// The policy definition.
    /// </summary>
    public partial class PolicyDefinitionAtManagementGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The policy definition description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The display name of the policy definition.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The policy definition metadata.
        /// </summary>
        [Output("metadata")]
        public Output<object?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The policy definition mode. Possible values are NotSpecified, Indexed, and All.
        /// </summary>
        [Output("mode")]
        public Output<string?> Mode { get; private set; } = null!;

        /// <summary>
        /// The name of the policy definition.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Required if a parameter is used in policy rule.
        /// </summary>
        [Output("parameters")]
        public Output<object?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The policy rule.
        /// </summary>
        [Output("policyRule")]
        public Output<object?> PolicyRule { get; private set; } = null!;

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        /// </summary>
        [Output("policyType")]
        public Output<string?> PolicyType { get; private set; } = null!;

        /// <summary>
        /// The type of the resource (Microsoft.Authorization/policyDefinitions).
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a PolicyDefinitionAtManagementGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PolicyDefinitionAtManagementGroup(string name, PolicyDefinitionAtManagementGroupArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:management/v20180301:PolicyDefinitionAtManagementGroup", name, args ?? new PolicyDefinitionAtManagementGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PolicyDefinitionAtManagementGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:management/v20180301:PolicyDefinitionAtManagementGroup", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:management/latest:PolicyDefinitionAtManagementGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:management/v20161201:PolicyDefinitionAtManagementGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:management/v20180501:PolicyDefinitionAtManagementGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:management/v20190101:PolicyDefinitionAtManagementGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:management/v20190601:PolicyDefinitionAtManagementGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:management/v20190901:PolicyDefinitionAtManagementGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:management/v20200301:PolicyDefinitionAtManagementGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:management/v20200901:PolicyDefinitionAtManagementGroup"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PolicyDefinitionAtManagementGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PolicyDefinitionAtManagementGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PolicyDefinitionAtManagementGroup(name, id, options);
        }
    }

    public sealed class PolicyDefinitionAtManagementGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy definition description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of the policy definition.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The ID of the management group.
        /// </summary>
        [Input("managementGroupId", required: true)]
        public Input<string> ManagementGroupId { get; set; } = null!;

        /// <summary>
        /// The policy definition metadata.
        /// </summary>
        [Input("metadata")]
        public Input<object>? Metadata { get; set; }

        /// <summary>
        /// The policy definition mode. Possible values are NotSpecified, Indexed, and All.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// Required if a parameter is used in policy rule.
        /// </summary>
        [Input("parameters")]
        public Input<object>? Parameters { get; set; }

        /// <summary>
        /// The name of the policy definition to create.
        /// </summary>
        [Input("policyDefinitionName", required: true)]
        public Input<string> PolicyDefinitionName { get; set; } = null!;

        /// <summary>
        /// The policy rule.
        /// </summary>
        [Input("policyRule")]
        public Input<object>? PolicyRule { get; set; }

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        /// </summary>
        [Input("policyType")]
        public Input<string>? PolicyType { get; set; }

        public PolicyDefinitionAtManagementGroupArgs()
        {
        }
    }
}
