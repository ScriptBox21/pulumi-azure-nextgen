// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ManagedIdentity.V20150831Preview
{
    /// <summary>
    /// Describes an identity resource.
    /// </summary>
    public partial class UserAssignedIdentity : Pulumi.CustomResource
    {
        /// <summary>
        /// The id of the app associated with the identity. This is a random generated UUID by MSI.
        /// </summary>
        [Output("clientId")]
        public Output<string> ClientId { get; private set; } = null!;

        /// <summary>
        ///  The ManagedServiceIdentity DataPlane URL that can be queried to obtain the identity credentials.
        /// </summary>
        [Output("clientSecretUrl")]
        public Output<string> ClientSecretUrl { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The id of the service principal object associated with the created identity.
        /// </summary>
        [Output("principalId")]
        public Output<string> PrincipalId { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The id of the tenant which the identity belongs to.
        /// </summary>
        [Output("tenantId")]
        public Output<string> TenantId { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a UserAssignedIdentity resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserAssignedIdentity(string name, UserAssignedIdentityArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:managedidentity/v20150831preview:UserAssignedIdentity", name, args ?? new UserAssignedIdentityArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserAssignedIdentity(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:managedidentity/v20150831preview:UserAssignedIdentity", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:managedidentity/latest:UserAssignedIdentity"},
                    new Pulumi.Alias { Type = "azure-nextgen:managedidentity/v20181130:UserAssignedIdentity"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing UserAssignedIdentity resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserAssignedIdentity Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new UserAssignedIdentity(name, id, options);
        }
    }

    public sealed class UserAssignedIdentityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group to which the identity belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the identity resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

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

        public UserAssignedIdentityArgs()
        {
        }
    }
}
