// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.V20191001Preview
{
    /// <summary>
    /// Define the move collection.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:migrate/v20191001preview:MoveCollection")]
    public partial class MoveCollection : Pulumi.CustomResource
    {
        /// <summary>
        /// The etag of the resource.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// Defines the MSI properties of the Move Collection.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.IdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Defines the move collection properties.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.MoveCollectionPropertiesResponse> Properties { get; private set; } = null!;

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
        /// Create a MoveCollection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MoveCollection(string name, MoveCollectionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:migrate/v20191001preview:MoveCollection", name, args ?? new MoveCollectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MoveCollection(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:migrate/v20191001preview:MoveCollection", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:migrate/v20210101:MoveCollection"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MoveCollection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MoveCollection Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MoveCollection(name, id, options);
        }
    }

    public sealed class MoveCollectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines the MSI properties of the Move Collection.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.IdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The geo-location where the resource lives.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The Move Collection Name.
        /// </summary>
        [Input("moveCollectionName", required: true)]
        public Input<string> MoveCollectionName { get; set; } = null!;

        /// <summary>
        /// Defines the move collection properties.
        /// </summary>
        [Input("properties")]
        public Input<Inputs.MoveCollectionPropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// The Resource Group Name.
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

        public MoveCollectionArgs()
        {
        }
    }
}
