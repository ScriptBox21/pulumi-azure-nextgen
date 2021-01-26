// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20200901
{
    /// <summary>
    /// The policy definition.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:authorization/v20200901:PolicyDefinition")]
    public partial class PolicyDefinition : Pulumi.CustomResource
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
        /// The policy definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Output("metadata")]
        public Output<object?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        [Output("mode")]
        public Output<string?> Mode { get; private set; } = null!;

        /// <summary>
        /// The name of the policy definition.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, Outputs.ParameterDefinitionsValueResponse>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The policy rule.
        /// </summary>
        [Output("policyRule")]
        public Output<object?> PolicyRule { get; private set; } = null!;

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [Output("policyType")]
        public Output<string?> PolicyType { get; private set; } = null!;

        /// <summary>
        /// The type of the resource (Microsoft.Authorization/policyDefinitions).
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a PolicyDefinition resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PolicyDefinition(string name, PolicyDefinitionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:authorization/v20200901:PolicyDefinition", name, args ?? new PolicyDefinitionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PolicyDefinition(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:authorization/v20200901:PolicyDefinition", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/latest:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20151001preview:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20160401:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20161201:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20180301:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20180501:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20190101:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20190601:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20190901:PolicyDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20200301:PolicyDefinition"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PolicyDefinition resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PolicyDefinition Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PolicyDefinition(name, id, options);
        }
    }

    public sealed class PolicyDefinitionArgs : Pulumi.ResourceArgs
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
        /// The policy definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Input("metadata")]
        public Input<object>? Metadata { get; set; }

        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("parameters")]
        private InputMap<Inputs.ParameterDefinitionsValueArgs>? _parameters;

        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        public InputMap<Inputs.ParameterDefinitionsValueArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterDefinitionsValueArgs>());
            set => _parameters = value;
        }

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
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [Input("policyType")]
        public InputUnion<string, Pulumi.AzureNextGen.Authorization.V20200901.PolicyType>? PolicyType { get; set; }

        public PolicyDefinitionArgs()
        {
            Mode = "Indexed";
        }
    }
}
