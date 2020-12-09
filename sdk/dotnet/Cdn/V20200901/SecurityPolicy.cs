// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901
{
    /// <summary>
    /// SecurityPolicy association for AzureFrontDoor profile
    /// </summary>
    public partial class SecurityPolicy : Pulumi.CustomResource
    {
        [Output("deploymentStatus")]
        public Output<string> DeploymentStatus { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// object which contains security policy parameters
        /// </summary>
        [Output("parameters")]
        public Output<Outputs.SecurityPolicyWebApplicationFirewallParametersResponse?> Parameters { get; private set; } = null!;

        /// <summary>
        /// Provisioning status
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Read only system data
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SecurityPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SecurityPolicy(string name, SecurityPolicyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/v20200901:SecurityPolicy", name, args ?? new SecurityPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SecurityPolicy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/v20200901:SecurityPolicy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/latest:SecurityPolicy"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SecurityPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SecurityPolicy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SecurityPolicy(name, id, options);
        }
    }

    public sealed class SecurityPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// object which contains security policy parameters
        /// </summary>
        [Input("parameters")]
        public Input<Inputs.SecurityPolicyWebApplicationFirewallParametersArgs>? Parameters { get; set; }

        /// <summary>
        /// Name of the CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the security policy under the profile.
        /// </summary>
        [Input("securityPolicyName", required: true)]
        public Input<string> SecurityPolicyName { get; set; } = null!;

        public SecurityPolicyArgs()
        {
        }
    }
}
