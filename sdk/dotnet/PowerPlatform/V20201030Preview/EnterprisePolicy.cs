// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.PowerPlatform.V20201030Preview
{
    /// <summary>
    /// Definition of the EnterprisePolicy.
    /// </summary>
    public partial class EnterprisePolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// The encryption settings for a configuration store.
        /// </summary>
        [Output("encryption")]
        public Output<Outputs.PropertiesResponseEncryption?> Encryption { get; private set; } = null!;

        /// <summary>
        /// The identity of the EnterprisePolicy.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.EnterprisePolicyIdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// Region where the EnterprisePolicy is located.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Settings concerning lockbox.
        /// </summary>
        [Output("lockbox")]
        public Output<Outputs.PropertiesResponseLockbox?> Lockbox { get; private set; } = null!;

        /// <summary>
        /// Name of the EnterprisePolicy.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a EnterprisePolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EnterprisePolicy(string name, EnterprisePolicyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:powerplatform/v20201030preview:EnterprisePolicy", name, args ?? new EnterprisePolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EnterprisePolicy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:powerplatform/v20201030preview:EnterprisePolicy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing EnterprisePolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EnterprisePolicy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new EnterprisePolicy(name, id, options);
        }
    }

    public sealed class EnterprisePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The encryption settings for a configuration store.
        /// </summary>
        [Input("encryption")]
        public Input<Inputs.PropertiesEncryptionArgs>? Encryption { get; set; }

        /// <summary>
        /// Name of the EnterprisePolicy.
        /// </summary>
        [Input("enterprisePolicyName", required: true)]
        public Input<string> EnterprisePolicyName { get; set; } = null!;

        /// <summary>
        /// The identity of the EnterprisePolicy.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.EnterprisePolicyIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The Azure Region where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public EnterprisePolicyArgs()
        {
        }
    }
}
