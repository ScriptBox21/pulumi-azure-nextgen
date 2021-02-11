// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20181101
{
    /// <summary>
    /// SSL certificate for an app.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/v20181101:Certificate")]
    public partial class Certificate : Pulumi.CustomResource
    {
        /// <summary>
        /// Raw bytes of .cer file
        /// </summary>
        [Output("cerBlob")]
        public Output<string> CerBlob { get; private set; } = null!;

        /// <summary>
        /// Certificate expiration date.
        /// </summary>
        [Output("expirationDate")]
        public Output<string> ExpirationDate { get; private set; } = null!;

        /// <summary>
        /// Friendly name of the certificate.
        /// </summary>
        [Output("friendlyName")]
        public Output<string> FriendlyName { get; private set; } = null!;

        /// <summary>
        /// Host names the certificate applies to.
        /// </summary>
        [Output("hostNames")]
        public Output<ImmutableArray<string>> HostNames { get; private set; } = null!;

        /// <summary>
        /// Specification for the App Service Environment to use for the certificate.
        /// </summary>
        [Output("hostingEnvironmentProfile")]
        public Output<Outputs.HostingEnvironmentProfileResponse> HostingEnvironmentProfile { get; private set; } = null!;

        /// <summary>
        /// Certificate issue Date.
        /// </summary>
        [Output("issueDate")]
        public Output<string> IssueDate { get; private set; } = null!;

        /// <summary>
        /// Certificate issuer.
        /// </summary>
        [Output("issuer")]
        public Output<string> Issuer { get; private set; } = null!;

        /// <summary>
        /// Key Vault Csm resource Id.
        /// </summary>
        [Output("keyVaultId")]
        public Output<string?> KeyVaultId { get; private set; } = null!;

        /// <summary>
        /// Key Vault secret name.
        /// </summary>
        [Output("keyVaultSecretName")]
        public Output<string?> KeyVaultSecretName { get; private set; } = null!;

        /// <summary>
        /// Status of the Key Vault secret.
        /// </summary>
        [Output("keyVaultSecretStatus")]
        public Output<string> KeyVaultSecretStatus { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Certificate password.
        /// </summary>
        [Output("password")]
        public Output<string> Password { get; private set; } = null!;

        /// <summary>
        /// Pfx blob.
        /// </summary>
        [Output("pfxBlob")]
        public Output<string?> PfxBlob { get; private set; } = null!;

        /// <summary>
        /// Public key hash.
        /// </summary>
        [Output("publicKeyHash")]
        public Output<string> PublicKeyHash { get; private set; } = null!;

        /// <summary>
        /// Self link.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
        /// </summary>
        [Output("serverFarmId")]
        public Output<string?> ServerFarmId { get; private set; } = null!;

        /// <summary>
        /// App name.
        /// </summary>
        [Output("siteName")]
        public Output<string> SiteName { get; private set; } = null!;

        /// <summary>
        /// Subject name of the certificate.
        /// </summary>
        [Output("subjectName")]
        public Output<string> SubjectName { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Certificate thumbprint.
        /// </summary>
        [Output("thumbprint")]
        public Output<string> Thumbprint { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Is the certificate valid?.
        /// </summary>
        [Output("valid")]
        public Output<bool> Valid { get; private set; } = null!;


        /// <summary>
        /// Create a Certificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Certificate(string name, CertificateArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20181101:Certificate", name, args ?? new CertificateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Certificate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/v20181101:Certificate", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/latest:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160301:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:Certificate"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20201001:Certificate"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Certificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Certificate Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Certificate(name, id, options);
        }
    }

    public sealed class CertificateArgs : Pulumi.ResourceArgs
    {
        [Input("hostNames")]
        private InputList<string>? _hostNames;

        /// <summary>
        /// Host names the certificate applies to.
        /// </summary>
        public InputList<string> HostNames
        {
            get => _hostNames ?? (_hostNames = new InputList<string>());
            set => _hostNames = value;
        }

        /// <summary>
        /// Key Vault Csm resource Id.
        /// </summary>
        [Input("keyVaultId")]
        public Input<string>? KeyVaultId { get; set; }

        /// <summary>
        /// Key Vault secret name.
        /// </summary>
        [Input("keyVaultSecretName")]
        public Input<string>? KeyVaultSecretName { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Resource Location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Name of the certificate.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Certificate password.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// Pfx blob.
        /// </summary>
        [Input("pfxBlob")]
        public Input<string>? PfxBlob { get; set; }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
        /// </summary>
        [Input("serverFarmId")]
        public Input<string>? ServerFarmId { get; set; }

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

        public CertificateArgs()
        {
        }
    }
}
