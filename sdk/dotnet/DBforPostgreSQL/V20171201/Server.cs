// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DBforPostgreSQL.V20171201
{
    /// <summary>
    /// Represents a server.
    /// </summary>
    public partial class Server : Pulumi.CustomResource
    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
        /// </summary>
        [Output("administratorLogin")]
        public Output<string?> AdministratorLogin { get; private set; } = null!;

        /// <summary>
        /// Status showing whether the server data encryption is enabled with customer-managed keys.
        /// </summary>
        [Output("byokEnforcement")]
        public Output<string> ByokEnforcement { get; private set; } = null!;

        /// <summary>
        /// Earliest restore point creation time (ISO8601 format)
        /// </summary>
        [Output("earliestRestoreDate")]
        public Output<string?> EarliestRestoreDate { get; private set; } = null!;

        /// <summary>
        /// The fully qualified domain name of a server.
        /// </summary>
        [Output("fullyQualifiedDomainName")]
        public Output<string?> FullyQualifiedDomainName { get; private set; } = null!;

        /// <summary>
        /// The Azure Active Directory identity of the server.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.ResourceIdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// Status showing whether the server enabled infrastructure encryption.
        /// </summary>
        [Output("infrastructureEncryption")]
        public Output<string?> InfrastructureEncryption { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The master server id of a replica server.
        /// </summary>
        [Output("masterServerId")]
        public Output<string?> MasterServerId { get; private set; } = null!;

        /// <summary>
        /// Enforce a minimal Tls version for the server.
        /// </summary>
        [Output("minimalTlsVersion")]
        public Output<string?> MinimalTlsVersion { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of private endpoint connections on a server
        /// </summary>
        [Output("privateEndpointConnections")]
        public Output<ImmutableArray<Outputs.ServerPrivateEndpointConnectionResponse>> PrivateEndpointConnections { get; private set; } = null!;

        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'
        /// </summary>
        [Output("publicNetworkAccess")]
        public Output<string?> PublicNetworkAccess { get; private set; } = null!;

        /// <summary>
        /// The maximum number of replicas that a master server can have.
        /// </summary>
        [Output("replicaCapacity")]
        public Output<int?> ReplicaCapacity { get; private set; } = null!;

        /// <summary>
        /// The replication role of the server.
        /// </summary>
        [Output("replicationRole")]
        public Output<string?> ReplicationRole { get; private set; } = null!;

        /// <summary>
        /// The SKU (pricing tier) of the server.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Enable ssl enforcement or not when connect to server.
        /// </summary>
        [Output("sslEnforcement")]
        public Output<string?> SslEnforcement { get; private set; } = null!;

        /// <summary>
        /// Storage profile of a server.
        /// </summary>
        [Output("storageProfile")]
        public Output<Outputs.StorageProfileResponse?> StorageProfile { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// A state of a server that is visible to user.
        /// </summary>
        [Output("userVisibleState")]
        public Output<string?> UserVisibleState { get; private set; } = null!;

        /// <summary>
        /// Server version.
        /// </summary>
        [Output("version")]
        public Output<string?> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Server resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Server(string name, ServerArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:dbforpostgresql/v20171201:Server", name, args ?? new ServerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Server(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:dbforpostgresql/v20171201:Server", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:dbforpostgresql/latest:Server"},
                    new Pulumi.Alias { Type = "azure-nextgen:dbforpostgresql/v20171201preview:Server"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Server resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Server Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Server(name, id, options);
        }
    }

    public sealed class ServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Azure Active Directory identity of the server.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.ResourceIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The location the resource resides in.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Properties of the server.
        /// </summary>
        [Input("properties", required: true)]
        public InputUnion<Inputs.ServerPropertiesForDefaultCreateArgs, InputUnion<Inputs.ServerPropertiesForGeoRestoreArgs, InputUnion<Inputs.ServerPropertiesForReplicaArgs, Inputs.ServerPropertiesForRestoreArgs>>> Properties { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        /// <summary>
        /// The SKU (pricing tier) of the server.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Application-specific metadata in the form of key-value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ServerArgs()
        {
        }
    }
}
